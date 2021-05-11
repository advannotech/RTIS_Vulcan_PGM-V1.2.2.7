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

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucDecant : UserControl
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
        string checkCode = string.Empty;
        bool remCap = false;

        public ucDecant(Panel _parent, frmMain _main, bool _remCap)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
            remCap = _remCap;
        }
        private void ucDecant_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;
            cntrlOmniPad keypad = new cntrlOmniPad();
            keypad.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(keypad);

            txtWeight1.Focus();
            GlobalVars.focusedEdit = txtWeight1;

            getBatchContainers();
            //txtContainer.Text = "CONT_ND-VW-33$CHEM-1640";
        }
        public void getBatchContainers()
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
                string batchcontainers = Client.getBatchLines(GlobalVars.manufItem + "|" + GlobalVars.manufBatch + "|" + whse);
                if (batchcontainers != string.Empty)
                {
                    switch (batchcontainers.Split('*')[0])
                    {
                        case "1":
                            batchcontainers = batchcontainers.Remove(0, 2);
                            string[] allBatchContainers = batchcontainers.Split('~');
                            foreach (string container in allBatchContainers)
                            {
                                if (container != string.Empty)
                                {
                                    string contNo = container.Split('|')[0];
                                    string weight = container.Split('|')[1];
                                    bool manuf = Convert.ToBoolean(container.Split('|')[2]);
                                    bool trans = Convert.ToBoolean(container.Split('|')[3]);
                                    cntrlContainerItem contItem = new cntrlContainerItem(GlobalVars.manufItem, GlobalVars.manufBatch, GlobalVars.manufConcen, weight, contNo, manuf, trans);
                                    contItem.Dock = DockStyle.Top;
                                    xscContainers.Controls.Add(contItem);
                                }
                            }
                            break;
                        case "0":

                            //batchcontainers = batchcontainers.Remove(0, 2);
                            //msg = new frmMsg("The following server side issue was encountered:", batchcontainers, GlobalVars.msgState.Error);
                            //msg.ShowDialog();
                            break;
                        case "-1":
                            batchcontainers = batchcontainers.Remove(0, 3);
                            errMsg = batchcontainers.Split('|')[0];
                            errInfo = batchcontainers.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            batchcontainers = batchcontainers.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", batchcontainers, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while getting batch containers";
                            errInfo = "Unexpected error while getting batch containers" + Environment.NewLine + "Data Returned:" + Environment.NewLine + batchcontainers;
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
        private void txtContainer_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txtContainer.Text.Substring(0, 5) == "CONT_" && txtContainer.Text.Contains("$"))
                    {
                        txtContainer.Text = txtContainer.Text.Substring(5, txtContainer.Text.Length - 5);
                        checkCode = txtContainer.Text.Split('$')[1];
                        txtContainer.Text = txtContainer.Text.Split('$')[0];
                        if (GlobalVars.manufItem != checkCode)
                        {
                            msg = new frmMsg("Error", "Invalid container for item!", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            txtContainer.Text = string.Empty;
                        }
                    }
                    else
                    {
                        msg = new frmMsg("Error", "Please scan a valid container barcode!", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
                }         
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnManufacture_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtWeight1.Text != string.Empty && txtWeight2.Text != string.Empty && txtContainer.Text != string.Empty)
                {
                    string weight = txtWeight1.Text + "." + txtWeight2.Text;
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
                    string manufactured = Client.manufacturePGM(GlobalVars.manufItem + "|" + GlobalVars.manufBatch + "|" + txtContainer.Text + "|" + weight + "|" + GlobalVars.manufConcen + "|" + whse + "|" + GlobalVars.userName);
                    if (manufactured != string.Empty)
                    {
                        switch (manufactured.Split('*')[0])
                        {
                            case "1":
                                cntrlContainerItem contItem = new cntrlContainerItem(GlobalVars.manufItem, GlobalVars.manufBatch, GlobalVars.manufConcen, weight, txtContainer.Text, false, false);
                                contItem.Dock = DockStyle.Top;
                                xscContainers.Controls.Add(contItem);
                                //txtWeight1.Text = string.Empty;
                                //txtWeight2.Text = string.Empty;
                                txtContainer.Text = string.Empty;

                                txtWeight1.Focus();
                                GlobalVars.focusedEdit = txtWeight1;
                                break;
                            case "2":
                                //Container In use and not received
                                manufactured = manufactured.Remove(0, 2);
                                msg = new frmMsg("", manufactured, GlobalVars.msgState.Question);
                                msg.ShowDialog();
                                if (msg.DialogResult == DialogResult.Yes)
                                {
                                    refillContainer();
                                }
                                break;
                            case "3":
                                //Container In use and received
                                //manufactured = manufactured.Remove(0, 2);
                                //msg = new frmMsg("", manufactured, GlobalVars.msgState.Question);
                                //msg.ShowDialog();
                                //if (msg.DialogResult == DialogResult.Yes)
                                //{
                                //    refillContainer();
                                //}
                                break;
                            case "0":
                                manufactured = manufactured.Remove(0, 2);
                                msg = new frmMsg("The following server side issue was encountered:", manufactured, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                break;
                            case "-1":
                                manufactured = manufactured.Remove(0, 3);
                                errMsg = manufactured.Split('|')[0];
                                errInfo = manufactured.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);
                                break;
                            case "-2":
                                manufactured = manufactured.Remove(0, 2);
                                msg = new frmMsg("A connection level error has occured", manufactured, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while manufacturing item";
                                errInfo = "Unexpected error while manufacturing item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + manufactured;
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
                    msg = new frmMsg("Cannot Continue", "Please enter all valid information before continuing", GlobalVars.msgState.Error);
                    msg.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        public void refillContainer()
        {
            try
            {
                string weight = txtWeight1.Text + "." + txtWeight2.Text;
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
                string refilled = Client.refillPGM(GlobalVars.manufItem + "|" + GlobalVars.manufBatch + "|" + txtContainer.Text + "|" + weight + "|" + GlobalVars.manufConcen + "|" + whse + "|" + GlobalVars.userName);
                if (refilled != string.Empty)
                {
                    switch (refilled.Split('*')[0])
                    {
                        case "1":
                            cntrlContainerItem contItem = new cntrlContainerItem(GlobalVars.manufItem, GlobalVars.manufBatch, GlobalVars.manufConcen, weight, txtContainer.Text, false, false);
                            contItem.Dock = DockStyle.Top;
                            xscContainers.Controls.Add(contItem);
                            //txtWeight1.Text = string.Empty;
                            //txtWeight2.Text = string.Empty;
                            txtContainer.Text = string.Empty;

                            txtWeight1.Focus();
                            GlobalVars.focusedEdit = txtWeight1;
                            break;                        
                        case "0":
                            refilled = refilled.Remove(0, 2);
                            using (msg = new frmMsg("The following server side issue was encountered:", refilled, GlobalVars.msgState.Error))
                            {
                                msg.ShowDialog();
                            }
                            break;
                        case "-1":
                            refilled = refilled.Remove(0, 3);
                            errMsg = refilled.Split('|')[0];
                            errInfo = refilled.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            refilled = refilled.Remove(0, 2);
                            using (msg = new frmMsg("A connection level error has occured", refilled, GlobalVars.msgState.Error))
                            {
                                msg.ShowDialog();
                            }
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while manufacturing item";
                            errInfo = "Unexpected error while manufacturing item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + refilled;
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
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(GlobalVars.lastControl);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void txtWeight1_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtWeight1;
        }
        private void txtWeight2_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtWeight2;
        }
        private void txtContainer_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtContainer;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                if (!remCap)
                {
                    using (frmRemainder remainder = new frmRemainder())
                    {
                        remainder.ShowDialog();
                        if (remainder.DialogResult == DialogResult.OK)
                        {
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(new ucMenu(parent, main));
                        }
                    }
                }
                else
                {
                    using (msg = new frmMsg("Cannot capture remainder", "The remainder for this batch has already been captured!", GlobalVars.msgState.Error))
                    {
                        msg.ShowDialog();
                    }
                }
               
                
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
