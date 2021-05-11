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
using System.Threading;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucItemTransactions : UserControl
    {
        #region Error handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        StackTrace st;
        string msgStr = string.Empty;
        string infoStr = string.Empty;
        #endregion

        public frmMain main;
        Panel parent;

        public string itemLines = string.Empty;
        public bool itemsPulled = false;

        public ucItemTransactions(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucItemTransactions_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            //getItems();
            refreshItems();
        }
        public void refreshItems()
        {
            ppnlWait.BringToFront();
            ppnlWait.Visible = true;
            itemsPulled = false;
            Application.DoEvents();
            tmrItems.Start();
            Thread thread = new Thread(getItems);
            thread.Start();
        }
        public void getItems()
        {
            try
            {
                string whse = string.Empty;
                switch (GlobalVars.currentCompany)
                {
                    case GlobalVars.Companies.None:
                        break;
                    case GlobalVars.Companies.VW:
                        whse = GlobalVars.VWWhse;
                        break;
                    case GlobalVars.Companies.Toyota:
                        whse = GlobalVars.ToyotaWhse;
                        break;
                    default:
                        break;
                }

                itemLines = Client.GetAllPGMTransactions(GlobalVars.TransactionItem + "|" + GlobalVars.TransactionBatch + "|" + whse);
                itemsPulled = true;
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }                   
        }
        public void setItems()
        {
            try
            {
                if (itemsPulled == true)
                {
                    tmrItems.Stop();
                    if (itemLines != string.Empty)
                    {
                        switch (itemLines.Split('*')[0])
                        {
                            case "1":
                                itemLines = itemLines.Remove(0, 2);
                                string[] alItems = itemLines.Split('~');
                                foreach (string item in alItems)
                                {
                                    if (item != string.Empty)
                                    {
                                        string username = item.Split('|')[0];
                                        string dateTime = item.Split('|')[1];
                                        string container = item.Split('|')[2];
                                        string concentration = item.Split('|')[3];
                                        string qtyIn = item.Split('|')[4];
                                        string qtyOut = item.Split('|')[5];
                                        string lotNumber = item.Split('|')[6];
                                        cntrlPGMTransaction PGM = new cntrlPGMTransaction(username, dateTime, container, concentration, qtyIn, qtyOut, lotNumber);
                                        double dIn = Convert.ToDouble(qtyIn.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep));
                                        double dOut = Convert.ToDouble(qtyOut.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep));
                                        if (dIn > 0)
                                        {
                                            PGM.lblIn.ForeColor = Color.Green;
                                        }
                                        if (dOut > 0)
                                        {
                                            PGM.lblOut.ForeColor = Color.Orange;
                                        }
                                        PGM.Dock = DockStyle.Top;
                                        pnlItems.Controls.Add(PGM);
                                    }
                                }

                                cntrlPGMTransaction title = new cntrlPGMTransaction("Username", "Date", "Container", "Concentration", "Qty In", "Qty Out", "Lot Number");
                                title.Dock = DockStyle.Top;
                                pnlItems.Controls.Add(title);
                                
                                if (pnlItems.Height < pnlParent.Height)
                                {
                                    vsbFG.Visible = false;
                                    pnlItems.Dock = DockStyle.Fill;
                                }
                                else
                                {
                                    vsbFG.Visible = true;
                                    vsbFG.BringToFront();
                                    pnlItems.Parent = pnlParent;
                                    pnlItems.Height = pnlItems.Height + 80;
                                    vsbFG.Maximum = pnlItems.Height - pnlParent.Height;
                                    vsbFG.LargeChange = vsbFG.Maximum / 6;
                                }
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "0":
                                itemLines = itemLines.Remove(0, 2);
                                msg = new frmMsg("The following server side issue was encountered:", itemLines, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-1":
                                itemLines = itemLines.Remove(0, 3);
                                errMsg = itemLines.Split('|')[0];
                                errInfo = itemLines.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-2":
                                itemLines = itemLines.Remove(0, 2);
                                msg = new frmMsg("A connection level error has occured", itemLines, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while getting items";
                                errInfo = "Unexpected error while getting itemS" + Environment.NewLine + "Data Returned:" + Environment.NewLine + itemLines;
                                ExHandler.showErrorST(st, msgStr, errInfo);
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                        }
                    }
                    else
                    {
                        msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        ppnlWait.SendToBack();
                        ppnlWait.Visible = false;
                    }
                }                
            }
            catch (Exception ex)
            {
                tmrItems.Stop();
                ExHandler.showErrorEx(ex);
                ppnlWait.SendToBack();
                ppnlWait.Visible = false;
            }
        }
        private void tmrItems_Tick(object sender, EventArgs e)
        {
            setItems();
        }
        private void vsbFG_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = pnlItems.Location;
            p.Y = 0 - e.NewValue;
            pnlItems.Location = p;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.lastControl = new ucSelectItem(parent, main);
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
