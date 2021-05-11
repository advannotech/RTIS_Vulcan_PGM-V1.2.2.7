using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Forms;
using System.Diagnostics;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class ucSettings : UserControl
    {
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        Panel parent;
        public frmMain main;

        public ucSettings(Panel _parent, frmMain _main)
        {
            InitializeComponent();
            parent = _parent;
            main = _main;
        }

        private void ucSettings_Load(object sender, EventArgs e)
        {
            SkinElement element = SkinManager.GetSkinElement(SkinProductId.Editors, DevExpress.LookAndFeel.UserLookAndFeel.Default, EditorsSkins.SkinCheckBox);
            element.Size.MinSize = new System.Drawing.Size(20, 20);
            element.Image.Stretch = SkinImageStretch.Stretch;
            LookAndFeelHelper.ForceDefaultLookAndFeelChanged();

            this.Size = parent.Size;

            cntrlOmniPad keypad = new cntrlOmniPad();
            keypad.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(keypad);

            if (GlobalVars.lastControl != null)
            {
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = false;
            }

            getSettings();
        }

        public void getSettings()
        {
            try
            {
                try
                {
                    txtIP.Text = GlobalVars.ServerIP.Split('.')[0];
                    txtIP2.Text = GlobalVars.ServerIP.Split('.')[1];
                    txtIP3.Text = GlobalVars.ServerIP.Split('.')[2];
                    txtIP4.Text = GlobalVars.ServerIP.Split('.')[3];
                }
                catch (Exception)
                { }
                txtPort.Text = GlobalVars.ServerPort;

                txtVault.Text = GlobalVars.vaultWhse;
                txtToyotaWhse.Text = GlobalVars.ToyotaWhse;
                txtVWWhse.Text = GlobalVars.VWWhse;
                txtToyotaIT.Text = GlobalVars.ToyotaIT;
                txtVWIT.Text = GlobalVars.VWIT;

                cbFromVault.Checked = GlobalVars.bToVAult;
                cbRec.Checked = GlobalVars.bReceive;
                cbManuf.Checked = GlobalVars.bManufacture;
                cbToWIP.Checked = GlobalVars.bToWIP;
                cbTransViewer.Checked = GlobalVars.bTransViewer;

                txtRows.Text = GlobalVars.PGMLineCount;
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIP.Text != string.Empty && txtIP2.Text != string.Empty && txtIP3.Text != string.Empty && txtIP4.Text != string.Empty)
                {
                    if (txtPort.Text != string.Empty)
                    {
                        if (txtVault.Text != string.Empty && txtToyotaWhse.Text != string.Empty && txtVWWhse.Text != string.Empty)
                        {
                            string updateCommand = string.Empty;
                            string ip = txtIP.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text;
                            updateCommand += "UPDATE [Settings] SET [Value] ='" +  ip + "' WHERE [SettingName] = 'ServerIP';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtPort.Text + "' WHERE [SettingName] = 'ServerPort';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtVault.Text + "' WHERE [SettingName] = 'VaultWhse';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtToyotaWhse.Text + "' WHERE [SettingName] = 'ToyotaWhse';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtVWWhse.Text + "' WHERE [SettingName] = 'VWWhse';";

                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtToyotaIT.Text + "' WHERE [SettingName] = 'ToyotaIT';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtVWIT.Text + "' WHERE [SettingName] = 'VWIT';";

                            updateCommand += "UPDATE [Settings] SET [Value] ='" + cbFromVault.Checked + "' WHERE [SettingName] = 'bFromVault';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + cbRec.Checked + "' WHERE [SettingName] = 'bReceive';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + cbManuf.Checked + "' WHERE [SettingName] = 'bManufacture';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + cbToWIP.Checked + "' WHERE [SettingName] = 'bToWIP';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + cbTransViewer.Checked + "' WHERE [SettingName] = 'bTransViewer';";
                            updateCommand += "UPDATE [Settings] SET [Value] ='" + txtRows.Text + "' WHERE [SettingName] = 'PGMMManufLines';";

                            string updated = SQLite.UpdateSettings(updateCommand, GlobalVars.SettingsDB);
                            switch (updated.Split('*')[0])
                            {
                                case "1":
                                    msg = new frmMsg("Success!", "Settings have been saved successfully", GlobalVars.msgState.Success);
                                    msg.ShowDialog();

                                    GlobalVars.ServerIP = ip;
                                    GlobalVars.ServerPort = txtPort.Text;

                                    GlobalVars.vaultWhse = txtVault.Text;
                                    GlobalVars.ToyotaWhse = txtToyotaWhse.Text;
                                    GlobalVars.VWWhse = txtVWWhse.Text;

                                    GlobalVars.bToVAult = cbFromVault.Checked;
                                    GlobalVars.bReceive = cbRec.Checked;
                                    GlobalVars.bManufacture = cbManuf.Checked;
                                    GlobalVars.bToWIP = cbToWIP.Checked;
                                    GlobalVars.bTransViewer = cbTransViewer.Checked;

                                    GlobalVars.PGMLineCount = txtRows.Text;
                                    break;
                                case "-1":
                                    updated = updated.Remove(0, 3);
                                    errMsg = updated.Split('|')[0];
                                    errInfo = updated.Split('|')[1];
                                    ExHandler.showErrorStr(errMsg, errInfo);
                                    break;
                                default:
                                    Cursor.Current = Cursors.Default;
                                    StackTrace st1 = new StackTrace(0, true);
                                    string msgStr1 = "Unexpected saving settings";
                                    string infoStr1 = "Unexpected saving setting";
                                    ExHandler.showErrorST(st1, msgStr1, infoStr1);
                                    break;
                            }
                        }
                        else
                        {
                            msg = new frmMsg("Error", "Please enter all required warehouse codes!", GlobalVars.msgState.Error);
                            msg.ShowDialog();
                        }
                    }
                    else
                    {
                        msg = new frmMsg("Error", "Please enter a port number!", GlobalVars.msgState.Error);
                        msg.ShowDialog();
                    }
                }
                else
                {
                    msg = new frmMsg("Error", "Please enter a valid IP address!", GlobalVars.msgState.Error);
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

        private void labelControl1_Click(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIP_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtIP;
        }

        private void txtIP2_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtIP2;
        }

        private void txtIP3_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtIP3;
        }

        private void txtIP4_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtIP4;
        }

        private void txtPort_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtPort;
        }

        private void txtVault_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtVault;
        }

        private void txtToyotaWhse_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtToyotaWhse;
        }

        private void txtVWWhse_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtVWWhse;
        }
        private void txtToyotaIT_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtToyotaIT;
        }
        private void txtVWIT_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtVWIT;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtRows_Click(object sender, EventArgs e)
        {
            GlobalVars.focusedEdit = txtRows;
        }
    }
}
