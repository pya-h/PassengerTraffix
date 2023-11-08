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

namespace PassengerTraffix
{
    public partial class SurveillanceForm : Form
    {
        private MainForm parent;
        private DataTable data;

        public SurveillanceForm(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void SurveillanceForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                this.Data = SQLiteInterface.Database.Fetch();

            }
            catch(DatabaseOutOfReachException ex)
            {
                BehComponents.MessageBoxFarsi.Show(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxFarsi.Show(ex.Message, "خطای نامشخص",
                    MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
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
                dt.Columns[i].ColumnName = SQLiteInterface.TABLE_HEADERS_FA[i];
                
                //dgvTraffics.Columns[keyIndex].DefaultCellStyle.Font =
                //    new Font("Mitra", 14.5f, GraphicsUnit.Point);

            }

        }

        private void tsBtnFilter_Click(object sender, EventArgs e)
        {
            new FilterForm(this).ShowDialog();
        }

        public DataTable Data
        {
            get { return this.data; }
            set
            {
                this.data = value;
                dgvTraffics.DataSource = this.data;
            }
        }
        public static void SmoothUpdateProgressBar(ToolStripProgressBar progressBar, int value)
        {
            if (value < 100)    // prevent ArgumentException error on value = 100
            {
                progressBar.Value = value + 1;    // set the value +1
            }

            progressBar.Value = value;    // set the actual value

        }

        private void tsBtnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog outputFile = new SaveFileDialog();
                outputFile.Filter = "Excel File (*.xlsx)| *.xlsx";

                if (outputFile.ShowDialog() != DialogResult.OK || outputFile.FileName.Trim() == "")
                {
                    MessageBoxFarsi.Show("برای ذخیره سازی فایل اکسل باید محل ذخیره سازی مشخص شود!", "مسیر اشتباه",
                        MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);
                    return;
                }
                tsBtnExportExcel.Visible = false;
                pgbExporting.Visible = true;
                pgbExporting.Value = 0;
                // creating Excel Application  
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            
                app.DefaultSheetDirection = 1; // right to left
                // creating new WorkBook within Excel application  
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                
                // creating new Excelsheet in workbook  
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                
                // see the excel sheet behind the program  
                app.Visible = false;
                // get the reference of first sheet. By default its name is Sheet1.  
                // store its reference to worksheet  
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                // changing the name of active sheet  
                worksheet.Name = "لیست ترددها";
                //worksheet.Cells.WrapText = true;
    
                // storing header part in Excel  
                for (int i = 1; i < dgvTraffics.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvTraffics.Columns[i - 1].HeaderText;
                }
                // storing Each row and column value to excel sheet  
                int x = dgvTraffics.Rows.Count;
                for (int i = 0; i < dgvTraffics.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvTraffics.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgvTraffics.Rows[i].Cells[j].Value.ToString();
                    }

                    SmoothUpdateProgressBar(pgbExporting, (int)(100 * (i + 1) / dgvTraffics.Rows.Count));
                }
                SmoothUpdateProgressBar(pgbExporting, 99);
                worksheet.Columns.AutoFit();
                worksheet.Cells.WrapText = true;
                // save the application  
                workbook.SaveAs(outputFile.FileName, Type.Missing, Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                // Exit from the application  
                
                tsBtnExportExcel.Visible = true;
                pgbExporting.Visible = false;
                app.Quit();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBoxFarsi.Show(ex.Message, "خطای نامشخص",
                    MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error);

            }
        }

        private void dgvTraffics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsBtnSave_Click(object sender, EventArgs e)
        {
            SQLiteInterface.Database.Save(this.Data);
        }

    }
}
