namespace RTIS_Vulcan_PGM.Controls
{
    partial class ucItemTransactions
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
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.vsbFG = new DevExpress.XtraEditors.VScrollBar();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.tmrItems = new System.Windows.Forms.Timer(this.components);
            this.ppnlWait = new DevExpress.XtraWaitForm.ProgressPanel();
            this.pnlParent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlParent
            // 
            this.pnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParent.Controls.Add(this.pnlItems);
            this.pnlParent.Controls.Add(this.vsbFG);
            this.pnlParent.Location = new System.Drawing.Point(21, 112);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1210, 642);
            this.pnlParent.TabIndex = 95;
            // 
            // pnlItems
            // 
            this.pnlItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlItems.AutoSize = true;
            this.pnlItems.Location = new System.Drawing.Point(3, 3);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1109, 634);
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
            this.vsbFG.Size = new System.Drawing.Size(89, 640);
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
            this.labelControl13.Location = new System.Drawing.Point(19, 9);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(1211, 96);
            this.labelControl13.TabIndex = 92;
            this.labelControl13.Text = "Transaction Veiwer";
            // 
            // tmrItems
            // 
            this.tmrItems.Tick += new System.EventHandler(this.tmrItems_Tick);
            // 
            // ppnlWait
            // 
            this.ppnlWait.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppnlWait.Appearance.BackColor = System.Drawing.Color.White;
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
            this.ppnlWait.Description = "Loading Transactions ...";
            this.ppnlWait.Location = new System.Drawing.Point(5, 112);
            this.ppnlWait.Name = "ppnlWait";
            this.ppnlWait.Size = new System.Drawing.Size(1246, 750);
            this.ppnlWait.TabIndex = 96;
            this.ppnlWait.Text = "progressPanel1";
            this.ppnlWait.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line;
            // 
            // ucItemTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.ppnlWait);
            this.Name = "ucItemTransactions";
            this.Size = new System.Drawing.Size(1254, 866);
            this.Load += new System.EventHandler(this.ucItemTransactions_Load);
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlParent;
        public System.Windows.Forms.Panel pnlItems;
        private DevExpress.XtraEditors.VScrollBar vsbFG;
        internal DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private System.Windows.Forms.Timer tmrItems;
        private DevExpress.XtraWaitForm.ProgressPanel ppnlWait;
    }
}
