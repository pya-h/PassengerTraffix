using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace VehicleTraffX
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
                Plate plate = new Plate(short.Parse(txtPlate1stSection.Text), txtPlateLetter.Text,
                    short.Parse(txtPlate2ndSection.Text), short.Parse(txtPlateIranID.Text));
                Passenger newPassenger = new Passenger(txtFullName.Text, txtNationalID.Text, txtVehicleModel.Text,
                    plate, persianCalendar.GetSelectedDateInPersianDateTime(),
                    (byte)txtEntranceHour.Value, (byte)txtEntranceMinute.Value,
                        (byte)txtExitHour.Value, (byte)txtExitMinute.Value);
                MySQLInterface.Database.Add(newPassenger);
                MessageBoxFarsi.Show(newPassenger.ToString() + " ثبت شد.");
                MessageBoxFarsi.Show(persianCalendar.GetSelectedDateInPersianDateTime().ToLongDateString());
            }
            catch (DatabaseOutOfReachException ex)
            {
                MessageBoxFarsi.Show(ex.Message);
                
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
    }
}
