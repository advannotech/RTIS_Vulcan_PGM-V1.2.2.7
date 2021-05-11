namespace RTIS_Vulcan_PGM.Controls
{
    partial class ucReceive
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
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnRec = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDesc = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lblItem = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblQty = new DevExpress.XtraEditors.LabelControl();
            this.lblLot = new DevExpress.XtraEditors.LabelControl();
            this.txtItem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.ppnlWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tmrGet = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRec
            // 
            this.btnRec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRec.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnRec.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnRec.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRec.Appearance.Options.UseBackColor = true;
            this.btnRec.Appearance.Options.UseFont = true;
            this.btnRec.Appearance.Options.UseForeColor = true;
            this.btnRec.Location = new System.Drawing.Point(1012, 761);
            this.btnRec.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnRec.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnRec.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRec.Margin = new System.Windows.Forms.Padding(4);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(222, 101);
            this.btnRec.TabIndex = 78;
            this.btnRec.Text = "Receive";
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(93, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 312);
            this.panel1.TabIndex = 82;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblItem, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelControl3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblQty, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLot, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 306);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDesc.Appearance.Options.UseFont = true;
            this.lblDesc.Appearance.Options.UseForeColor = true;
            this.lblDesc.Appearance.Options.UseTextOptions = true;
            this.lblDesc.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblDesc.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblDesc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDesc.Location = new System.Drawing.Point(318, 82);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(725, 63);
            this.lblDesc.TabIndex = 80;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl7.Location = new System.Drawing.Point(4, 80);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(254, 58);
            this.labelControl7.TabIndex = 79;
            this.labelControl7.Text = "Description : ";
            // 
            // lblItem
            // 
            this.lblItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItem.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblItem.Appearance.Options.UseFont = true;
            this.lblItem.Appearance.Options.UseForeColor = true;
            this.lblItem.Appearance.Options.UseTextOptions = true;
            this.lblItem.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItem.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblItem.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblItem.Location = new System.Drawing.Point(318, 4);
            this.lblItem.Margin = new System.Windows.Forms.Padding(4);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(725, 68);
            this.lblItem.TabIndex = 76;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(4, 4);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(233, 58);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Item Code : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl2.Location = new System.Drawing.Point(4, 156);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(264, 58);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Lot Number : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.Location = new System.Drawing.Point(4, 232);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(204, 58);
            this.labelControl3.TabIndex = 75;
            this.labelControl3.Text = "Quantity : ";
            // 
            // lblQty
            // 
            this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQty.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblQty.Appearance.Options.UseFont = true;
            this.lblQty.Appearance.Options.UseForeColor = true;
            this.lblQty.Appearance.Options.UseTextOptions = true;
            this.lblQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQty.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQty.Location = new System.Drawing.Point(318, 238);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(725, 58);
            this.lblQty.TabIndex = 78;
            // 
            // lblLot
            // 
            this.lblLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLot.Appearance.Font = new System.Drawing.Font("Calibri", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLot.Appearance.Options.UseFont = true;
            this.lblLot.Appearance.Options.UseForeColor = true;
            this.lblLot.Appearance.Options.UseTextOptions = true;
            this.lblLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblLot.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblLot.Location = new System.Drawing.Point(318, 161);
            this.lblLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(725, 58);
            this.lblLot.TabIndex = 77;
            // 
            // txtItem
            // 
            this.txtItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtItem.Location = new System.Drawing.Point(93, 165);
            this.txtItem.Name = "txtItem";
            this.txtItem.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 48F);
            this.txtItem.Properties.Appearance.Options.UseFont = true;
            this.txtItem.Properties.Appearance.Options.UseTextOptions = true;
            this.txtItem.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtItem.Size = new System.Drawing.Size(1054, 104);
            this.txtItem.TabIndex = 81;
            this.txtItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItem_KeyDown);
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(22, 37);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(1211, 100);
            this.labelControl13.TabIndex = 80;
            this.labelControl13.Text = "Scan CATscan Barcode";
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
            this.ppnlWait.Location = new System.Drawing.Point(3, 141);
            this.ppnlWait.Name = "ppnlWait";
            this.ppnlWait.Size = new System.Drawing.Size(1254, 722);
            this.ppnlWait.TabIndex = 92;
            this.ppnlWait.Text = "progressPanel1";
            this.ppnlWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // tmrGet
            // 
            this.tmrGet.Tick += new System.EventHandler(this.tmrGet_Tick);
            // 
            // ucReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.ppnlWait);
            this.Name = "ucReceive";
            this.Size = new System.Drawing.Size(1254, 866);
            this.Load += new System.EventHandler(this.ucReceive_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtItem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnBack;
        internal DevExpress.XtraEditors.SimpleButton btnRec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl lblDesc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lblItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lblQty;
        private DevExpress.XtraEditors.LabelControl lblLot;
        private DevExpress.XtraEditors.TextEdit txtItem;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraWaitForm.ProgressPanel ppnlWait;
        private System.Windows.Forms.Timer tmrGet;
    }
}
