namespace RTIS_Vulcan_PGM.Forms
{
    partial class frmConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.xtcMain = new DevExpress.XtraTab.XtraTabControl();
            this.xtpFromVault = new DevExpress.XtraTab.XtraTabPage();
            this.lblFVTo = new DevExpress.XtraEditors.LabelControl();
            this.lblFVFrom = new DevExpress.XtraEditors.LabelControl();
            this.lblFVQty = new DevExpress.XtraEditors.LabelControl();
            this.lblFVLot = new DevExpress.XtraEditors.LabelControl();
            this.lblFVCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnFVYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnFVNo = new DevExpress.XtraEditors.SimpleButton();
            this.xtpReceive = new DevExpress.XtraTab.XtraTabPage();
            this.lblRecTo = new DevExpress.XtraEditors.LabelControl();
            this.lblRecFrom = new DevExpress.XtraEditors.LabelControl();
            this.lblRecQty = new DevExpress.XtraEditors.LabelControl();
            this.lblRecLot = new DevExpress.XtraEditors.LabelControl();
            this.lblRecCode = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.btnRecYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnRecNo = new DevExpress.XtraEditors.SimpleButton();
            this.xtpQuestion = new DevExpress.XtraTab.XtraTabPage();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.lblQuest = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.xtpVir = new DevExpress.XtraTab.XtraTabPage();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.btnVirOk = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtpInfo = new DevExpress.XtraTab.XtraTabPage();
            this.lblInfoHeader = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.btnInfoOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblInfoMsg = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).BeginInit();
            this.xtcMain.SuspendLayout();
            this.xtpFromVault.SuspendLayout();
            this.xtpReceive.SuspendLayout();
            this.xtpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.xtpVir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            this.xtpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xtcMain);
            this.panel1.Location = new System.Drawing.Point(13, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 419);
            this.panel1.TabIndex = 0;
            // 
            // xtcMain
            // 
            this.xtcMain.Appearance.BackColor = System.Drawing.Color.White;
            this.xtcMain.Appearance.Options.UseBackColor = true;
            this.xtcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcMain.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcMain.Location = new System.Drawing.Point(0, 0);
            this.xtcMain.Margin = new System.Windows.Forms.Padding(4);
            this.xtcMain.Name = "xtcMain";
            this.xtcMain.PaintStyleName = "Standard";
            this.xtcMain.SelectedTabPage = this.xtpFromVault;
            this.xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtcMain.Size = new System.Drawing.Size(577, 419);
            this.xtcMain.TabIndex = 61;
            this.xtcMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpFromVault,
            this.xtpReceive,
            this.xtpQuestion,
            this.xtpVir,
            this.xtpInfo});
            // 
            // xtpFromVault
            // 
            this.xtpFromVault.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpFromVault.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpFromVault.Controls.Add(this.lblFVTo);
            this.xtpFromVault.Controls.Add(this.lblFVFrom);
            this.xtpFromVault.Controls.Add(this.lblFVQty);
            this.xtpFromVault.Controls.Add(this.lblFVLot);
            this.xtpFromVault.Controls.Add(this.lblFVCode);
            this.xtpFromVault.Controls.Add(this.labelControl7);
            this.xtpFromVault.Controls.Add(this.labelControl6);
            this.xtpFromVault.Controls.Add(this.labelControl5);
            this.xtpFromVault.Controls.Add(this.labelControl4);
            this.xtpFromVault.Controls.Add(this.labelControl3);
            this.xtpFromVault.Controls.Add(this.labelControl2);
            this.xtpFromVault.Controls.Add(this.btnFVYes);
            this.xtpFromVault.Controls.Add(this.btnFVNo);
            this.xtpFromVault.Margin = new System.Windows.Forms.Padding(4);
            this.xtpFromVault.Name = "xtpFromVault";
            this.xtpFromVault.Size = new System.Drawing.Size(577, 396);
            this.xtpFromVault.Text = "To Vault";
            // 
            // lblFVTo
            // 
            this.lblFVTo.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVTo.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFVTo.Appearance.Options.UseFont = true;
            this.lblFVTo.Appearance.Options.UseForeColor = true;
            this.lblFVTo.Appearance.Options.UseTextOptions = true;
            this.lblFVTo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFVTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFVTo.Location = new System.Drawing.Point(218, 281);
            this.lblFVTo.Margin = new System.Windows.Forms.Padding(4);
            this.lblFVTo.Name = "lblFVTo";
            this.lblFVTo.Size = new System.Drawing.Size(351, 36);
            this.lblFVTo.TabIndex = 71;
            this.lblFVTo.Text = "[To]";
            // 
            // lblFVFrom
            // 
            this.lblFVFrom.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVFrom.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFVFrom.Appearance.Options.UseFont = true;
            this.lblFVFrom.Appearance.Options.UseForeColor = true;
            this.lblFVFrom.Appearance.Options.UseTextOptions = true;
            this.lblFVFrom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFVFrom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFVFrom.Location = new System.Drawing.Point(218, 239);
            this.lblFVFrom.Margin = new System.Windows.Forms.Padding(4);
            this.lblFVFrom.Name = "lblFVFrom";
            this.lblFVFrom.Size = new System.Drawing.Size(351, 36);
            this.lblFVFrom.TabIndex = 70;
            this.lblFVFrom.Text = "[From]";
            // 
            // lblFVQty
            // 
            this.lblFVQty.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVQty.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFVQty.Appearance.Options.UseFont = true;
            this.lblFVQty.Appearance.Options.UseForeColor = true;
            this.lblFVQty.Appearance.Options.UseTextOptions = true;
            this.lblFVQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFVQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFVQty.Location = new System.Drawing.Point(218, 197);
            this.lblFVQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblFVQty.Name = "lblFVQty";
            this.lblFVQty.Size = new System.Drawing.Size(351, 36);
            this.lblFVQty.TabIndex = 69;
            this.lblFVQty.Text = "[Qty]";
            // 
            // lblFVLot
            // 
            this.lblFVLot.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFVLot.Appearance.Options.UseFont = true;
            this.lblFVLot.Appearance.Options.UseForeColor = true;
            this.lblFVLot.Appearance.Options.UseTextOptions = true;
            this.lblFVLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFVLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFVLot.Location = new System.Drawing.Point(218, 155);
            this.lblFVLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblFVLot.Name = "lblFVLot";
            this.lblFVLot.Size = new System.Drawing.Size(351, 36);
            this.lblFVLot.TabIndex = 68;
            this.lblFVLot.Text = "[Lot Number]";
            // 
            // lblFVCode
            // 
            this.lblFVCode.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFVCode.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFVCode.Appearance.Options.UseFont = true;
            this.lblFVCode.Appearance.Options.UseForeColor = true;
            this.lblFVCode.Appearance.Options.UseTextOptions = true;
            this.lblFVCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFVCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblFVCode.Location = new System.Drawing.Point(218, 111);
            this.lblFVCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblFVCode.Name = "lblFVCode";
            this.lblFVCode.Size = new System.Drawing.Size(351, 36);
            this.lblFVCode.TabIndex = 67;
            this.lblFVCode.Text = "[Code]";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(4, 281);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(206, 34);
            this.labelControl7.TabIndex = 66;
            this.labelControl7.Text = "To:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(4, 239);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(206, 34);
            this.labelControl6.TabIndex = 65;
            this.labelControl6.Text = "From:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(4, 197);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(206, 34);
            this.labelControl5.TabIndex = 64;
            this.labelControl5.Text = "Quantity:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(4, 155);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(206, 34);
            this.labelControl4.TabIndex = 63;
            this.labelControl4.Text = "Lot Number: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(4, 111);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(206, 36);
            this.labelControl3.TabIndex = 62;
            this.labelControl3.Text = "Item Code: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(4, 4);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(565, 99);
            this.labelControl2.TabIndex = 61;
            this.labelControl2.Text = "Are you sure these details are correct?";
            // 
            // btnFVYes
            // 
            this.btnFVYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFVYes.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnFVYes.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFVYes.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnFVYes.Appearance.Options.UseBackColor = true;
            this.btnFVYes.Appearance.Options.UseFont = true;
            this.btnFVYes.Appearance.Options.UseForeColor = true;
            this.btnFVYes.Location = new System.Drawing.Point(391, 323);
            this.btnFVYes.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnFVYes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnFVYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnFVYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnFVYes.Name = "btnFVYes";
            this.btnFVYes.Size = new System.Drawing.Size(178, 69);
            this.btnFVYes.TabIndex = 40;
            this.btnFVYes.Text = "Yes";
            this.btnFVYes.Click += new System.EventHandler(this.btnFVYes_Click);
            // 
            // btnFVNo
            // 
            this.btnFVNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFVNo.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnFVNo.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFVNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnFVNo.Appearance.Options.UseBackColor = true;
            this.btnFVNo.Appearance.Options.UseFont = true;
            this.btnFVNo.Appearance.Options.UseForeColor = true;
            this.btnFVNo.Location = new System.Drawing.Point(4, 323);
            this.btnFVNo.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnFVNo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnFVNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnFVNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnFVNo.Name = "btnFVNo";
            this.btnFVNo.Size = new System.Drawing.Size(178, 69);
            this.btnFVNo.TabIndex = 38;
            this.btnFVNo.Text = "No";
            this.btnFVNo.Click += new System.EventHandler(this.btnFVNo_Click);
            // 
            // xtpReceive
            // 
            this.xtpReceive.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpReceive.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpReceive.Controls.Add(this.lblRecTo);
            this.xtpReceive.Controls.Add(this.lblRecFrom);
            this.xtpReceive.Controls.Add(this.lblRecQty);
            this.xtpReceive.Controls.Add(this.lblRecLot);
            this.xtpReceive.Controls.Add(this.lblRecCode);
            this.xtpReceive.Controls.Add(this.labelControl14);
            this.xtpReceive.Controls.Add(this.labelControl15);
            this.xtpReceive.Controls.Add(this.labelControl16);
            this.xtpReceive.Controls.Add(this.labelControl17);
            this.xtpReceive.Controls.Add(this.labelControl18);
            this.xtpReceive.Controls.Add(this.labelControl19);
            this.xtpReceive.Controls.Add(this.btnRecYes);
            this.xtpReceive.Controls.Add(this.btnRecNo);
            this.xtpReceive.Margin = new System.Windows.Forms.Padding(4);
            this.xtpReceive.Name = "xtpReceive";
            this.xtpReceive.Size = new System.Drawing.Size(577, 396);
            this.xtpReceive.Text = "Receive";
            // 
            // lblRecTo
            // 
            this.lblRecTo.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecTo.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecTo.Appearance.Options.UseFont = true;
            this.lblRecTo.Appearance.Options.UseForeColor = true;
            this.lblRecTo.Appearance.Options.UseTextOptions = true;
            this.lblRecTo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecTo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecTo.Location = new System.Drawing.Point(220, 281);
            this.lblRecTo.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecTo.Name = "lblRecTo";
            this.lblRecTo.Size = new System.Drawing.Size(351, 36);
            this.lblRecTo.TabIndex = 84;
            this.lblRecTo.Text = "[To]";
            // 
            // lblRecFrom
            // 
            this.lblRecFrom.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecFrom.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecFrom.Appearance.Options.UseFont = true;
            this.lblRecFrom.Appearance.Options.UseForeColor = true;
            this.lblRecFrom.Appearance.Options.UseTextOptions = true;
            this.lblRecFrom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecFrom.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecFrom.Location = new System.Drawing.Point(220, 239);
            this.lblRecFrom.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecFrom.Name = "lblRecFrom";
            this.lblRecFrom.Size = new System.Drawing.Size(351, 36);
            this.lblRecFrom.TabIndex = 83;
            this.lblRecFrom.Text = "[From]";
            // 
            // lblRecQty
            // 
            this.lblRecQty.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecQty.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecQty.Appearance.Options.UseFont = true;
            this.lblRecQty.Appearance.Options.UseForeColor = true;
            this.lblRecQty.Appearance.Options.UseTextOptions = true;
            this.lblRecQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecQty.Location = new System.Drawing.Point(220, 197);
            this.lblRecQty.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecQty.Name = "lblRecQty";
            this.lblRecQty.Size = new System.Drawing.Size(351, 36);
            this.lblRecQty.TabIndex = 82;
            this.lblRecQty.Text = "[Qty]";
            // 
            // lblRecLot
            // 
            this.lblRecLot.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecLot.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecLot.Appearance.Options.UseFont = true;
            this.lblRecLot.Appearance.Options.UseForeColor = true;
            this.lblRecLot.Appearance.Options.UseTextOptions = true;
            this.lblRecLot.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecLot.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecLot.Location = new System.Drawing.Point(220, 155);
            this.lblRecLot.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecLot.Name = "lblRecLot";
            this.lblRecLot.Size = new System.Drawing.Size(351, 36);
            this.lblRecLot.TabIndex = 81;
            this.lblRecLot.Text = "[Lot Number]";
            // 
            // lblRecCode
            // 
            this.lblRecCode.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecCode.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecCode.Appearance.Options.UseFont = true;
            this.lblRecCode.Appearance.Options.UseForeColor = true;
            this.lblRecCode.Appearance.Options.UseTextOptions = true;
            this.lblRecCode.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblRecCode.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblRecCode.Location = new System.Drawing.Point(220, 111);
            this.lblRecCode.Margin = new System.Windows.Forms.Padding(4);
            this.lblRecCode.Name = "lblRecCode";
            this.lblRecCode.Size = new System.Drawing.Size(351, 36);
            this.lblRecCode.TabIndex = 80;
            this.lblRecCode.Text = "[Code]";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl14.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl14.Appearance.Options.UseFont = true;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl14.Location = new System.Drawing.Point(6, 281);
            this.labelControl14.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(206, 34);
            this.labelControl14.TabIndex = 79;
            this.labelControl14.Text = "To:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl15.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Appearance.Options.UseForeColor = true;
            this.labelControl15.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl15.Location = new System.Drawing.Point(6, 239);
            this.labelControl15.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(206, 34);
            this.labelControl15.TabIndex = 78;
            this.labelControl15.Text = "From:";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl16.Appearance.Options.UseFont = true;
            this.labelControl16.Appearance.Options.UseForeColor = true;
            this.labelControl16.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl16.Location = new System.Drawing.Point(6, 197);
            this.labelControl16.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(206, 34);
            this.labelControl16.TabIndex = 77;
            this.labelControl16.Text = "Quantity:";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Calibri", 18F);
            this.labelControl17.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl17.Appearance.Options.UseFont = true;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl17.Location = new System.Drawing.Point(6, 155);
            this.labelControl17.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(206, 34);
            this.labelControl17.TabIndex = 76;
            this.labelControl17.Text = "Lot Number: ";
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl18.Appearance.Options.UseFont = true;
            this.labelControl18.Appearance.Options.UseForeColor = true;
            this.labelControl18.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl18.Location = new System.Drawing.Point(6, 111);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(206, 36);
            this.labelControl18.TabIndex = 75;
            this.labelControl18.Text = "Item Code: ";
            // 
            // labelControl19
            // 
            this.labelControl19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Appearance.Options.UseForeColor = true;
            this.labelControl19.Appearance.Options.UseTextOptions = true;
            this.labelControl19.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl19.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl19.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl19.Location = new System.Drawing.Point(6, 4);
            this.labelControl19.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(565, 99);
            this.labelControl19.TabIndex = 74;
            this.labelControl19.Text = "Are you sure these details are correct?";
            // 
            // btnRecYes
            // 
            this.btnRecYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecYes.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnRecYes.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecYes.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRecYes.Appearance.Options.UseBackColor = true;
            this.btnRecYes.Appearance.Options.UseFont = true;
            this.btnRecYes.Appearance.Options.UseForeColor = true;
            this.btnRecYes.Location = new System.Drawing.Point(393, 323);
            this.btnRecYes.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnRecYes.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnRecYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRecYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecYes.Name = "btnRecYes";
            this.btnRecYes.Size = new System.Drawing.Size(178, 69);
            this.btnRecYes.TabIndex = 73;
            this.btnRecYes.Text = "Yes";
            this.btnRecYes.Click += new System.EventHandler(this.btnRecYes_Click);
            // 
            // btnRecNo
            // 
            this.btnRecNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecNo.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnRecNo.Appearance.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecNo.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRecNo.Appearance.Options.UseBackColor = true;
            this.btnRecNo.Appearance.Options.UseFont = true;
            this.btnRecNo.Appearance.Options.UseForeColor = true;
            this.btnRecNo.Location = new System.Drawing.Point(6, 323);
            this.btnRecNo.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnRecNo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.btnRecNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRecNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecNo.Name = "btnRecNo";
            this.btnRecNo.Size = new System.Drawing.Size(206, 69);
            this.btnRecNo.TabIndex = 72;
            this.btnRecNo.Text = "No";
            this.btnRecNo.Click += new System.EventHandler(this.btnRecNo_Click);
            // 
            // xtpQuestion
            // 
            this.xtpQuestion.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpQuestion.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpQuestion.Controls.Add(this.btnNo);
            this.xtpQuestion.Controls.Add(this.btnYes);
            this.xtpQuestion.Controls.Add(this.lblQuest);
            this.xtpQuestion.Controls.Add(this.pictureEdit3);
            this.xtpQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.xtpQuestion.Name = "xtpQuestion";
            this.xtpQuestion.Size = new System.Drawing.Size(577, 396);
            this.xtpQuestion.Text = "xtraTabPage1";
            // 
            // btnNo
            // 
            this.btnNo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNo.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnNo.Appearance.Options.UseBackColor = true;
            this.btnNo.Location = new System.Drawing.Point(329, 208);
            this.btnNo.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnNo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnNo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(168, 49);
            this.btnNo.TabIndex = 44;
            this.btnNo.Text = "No";
            // 
            // btnYes
            // 
            this.btnYes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnYes.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnYes.Appearance.Options.UseBackColor = true;
            this.btnYes.Location = new System.Drawing.Point(16, 208);
            this.btnYes.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnYes.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnYes.Margin = new System.Windows.Forms.Padding(4);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(168, 49);
            this.btnYes.TabIndex = 43;
            this.btnYes.Text = "Yes";
            // 
            // lblQuest
            // 
            this.lblQuest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuest.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuest.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblQuest.Appearance.Options.UseFont = true;
            this.lblQuest.Appearance.Options.UseForeColor = true;
            this.lblQuest.Appearance.Options.UseTextOptions = true;
            this.lblQuest.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblQuest.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblQuest.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblQuest.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblQuest.Location = new System.Drawing.Point(4, 75);
            this.lblQuest.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(505, 126);
            this.lblQuest.TabIndex = 42;
            this.lblQuest.Text = "The following error has occured:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(229, 16);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit3.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit3.TabIndex = 0;
            // 
            // xtpVir
            // 
            this.xtpVir.Appearance.PageClient.BackColor = System.Drawing.Color.White;
            this.xtpVir.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpVir.Controls.Add(this.pictureEdit4);
            this.xtpVir.Controls.Add(this.btnVirOk);
            this.xtpVir.Controls.Add(this.labelControl1);
            this.xtpVir.Margin = new System.Windows.Forms.Padding(4);
            this.xtpVir.Name = "xtpVir";
            this.xtpVir.Size = new System.Drawing.Size(577, 396);
            this.xtpVir.Text = "xtraTabPage1";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit4.Location = new System.Drawing.Point(229, 27);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit4.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit4.TabIndex = 40;
            // 
            // btnVirOk
            // 
            this.btnVirOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVirOk.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnVirOk.Appearance.Options.UseBackColor = true;
            this.btnVirOk.Location = new System.Drawing.Point(171, 201);
            this.btnVirOk.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnVirOk.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnVirOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnVirOk.Name = "btnVirOk";
            this.btnVirOk.Size = new System.Drawing.Size(168, 49);
            this.btnVirOk.TabIndex = 39;
            this.btnVirOk.Text = "OK";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(69, 97);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(380, 84);
            this.labelControl1.TabIndex = 38;
            this.labelControl1.Text = "Initial use detected\r\n\r\nYou will be logged in as a Service User";
            // 
            // xtpInfo
            // 
            this.xtpInfo.Appearance.PageClient.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xtpInfo.Appearance.PageClient.Options.UseBackColor = true;
            this.xtpInfo.Controls.Add(this.lblInfoHeader);
            this.xtpInfo.Controls.Add(this.pictureEdit5);
            this.xtpInfo.Controls.Add(this.btnInfoOK);
            this.xtpInfo.Controls.Add(this.lblInfoMsg);
            this.xtpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.xtpInfo.Name = "xtpInfo";
            this.xtpInfo.Size = new System.Drawing.Size(577, 396);
            this.xtpInfo.Text = "Info";
            // 
            // lblInfoHeader
            // 
            this.lblInfoHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoHeader.Appearance.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoHeader.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblInfoHeader.Appearance.Options.UseFont = true;
            this.lblInfoHeader.Appearance.Options.UseForeColor = true;
            this.lblInfoHeader.Appearance.Options.UseTextOptions = true;
            this.lblInfoHeader.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfoHeader.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblInfoHeader.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblInfoHeader.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInfoHeader.Location = new System.Drawing.Point(67, 91);
            this.lblInfoHeader.Margin = new System.Windows.Forms.Padding(4);
            this.lblInfoHeader.Name = "lblInfoHeader";
            this.lblInfoHeader.Size = new System.Drawing.Size(380, 25);
            this.lblInfoHeader.TabIndex = 44;
            this.lblInfoHeader.Text = "info header";
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit5.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit5.Location = new System.Drawing.Point(227, 21);
            this.pictureEdit5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit5.Size = new System.Drawing.Size(68, 63);
            this.pictureEdit5.TabIndex = 43;
            // 
            // btnInfoOK
            // 
            this.btnInfoOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInfoOK.Appearance.BackColor = System.Drawing.Color.Black;
            this.btnInfoOK.Appearance.Options.UseBackColor = true;
            this.btnInfoOK.Location = new System.Drawing.Point(168, 194);
            this.btnInfoOK.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnInfoOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnInfoOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnInfoOK.Name = "btnInfoOK";
            this.btnInfoOK.Size = new System.Drawing.Size(168, 49);
            this.btnInfoOK.TabIndex = 42;
            this.btnInfoOK.Text = "OK";
            // 
            // lblInfoMsg
            // 
            this.lblInfoMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoMsg.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMsg.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblInfoMsg.Appearance.Options.UseFont = true;
            this.lblInfoMsg.Appearance.Options.UseForeColor = true;
            this.lblInfoMsg.Appearance.Options.UseTextOptions = true;
            this.lblInfoMsg.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblInfoMsg.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblInfoMsg.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblInfoMsg.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblInfoMsg.Location = new System.Drawing.Point(67, 123);
            this.lblInfoMsg.Margin = new System.Windows.Forms.Padding(4);
            this.lblInfoMsg.Name = "lblInfoMsg";
            this.lblInfoMsg.Size = new System.Drawing.Size(380, 64);
            this.lblInfoMsg.TabIndex = 41;
            this.lblInfoMsg.Text = "info message";
            // 
            // labelControl13
            // 
            this.labelControl13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Appearance.Options.UseTextOptions = true;
            this.labelControl13.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl13.Location = new System.Drawing.Point(13, 13);
            this.labelControl13.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(569, 44);
            this.labelControl13.TabIndex = 60;
            this.labelControl13.Text = "Confirm";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 495);
            this.panel2.TabIndex = 61;
            // 
            // frmConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirm";
            this.Load += new System.EventHandler(this.frmConfirm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcMain)).EndInit();
            this.xtcMain.ResumeLayout(false);
            this.xtpFromVault.ResumeLayout(false);
            this.xtpReceive.ResumeLayout(false);
            this.xtpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.xtpVir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            this.xtpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraTab.XtraTabControl xtcMain;
        private DevExpress.XtraTab.XtraTabPage xtpFromVault;
        private DevExpress.XtraEditors.SimpleButton btnFVNo;
        private DevExpress.XtraTab.XtraTabPage xtpReceive;
        private DevExpress.XtraTab.XtraTabPage xtpQuestion;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.LabelControl lblQuest;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraTab.XtraTabPage xtpVir;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.SimpleButton btnVirOk;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtpInfo;
        private DevExpress.XtraEditors.LabelControl lblInfoHeader;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.SimpleButton btnInfoOK;
        private DevExpress.XtraEditors.LabelControl lblInfoMsg;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnFVYes;
        private DevExpress.XtraEditors.LabelControl lblFVTo;
        private DevExpress.XtraEditors.LabelControl lblFVFrom;
        private DevExpress.XtraEditors.LabelControl lblFVQty;
        private DevExpress.XtraEditors.LabelControl lblFVLot;
        private DevExpress.XtraEditors.LabelControl lblFVCode;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl lblRecTo;
        private DevExpress.XtraEditors.LabelControl lblRecFrom;
        private DevExpress.XtraEditors.LabelControl lblRecQty;
        private DevExpress.XtraEditors.LabelControl lblRecLot;
        private DevExpress.XtraEditors.LabelControl lblRecCode;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.SimpleButton btnRecYes;
        private DevExpress.XtraEditors.SimpleButton btnRecNo;
    }
}