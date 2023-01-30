namespace VehicleTraffX
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
            this.groupPersonSearch = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.rbByNationalID = new System.Windows.Forms.RadioButton();
            this.groupVehicleSearch = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rbByPlate = new System.Windows.Forms.RadioButton();
            this.rbByModel = new System.Windows.Forms.RadioButton();
            this.groupّFilterDates = new System.Windows.Forms.GroupBox();
            this.btnSubmitFilter = new BehComponents.ButtonX();
            this.dtpFrom = new BehComponents.DateTimePickerX();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblUntil = new System.Windows.Forms.Label();
            this.dtpUntil = new BehComponents.DateTimePickerX();
            this.groupPersonSearch.SuspendLayout();
            this.groupVehicleSearch.SuspendLayout();
            this.groupّFilterDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPersonSearch
            // 
            this.groupPersonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPersonSearch.Controls.Add(this.textBox1);
            this.groupPersonSearch.Controls.Add(this.rbByName);
            this.groupPersonSearch.Controls.Add(this.rbByNationalID);
            this.groupPersonSearch.Location = new System.Drawing.Point(12, 12);
            this.groupPersonSearch.Name = "groupPersonSearch";
            this.groupPersonSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPersonSearch.Size = new System.Drawing.Size(259, 97);
            this.groupPersonSearch.TabIndex = 0;
            this.groupPersonSearch.TabStop = false;
            this.groupPersonSearch.Text = "جستجوی شخص";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 20);
            this.textBox1.TabIndex = 1;
            // 
            // rbByName
            // 
            this.rbByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByName.AutoSize = true;
            this.rbByName.Location = new System.Drawing.Point(85, 28);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(38, 17);
            this.rbByName.TabIndex = 1;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "نام";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // rbByNationalID
            // 
            this.rbByNationalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByNationalID.AutoSize = true;
            this.rbByNationalID.Location = new System.Drawing.Point(129, 28);
            this.rbByNationalID.Name = "rbByNationalID";
            this.rbByNationalID.Size = new System.Drawing.Size(58, 17);
            this.rbByNationalID.TabIndex = 0;
            this.rbByNationalID.TabStop = true;
            this.rbByNationalID.Text = "کد ملی";
            this.rbByNationalID.UseVisualStyleBackColor = true;
            // 
            // groupVehicleSearch
            // 
            this.groupVehicleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVehicleSearch.Controls.Add(this.textBox2);
            this.groupVehicleSearch.Controls.Add(this.rbByPlate);
            this.groupVehicleSearch.Controls.Add(this.rbByModel);
            this.groupVehicleSearch.Location = new System.Drawing.Point(12, 135);
            this.groupVehicleSearch.Name = "groupVehicleSearch";
            this.groupVehicleSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupVehicleSearch.Size = new System.Drawing.Size(259, 97);
            this.groupVehicleSearch.TabIndex = 1;
            this.groupVehicleSearch.TabStop = false;
            this.groupVehicleSearch.Text = "جستجوی وسیله نقلیه";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 20);
            this.textBox2.TabIndex = 1;
            // 
            // rbByPlate
            // 
            this.rbByPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByPlate.AutoSize = true;
            this.rbByPlate.Location = new System.Drawing.Point(85, 30);
            this.rbByPlate.Name = "rbByPlate";
            this.rbByPlate.Size = new System.Drawing.Size(43, 17);
            this.rbByPlate.TabIndex = 1;
            this.rbByPlate.TabStop = true;
            this.rbByPlate.Text = "پلاک";
            this.rbByPlate.UseVisualStyleBackColor = true;
            // 
            // rbByModel
            // 
            this.rbByModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByModel.AutoSize = true;
            this.rbByModel.Location = new System.Drawing.Point(145, 30);
            this.rbByModel.Name = "rbByModel";
            this.rbByModel.Size = new System.Drawing.Size(42, 17);
            this.rbByModel.TabIndex = 0;
            this.rbByModel.TabStop = true;
            this.rbByModel.Text = "مدل";
            this.rbByModel.UseVisualStyleBackColor = true;
            // 
            // groupّFilterDates
            // 
            this.groupّFilterDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupّFilterDates.Controls.Add(this.lblUntil);
            this.groupّFilterDates.Controls.Add(this.dtpUntil);
            this.groupّFilterDates.Controls.Add(this.lblFrom);
            this.groupّFilterDates.Controls.Add(this.dtpFrom);
            this.groupّFilterDates.Location = new System.Drawing.Point(9, 281);
            this.groupّFilterDates.Name = "groupّFilterDates";
            this.groupّFilterDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupّFilterDates.Size = new System.Drawing.Size(259, 107);
            this.groupّFilterDates.TabIndex = 2;
            this.groupّFilterDates.TabStop = false;
            this.groupّFilterDates.Text = "بازه ی زمانی";
            // 
            // btnSubmitFilter
            // 
            this.btnSubmitFilter.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSubmitFilter.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSubmitFilter.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSubmitFilter.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSubmitFilter.IsBolded = false;
            this.btnSubmitFilter.IsHoliday = false;
            this.btnSubmitFilter.IsTrailing = false;
            this.btnSubmitFilter.Location = new System.Drawing.Point(45, 399);
            this.btnSubmitFilter.Name = "btnSubmitFilter";
            this.btnSubmitFilter.PushedAlways = false;
            this.btnSubmitFilter.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSubmitFilter.SecondBorderDistanceToEdge = 3F;
            this.btnSubmitFilter.SecondBorderWidth = 3F;
            this.btnSubmitFilter.ShowFirstBorder = true;
            this.btnSubmitFilter.ShowSecondBorder = false;
            this.btnSubmitFilter.Size = new System.Drawing.Size(188, 38);
            this.btnSubmitFilter.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnSubmitFilter.TabIndex = 3;
            this.btnSubmitFilter.Text = "اعمال فیلتر";
            this.btnSubmitFilter.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSubmitFilter.UseVisualStyleBackColor = true;
            // 
            // dtpFrom
            // 
            this.dtpFrom.AnchorSize = new System.Drawing.Size(170, 27);
            this.dtpFrom.BackColor = System.Drawing.Color.White;
            this.dtpFrom.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpFrom.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpFrom.CalendarDayRectTickness = 2F;
            this.dtpFrom.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpFrom.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFrom.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpFrom.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpFrom.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpFrom.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpFrom.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpFrom.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpFrom.CalendarShowToday = true;
            this.dtpFrom.CalendarShowTodayRect = true;
            this.dtpFrom.CalendarShowToolTips = false;
            this.dtpFrom.CalendarShowTrailing = true;
            this.dtpFrom.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpFrom.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFrom.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpFrom.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpFrom.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpFrom.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpFrom.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpFrom.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpFrom.CalendarTodayRectTickness = 2F;
            this.dtpFrom.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpFrom.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpFrom.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpFrom.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpFrom.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpFrom.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpFrom.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFrom.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpFrom.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpFrom.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpFrom.ClearButtonImage")));
            this.dtpFrom.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpFrom.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpFrom.ClearButtonText = "";
            this.dtpFrom.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.ClearButtonToolTip = "";
            this.dtpFrom.ClearButtonWidth = 17;
            this.dtpFrom.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpFrom.CustomFormat = "";
            this.dtpFrom.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpFrom.DropDownClosedWhenClickOnDays = false;
            this.dtpFrom.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpFrom.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpFrom.Format4Binding = "yyyy/MM/dd";
            this.dtpFrom.Location = new System.Drawing.Point(17, 28);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.ShowClearButton = false;
            this.dtpFrom.Size = new System.Drawing.Size(170, 27);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.TextWhenClearButtonClicked = "";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(206, 34);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(15, 13);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "از";
            this.lblFrom.Click += new System.EventHandler(this.lblFrom_Click);
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(202, 67);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(23, 13);
            this.lblUntil.TabIndex = 3;
            this.lblUntil.Text = "الی";
            // 
            // dtpUntil
            // 
            this.dtpUntil.AnchorSize = new System.Drawing.Size(170, 27);
            this.dtpUntil.BackColor = System.Drawing.Color.White;
            this.dtpUntil.CalendarBoldedDayForeColor = System.Drawing.Color.Blue;
            this.dtpUntil.CalendarBorderColor = System.Drawing.Color.CadetBlue;
            this.dtpUntil.CalendarDayRectTickness = 2F;
            this.dtpUntil.CalendarDaysBackColor = System.Drawing.Color.LightGray;
            this.dtpUntil.CalendarDaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpUntil.CalendarDaysForeColor = System.Drawing.Color.DodgerBlue;
            this.dtpUntil.CalendarEnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishHolidayDates = new System.DateTime[0];
            this.dtpUntil.CalendarEnglishMonthlyBoldedDates = new System.DateTime[0];
            this.dtpUntil.CalendarHolidayForeColor = System.Drawing.Color.Red;
            this.dtpUntil.CalendarHolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.dtpUntil.CalendarLineWeekColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarPersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarPersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.dtpUntil.CalendarShowToday = true;
            this.dtpUntil.CalendarShowTodayRect = true;
            this.dtpUntil.CalendarShowToolTips = false;
            this.dtpUntil.CalendarShowTrailing = true;
            this.dtpUntil.CalendarStyle_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.dtpUntil.CalendarStyle_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpUntil.CalendarStyle_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.dtpUntil.CalendarStyle_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.dtpUntil.CalendarTitleBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarTitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpUntil.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarTodayBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarTodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.dtpUntil.CalendarTodayForeColor = System.Drawing.Color.Black;
            this.dtpUntil.CalendarTodayRectColor = System.Drawing.Color.Coral;
            this.dtpUntil.CalendarTodayRectTickness = 2F;
            this.dtpUntil.CalendarTrailingForeColor = System.Drawing.Color.DarkGray;
            this.dtpUntil.CalendarType = BehComponents.CalendarTypes.Persian;
            this.dtpUntil.CalendarWeekDaysBackColor = System.Drawing.Color.Wheat;
            this.dtpUntil.CalendarWeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.dtpUntil.CalendarWeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.dtpUntil.CalendarWeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            this.dtpUntil.ClearButtonAlignment = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpUntil.ClearButtonBackColor = System.Drawing.Color.White;
            this.dtpUntil.ClearButtonForeColor = System.Drawing.SystemColors.ControlText;
            this.dtpUntil.ClearButtonImage = ((System.Drawing.Image)(resources.GetObject("dtpUntil.ClearButtonImage")));
            this.dtpUntil.ClearButtonImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.ClearButtonImageFixedSize = new System.Drawing.Size(0, 0);
            this.dtpUntil.ClearButtonImageSizeMode = BehComponents.DropDownEmpty.ImageSizeModes.Zoom;
            this.dtpUntil.ClearButtonText = "";
            this.dtpUntil.ClearButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.ClearButtonToolTip = "";
            this.dtpUntil.ClearButtonWidth = 17;
            this.dtpUntil.ClearDateTimeWhenDownDeleteKey = true;
            this.dtpUntil.CustomFormat = "";
            this.dtpUntil.DockSide = BehComponents.DropDownEmpty.Alignments.Left;
            this.dtpUntil.DropDownClosedWhenClickOnDays = false;
            this.dtpUntil.DropDownClosedWhenSelectedDateChanged = false;
            this.dtpUntil.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpUntil.Format4Binding = "yyyy/MM/dd";
            this.dtpUntil.Location = new System.Drawing.Point(17, 61);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.RightToLeftLayout = true;
            this.dtpUntil.ShowClearButton = false;
            this.dtpUntil.Size = new System.Drawing.Size(170, 27);
            this.dtpUntil.TabIndex = 2;
            this.dtpUntil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.TextWhenClearButtonClicked = "";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(283, 449);
            this.Controls.Add(this.btnSubmitFilter);
            this.Controls.Add(this.groupّFilterDates);
            this.Controls.Add(this.groupVehicleSearch);
            this.Controls.Add(this.groupPersonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.groupPersonSearch.ResumeLayout(false);
            this.groupPersonSearch.PerformLayout();
            this.groupVehicleSearch.ResumeLayout(false);
            this.groupVehicleSearch.PerformLayout();
            this.groupّFilterDates.ResumeLayout(false);
            this.groupّFilterDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonSearch;
        private System.Windows.Forms.RadioButton rbByNationalID;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupVehicleSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton rbByPlate;
        private System.Windows.Forms.RadioButton rbByModel;
        private System.Windows.Forms.GroupBox groupّFilterDates;
        private BehComponents.ButtonX btnSubmitFilter;
        private System.Windows.Forms.Label lblUntil;
        private BehComponents.DateTimePickerX dtpUntil;
        private System.Windows.Forms.Label lblFrom;
        private BehComponents.DateTimePickerX dtpFrom;

    }
}