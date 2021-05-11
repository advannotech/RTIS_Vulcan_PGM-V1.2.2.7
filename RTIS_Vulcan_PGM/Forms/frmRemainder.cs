using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Controls;

namespace RTIS_Vulcan_PGM.Forms
{
    public partial class frmRemainder : Form
    {
        #region Error handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        StackTrace st;
        string msgStr = string.Empty;
        string infoStr = string.Empty;
        #endregion

        public frmRemainder()
        {
            InitializeComponent();
        }

        private void frmRemainder_Load(object sender, EventArgs e)
        {
            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);

            txtWeight1.Focus();
            GlobalVars.focusedEdit = txtWeight1;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            try
            {
                string remainder = txtWeight1.Text + GlobalVars.sep + txtWeight2.Text;
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
                using (msg = new frmMsg("", "Is the remainder quantity entered correct?" + Environment.NewLine + $"Remainder: {remainder}", GlobalVars.msgState.Question))
                {
                    msg.ShowDialog();
                    if (msg.DialogResult == DialogResult.Yes)
                    {
                        string saved = Client.setBatchRemainder( GlobalVars.manufItem + "|" + GlobalVars.manufBatch + "|" + GlobalVars.manufConcen + "|" + whse + "|" + remainder + "|" + GlobalVars.userName);
                        switch (saved.Split('*')[0])
                        {
                            case "1":
                                using (msg = new frmMsg("Success", "The remainder has been captured", GlobalVars.msgState.Success))
                                {
                                    msg.ShowDialog();
                                }
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                                break;
                            case "0":
                                saved = saved.Remove(0, 2);
                                using (msg = new frmMsg("The following server side issue was encountered:", saved, GlobalVars.msgState.Error))
                                {
                                    msg.ShowDialog();
                                }
                                break;
                            case "-1":
                                saved = saved.Remove(0, 3);
                                errMsg = saved.Split('|')[0];
                                errInfo = saved.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);
                                break;
                            case "-2":
                                saved = saved.Remove(0, 2);
                                using (msg = new frmMsg("A connection level error has occured", saved, GlobalVars.msgState.Error))
                                {
                                    msg.ShowDialog();
                                }
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while retrieving data";
                                errInfo = "Unexpected error while retrieving data" + Environment.NewLine + "Data Returned:" + Environment.NewLine + saved;
                                ExHandler.showErrorST(st, msgStr, errInfo);
                                break;
                        }
                    }
                }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
