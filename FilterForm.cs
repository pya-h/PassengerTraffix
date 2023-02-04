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

namespace VehicleTraffix
{

    public partial class FilterForm : Form
    {
        private bool useTimeRange = false;
        private SurveillanceForm parent;
        public FilterForm(SurveillanceForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnSubmitFilter;
        }

        private void btnSelectTimeRange_Click(object sender, EventArgs e)
        {
            useTimeRange = !useTimeRange;
            btnSelectTimeRange.Style = useTimeRange 
                ? BehComponents.ButtonX.ButtonStyles.Green 
                : BehComponents.ButtonX.ButtonStyles.Simple;
            dtpFrom.Enabled = dtpUntil.Enabled = useTimeRange;
        }

        private void btnSubmitFilter_Click(object sender, EventArgs e)
        {
            DataTable wholeData = SQLiteInterface.Database.Fetch();
            try
            {
                if(txtPersonSearch.Text.Trim() != "")
                {
                    wholeData = wholeData.Select(string.Format("{0} LIKE '%{1}%'",
                        rbByNationalID.Checked ? SQLiteInterface.TABLE_HEADERS_EN[1] : SQLiteInterface.TABLE_HEADERS_EN[0], 
                        TraffixTools.RemoveWhiteSpaces(txtPersonSearch.Text))).CopyToDataTable();
                }

                if(txtVehicleSearch.Text.Trim() != "")
                {
                    wholeData = wholeData.Select(string.Format("{0} LIKE '%{1}%'",
                        rbByPlate.Checked ? SQLiteInterface.TABLE_HEADERS_EN[3] : SQLiteInterface.TABLE_HEADERS_EN[2],
                        TraffixTools.RemoveWhiteSpaces(txtVehicleSearch.Text))).CopyToDataTable();
                }

                if (useTimeRange)
                {
                    PersianDateTime from = dtpFrom.GetSelectedDateInPersianDateTime(),
                        until = dtpUntil.GetSelectedDateInPersianDateTime();

                    wholeData = wholeData.Select(string.Format("#{0}# <= {1} AND #{2}# >= {1}", from.ToShortDateString(), SQLiteInterface.TABLE_HEADERS_EN[4],
                        until.ToShortDateString())).CopyToDataTable();
                }
                this.parent.Data = wholeData;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           this.Close();
        }

    }
}
