namespace RTIS_Vulcan_PGM.Controls
{
    partial class cntrlWhse
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
            this.pnlBack = new System.Windows.Forms.Panel();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.White;
            this.pnlBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBack.Controls.Add(this.lblName);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1082, 150);
            this.pnlBack.TabIndex = 0;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Appearance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblName.Appearance.Options.UseFont = true;
            this.lblName.Appearance.Options.UseForeColor = true;
            this.lblName.Appearance.Options.UseTextOptions = true;
            this.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.Location = new System.Drawing.Point(45, 24);
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(983, 100);
            this.lblName.TabIndex = 81;
            this.lblName.Text = "[Whse]";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // cntrlWhse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "cntrlWhse";
            this.Size = new System.Drawing.Size(1082, 150);
            this.Load += new System.EventHandler(this.cntrlWhse_Load);
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        private DevExpress.XtraEditors.LabelControl lblName;
    }
}
