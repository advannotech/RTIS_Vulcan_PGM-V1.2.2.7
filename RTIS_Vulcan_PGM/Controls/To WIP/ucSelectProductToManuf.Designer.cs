namespace RTIS_Vulcan_PGM.Controls
{
    partial class ucSelectProductToManuf
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
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.pnlFG = new System.Windows.Forms.Panel();
            this.vsbFG = new DevExpress.XtraEditors.VScrollBar();
            this.pnlParent.SuspendLayout();
            this.SuspendLayout();
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
            this.labelControl13.TabIndex = 82;
            this.labelControl13.Text = "Select FG Product";
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
            this.btnBack.TabIndex = 86;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnNext.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.btnNext.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNext.Appearance.Options.UseBackColor = true;
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.Appearance.Options.UseForeColor = true;
            this.btnNext.Location = new System.Drawing.Point(1012, 761);
            this.btnNext.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNext.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnNext.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(222, 101);
            this.btnNext.TabIndex = 85;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlParent
            // 
            this.pnlParent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlParent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParent.Controls.Add(this.pnlFG);
            this.pnlParent.Controls.Add(this.vsbFG);
            this.pnlParent.Location = new System.Drawing.Point(22, 128);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1210, 610);
            this.pnlParent.TabIndex = 87;
            // 
            // pnlFG
            // 
            this.pnlFG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFG.AutoSize = true;
            this.pnlFG.Location = new System.Drawing.Point(3, 3);
            this.pnlFG.Name = "pnlFG";
            this.pnlFG.Size = new System.Drawing.Size(1109, 602);
            this.pnlFG.TabIndex = 85;
            // 
            // vsbFG
            // 
            this.vsbFG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vsbFG.Location = new System.Drawing.Point(1119, 0);
            this.vsbFG.Margin = new System.Windows.Forms.Padding(4);
            this.vsbFG.Name = "vsbFG";
            this.vsbFG.Opacity = 1F;
            this.vsbFG.Size = new System.Drawing.Size(89, 608);
            this.vsbFG.TabIndex = 1;
            this.vsbFG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFG_Scroll);
            // 
            // ucSelectProductToManuf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.labelControl13);
            this.Name = "ucSelectProductToManuf";
            this.Size = new System.Drawing.Size(1254, 866);
            this.Load += new System.EventHandler(this.ucSelectProductToManuf_Load);
            this.pnlParent.ResumeLayout(false);
            this.pnlParent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl13;
        internal DevExpress.XtraEditors.SimpleButton btnBack;
        internal DevExpress.XtraEditors.SimpleButton btnNext;
        private System.Windows.Forms.Panel pnlParent;
        public System.Windows.Forms.Panel pnlFG;
        private DevExpress.XtraEditors.VScrollBar vsbFG;
    }
}
