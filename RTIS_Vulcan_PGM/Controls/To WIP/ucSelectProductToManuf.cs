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
using System.Diagnostics;
using RTIS_Vulcan_PGM.Classes;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucSelectProductToManuf : UserControl
    {
        #region Error Handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        public StackTrace st;
        public string msgStr;
        #endregion

        Panel parent;
        public frmMain main;

        public ucSelectProductToManuf(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }      
        private void ucSelectProductToManuf_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getFGList();

            if (pnlFG.Height < pnlParent.Height)
            {
                vsbFG.Visible = false;
                pnlFG.Dock = DockStyle.Fill;
            }
            else
            {
                vsbFG.Visible = true;
                vsbFG.BringToFront();
                pnlFG.Parent = pnlParent;
                pnlFG.Height = pnlFG.Height + 80;
                vsbFG.Maximum = pnlFG.Height - pnlParent.Height;
                vsbFG.LargeChange = vsbFG.Maximum / 6;
            }
        }
        public void getFGList()
        {
            try
            {
                string fgType = string.Empty;
                switch (GlobalVars.currentFGType)
                {
                    case GlobalVars.FGType.None:
                        break;
                    case GlobalVars.FGType.VWSlurry:
                        fgType = "VW";
                        break;
                    case GlobalVars.FGType.ToyotaPowder:
                        fgType = "TPP";
                        break;
                    case GlobalVars.FGType.ToyotaSlurry:
                        fgType = "TSP";
                        break;
                    case GlobalVars.FGType.ToyotaAW:
                        fgType = "TAW";
                        break;
                    default:
                        break;
                }

                string fgList = Client.GetFGItems(fgType);
                if (fgList != string.Empty)
                {
                    switch (fgList.Split('*')[0])
                    {
                        case "1":
                            fgList = fgList.Remove(0, 2);
                            string[] allFGs = fgList.Split('~');
                            foreach (string fg in allFGs)
                            {
                                if (fg != string.Empty)
                                {
                                    cntrlFGItem fgItem = new cntrlFGItem(fg, this);
                                    fgItem.Dock = DockStyle.Top;
                                    pnlFG.Controls.Add(fgItem);
                                }
                            }
                            break;
                        case "0":
                            fgList = fgList.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", fgList, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            fgList = fgList.Remove(0, 3);
                            errMsg = fgList.Split('|')[0];
                            errInfo = fgList.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            fgList = fgList.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", fgList, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while getting item information";
                            errInfo = "Unexpected error while getting item information" + Environment.NewLine + "Data Returned:" + Environment.NewLine + fgList;
                            break;
                    }
                }
                else
                {
                    msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (cntrlFGItem item in pnlFG.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.WIPFGCode = item.code;
                    }
                }

                if (found == true)
                {
                    GlobalVars.lastControl = this;

                    ucToWipInfo wip = new ucToWipInfo(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(wip);
                }
                else
                {
                    msg = new frmMsg("Cannot Continue", "Please select an item", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
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

        private void vsbFG_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlFG.Location;
            p.Y = 0 - e.NewValue;
            pnlFG.Location = p;
        }
    }
}
