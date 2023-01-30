namespace VehicleTraffX
{
    partial class MainForm
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtPlate1stSection = new System.Windows.Forms.TextBox();
            this.txtPlateLetter = new System.Windows.Forms.TextBox();
            this.txtPlate2ndSection = new System.Windows.Forms.TextBox();
            this.txtPlateIranID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.persianCalendar = new BehComponents.MonthCalendarX();
            this.txtEntranceHour = new System.Windows.Forms.NumericUpDown();
            this.lblColon2 = new System.Windows.Forms.Label();
            this.txtEntranceMinute = new System.Windows.Forms.NumericUpDown();
            this.txtExitMinute = new System.Windows.Forms.NumericUpDown();
            this.lblColon = new System.Windows.Forms.Label();
            this.txtExitHour = new System.Windows.Forms.NumericUpDown();
            this.lblTimeIn = new System.Windows.Forms.Label();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSurveillance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubmit = new BehComponents.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntranceHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntranceMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExitMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExitHour)).BeginInit();
            this.menuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(199, 42);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "کد ملی";
            // 
            // txtNationalID
            // 
            this.txtNationalID.Location = new System.Drawing.Point(24, 39);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(169, 20);
            this.txtNationalID.TabIndex = 1;
            this.txtNationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNationalID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            this.txtNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.Location = new System.Drawing.Point(214, 99);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(25, 13);
            this.lblPlate.TabIndex = 2;
            this.lblPlate.Text = "پلاک";
            // 
            // txtPlate1stSection
            // 
            this.txtPlate1stSection.Location = new System.Drawing.Point(24, 96);
            this.txtPlate1stSection.Name = "txtPlate1stSection";
            this.txtPlate1stSection.Size = new System.Drawing.Size(41, 20);
            this.txtPlate1stSection.TabIndex = 3;
            this.txtPlate1stSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlateLetter
            // 
            this.txtPlateLetter.Location = new System.Drawing.Point(71, 96);
            this.txtPlateLetter.Name = "txtPlateLetter";
            this.txtPlateLetter.Size = new System.Drawing.Size(34, 20);
            this.txtPlateLetter.TabIndex = 4;
            // 
            // txtPlate2ndSection
            // 
            this.txtPlate2ndSection.Location = new System.Drawing.Point(111, 96);
            this.txtPlate2ndSection.Name = "txtPlate2ndSection";
            this.txtPlate2ndSection.Size = new System.Drawing.Size(41, 20);
            this.txtPlate2ndSection.TabIndex = 5;
            this.txtPlate2ndSection.Tag = "";
            this.txtPlate2ndSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlateIranID
            // 
            this.txtPlateIranID.Location = new System.Drawing.Point(158, 96);
            this.txtPlateIranID.Name = "txtPlateIranID";
            this.txtPlateIranID.Size = new System.Drawing.Size(35, 20);
            this.txtPlateIranID.TabIndex = 6;
            this.txtPlateIranID.Tag = "";
            this.txtPlateIranID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ایران";
            // 
            // persianCalendar
            // 
            this.persianCalendar.BoldedDayForeColor = System.Drawing.Color.Blue;
            this.persianCalendar.BorderColor = System.Drawing.Color.CadetBlue;
            this.persianCalendar.CalendarType = BehComponents.CalendarTypes.Persian;
            this.persianCalendar.DayRectTickness = 2F;
            this.persianCalendar.DaysBackColor = System.Drawing.Color.LightGray;
            this.persianCalendar.DaysFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persianCalendar.DaysForeColor = System.Drawing.Color.DodgerBlue;
            this.persianCalendar.EnglishAnnuallyBoldedDates = new System.DateTime[0];
            this.persianCalendar.EnglishBoldedDates = new System.DateTime[0];
            this.persianCalendar.EnglishHolidayDates = new System.DateTime[0];
            this.persianCalendar.EnglishMonthlyBoldedDates = new System.DateTime[0];
            this.persianCalendar.HolidayForeColor = System.Drawing.Color.Red;
            this.persianCalendar.HolidayWeekly = BehComponents.MonthCalendarX.DayOfWeekForHoliday.Friday;
            this.persianCalendar.LineWeekColor = System.Drawing.Color.Black;
            this.persianCalendar.Location = new System.Drawing.Point(63, 212);
            this.persianCalendar.Name = "persianCalendar";
            this.persianCalendar.PersianAnnuallyBoldedDates = new BehComponents.PersianDateTime[0];
            this.persianCalendar.PersianBoldedDates = new BehComponents.PersianDateTime[0];
            this.persianCalendar.PersianHolidayDates = new BehComponents.PersianDateTime[0];
            this.persianCalendar.PersianMonthlyBoldedDates = new BehComponents.PersianDateTime[0];
            this.persianCalendar.ShowToday = true;
            this.persianCalendar.ShowTodayRect = true;
            this.persianCalendar.ShowToolTips = false;
            this.persianCalendar.ShowTrailing = true;
            this.persianCalendar.Size = new System.Drawing.Size(362, 262);
            this.persianCalendar.Style_DaysButton = BehComponents.ButtonX.ButtonStyles.Simple;
            this.persianCalendar.Style_GotoTodayButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.persianCalendar.Style_MonthButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.persianCalendar.Style_NextMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.persianCalendar.Style_PreviousMonthButton = BehComponents.ButtonX.ButtonStyles.Green;
            this.persianCalendar.Style_YearButton = BehComponents.ButtonX.ButtonStyles.Blue;
            this.persianCalendar.TabIndex = 11;
            this.persianCalendar.TitleBackColor = System.Drawing.Color.Wheat;
            this.persianCalendar.TitleFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.persianCalendar.TitleForeColor = System.Drawing.Color.Black;
            this.persianCalendar.TodayBackColor = System.Drawing.Color.Wheat;
            this.persianCalendar.TodayFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.persianCalendar.TodayForeColor = System.Drawing.Color.Black;
            this.persianCalendar.TodayRectColor = System.Drawing.Color.Coral;
            this.persianCalendar.TodayRectTickness = 2F;
            this.persianCalendar.TrailingForeColor = System.Drawing.Color.DarkGray;
            this.persianCalendar.WeekDaysBackColor = System.Drawing.Color.Wheat;
            this.persianCalendar.WeekDaysFont = new System.Drawing.Font("Tahoma", 8.25F);
            this.persianCalendar.WeekDaysForeColor = System.Drawing.Color.OrangeRed;
            this.persianCalendar.WeekStartsOn = BehComponents.MonthCalendarX.WeekDays.Saturday;
            // 
            // txtEntranceHour
            // 
            this.txtEntranceHour.Location = new System.Drawing.Point(321, 170);
            this.txtEntranceHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtEntranceHour.Name = "txtEntranceHour";
            this.txtEntranceHour.Size = new System.Drawing.Size(41, 20);
            this.txtEntranceHour.TabIndex = 7;
            this.txtEntranceHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblColon2
            // 
            this.lblColon2.AutoSize = true;
            this.lblColon2.Location = new System.Drawing.Point(368, 172);
            this.lblColon2.Name = "lblColon2";
            this.lblColon2.Size = new System.Drawing.Size(10, 13);
            this.lblColon2.TabIndex = 10;
            this.lblColon2.Text = ":";
            // 
            // txtEntranceMinute
            // 
            this.txtEntranceMinute.Location = new System.Drawing.Point(384, 170);
            this.txtEntranceMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtEntranceMinute.Name = "txtEntranceMinute";
            this.txtEntranceMinute.Size = new System.Drawing.Size(41, 20);
            this.txtEntranceMinute.TabIndex = 8;
            this.txtEntranceMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtExitMinute
            // 
            this.txtExitMinute.Location = new System.Drawing.Point(126, 172);
            this.txtExitMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtExitMinute.Name = "txtExitMinute";
            this.txtExitMinute.Size = new System.Drawing.Size(41, 20);
            this.txtExitMinute.TabIndex = 10;
            this.txtExitMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblColon
            // 
            this.lblColon.AutoSize = true;
            this.lblColon.Location = new System.Drawing.Point(110, 174);
            this.lblColon.Name = "lblColon";
            this.lblColon.Size = new System.Drawing.Size(10, 13);
            this.lblColon.TabIndex = 13;
            this.lblColon.Text = ":";
            // 
            // txtExitHour
            // 
            this.txtExitHour.Location = new System.Drawing.Point(63, 172);
            this.txtExitHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.txtExitHour.Name = "txtExitHour";
            this.txtExitHour.Size = new System.Drawing.Size(41, 20);
            this.txtExitHour.TabIndex = 9;
            this.txtExitHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimeIn
            // 
            this.lblTimeIn.AutoSize = true;
            this.lblTimeIn.Location = new System.Drawing.Point(336, 154);
            this.lblTimeIn.Name = "lblTimeIn";
            this.lblTimeIn.Size = new System.Drawing.Size(60, 13);
            this.lblTimeIn.TabIndex = 15;
            this.lblTimeIn.Text = "ساعت ورود";
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Location = new System.Drawing.Point(80, 154);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(64, 13);
            this.lblTimeOut.TabIndex = 16;
            this.lblTimeOut.Text = "ساعت خروج";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(256, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(169, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(441, 42);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(46, 13);
            this.lblFullName.TabIndex = 18;
            this.lblFullName.Text = "نام کامل";
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Location = new System.Drawing.Point(256, 96);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(169, 20);
            this.txtVehicleModel.TabIndex = 2;
            this.txtVehicleModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Location = new System.Drawing.Point(431, 99);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(56, 13);
            this.lblVehicleModel.TabIndex = 20;
            this.lblVehicleModel.Text = "مدل خودرو";
            // 
            // menuOptions
            // 
            this.menuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuOptions.Size = new System.Drawing.Size(504, 24);
            this.menuOptions.TabIndex = 21;
            this.menuOptions.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuOptions_ItemClicked);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSurveillance,
            this.mnuExit});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuOptions.Size = new System.Drawing.Size(58, 20);
            this.mnuOptions.Text = "گزینه ها";
            // 
            // mnuSurveillance
            // 
            this.mnuSurveillance.Name = "mnuSurveillance";
            this.mnuSurveillance.Size = new System.Drawing.Size(103, 22);
            this.mnuSurveillance.Text = "نظارت";
            this.mnuSurveillance.Click += new System.EventHandler(this.mnuSurveillanceMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(103, 22);
            this.mnuExit.Text = "خروج";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSubmit.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSubmit.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSubmit.IsBolded = false;
            this.btnSubmit.IsHoliday = false;
            this.btnSubmit.IsTrailing = false;
            this.btnSubmit.Location = new System.Drawing.Point(63, 480);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PushedAlways = false;
            this.btnSubmit.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSubmit.SecondBorderDistanceToEdge = 3F;
            this.btnSubmit.SecondBorderWidth = 3F;
            this.btnSubmit.ShowFirstBorder = true;
            this.btnSubmit.ShowSecondBorder = false;
            this.btnSubmit.Size = new System.Drawing.Size(362, 33);
            this.btnSubmit.Style = BehComponents.ButtonX.ButtonStyles.Green;
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(504, 525);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.lblVehicleModel);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.lblTimeIn);
            this.Controls.Add(this.txtExitMinute);
            this.Controls.Add(this.lblColon);
            this.Controls.Add(this.txtExitHour);
            this.Controls.Add(this.txtEntranceMinute);
            this.Controls.Add(this.lblColon2);
            this.Controls.Add(this.txtEntranceHour);
            this.Controls.Add(this.persianCalendar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlateIranID);
            this.Controls.Add(this.txtPlate2ndSection);
            this.Controls.Add(this.txtPlateLetter);
            this.Controls.Add(this.txtPlate1stSection);
            this.Controls.Add(this.lblPlate);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.menuOptions);
            this.MainMenuStrip = this.menuOptions;
            this.Name = "MainForm";
            this.Text = "  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtEntranceHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEntranceMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExitMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExitHour)).EndInit();
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtPlate1stSection;
        private System.Windows.Forms.TextBox txtPlateLetter;
        private System.Windows.Forms.TextBox txtPlate2ndSection;
        private System.Windows.Forms.TextBox txtPlateIranID;
        private System.Windows.Forms.Label label1;
        private BehComponents.MonthCalendarX persianCalendar;
        private System.Windows.Forms.NumericUpDown txtEntranceHour;
        private System.Windows.Forms.Label lblColon2;
        private System.Windows.Forms.NumericUpDown txtEntranceMinute;
        private System.Windows.Forms.NumericUpDown txtExitMinute;
        private System.Windows.Forms.Label lblColon;
        private System.Windows.Forms.NumericUpDown txtExitHour;
        private System.Windows.Forms.Label lblTimeIn;
        private System.Windows.Forms.Label lblTimeOut;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSurveillance;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private BehComponents.ButtonX btnSubmit;
    }
}

