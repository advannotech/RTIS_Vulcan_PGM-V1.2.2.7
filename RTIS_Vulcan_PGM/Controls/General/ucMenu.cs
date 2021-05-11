using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Forms;
using RTIS_Vulcan_PGM.Classes;
using Q183543;
using DevExpress.XtraEditors;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucMenu : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        Panel parent;
        public frmMain main;

        public ucMenu(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            foreach (string permission in GlobalVars.userPerms)
            {
                foreach (SimpleButton butt in pnlButtons.Controls)
                {
                    if (butt.Text.ToUpper() == permission.Replace(" (PGM)", string.Empty).ToUpper())
                    {
                        butt.Enabled = true;
                        butt.ForeColor = Color.White;
                        butt.Appearance.BackColor = Color.Teal;
                    }
                }
            }
        }

        private void btnFromVault_Click(object sender, EventArgs e)
        {
            GlobalVars.lastControl = main.pnlMain.Controls[0];
            GlobalVars.currentState = GlobalVars.ApplicationStates.FromV;
            try
            {
                ucCompany company = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(company);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            GlobalVars.currentState = GlobalVars.ApplicationStates.Rec;
            try
            {
                ucCompany company = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(company);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnManufacture_Click(object sender, EventArgs e)
        {
            GlobalVars.currentState = GlobalVars.ApplicationStates.Manuf;
            try
            {
                ucCompany company = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(company);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnToWIP_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.ShowDialog();
            GlobalVars.currentState = GlobalVars.ApplicationStates.ToWip;
            try
            {
                ucCompany company = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(company);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnTransViewer_Click(object sender, EventArgs e)
        {
            GlobalVars.currentState = GlobalVars.ApplicationStates.TransView;
            try
            {
                ucCompany company = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(company);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.userName = string.Empty;
                ucLogin login = new ucLogin(parent, main);
                GlobalVars.lastControl = login;
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(login);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
