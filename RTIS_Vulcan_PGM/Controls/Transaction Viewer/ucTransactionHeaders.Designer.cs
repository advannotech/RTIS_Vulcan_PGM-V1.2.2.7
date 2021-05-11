namespace RTIS_Vulcan_PGM.Controls.Transaction_Viewer
{
    partial class ucTransactionHeaders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblItem = new DevExpress.XtraEditors.LabelControl();
            this.ppnlWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.vsbFG = new DevExpress.XtraEditors.VScrollBar();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.tmrItems = new System.Windows.Forms.Timer(this.components);
            this.tblHeading = new System.Windows.Forms.TableLayoutPanel();
            this.lblBalance = new DevExpress.XtraEditors.LabelControl();
            this.lblLot = new DevExpress.XtraEditors.LabelControl();
            this.lblConcen = new DevExpress.XtraEditors.LabelControl();
            this.lblIn = new DevExpress.XtraEditors.LabelControl();
            this.lblOut = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pnlParent.SuspendLayout();
            this.tblHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItem.Appearance.Options.UseFont = true;
            this.lblItem.Appearance.Options.UseForeColor = true;
            this.lblItem.Appearance.Options.UseTextOptions = true;
            this.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItem.Location = new System.Drawing.Point(4, 4);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(1246, 100);
            this.lblItem.TabIndex = 89;
            this.lblItem.Text = "[ItemCode]";
            // 
            // ppnlWait
            // 
            this.ppnlWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppnlWait.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.ppnlWait.Appearance.Font = new System.Drawing.Font("Calibri", 48F);
            this.ppnlWait.Appearance.Options.UseBackColor = true;
            this.ppnlWait.Appearance.Options.UseFont = true;
            this.ppnlWait.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 48F);
            this.ppnlWait.AppearanceCaption.ForeColor = System.Drawing.Color.Teal;
            this.ppnlWait.AppearanceCaption.Options.UseFont = true;
            this.ppnlWait.AppearanceCaption.Options.UseForeColor = true;
            this.ppnlWait.AppearanceCaption.Options.UseTextOptions = true;
            this.ppnlWait.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ppnlWait.AppearanceDescription.Font = new System.Drawing.Font("Calibri", 48F);
            this.ppnlWait.AppearanceDescription.ForeColor = System.Drawing.Color.Teal;
            this.ppnlWait.AppearanceDescription.Options.UseFont = true;
            this.ppnlWait.AppearanceDescription.Options.UseForeColor = true;
            this.ppnlWait.AppearanceDescription.Options.UseTextOptions = true;
            this.ppnlWait.AppearanceDescription.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ppnlWait.BarAnimationElementThickness = 2;
            this.ppnlWait.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ppnlWait.Description = "Loading Batches ...";
            this.ppnlWait.Location = new System.Drawing.Point(4, 111);
            this.ppnlWait.Name = "ppnlWait";
            this.ppnlWait.Size = new System.Drawing.Size(1246, 752);
            this.ppnlWait.TabIndex = 90;
            this.ppnlWait.Text = "progressPanel1";
            this.ppnlWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // pnlParent
            // 
            this.pnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParent.Controls.Add(this.pnlItems);
            this.pnlParent.Controls.Add(this.vsbFG);
            this.pnlParent.Location = new System.Drawing.Point(22, 202);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1210, 536);
            this.pnlParent.TabIndex = 92;
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.AutoSize = true;
            this.pnlItems.Location = new System.Drawing.Point(3, 3);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1109, 528);
            this.pnlItems.TabIndex = 85;
            // 
            // vsbFG
            // 
            this.vsbFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbFG.Location = new System.Drawing.Point(1119, 0);
            this.vsbFG.Margin = new System.Windows.Forms.Padding(4);
            this.vsbFG.Name = "vsbFG";
            this.vsbFG.Opacity = 1F;
            this.vsbFG.Size = new System.Drawing.Size(89, 534);
            this.vsbFG.TabIndex = 1;
            this.vsbFG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFG_Scroll);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.Location = new System.Drawing.Point(23, 761);
            this.btnBack.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnBack.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnBack.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(222, 101);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tmrItems
            // 
            this.tmrItems.Tick += new System.EventHandler(this.tmrItems_Tick);
            // 
            // tblHeading
            // 
            this.tblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblHeading.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblHeading.ColumnCount = 6;
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblHeading.Controls.Add(this.labelControl1, 5, 0);
            this.tblHeading.Controls.Add(this.lblBalance, 4, 0);
            this.tblHeading.Controls.Add(this.lblLot, 0, 0);
            this.tblHeading.Controls.Add(this.lblConcen, 1, 0);
            this.tblHeading.Controls.Add(this.lblIn, 2, 0);
            this.tblHeading.Controls.Add(this.lblOut, 3, 0);
            this.tblHeading.ForeColor = System.Drawing.Color.Black;
            this.tblHeading.Location = new System.Drawing.Point(22, 131);
            this.tblHeading.Name = "tblHeading";
            this.tblHeading.RowCount = 1;
            this.tblHeading.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblHeading.Size = new System.Drawing.Size(1113, 71);
            this.tblHeading.TabIndex = 96;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBalance.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblBalance.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBalance.Appearance.Options.UseBackColor = true;
            this.lblBalance.Appearance.Options.UseFont = true;
            this.lblBalance.Appearance.Options.UseForeColor = true;
            this.lblBalance.Appearance.Options.UseTextOptions = true;
            this.lblBalance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBalance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBalance.Location = new System.Drawing.Point(745, 5);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(176, 61);
            this.lblBalance.TabIndex = 97;
            this.lblBalance.Text = "Balance";
            // 
            // lblLot
            // 
            this.lblLot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLot.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblLot.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLot.Appearance.Options.UseBackColor = true;
            this.lblLot.Appearance.Options.UseFont = true;
            this.lblLot.Appearance.Options.UseForeColor = true;
            this.lblLot.Appearance.Options.UseTextOptions = true;
            this.lblLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLot.Location = new System.Drawing.Point(5, 5);
            this.lblLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(176, 61);
            this.lblLot.TabIndex = 94;
            this.lblLot.Text = "Batch";
            // 
            // lblConcen
            // 
            this.lblConcen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConcen.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblConcen.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConcen.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblConcen.Appearance.Options.UseBackColor = true;
            this.lblConcen.Appearance.Options.UseFont = true;
            this.lblConcen.Appearance.Options.UseForeColor = true;
            this.lblConcen.Appearance.Options.UseTextOptions = true;
            this.lblConcen.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblConcen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblConcen.Location = new System.Drawing.Point(190, 5);
            this.lblConcen.Margin = new System.Windows.Forms.Padding(4);
            this.lblConcen.Name = "lblConcen";
            this.lblConcen.Size = new System.Drawing.Size(176, 61);
            this.lblConcen.TabIndex = 91;
            this.lblConcen.Text = "Concentration";
            // 
            // lblIn
            // 
            this.lblIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIn.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblIn.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblIn.Appearance.Options.UseBackColor = true;
            this.lblIn.Appearance.Options.UseFont = true;
            this.lblIn.Appearance.Options.UseForeColor = true;
            this.lblIn.Appearance.Options.UseTextOptions = true;
            this.lblIn.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblIn.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblIn.Location = new System.Drawing.Point(375, 5);
            this.lblIn.Margin = new System.Windows.Forms.Padding(4);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(176, 61);
            this.lblIn.TabIndex = 92;
            this.lblIn.Text = "In";
            // 
            // lblOut
            // 
            this.lblOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOut.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblOut.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOut.Appearance.Options.UseBackColor = true;
            this.lblOut.Appearance.Options.UseFont = true;
            this.lblOut.Appearance.Options.UseForeColor = true;
            this.lblOut.Appearance.Options.UseTextOptions = true;
            this.lblOut.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblOut.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOut.Location = new System.Drawing.Point(560, 5);
            this.lblOut.Margin = new System.Windows.Forms.Padding(4);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(176, 61);
            this.lblOut.TabIndex = 93;
            this.lblOut.Text = "Out";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(930, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(178, 61);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "View";
            // 
            // ucTransactionHeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblHeading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.ppnlWait);
            this.Controls.Add(this.lblItem);
            this.Name = "ucTransactionHeaders";
            this.Size = new System.Drawing.Size(1254, 866);
            this.Load += new System.EventHandler(this.ucTransactionHeaders_Load);
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.tblHeading.ResumeLayout(false);
            this.tblHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblItem;
        private DevExpress.XtraWaitForm.ProgressPanel ppnlWait;
        private System.Windows.Forms.Panel pnlParent;
        public System.Windows.Forms.Panel pnlItems;
        private DevExpress.XtraEditors.VScrollBar vsbFG;
        internal DevExpress.XtraEditors.SimpleButton btnBack;
        private System.Windows.Forms.Timer tmrItems;
        private System.Windows.Forms.TableLayoutPanel tblHeading;
        public DevExpress.XtraEditors.LabelControl lblBalance;
        public DevExpress.XtraEditors.LabelControl lblLot;
        public DevExpress.XtraEditors.LabelControl lblConcen;
        public DevExpress.XtraEditors.LabelControl lblIn;
        public DevExpress.XtraEditors.LabelControl lblOut;
        public DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
