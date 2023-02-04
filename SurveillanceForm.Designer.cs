namespace VehicleTraffix
{
    partial class SurveillanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurveillanceForm));
            this.dgvTraffics = new System.Windows.Forms.DataGridView();
            this.tsOptionsContainer = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pgbExporting = new System.Windows.Forms.ToolStripProgressBar();
            this.tsBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraffics)).BeginInit();
            this.tsOptionsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTraffics
            // 
            this.dgvTraffics.AllowUserToAddRows = false;
            this.dgvTraffics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraffics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTraffics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraffics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTraffics.Location = new System.Drawing.Point(0, 0);
            this.dgvTraffics.Name = "dgvTraffics";
            this.dgvTraffics.ReadOnly = true;
            this.dgvTraffics.Size = new System.Drawing.Size(825, 468);
            this.dgvTraffics.TabIndex = 0;
            this.dgvTraffics.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraffics_CellContentClick);
            this.dgvTraffics.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTraffics_DataBindingComplete);
            // 
            // tsOptionsContainer
            // 
            this.tsOptionsContainer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tsOptionsContainer.Dock = System.Windows.Forms.DockStyle.None;
            this.tsOptionsContainer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOptionsContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.pgbExporting,
            this.tsBtnExportExcel,
            this.toolStripSeparator1,
            this.tsBtnFilter,
            this.toolStripSeparator2,
            this.tsBtnSave,
            this.toolStripSeparator4});
            this.tsOptionsContainer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsOptionsContainer.Location = new System.Drawing.Point(326, 426);
            this.tsOptionsContainer.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsOptionsContainer.Name = "tsOptionsContainer";
            this.tsOptionsContainer.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsOptionsContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsOptionsContainer.Size = new System.Drawing.Size(132, 39);
            this.tsOptionsContainer.TabIndex = 2;
            this.tsOptionsContainer.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 23);
            // 
            // pgbExporting
            // 
            this.pgbExporting.Margin = new System.Windows.Forms.Padding(1, 8, 1, 1);
            this.pgbExporting.Name = "pgbExporting";
            this.pgbExporting.Size = new System.Drawing.Size(100, 15);
            this.pgbExporting.Visible = false;
            // 
            // tsBtnExportExcel
            // 
            this.tsBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnExportExcel.Image")));
            this.tsBtnExportExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnExportExcel.Name = "tsBtnExportExcel";
            this.tsBtnExportExcel.Size = new System.Drawing.Size(36, 36);
            this.tsBtnExportExcel.Click += new System.EventHandler(this.tsBtnExportExcel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // tsBtnFilter
            // 
            this.tsBtnFilter.AutoSize = false;
            this.tsBtnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnFilter.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnFilter.Image")));
            this.tsBtnFilter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilter.Name = "tsBtnFilter";
            this.tsBtnFilter.Size = new System.Drawing.Size(35, 35);
            this.tsBtnFilter.Click += new System.EventHandler(this.tsBtnFilter_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // tsBtnSave
            // 
            this.tsBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSave.Image")));
            this.tsBtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSave.Name = "tsBtnSave";
            this.tsBtnSave.Size = new System.Drawing.Size(36, 36);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 23);
            // 
            // SurveillanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 468);
            this.Controls.Add(this.tsOptionsContainer);
            this.Controls.Add(this.dgvTraffics);
            this.Name = "SurveillanceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SurveillanceForm_FormClosed);
            this.Load += new System.EventHandler(this.SurveillanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraffics)).EndInit();
            this.tsOptionsContainer.ResumeLayout(false);
            this.tsOptionsContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTraffics;
        private System.Windows.Forms.ToolStrip tsOptionsContainer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsBtnExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsBtnFilter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripProgressBar pgbExporting;
        //private BehComponents.DataGridViewX dgvTraffics;
    }
}