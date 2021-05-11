using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Forms;
using System.Diagnostics;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucWarehouseFrom : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;
        public StackTrace st;
        public string msgStr;

        Panel parent;
        public frmMain main;

        public ucWarehouseFrom(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }
        private void ucWarehouseFrom_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            getFromWhses();

            if (pnlWhses.Height < pnlParent.Height)
            {
                vsbWhse.Visible = false;
                pnlWhses.Dock = DockStyle.Fill;
            }
            else
            {
                vsbWhse.Visible = true;
                vsbWhse.BringToFront();
                pnlWhses.Parent = pnlParent;
                pnlWhses.Height = pnlWhses.Height + 80;
                vsbWhse.Maximum = pnlWhses.Height - pnlParent.Height;
                vsbWhse.LargeChange = vsbWhse.Maximum / 6;               
            }
            
        }
        public void getFromWhses()
        {
            try
            {
                string allWhses = Client.GetFromWarehouses();
                if (allWhses != string.Empty)
                {
                    switch (allWhses.Split('*')[0])
                    {
                        case "1":
                            allWhses = allWhses.Remove(0, 2);
                            string[] allWhsesSplit = allWhses.Split('~');
                            foreach (string whse in allWhsesSplit)
                            {
                                if (whse != string.Empty)
                                {
                                    switch (GlobalVars.currentCompany)
                                    {
                                        case GlobalVars.Companies.None:
                                            break;
                                        case GlobalVars.Companies.VW:
                                            if (whse.Contains("(VW)"))
                                            {
                                                string code = whse.Split('|')[0];
                                                string name = whse.Split('|')[1];
                                                cntrlWhse whseItem = new cntrlWhse(name, code, this);
                                                whseItem.Dock = DockStyle.Top;

                                                //xscWhses.Controls.Add(whseItem);
                                                pnlWhses.Controls.Add(whseItem);
                                                whseItem.SendToBack();
                                            }
                                            break;
                                        case GlobalVars.Companies.Toyota:
                                            if (whse.Contains("(Toyota)"))
                                            {
                                                string code = whse.Split('|')[0];
                                                string name = whse.Split('|')[1];
                                                cntrlWhse whseItem = new cntrlWhse(name, code, this);
                                                whseItem.Dock = DockStyle.Top;

                                                //xscWhses.Controls.Add(whseItem);
                                                pnlWhses.Controls.Add(whseItem);
                                                whseItem.SendToBack();
                                            }        
                                            break;
                                        default:
                                            break;
                                    }
                                   
                                }
                            }
                            
                            break;
                        case "0":
                            allWhses = allWhses.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", allWhses, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            allWhses = allWhses.Remove(0, 3);
                            errMsg = allWhses.Split('|')[0];
                            errInfo = allWhses.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            allWhses = allWhses.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", allWhses, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error retreiving warehouse list";
                            errInfo = "Unexpected error retreiving warehouse list" + Environment.NewLine + "Data Returned:" + Environment.NewLine + allWhses;
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                foreach (cntrlWhse item in pnlWhses.Controls)
                {
                    if (item.selected == true)
                    {
                        found = true;
                        GlobalVars.RecWhseFromCode = item.code;
                        GlobalVars.RecWhseFromName = item.name;
                    }
                }

                if (found == true)
                {
                    GlobalVars.lastControl = this;
                    ucReceive rec = new ucReceive(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(rec);
                }
                else
                {
                    msg = new frmMsg("Cannot Continue", "Please select a warehouse", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void vsbWhse_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlWhses.Location;
            p.Y = 0 - e.NewValue;
            pnlWhses.Location = p;
        }
    }
}
