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
using System.Diagnostics;
using System.Threading;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucScanItem : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        Panel parent;
        public frmMain main;
        public StackTrace st;
        public string msgStr;

        public string unq = string.Empty;

        string dataLines = string.Empty;
        bool dataPulled = false;

        string sentDataLines = string.Empty;
        bool dataSent = false;

        public ucScanItem(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucScanItem_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            txtItem.Focus();
            GlobalVars.focusedEdit = txtItem;

            ppnlWait.SendToBack();
            ppnlWait.Visible = false;
        }

        #region Scan Item
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtItem.Text.Contains("(") && txtItem.Text.Contains(")"))
                    {
                        refreshDesc();
                    }
                    else
                    {
                        msg = new frmMsg("Error", "Please scan a valid CATscan barcode!", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
                }            
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        public void refreshDesc()
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
                string itemCode = Barcodes.GetItemCode(txtItem.Text);
                dataLines = Client.GetFVItemDetails(itemCode); ;
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
                    string itemCode = Barcodes.GetItemCode(txtItem.Text);
                    string itemInfo = dataLines;
                    if (itemInfo != string.Empty)
                    {
                        switch (itemInfo.Split('*')[0])
                        {
                            case "1":
                                itemInfo = itemInfo.Remove(0, 2);
                                string desc = itemInfo;
                                lblItem.Text = itemCode;
                                lblDesc.Text = desc;
                                lblLot.Text = Barcodes.GetItemLot(txtItem.Text);
                                lblQty.Text = Barcodes.GetItemQty(txtItem.Text);
                                unq = Barcodes.GetUniqCode(txtItem.Text);
                                txtItem.Text = string.Empty;

                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "0":
                                itemInfo = itemInfo.Remove(0, 2);
                                msg = new frmMsg("The following server side issue was encountered:", itemInfo, GlobalVars.msgState.Error);
                                msg.ShowDialog();

                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-1":
                                itemInfo = itemInfo.Remove(0, 3);
                                errMsg = itemInfo.Split('|')[0];
                                errInfo = itemInfo.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);

                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            case "-2":
                                itemInfo = itemInfo.Remove(0, 2);
                                msg = new frmMsg("A connection level error has occured", itemInfo, GlobalVars.msgState.Error);
                                msg.ShowDialog();

                                ppnlWait.SendToBack();
                                ppnlWait.Visible = false;
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while getting item information";
                                errInfo = "Unexpected error while getting item information" + Environment.NewLine + "Data Returned:" + Environment.NewLine + itemInfo;

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
        #endregion

        #region Transfer Item
        private void btnTrans_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblItem.Text != string.Empty && lblLot.Text != string.Empty && lblQty.Text != string.Empty)
                {
                    string whseTo = string.Empty;
                    switch (GlobalVars.currentCompany)
                    {
                        case GlobalVars.Companies.None:
                            break;
                        case GlobalVars.Companies.VW:
                            whseTo = GlobalVars.VWIT;
                            break;
                        case GlobalVars.Companies.Toyota:
                            whseTo = GlobalVars.ToyotaIT;
                            break;
                        default:
                            break;
                    }

                    frmConfirm conf = new frmConfirm(lblItem.Text, lblLot.Text, lblQty.Text, GlobalVars.vaultWhse, whseTo, GlobalVars.currentState);
                    conf.ShowDialog();
                    DialogResult res = conf.DialogResult;
                    if (conf.DialogResult == DialogResult.Yes)
                    {
                        string transferred = Client.TransferFromVault(lblItem.Text + "|" + lblLot.Text + "|" + GlobalVars.vaultWhse + "|" + whseTo + "|" + lblQty.Text + "|" + GlobalVars.userName + "|PGM|" + unq);
                        if (transferred != string.Empty)
                        {
                            switch (transferred.Split('*')[0])
                            {
                                case "1":
                                    msg = new frmMsg("Success", "Item Transferred Successfully", GlobalVars.msgState.Success);
                                    msg.ShowDialog();
                                    txtItem.Text = string.Empty;
                                    lblItem.Text = string.Empty;
                                    lblDesc.Text = string.Empty;
                                    lblLot.Text = string.Empty;
                                    lblQty.Text = string.Empty;
                                    txtItem.Focus();
                                    break;
                                case "0":
                                    transferred = transferred.Remove(0, 2);
                                    msg = new frmMsg("The following server side issue was encountered:", transferred, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    break;
                                case "-1":
                                    transferred = transferred.Remove(0, 3);
                                    errMsg = transferred.Split('|')[0];
                                    errInfo = transferred.Split('|')[1];
                                    ExHandler.showErrorStr(errMsg, errInfo);
                                    break;
                                case "-2":
                                    transferred = transferred.Remove(0, 2);
                                    msg = new frmMsg("A connection level error has occured", transferred, GlobalVars.msgState.Error);
                                    msg.ShowDialog();
                                    break;
                                default:
                                    st = new StackTrace(0, true);
                                    msgStr = "Unexpected error while transferring item";
                                    errInfo = "Unexpected error while transferring item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + transferred;
                                    break;
                            }
                        }
                        else
                        {
                            msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                        }
                    }
                    else
                    {
                        txtItem.Text = string.Empty;
                        lblItem.Text = string.Empty;
                        lblDesc.Text = string.Empty;
                        lblLot.Text = string.Empty;
                        lblQty.Text = string.Empty;
                    }
                }
                else
                {
                    msg = new frmMsg("Cannot Continue", "Please scan a valid CATscan barcode", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        #endregion

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
