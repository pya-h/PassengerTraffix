namespace PassengerTraffix
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
            this.txtPersonSearch = new System.Windows.Forms.TextBox();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.rbByNationalID = new System.Windows.Forms.RadioButton();
            this.groupVehicleSearch = new System.Windows.Forms.GroupBox();
            this.txtVehicleSearch = new System.Windows.Forms.TextBox();
            this.rbByPlate = new System.Windows.Forms.RadioButton();
            this.rbByModel = new System.Windows.Forms.RadioButton();
            this.groupّFilterDates = new System.Windows.Forms.GroupBox();
            this.btnSelectTimeRange = new BehComponents.ButtonX();
            this.lblUntil = new System.Windows.Forms.Label();
            this.dtpUntil = new BehComponents.DateTimePickerX();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new BehComponents.DateTimePickerX();
            this.btnSubmitFilter = new BehComponents.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPersonSearch.SuspendLayout();
            this.groupVehicleSearch.SuspendLayout();
            this.groupّFilterDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPersonSearch
            // 
            this.groupPersonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPersonSearch.Controls.Add(this.txtPersonSearch);
            this.groupPersonSearch.Controls.Add(this.rbByName);
            this.groupPersonSearch.Controls.Add(this.rbByNationalID);
            this.groupPersonSearch.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupPersonSearch.Location = new System.Drawing.Point(24, 23);
            this.groupPersonSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupPersonSearch.Name = "groupPersonSearch";
            this.groupPersonSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupPersonSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPersonSearch.Size = new System.Drawing.Size(558, 215);
            this.groupPersonSearch.TabIndex = 0;
            this.groupPersonSearch.TabStop = false;
            this.groupPersonSearch.Text = "جستجوی شخص";
            // 
            // txtPersonSearch
            // 
            this.txtPersonSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPersonSearch.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPersonSearch.Location = new System.Drawing.Point(76, 112);
            this.txtPersonSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPersonSearch.Name = "txtPersonSearch";
            this.txtPersonSearch.Size = new System.Drawing.Size(374, 59);
            this.txtPersonSearch.TabIndex = 1;
            // 
            // rbByName
            // 
            this.rbByName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByName.AutoSize = true;
            this.rbByName.Checked = true;
            this.rbByName.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbByName.Location = new System.Drawing.Point(308, 40);
            this.rbByName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(81, 55);
            this.rbByName.TabIndex = 1;
            this.rbByName.TabStop = true;
            this.rbByName.Text = "نام";
            this.rbByName.UseVisualStyleBackColor = true;
            // 
            // rbByNationalID
            // 
            this.rbByNationalID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByNationalID.AutoSize = true;
            this.rbByNationalID.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbByNationalID.Location = new System.Drawing.Point(158, 40);
            this.rbByNationalID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByNationalID.Name = "rbByNationalID";
            this.rbByNationalID.Size = new System.Drawing.Size(127, 55);
            this.rbByNationalID.TabIndex = 0;
            this.rbByNationalID.Text = "کد ملی";
            this.rbByNationalID.UseVisualStyleBackColor = true;
            // 
            // groupVehicleSearch
            // 
            this.groupVehicleSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupVehicleSearch.Controls.Add(this.txtVehicleSearch);
            this.groupVehicleSearch.Controls.Add(this.rbByPlate);
            this.groupVehicleSearch.Controls.Add(this.rbByModel);
            this.groupVehicleSearch.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupVehicleSearch.Location = new System.Drawing.Point(24, 250);
            this.groupVehicleSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupVehicleSearch.Name = "groupVehicleSearch";
            this.groupVehicleSearch.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupVehicleSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupVehicleSearch.Size = new System.Drawing.Size(558, 229);
            this.groupVehicleSearch.TabIndex = 1;
            this.groupVehicleSearch.TabStop = false;
            this.groupVehicleSearch.Text = "جستجوی وسیله نقلیه";
            // 
            // txtVehicleSearch
            // 
            this.txtVehicleSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleSearch.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVehicleSearch.Location = new System.Drawing.Point(76, 115);
            this.txtVehicleSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtVehicleSearch.Name = "txtVehicleSearch";
            this.txtVehicleSearch.Size = new System.Drawing.Size(374, 59);
            this.txtVehicleSearch.TabIndex = 1;
            // 
            // rbByPlate
            // 
            this.rbByPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByPlate.AutoSize = true;
            this.rbByPlate.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbByPlate.Location = new System.Drawing.Point(158, 44);
            this.rbByPlate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByPlate.Name = "rbByPlate";
            this.rbByPlate.Size = new System.Drawing.Size(110, 55);
            this.rbByPlate.TabIndex = 1;
            this.rbByPlate.Text = "پلاک";
            this.rbByPlate.UseVisualStyleBackColor = true;
            // 
            // rbByModel
            // 
            this.rbByModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbByModel.AutoSize = true;
            this.rbByModel.Checked = true;
            this.rbByModel.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbByModel.Location = new System.Drawing.Point(290, 44);
            this.rbByModel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByModel.Name = "rbByModel";
            this.rbByModel.Size = new System.Drawing.Size(97, 55);
            this.rbByModel.TabIndex = 0;
            this.rbByModel.TabStop = true;
            this.rbByModel.Text = "مدل";
            this.rbByModel.UseVisualStyleBackColor = true;
            // 
            // groupّFilterDates
            // 
            this.groupّFilterDates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupّFilterDates.Controls.Add(this.btnSelectTimeRange);
            this.groupّFilterDates.Controls.Add(this.lblUntil);
            this.groupّFilterDates.Controls.Add(this.dtpUntil);
            this.groupّFilterDates.Controls.Add(this.lblFrom);
            this.groupّFilterDates.Controls.Add(this.dtpFrom);
            this.groupّFilterDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupّFilterDates.Location = new System.Drawing.Point(24, 529);
            this.groupّFilterDates.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupّFilterDates.Name = "groupّFilterDates";
            this.groupّFilterDates.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupّFilterDates.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupّFilterDates.Size = new System.Drawing.Size(558, 333);
            this.groupّFilterDates.TabIndex = 2;
            this.groupّFilterDates.TabStop = false;
            this.groupّFilterDates.Text = "بازه ی زمانی";
            // 
            // btnSelectTimeRange
            // 
            this.btnSelectTimeRange.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnSelectTimeRange.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSelectTimeRange.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectTimeRange.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSelectTimeRange.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSelectTimeRange.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSelectTimeRange.IsBolded = false;
            this.btnSelectTimeRange.IsHoliday = false;
            this.btnSelectTimeRange.IsTrailing = false;
            this.btnSelectTimeRange.Location = new System.Drawing.Point(52, 244);
            this.btnSelectTimeRange.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSelectTimeRange.Name = "btnSelectTimeRange";
            this.btnSelectTimeRange.PushedAlways = false;
            this.btnSelectTimeRange.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSelectTimeRange.SecondBorderDistanceToEdge = 3F;
            this.btnSelectTimeRange.SecondBorderWidth = 3F;
            this.btnSelectTimeRange.ShowFirstBorder = true;
            this.btnSelectTimeRange.ShowSecondBorder = false;
            this.btnSelectTimeRange.Size = new System.Drawing.Size(400, 69);
            this.btnSelectTimeRange.Style = BehComponents.ButtonX.ButtonStyles.Simple;
            this.btnSelectTimeRange.TabIndex = 5;
            this.btnSelectTimeRange.Text = "انتخاب بازه زمانی";
            this.btnSelectTimeRange.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSelectTimeRange.UseVisualStyleBackColor = false;
            this.btnSelectTimeRange.Click += new System.EventHandler(this.btnSelectTimeRange_Click);
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUntil.Location = new System.Drawing.Point(486, 160);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(59, 44);
            this.lblUntil.TabIndex = 3;
            this.lblUntil.Text = "الی";
            // 
            // dtpUntil
            // 
            this.dtpUntil.AnchorSize = new System.Drawing.Size(432, 65);
            this.dtpUntil.BackColor = System.Drawing.Color.White;
            this.dtpUntil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.dtpUntil.Enabled = false;
            this.dtpUntil.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpUntil.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpUntil.Format4Binding = "yyyy/MM/dd";
            this.dtpUntil.Location = new System.Drawing.Point(34, 144);
            this.dtpUntil.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.RightToLeftLayout = true;
            this.dtpUntil.ShowClearButton = false;
            this.dtpUntil.Size = new System.Drawing.Size(432, 65);
            this.dtpUntil.TabIndex = 2;
            this.dtpUntil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpUntil.TextWhenClearButtonClicked = "";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFrom.Location = new System.Drawing.Point(504, 58);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(47, 44);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "از";
            // 
            // dtpFrom
            // 
            this.dtpFrom.AnchorSize = new System.Drawing.Size(432, 65);
            this.dtpFrom.BackColor = System.Drawing.Color.White;
            this.dtpFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtpFrom.Format = BehComponents.DateTimePickerX.FormatDate.Long;
            this.dtpFrom.Format4Binding = "yyyy/MM/dd";
            this.dtpFrom.Location = new System.Drawing.Point(34, 54);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeftLayout = true;
            this.dtpFrom.ShowClearButton = false;
            this.dtpFrom.Size = new System.Drawing.Size(432, 65);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dtpFrom.TextWhenClearButtonClicked = "";
            // 
            // btnSubmitFilter
            // 
            this.btnSubmitFilter.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSubmitFilter.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmitFilter.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSubmitFilter.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSubmitFilter.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSubmitFilter.IsBolded = false;
            this.btnSubmitFilter.IsHoliday = false;
            this.btnSubmitFilter.IsTrailing = false;
            this.btnSubmitFilter.Location = new System.Drawing.Point(100, 873);
            this.btnSubmitFilter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubmitFilter.Name = "btnSubmitFilter";
            this.btnSubmitFilter.PushedAlways = false;
            this.btnSubmitFilter.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSubmitFilter.SecondBorderDistanceToEdge = 3F;
            this.btnSubmitFilter.SecondBorderWidth = 3F;
            this.btnSubmitFilter.ShowFirstBorder = true;
            this.btnSubmitFilter.ShowSecondBorder = false;
            this.btnSubmitFilter.Size = new System.Drawing.Size(376, 73);
            this.btnSubmitFilter.Style = BehComponents.ButtonX.ButtonStyles.Blue;
            this.btnSubmitFilter.TabIndex = 3;
            this.btnSubmitFilter.Text = "اعمال فیلتر";
            this.btnSubmitFilter.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSubmitFilter.UseVisualStyleBackColor = true;
            this.btnSubmitFilter.Click += new System.EventHandler(this.btnSubmitFilter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(24, 513);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 4);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(606, 967);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmitFilter);
            this.Controls.Add(this.groupّFilterDates);
            this.Controls.Add(this.groupVehicleSearch);
            this.Controls.Add(this.groupPersonSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterForm";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            this.groupPersonSearch.ResumeLayout(false);
            this.groupPersonSearch.PerformLayout();
            this.groupVehicleSearch.ResumeLayout(false);
            this.groupVehicleSearch.PerformLayout();
            this.groupّFilterDates.ResumeLayout(false);
            this.groupّFilterDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupPersonSearch;
        private System.Windows.Forms.RadioButton rbByNationalID;
        private System.Windows.Forms.RadioButton rbByName;
        private System.Windows.Forms.TextBox txtPersonSearch;
        private System.Windows.Forms.GroupBox groupVehicleSearch;
        private System.Windows.Forms.TextBox txtVehicleSearch;
        private System.Windows.Forms.RadioButton rbByPlate;
        private System.Windows.Forms.RadioButton rbByModel;
        private System.Windows.Forms.GroupBox groupّFilterDates;
        private BehComponents.ButtonX btnSubmitFilter;
        private System.Windows.Forms.Label lblUntil;
        private BehComponents.DateTimePickerX dtpUntil;
        private System.Windows.Forms.Label lblFrom;
        private BehComponents.DateTimePickerX dtpFrom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BehComponents.ButtonX btnSelectTimeRange;

    }
}