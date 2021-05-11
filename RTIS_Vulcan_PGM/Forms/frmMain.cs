using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RTIS_Vulcan_PGM.Controls;
using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Forms;
using System.IO;
using System.Diagnostics;

namespace RTIS_Vulcan_PGM
{
    public partial class frmMain : Form
    {
        public string returnString { get; set; }
        public string errMsg = string.Empty;
        public string errInfo = string.Empty;
        public frmMsg msg;

        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                tmrBat.Start();
                tmrWifi.Start();

                lblDT.Text = DateTime.Now.ToString("dd/MM/yy hh:mm");
                lblVersion.Text = Application.ProductVersion.ToString();
                lblUsername.Text = "Reltech";

                GlobalVars.RSCFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\RSC";
                GlobalVars.SettingsDB = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\RSC\\SettingDB.db3";
                string init = SQLite.InitSettingsDB();
                switch (init.Split('*')[0])
                {
                    case "1":
                        ucLogin login = new ucLogin(pnlMain, this); 
                        pnlMain.Controls.Add(login);
                        break;
                    case "0":
                        this.Width = 0;
                        returnString = "0";
                        msg = new frmMsg(string.Empty, string.Empty, GlobalVars.msgState.First);
                        msg.ShowDialog();
                        ucSettings settings2 = new ucSettings(pnlMain, this);
                        pnlMain.Controls.Add(settings2);
                        break;
                    case "-1":
                        this.Width = 0;
                        returnString = "-1";
                        init = init.Split('*')[1];
                        errMsg = init.Split('|')[0];
                        errInfo = init.Split('|')[1];
                        ExHandler.showErrorStr(errMsg, errInfo);
                        break;
                    default:
                        this.Width = 0;
                        returnString = "-1";
                        StackTrace st = new StackTrace(0, true);
                        string msgStr = "Unexpected error initializing db";
                        string infoStr = "Unexpected error initializing db";
                        ExHandler.showErrorST(st, msgStr, infoStr);
                        Application.Exit();
                        break;
                }
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                ucPassword settings = new ucPassword(pnlMain, this);
                GlobalVars.lastControl = pnlMain.Controls[0];
                pnlMain.Controls.Clear();
                pnlMain.Controls.Add(settings);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
        private void tmrBat_Tick(object sender, EventArgs e)
        {
            try
            {
                tmrBat.Stop();

                lblDT.Text = DateTime.Now.ToString("dd/MM/yy hh:mm");
                string messaeg = string.Empty;

                PowerStatus status = SystemInformation.PowerStatus;
                float percent = (status.BatteryLifePercent * 100);
                BatteryChargeStatus powerLevel = status.BatteryChargeStatus;
                string charging = status.PowerLineStatus.ToString();

                //messaeg += percent;
                //messaeg += powerLevel.ToString();
                //messaeg += charging;

                //msg = new frmMsg("BatteryStuff", messaeg, GlobalVars.msgState.Error);
                //msg.ShowDialog();

                if (charging == "Online")
                {
                    if (percent > 90)
                    {
                        pbxBattery.Image = Properties.Resources.chargefull;
                    }
                    else if (percent <= 90 && percent >= 70)
                    {
                        pbxBattery.Image = Properties.Resources.chargeafull;
                    }
                    else if (percent <= 70 && percent >= 50)
                    {
                        pbxBattery.Image = Properties.Resources.chargeahalf;
                    }
                    else if (percent <= 50 && percent >= 30)
                    {
                        pbxBattery.Image = Properties.Resources.chargehalf;
                    }
                    else if (percent <= 30 && percent >= 20)
                    {
                        pbxBattery.Image = Properties.Resources.chargeaempty;
                    }
                    else if (percent <= 20)
                    {
                        pbxBattery.Image = Properties.Resources.chargeempty;
                    }
                }
                else
                {
                    if (percent > 90)
                    {
                        pbxBattery.Image = Properties.Resources.levelfull;
                    }
                    else if (percent <= 90 && percent >= 70)
                    {
                        pbxBattery.Image = Properties.Resources.levelafull;
                    }
                    else if (percent <= 70 && percent >= 50)
                    {
                        pbxBattery.Image = Properties.Resources.levelahalf;
                    }
                    else if (percent <= 50 && percent >= 30)
                    {
                        pbxBattery.Image = Properties.Resources.levelhalf;
                    }
                    else if (percent <= 30 && percent >= 20)
                    {
                        pbxBattery.Image = Properties.Resources.levelaempty;
                    }
                    else if (percent <= 20)
                    {
                        pbxBattery.Image = Properties.Resources.levelempty;
                    }
                }
                tmrBat.Start();
            }
            catch (Exception)
            {

            }
        }
        private void tmrWifi_Tick(object sender, EventArgs e)
        {
            int sigStrength = Convert.ToInt32(WifiChecker.getSignal());
            if (sigStrength > 70)
            {
                pbXWifi.Image = Properties.Resources.signalhigh;
            }
            else if (sigStrength <= 70 && sigStrength >= 40)
            {
                pbXWifi.Image = Properties.Resources.signalmedium;
            }
            else if (sigStrength < 40 && sigStrength >= 1)
            {
                pbXWifi.Image = Properties.Resources.signallow;
            }
            else
            {
                pbXWifi.Image = Properties.Resources.notfound2;
            }
        }
    }
}
