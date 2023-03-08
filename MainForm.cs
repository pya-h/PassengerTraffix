using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace PassengerTraffix
{
    public partial class MainForm : Form
    {
        private List<Passenger> passengers;
        
        public MainForm()
        {
            InitializeComponent();
            this.passengers = new List<Passenger>();
        }

        private SurveillanceForm frmSurveillance;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.btnSubmit;
            this.Text = "Created By thcpp@fsociety";

        }

        private void numericTextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string emptyFields = "";
                if (txtFullName.Text.Trim() == "")
                    emptyFields += "نام\n";
                if (txtNationalID.Text.Trim() == "")
                    emptyFields += "کد ملی\n";

                if(checkHasARide.Checked)
                {
                    if (txtVehicleModel.Text.Trim() == "")
                        emptyFields += "مدل خودرو\n";
                    if (txtPlate1stSection.Text.Trim() == "" || txtPlate2ndSection.Text.Trim() == ""
                        || txtPlateIranID.Text.Trim() == "" || txtPlateLetter.Text.Trim() == "")
                        emptyFields += "پلاک خودرو\n";
                }
                if (emptyFields != "")
                    throw new FillRequiredFieldsException(emptyFields);
                
                // double check values
                // they can bypass keypress by copy paste
                Plate plate = !checkHasARide.Checked || txtPlate1stSection.Text.Trim() == "" || txtPlate2ndSection.Text.Trim() == ""
                    || txtPlateIranID.Text.Trim() == "" || txtPlateLetter.Text.Trim() == "" ? null :
                    new Plate(short.Parse(txtPlate1stSection.Text.Trim()), txtPlateLetter.Text.Trim(),
                    short.Parse(txtPlate2ndSection.Text.Trim()), short.Parse(txtPlateIranID.Text.Trim()));
                Passenger newPassenger = new Passenger(TraffixTools.RemoveWhiteSpaces(txtFullName.Text),
                    txtNationalID.Text.Trim(), txtPhonenumber.Text.Trim(), cbTargetUnit.SelectedItem.ToString().Trim(),
                    TraffixTools.RemoveWhiteSpaces(txtVehicleModel.Text), plate, PersianDateTime.Now,
                    (short)DateTime.Now.Hour, (short)DateTime.Now.Minute, this.checkIsEntering.Checked);

                SQLiteInterface.Database.Add(newPassenger);

                MessageBoxFarsi.Show(newPassenger.ToString() + " ثبت شد.", "Okey Dokey");
                this.ClearForm();
                cbTargetUnit.SelectedIndex = -1;

                cbPassengers.DataSource = null;
                int i = 0;
                for (i = 0; i < this.passengers.Count; i++ )
                {
                    if(this.passengers[i].NationalID == newPassenger.NationalID)
                    {
                        this.passengers[i] = newPassenger;
                        break;
                    }
                }
                if(i >= this.passengers.Count)
                    this.passengers.Add(newPassenger);
                cbPassengers.DataSource = this.passengers;
                cbPassengers.DisplayMember = "FullName";
                cbPassengers.SelectedIndex = -1;
            }
            catch (DatabaseOutOfReachException dox)
            {
                MessageBoxFarsi.Show(dox.Message, "خطای در اتصال به پایگاه داده", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
            catch (FillRequiredFieldsException frx)
            {
                MessageBoxFarsi.Show(frx.Message, "هشدار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtPlate1stSection.Text = txtPlate2ndSection.Text = txtPlateIranID.Text = txtPlateLetter.Text =
                txtPlateIranID.Text = txtNationalID.Text = txtVehicleModel.Text = txtVehicleModel.Text =
                txtPhonenumber.Text = txtFullName.Text = "";
            checkHasARide.Checked = false;
            checkIsEntering.Checked = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // check are you sure?
            this.Close();
        }

        private void mnuSurveillanceMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.frmSurveillance == null)
                {
                    string password = Microsoft.VisualBasic.Interaction.InputBox("رمز عبور را وارد کنید:", "رمز عبور");
                    if (password != "110110")
                        throw new WrongCredentialsException();
                    //ask for admin passowrd
                    this.frmSurveillance = new SurveillanceForm(this);
                    this.frmSurveillance.Show();
                }
            }
            catch(WrongCredentialsException ex)
            {
                MessageBoxFarsi.Show(ex.Message, "خطا", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxFarsi.Show("یک خطای نامشخص اتفاق افتاده است. لطفا متن خطای انگلیسی را به واحد فاوا گزارش دهید:\n" + ex.Message, "خطای نامشخص",
                    MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
            }
        }

        public void CloseSurveillanceForm()
        {
            this.frmSurveillance = null;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.frmSurveillance != null)
                this.frmSurveillance.Close();
        }

        private void txtPlateLetter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || e.KeyChar == ' ';
        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Length >= 10)
                cbTargetUnit.Focus();
        }

        private void txtPlate1stSection_TextChanged(object sender, EventArgs e)
        {
            if (txtPlate1stSection.Text.Length >= 2)
                txtPlateLetter.Focus();
        }

        private void txtPlate2ndSection_TextChanged(object sender, EventArgs e)
        {
            if(txtPlate2ndSection.Text.Length >= 3)
                txtPlateIranID.Focus();
        }

        private void txtPlateIranID_TextChanged(object sender, EventArgs e)
        {
            if (txtPlateIranID.Text.Length >= 2)
                checkIsEntering.Focus();
        }

        private void checkHasARide_CheckedChanged(object sender, EventArgs e)
        {
            txtVehicleModel.Enabled = txtPlate1stSection.Enabled = txtPlate2ndSection.Enabled =
                txtPlateIranID.Enabled = txtPlateLetter.Enabled = checkHasARide.Checked;
            if (checkHasARide.Checked)
            {
                checkHasARide.BackColor = Color.Lime;
                checkHasARide.Text = "سواره";
                txtPlate1stSection.BackColor = txtPlate2ndSection.BackColor =
                txtVehicleModel.BackColor = txtPlateIranID.BackColor = txtPlateLetter.BackColor = Color.White;
            }
            else
            {
                checkHasARide.BackColor = Color.White;
                checkHasARide.Text = "پیاده";
                txtPlate1stSection.BackColor = txtPlate2ndSection.BackColor =
                txtVehicleModel.BackColor = txtPlateIranID.BackColor = txtPlateLetter.BackColor = Color.Silver;
            }
            txtVehicleModel.Text = txtPlate1stSection.Text = txtPlate2ndSection.Text =
                txtPlateIranID.Text = txtPlateLetter.Text = "";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            this.Text = "                                                                                                          " +
                PersianDateTime.Now.ToLongDateString() + " " + PersianDateTime.Now.ToLongTimeString();
        }

        private void checkIsEntering_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsEntering.Checked)
            {
                checkIsEntering.BackColor = Color.SpringGreen;
                checkIsEntering.Text = "ورود";
            }
            else
            {
                checkIsEntering.BackColor = Color.Coral;
                checkIsEntering.Text = "خروج";
            }
        }

        private void txtPhonenumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalID.Text.Length >= 11)
                checkHasARide.Focus();
        }

        private void cbPassengers_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (cbPassengers.SelectedIndex >= 0 && cbPassengers.SelectedIndex <= cbPassengers.Items.Count)
                {
                    this.ClearForm();
                    LoadPassenger(cbPassengers.SelectedItem as Passenger);
                    
                }
            }
        }

        private void LoadPassenger(Passenger passenger)
        {
            txtFullName.Text = passenger.FullName;
            txtNationalID.Text = passenger.NationalID;
            txtPhonenumber.Text = passenger.Phonenumber;
            cbTargetUnit.SelectedItem = passenger.TargetUnit;

            if (passenger.VehicleModel.Trim() != "")
            {
                checkHasARide.Checked = true;
                txtVehicleModel.Text = passenger.VehicleModel;
                txtPlate1stSection.Text = passenger.Plate.FirstSection.ToString();
                txtPlate2ndSection.Text = passenger.Plate.SecondSection.ToString();
                txtPlateLetter.Text = passenger.Plate.Letter;
                txtPlateIranID.Text = passenger.Plate.IranID.ToString();
            }
        }

        private void mnuClearForm_Click(object sender, EventArgs e)
        {
            this.ClearForm();

        }

        private void AutoSelectComboItem(object sender, KeyEventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape && e.KeyCode != Keys.Back && e.KeyCode != Keys.Tab
                  && e.KeyCode != Keys.CapsLock && combobox.Text.Length >= 3)
            {

                combobox.DroppedDown = true;
                for (int i = 0; i < combobox.Items.Count; i++)
                {
                    if (combobox.Items[i].ToString().Contains(combobox.Text))
                    {
                        combobox.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void txtPlateLetter_TextChanged(object sender, EventArgs e)
        {
            if (txtPlateLetter.Text.Length >= 3)
                txtPlate2ndSection.Focus();
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar);

        }

        private void sections_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
