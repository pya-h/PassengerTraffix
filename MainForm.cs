using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace VehicleTraffix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private SurveillanceForm frmSurveillance;
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            txtEntranceHour.Value = DateTime.Now.Hour;
            txtEntranceMinute.Value = DateTime.Now.Minute;

            txtExitHour.Value = DateTime.Now.Hour;
            txtExitMinute.Value = DateTime.Now.Minute;

            this.AcceptButton = this.btnSubmit;

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

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
                if (txtVehicleModel.Text.Trim() == "")
                    emptyFields += "مدل خودرو\n";
                if (txtPlate1stSection.Text.Trim() == "" || txtPlate2ndSection.Text.Trim() == ""
                    || txtPlateIranID.Text.Trim() == "" || txtPlateLetter.Text.Trim() == "")
                     emptyFields += "پلاک خودرو\n";
                if (emptyFields != "")
                    throw new FillRequiredFieldsException(emptyFields);

                // double check values
                // they can bypass keypress by copy paste
                Plate plate = new Plate(short.Parse(txtPlate1stSection.Text.Trim()), txtPlateLetter.Text.Trim(),
                    short.Parse(txtPlate2ndSection.Text.Trim()), short.Parse(txtPlateIranID.Text.Trim()));
                Passenger newPassenger = new Passenger(TraffixTools.RemoveWhiteSpaces(txtFullName.Text),
                    txtNationalID.Text.Trim(), TraffixTools.RemoveWhiteSpaces(txtVehicleModel.Text),
                    plate, persianCalendar.GetSelectedDateInPersianDateTime(),
                    (byte)txtEntranceHour.Value, (byte)txtEntranceMinute.Value,
                        (byte)txtExitHour.Value, (byte)txtExitMinute.Value);

                SQLiteInterface.Database.Add(newPassenger);
                MessageBoxFarsi.Show(newPassenger.ToString() + " ثبت شد.");
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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            // check are you sure?
            this.Close();
        }

        private void mnuSurveillanceMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmSurveillance == null)
            {
                //ask for admin passowrd
                this.frmSurveillance = new SurveillanceForm(this);
                this.frmSurveillance.Show();
            }
        }

        private void menuOptions_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

    }
}
