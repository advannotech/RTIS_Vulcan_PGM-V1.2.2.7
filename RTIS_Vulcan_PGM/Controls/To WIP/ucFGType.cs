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

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucFGType : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        Panel parent;
        public frmMain main;


        public ucFGType(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
            GlobalVars.lastControl = new ucCompany(parent, main);
        }

        private void ucFGType_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
        }
        private void btnFreshSlurry_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = main.pnlMain.Controls[0];
                GlobalVars.currentFGType = GlobalVars.FGType.ToyotaSlurry;
                ucSelectProductToManuf prod = new ucSelectProductToManuf(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(prod);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnPowder_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = main.pnlMain.Controls[0];
                GlobalVars.currentFGType = GlobalVars.FGType.ToyotaPowder;
                ucSelectProductToManuf prod = new ucSelectProductToManuf(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(prod);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnAW_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = main.pnlMain.Controls[0];
                GlobalVars.currentFGType = GlobalVars.FGType.ToyotaAW;
                ucSelectProductToManuf prod = new ucSelectProductToManuf(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(prod);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = new ucCompany(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }       
    }
}
