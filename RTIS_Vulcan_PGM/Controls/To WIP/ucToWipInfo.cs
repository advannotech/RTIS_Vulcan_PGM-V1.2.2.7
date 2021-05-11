using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using RTIS_Vulcan_PGM.Forms;
using RTIS_Vulcan_PGM.Classes;
using System.Threading;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucToWipInfo : UserControl
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

        string dataLines = string.Empty;
        bool dataPulled = false;

        public ucToWipInfo(Panel _parent, frmMain _main)
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            parent = _parent;
            main = _main;
        }
        private void ucToWipInfo_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlOmniPad keypad = new cntrlOmniPad();
            keypad.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(keypad);

            txtBatch.Focus();
            GlobalVars.focusedEdit = txtBatch;

            ppnlWait.SendToBack();
            ppnlWait.Visible = false;
        }
        private void txtItem_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtBatch;
        }
        private void txtBatch_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtCont;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void txtBatch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtBatch.Text != string.Empty)
                    {
                        if (txtCont.Text.Substring(0, 5) == "CONT_" && txtCont.Text.Contains("$"))
                        {
                            SendData();
                        }
                        else
                        {
                            msg = new frmMsg("Error", "Please scan a valid container barcode!", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                        }
                    }
                    else
                    {
                        msg = new frmMsg("Cannot Continue", "Please enter a batch number", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtCont.Text = string.Empty;
                    }
                }               
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }

            //txtCont.Text = txtCont.Text.Substring(5, txtCont.Text.Length - 5);
            //txtCont.Text = txtCont.Text.Split('$')[0];

            //string whseFrom = string.Empty;
            //switch (GlobalVars.currentCompany)
            //{
            //    case GlobalVars.Companies.None:
            //        break;
            //    case GlobalVars.Companies.VW:
            //        whseFrom = GlobalVars.VWWhse;
            //        break;
            //    case GlobalVars.Companies.Toyota:
            //        whseFrom = GlobalVars.ToyotaWhse;
            //        break;
            //    default:
            //        break;
            //}

            //string fgType = string.Empty;
            //switch (GlobalVars.currentFGType)
            //{
            //    case GlobalVars.FGType.None:
            //        break;
            //    case GlobalVars.FGType.VWSlurry:
            //        fgType = "VW";
            //        break;
            //    case GlobalVars.FGType.ToyotaPowder:
            //        fgType = "TPP";
            //        break;
            //    case GlobalVars.FGType.ToyotaSlurry:
            //        fgType = "TSP";
            //        break;
            //    case GlobalVars.FGType.ToyotaAW:
            //        fgType = "TAW";
            //        break;
            //    default:
            //        break;
            //}

            //string transferred = Client.TransferItemToWIP(txtCont.Text + "|" + GlobalVars.WIPFGCode + "|" + txtBatch.Text + "|" + whseFrom + "|" + GlobalVars.userName + "|" + fgType);
            //if (transferred != string.Empty)
            //{
            //    switch (transferred.Split('*')[0])
            //    {
            //        case "1":
            //            msg = new frmMsg("Success", "Item successfully transferred", GlobalVars.msgState.Success);
            //            msg.ShowDialog();
            //            txtCont.Text = string.Empty;
            //            break;
            //        case "0":
            //            transferred = transferred.Remove(0, 2);
            //            msg = new frmMsg("The following server side issue was encountered:", transferred, GlobalVars.msgState.Error);
            //            msg.ShowDialog();
            //            break;
            //        case "-1":
            //            transferred = transferred.Remove(0, 3);
            //            errMsg = transferred.Split('|')[0];
            //            errInfo = transferred.Split('|')[1];
            //            ExHandler.showErrorStr(errMsg, errInfo);
            //            break;
            //        case "-2":
            //            transferred = transferred.Remove(0, 2);
            //            msg = new frmMsg("A connection level error has occured", transferred, GlobalVars.msgState.Error);
            //            msg.ShowDialog();
            //            break;
            //        default:
            //            st = new StackTrace(0, true);
            //            msgStr = "Unexpected error while manufacturing item";
            //            errInfo = "Unexpected error while manufacturing item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + transferred;
            //            break;
            //    }
            //}
            //else
            //{
            //    msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
            //    msg.ShowDialog();
            //}
        }
        public void SendData()
        {
            ppnlWait.BringToFront();
            ppnlWait.Visible = true;
            dataPulled = false;
            Application.DoEvents();
            tmrGet.Start();
            Thread thread = new Thread(getData);
            thread.Start();
        }
        public void getData()
        {
            try
            {
                txtCont.Text = txtCont.Text.Substring(5, txtCont.Text.Length - 5);
                txtCont.Text = txtCont.Text.Split('$')[0];

                string whseFrom = string.Empty;
                switch (GlobalVars.currentCompany)
                {
                    case GlobalVars.Companies.None:
                        break;
                    case GlobalVars.Companies.VW:
                        whseFrom = GlobalVars.VWWhse;
                        break;
                    case GlobalVars.Companies.Toyota:
                        whseFrom = GlobalVars.ToyotaWhse;
                        break;
                    default:
                        break;
                }

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

                dataLines = Client.TransferItemToWIP(txtCont.Text + "|" + GlobalVars.WIPFGCode + "|" + txtBatch.Text + "|" + whseFrom + "|" + GlobalVars.userName + "|" + fgType);
                dataPulled = true;
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        public void setData()
        {
            try
            {
                if (dataPulled == true)
                {
                    tmrGet.Stop();
                    string transferred = dataLines;
                    if (transferred != string.Empty)
                    {
                        switch (transferred.Split('*')[0])
                        {
                            case "1":
                                msg = new frmMsg("Success", "Item successfully transferred", GlobalVars.msgState.Success);
                                msg.ShowDialog();
                                txtCont.Text = string.Empty;
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "0":
                                transferred = transferred.Remove(0, 2);
                                msg = new frmMsg("The following server side issue was encountered:", transferred, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-1":
                                transferred = transferred.Remove(0, 3);
                                errMsg = transferred.Split('|')[0];
                                errInfo = transferred.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-2":
                                transferred = transferred.Remove(0, 2);
                                msg = new frmMsg("A connection level error has occured", transferred, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while manufacturing item";
                                errInfo = "Unexpected error while manufacturing item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + transferred;
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
                tmrGet.Stop();
                ExHandler.showErrorEx(ex);
                ppnlWait.SendToBack();
                ppnlWait.Visible = false;
            }
        }
        private void tmrGet_Tick(object sender, EventArgs e)
        {
            setData();
        }
    }
}
