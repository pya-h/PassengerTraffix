using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BehComponents;

namespace VehicleTraffX
{
    public partial class SurveillanceForm : Form
    {
        private MainForm parent;
 
        public SurveillanceForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void SurveillanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvTraffics.DataSource = MySQLInterface.Database.Fetch();
                
            }
            catch(DatabaseOutOfReachException ex)
            {
                BehComponents.MessageBoxFarsi.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        private void SurveillanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.parent.CloseSurveillanceForm();
        }

        private void dgvTraffics_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // translate column headers
            DataTable dt = (DataTable)dgvTraffics.DataSource;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                dt.Columns[i].ColumnName = MySQLInterface.TABLE_HEADERS_FA[i];
                
            }

        }

        private void tsBtnFilter_Click(object sender, EventArgs e)
        {
            new FilterForm().ShowDialog();
        }

    }
}
