namespace PassengerTraffix
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
            this.components = new System.ComponentModel.Container();
            this.menuOptions = new System.Windows.Forms.MenuStrip();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSurveillance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClearForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.sections = new System.Windows.Forms.SplitContainer();
            this.cbPassengers = new System.Windows.Forms.ComboBox();
            this.cbTargetUnit = new System.Windows.Forms.ComboBox();
            this.lblEnterExit = new System.Windows.Forms.Label();
            this.lblPassingType = new System.Windows.Forms.Label();
            this.checkIsEntering = new System.Windows.Forms.CheckBox();
            this.lblTargetUnit = new System.Windows.Forms.Label();
            this.txtPhonenumber = new System.Windows.Forms.TextBox();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.checkHasARide = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new BehComponents.ButtonX();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblran = new System.Windows.Forms.Label();
            this.txtPlateIranID = new System.Windows.Forms.TextBox();
            this.txtPlate2ndSection = new System.Windows.Forms.TextBox();
            this.txtPlateLetter = new System.Windows.Forms.TextBox();
            this.txtPlate1stSection = new System.Windows.Forms.TextBox();
            this.lblPlate = new System.Windows.Forms.Label();
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.menuOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sections)).BeginInit();
            this.sections.Panel1.SuspendLayout();
            this.sections.Panel2.SuspendLayout();
            this.sections.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuOptions
            // 
            this.menuOptions.BackColor = System.Drawing.SystemColors.Control;
            this.menuOptions.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuOptions.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptions});
            this.menuOptions.Location = new System.Drawing.Point(0, 0);
            this.menuOptions.Name = "menuOptions";
            this.menuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuOptions.Size = new System.Drawing.Size(1856, 59);
            this.menuOptions.TabIndex = 21;
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSurveillance,
            this.toolStripSeparator1,
            this.mnuClearForm,
            this.mnuExit});
            this.mnuOptions.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnuOptions.Size = new System.Drawing.Size(129, 55);
            this.mnuOptions.Text = "گزینه ها";
            // 
            // mnuSurveillance
            // 
            this.mnuSurveillance.Name = "mnuSurveillance";
            this.mnuSurveillance.Size = new System.Drawing.Size(359, 60);
            this.mnuSurveillance.Text = "نظارت";
            this.mnuSurveillance.Click += new System.EventHandler(this.mnuSurveillanceMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // mnuClearForm
            // 
            this.mnuClearForm.Name = "mnuClearForm";
            this.mnuClearForm.Size = new System.Drawing.Size(359, 60);
            this.mnuClearForm.Text = "پاک کردن فرم";
            this.mnuClearForm.Click += new System.EventHandler(this.mnuClearForm_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(359, 60);
            this.mnuExit.Text = "خروج";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // sections
            // 
            this.sections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sections.Location = new System.Drawing.Point(24, 75);
            this.sections.Margin = new System.Windows.Forms.Padding(6);
            this.sections.Name = "sections";
            // 
            // sections.Panel1
            // 
            this.sections.Panel1.Controls.Add(this.cbPassengers);
            this.sections.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // sections.Panel2
            // 
            this.sections.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sections.Panel2.Controls.Add(this.cbTargetUnit);
            this.sections.Panel2.Controls.Add(this.lblEnterExit);
            this.sections.Panel2.Controls.Add(this.lblPassingType);
            this.sections.Panel2.Controls.Add(this.checkIsEntering);
            this.sections.Panel2.Controls.Add(this.lblTargetUnit);
            this.sections.Panel2.Controls.Add(this.txtPhonenumber);
            this.sections.Panel2.Controls.Add(this.lblPhonenumber);
            this.sections.Panel2.Controls.Add(this.checkHasARide);
            this.sections.Panel2.Controls.Add(this.btnSubmit);
            this.sections.Panel2.Controls.Add(this.txtVehicleModel);
            this.sections.Panel2.Controls.Add(this.lblVehicleModel);
            this.sections.Panel2.Controls.Add(this.txtFullName);
            this.sections.Panel2.Controls.Add(this.lblFullName);
            this.sections.Panel2.Controls.Add(this.lblran);
            this.sections.Panel2.Controls.Add(this.txtPlateIranID);
            this.sections.Panel2.Controls.Add(this.txtPlate2ndSection);
            this.sections.Panel2.Controls.Add(this.txtPlateLetter);
            this.sections.Panel2.Controls.Add(this.txtPlate1stSection);
            this.sections.Panel2.Controls.Add(this.lblPlate);
            this.sections.Panel2.Controls.Add(this.txtNationalID);
            this.sections.Panel2.Controls.Add(this.lblID);
            this.sections.Panel2.Font = new System.Drawing.Font("2  Mitra", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sections.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sections.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.sections_Panel2_Paint);
            this.sections.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sections.Size = new System.Drawing.Size(1808, 796);
            this.sections.SplitterDistance = 594;
            this.sections.SplitterWidth = 8;
            this.sections.TabIndex = 27;
            // 
            // cbPassengers
            // 
            this.cbPassengers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbPassengers.Font = new System.Drawing.Font("2  Mitra", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbPassengers.FormattingEnabled = true;
            this.cbPassengers.Location = new System.Drawing.Point(0, 0);
            this.cbPassengers.Margin = new System.Windows.Forms.Padding(6);
            this.cbPassengers.Name = "cbPassengers";
            this.cbPassengers.Size = new System.Drawing.Size(588, 841);
            this.cbPassengers.TabIndex = 12;
            this.cbPassengers.TabStop = false;
            this.cbPassengers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbPassengers_KeyDown);
            this.cbPassengers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoSelectComboItem);
            // 
            // cbTargetUnit
            // 
            this.cbTargetUnit.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cbTargetUnit.FormattingEnabled = true;
            this.cbTargetUnit.Items.AddRange(new object[] {
            "ایثارگران",
            "نیروی انسانی بسیج",
            "نیروی انسانی پایور (سرباز)",
            "سازندگی",
            "یگان شهید سلیمانی",
            "فرماندهی",
            "حفاظت اطلاعات",
            "فاوا",
            "قرارگاه",
            "پیشکسوتان",
            "عملیات",
            "آماد و پشتیبانی",
            "مهندسی",
            "اطلاعات",
            "حوزه نمایندگی ولی فقیه",
            "آموزش پایور",
            "ایمنی",
            "تربیت بدنی",
            "بازرسی",
            "طرح و برنامه مالی",
            "اداری و پشتیبانی - حقوقی قضایی",
            "فضای مجازی"});
            this.cbTargetUnit.Location = new System.Drawing.Point(616, 198);
            this.cbTargetUnit.Margin = new System.Windows.Forms.Padding(6);
            this.cbTargetUnit.Name = "cbTargetUnit";
            this.cbTargetUnit.Size = new System.Drawing.Size(378, 61);
            this.cbTargetUnit.TabIndex = 2;
            this.cbTargetUnit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AutoSelectComboItem);
            // 
            // lblEnterExit
            // 
            this.lblEnterExit.AutoSize = true;
            this.lblEnterExit.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblEnterExit.Location = new System.Drawing.Point(1022, 646);
            this.lblEnterExit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEnterExit.Name = "lblEnterExit";
            this.lblEnterExit.Size = new System.Drawing.Size(139, 53);
            this.lblEnterExit.TabIndex = 47;
            this.lblEnterExit.Text = "ورود/خروج";
            // 
            // lblPassingType
            // 
            this.lblPassingType.AutoSize = true;
            this.lblPassingType.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassingType.Location = new System.Drawing.Point(1050, 363);
            this.lblPassingType.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassingType.Name = "lblPassingType";
            this.lblPassingType.Size = new System.Drawing.Size(111, 53);
            this.lblPassingType.TabIndex = 46;
            this.lblPassingType.Text = "نوع تردد";
            // 
            // checkIsEntering
            // 
            this.checkIsEntering.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkIsEntering.BackColor = System.Drawing.Color.SpringGreen;
            this.checkIsEntering.Checked = true;
            this.checkIsEntering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIsEntering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkIsEntering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkIsEntering.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkIsEntering.Location = new System.Drawing.Point(616, 635);
            this.checkIsEntering.Margin = new System.Windows.Forms.Padding(6);
            this.checkIsEntering.Name = "checkIsEntering";
            this.checkIsEntering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkIsEntering.Size = new System.Drawing.Size(382, 73);
            this.checkIsEntering.TabIndex = 5;
            this.checkIsEntering.Text = "ورود";
            this.checkIsEntering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkIsEntering.UseVisualStyleBackColor = false;
            this.checkIsEntering.CheckedChanged += new System.EventHandler(this.checkIsEntering_CheckedChanged);
            // 
            // lblTargetUnit
            // 
            this.lblTargetUnit.AutoSize = true;
            this.lblTargetUnit.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblTargetUnit.Location = new System.Drawing.Point(1010, 204);
            this.lblTargetUnit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTargetUnit.Name = "lblTargetUnit";
            this.lblTargetUnit.Size = new System.Drawing.Size(149, 53);
            this.lblTargetUnit.TabIndex = 44;
            this.lblTargetUnit.Text = "واحد مراجعه";
            // 
            // txtPhonenumber
            // 
            this.txtPhonenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhonenumber.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPhonenumber.Location = new System.Drawing.Point(46, 204);
            this.txtPhonenumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhonenumber.MaxLength = 11;
            this.txtPhonenumber.Name = "txtPhonenumber";
            this.txtPhonenumber.Size = new System.Drawing.Size(382, 60);
            this.txtPhonenumber.TabIndex = 3;
            this.txtPhonenumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhonenumber.TextChanged += new System.EventHandler(this.txtPhonenumber_TextChanged);
            this.txtPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPhonenumber.Location = new System.Drawing.Point(442, 210);
            this.lblPhonenumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(140, 53);
            this.lblPhonenumber.TabIndex = 42;
            this.lblPhonenumber.Text = "شماره تلفن";
            // 
            // checkHasARide
            // 
            this.checkHasARide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkHasARide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkHasARide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkHasARide.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkHasARide.Location = new System.Drawing.Point(616, 356);
            this.checkHasARide.Margin = new System.Windows.Forms.Padding(6);
            this.checkHasARide.Name = "checkHasARide";
            this.checkHasARide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkHasARide.Size = new System.Drawing.Size(382, 73);
            this.checkHasARide.TabIndex = 4;
            this.checkHasARide.Text = "پیاده";
            this.checkHasARide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkHasARide.UseVisualStyleBackColor = true;
            this.checkHasARide.CheckedChanged += new System.EventHandler(this.checkHasARide_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BoldedForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnSubmit.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSubmit.HolidayForeColor = System.Drawing.Color.Red;
            this.btnSubmit.ImageFixedSize = new System.Drawing.Size(0, 0);
            this.btnSubmit.ImageSizeMode = BehComponents.ButtonX.ImageSizeModes.Normal;
            this.btnSubmit.IsBolded = false;
            this.btnSubmit.IsHoliday = false;
            this.btnSubmit.IsTrailing = false;
            this.btnSubmit.Location = new System.Drawing.Point(44, 631);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PushedAlways = false;
            this.btnSubmit.SecondBorderColor = System.Drawing.Color.Red;
            this.btnSubmit.SecondBorderDistanceToEdge = 3F;
            this.btnSubmit.SecondBorderWidth = 3F;
            this.btnSubmit.ShowFirstBorder = true;
            this.btnSubmit.ShowSecondBorder = false;
            this.btnSubmit.Size = new System.Drawing.Size(386, 81);
            this.btnSubmit.Style = BehComponents.ButtonX.ButtonStyles.Green;
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.TrailingForeColor = System.Drawing.Color.LightGray;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.BackColor = System.Drawing.Color.Silver;
            this.txtVehicleModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVehicleModel.Enabled = false;
            this.txtVehicleModel.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVehicleModel.Location = new System.Drawing.Point(616, 508);
            this.txtVehicleModel.Margin = new System.Windows.Forms.Padding(6);
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(382, 60);
            this.txtVehicleModel.TabIndex = 6;
            this.txtVehicleModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblVehicleModel.Location = new System.Drawing.Point(1020, 517);
            this.lblVehicleModel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(141, 53);
            this.lblVehicleModel.TabIndex = 40;
            this.lblVehicleModel.Text = "مدل خودرو";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtFullName.Location = new System.Drawing.Point(626, 96);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(6);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(370, 60);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblFullName.Location = new System.Drawing.Point(1044, 96);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(113, 53);
            this.lblFullName.TabIndex = 39;
            this.lblFullName.Text = "نام کامل";
            // 
            // lblran
            // 
            this.lblran.AutoSize = true;
            this.lblran.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblran.Location = new System.Drawing.Point(336, 438);
            this.lblran.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblran.Name = "lblran";
            this.lblran.Size = new System.Drawing.Size(74, 53);
            this.lblran.TabIndex = 33;
            this.lblran.Text = "ایران";
            // 
            // txtPlateIranID
            // 
            this.txtPlateIranID.BackColor = System.Drawing.Color.Silver;
            this.txtPlateIranID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlateIranID.Enabled = false;
            this.txtPlateIranID.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlateIranID.Location = new System.Drawing.Point(342, 504);
            this.txtPlateIranID.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlateIranID.MaxLength = 2;
            this.txtPlateIranID.Name = "txtPlateIranID";
            this.txtPlateIranID.Size = new System.Drawing.Size(68, 60);
            this.txtPlateIranID.TabIndex = 10;
            this.txtPlateIranID.Tag = "";
            this.txtPlateIranID.TextChanged += new System.EventHandler(this.txtPlateIranID_TextChanged);
            this.txtPlateIranID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlate2ndSection
            // 
            this.txtPlate2ndSection.BackColor = System.Drawing.Color.Silver;
            this.txtPlate2ndSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate2ndSection.Enabled = false;
            this.txtPlate2ndSection.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlate2ndSection.Location = new System.Drawing.Point(226, 504);
            this.txtPlate2ndSection.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlate2ndSection.MaxLength = 3;
            this.txtPlate2ndSection.Name = "txtPlate2ndSection";
            this.txtPlate2ndSection.Size = new System.Drawing.Size(84, 60);
            this.txtPlate2ndSection.TabIndex = 9;
            this.txtPlate2ndSection.Tag = "";
            this.txtPlate2ndSection.TextChanged += new System.EventHandler(this.txtPlate2ndSection_TextChanged);
            this.txtPlate2ndSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // txtPlateLetter
            // 
            this.txtPlateLetter.BackColor = System.Drawing.Color.Silver;
            this.txtPlateLetter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlateLetter.Enabled = false;
            this.txtPlateLetter.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlateLetter.Location = new System.Drawing.Point(142, 504);
            this.txtPlateLetter.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlateLetter.MaxLength = 2;
            this.txtPlateLetter.Name = "txtPlateLetter";
            this.txtPlateLetter.Size = new System.Drawing.Size(70, 60);
            this.txtPlateLetter.TabIndex = 8;
            this.txtPlateLetter.TextChanged += new System.EventHandler(this.txtPlateLetter_TextChanged);
            // 
            // txtPlate1stSection
            // 
            this.txtPlate1stSection.BackColor = System.Drawing.Color.Silver;
            this.txtPlate1stSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlate1stSection.Enabled = false;
            this.txtPlate1stSection.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPlate1stSection.Location = new System.Drawing.Point(44, 504);
            this.txtPlate1stSection.Margin = new System.Windows.Forms.Padding(6);
            this.txtPlate1stSection.MaxLength = 3;
            this.txtPlate1stSection.Name = "txtPlate1stSection";
            this.txtPlate1stSection.Size = new System.Drawing.Size(84, 60);
            this.txtPlate1stSection.TabIndex = 7;
            this.txtPlate1stSection.TextChanged += new System.EventHandler(this.txtPlate1stSection_TextChanged);
            this.txtPlate1stSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblPlate
            // 
            this.lblPlate.AutoSize = true;
            this.lblPlate.BackColor = System.Drawing.Color.White;
            this.lblPlate.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPlate.Location = new System.Drawing.Point(442, 504);
            this.lblPlate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPlate.Name = "lblPlate";
            this.lblPlate.Size = new System.Drawing.Size(82, 53);
            this.lblPlate.TabIndex = 29;
            this.lblPlate.Text = "پلاک";
            // 
            // txtNationalID
            // 
            this.txtNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNationalID.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNationalID.Location = new System.Drawing.Point(46, 96);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(6);
            this.txtNationalID.MaxLength = 10;
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.Size = new System.Drawing.Size(382, 60);
            this.txtNationalID.TabIndex = 1;
            this.txtNationalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNationalID.TextChanged += new System.EventHandler(this.txtNationalID_TextChanged);
            this.txtNationalID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericTextBoxes_KeyPress);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("2  Mitra", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblID.Location = new System.Drawing.Point(480, 96);
            this.lblID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(99, 53);
            this.lblID.TabIndex = 27;
            this.lblID.Text = "کد ملی";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1856, 898);
            this.Controls.Add(this.sections);
            this.Controls.Add(this.menuOptions);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuOptions;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "  ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuOptions.ResumeLayout(false);
            this.menuOptions.PerformLayout();
            this.sections.Panel1.ResumeLayout(false);
            this.sections.Panel2.ResumeLayout(false);
            this.sections.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sections)).EndInit();
            this.sections.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuSurveillance;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.SplitContainer sections;
        private System.Windows.Forms.Label lblTargetUnit;
        private System.Windows.Forms.TextBox txtPhonenumber;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.CheckBox checkHasARide;
        private BehComponents.ButtonX btnSubmit;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblran;
        private System.Windows.Forms.TextBox txtPlateIranID;
        private System.Windows.Forms.TextBox txtPlate2ndSection;
        private System.Windows.Forms.TextBox txtPlateLetter;
        private System.Windows.Forms.TextBox txtPlate1stSection;
        private System.Windows.Forms.Label lblPlate;
        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEnterExit;
        private System.Windows.Forms.Label lblPassingType;
        private System.Windows.Forms.CheckBox checkIsEntering;
        private System.Windows.Forms.ComboBox cbTargetUnit;
        private System.Windows.Forms.ComboBox cbPassengers;
        private System.Windows.Forms.ToolStripMenuItem mnuClearForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

