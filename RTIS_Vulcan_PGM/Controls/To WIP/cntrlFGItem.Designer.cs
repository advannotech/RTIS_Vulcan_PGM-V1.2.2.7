namespace RTIS_Vulcan_PGM.Controls
{
    partial class cntrlFGItem
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
            this.lblCode = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCode.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.Appearance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCode.Appearance.Options.UseBackColor = true;
            this.lblCode.Appearance.Options.UseFont = true;
            this.lblCode.Appearance.Options.UseForeColor = true;
            this.lblCode.Appearance.Options.UseTextOptions = true;
            this.lblCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCode.Location = new System.Drawing.Point(50, 25);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(983, 100);
            this.lblCode.TabIndex = 82;
            this.lblCode.Text = "[Code]";
            this.lblCode.Click += new System.EventHandler(this.lblCode_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 150);
            this.pnlBack.TabIndex = 83;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // cntrlFGItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlFGItem";
            this.Size = new System.Drawing.Size(1082, 150);
            this.Load += new System.EventHandler(this.cntrlFGItem_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBack;
        public DevExpress.XtraEditors.LabelControl lblCode;
    }
}
