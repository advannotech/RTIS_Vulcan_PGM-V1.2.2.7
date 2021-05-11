using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Forms;
using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Controls;

namespace RTIS_Vulcan_PGM
{
    public partial class ucManufacture : UserControl
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

        public ucManufacture(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucManufacture_Load(object sender, EventArgs e)
        {
            this.Size = parent.Size;

            cntrlOmniPad keypad = new cntrlOmniPad();
            keypad.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(keypad);

            txtItem.Focus();
            GlobalVars.focusedEdit = txtItem;

            //txtItem.Text = "SOL-10H VW@1.200";
            //txtBatch.Text = "184";
        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtItem;
        }

        private void txtBatch_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtBatch;
        }

        private void txtConcentration_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtConcentration;
        }
        private void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtItem.Text.Contains("@"))
                    {
                        string barcode = txtItem.Text.Split('@')[0];
                        string concentration = txtItem.Text.Split('@')[1];
                        txtItem.Text = barcode;
                        txtConcentration.Text = concentration.Replace("%", string.Empty);
                        txtItem.Enabled = false;
                        txtConcentration.Enabled = false;
                        btnBack.Text = "Clear";

                        txtBatch.Focus();
                        GlobalVars.focusedEdit = txtBatch;
                    }
                    else
                    {
                        msg = new frmMsg("Cannot continue", "Please sacn a valid barcode", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                        txtItem.Text = string.Empty;
                    }
                }
                catch (Exception ex)
                {
                    ExHandler.showErrorEx(ex);
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text != string.Empty && txtBatch.Text != string.Empty && txtConcentration.Text != string.Empty)
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
                    string remEntered = Client.getRemainderCaptured(txtItem.Text + "|" + txtBatch.Text + "|" + whse);
                    switch (remEntered.Split('*')[0])
                    {
                        case "1":
                            remEntered = remEntered.Remove(0, 2);
                            bool remCap = Convert.ToBoolean(remEntered);

                            GlobalVars.lastControl = this;
                            GlobalVars.manufItem = txtItem.Text;
                            GlobalVars.manufBatch = txtBatch.Text;
                            GlobalVars.manufConcen = txtConcentration.Text;

                            ucDecant dec = new ucDecant(parent, main, remCap);
                            main.pnlMain.Controls.Clear();
                            main.pnlMain.Controls.Add(dec);
                            break;
                        case "0":
                            remEntered = remEntered.Remove(0, 2);
                            msg = new frmMsg("The following server side issue was encountered:", remEntered, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        case "-1":
                            remEntered = remEntered.Remove(0, 3);
                            errMsg = remEntered.Split('|')[0];
                            errInfo = remEntered.Split('|')[1];
                            ExHandler.showErrorStr(errMsg, errInfo);
                            break;
                        case "-2":
                            remEntered = remEntered.Remove(0, 2);
                            msg = new frmMsg("A connection level error has occured", remEntered, GlobalVars.msgState.Error);
                            msg.ShowDialog();
                            break;
                        default:
                            st = new StackTrace(0, true);
                            msgStr = "Unexpected error while manufacturing item";
                            errInfo = "Unexpected error while manufacturing item" + Environment.NewLine + "Data Returned:" + Environment.NewLine + remEntered;
                            break;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnBack.Text == "Clear")
                {
                    txtItem.Text = string.Empty;
                    txtConcentration.Text = string.Empty;
                    txtBatch.Text = string.Empty;
                    txtItem.Enabled = true;
                    txtConcentration.Enabled = true;
                    txtItem.Focus();
                    GlobalVars.focusedEdit = txtItem;
                    btnBack.Text = "Back";
                }
                else
                {
                    GlobalVars.lastControl = new ucCompany(parent, main);
                    main.pnlMain.Controls.Clear();
                    main.pnlMain.Controls.Add(GlobalVars.lastControl);
                }          
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }        
    }
}
