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
    public partial class cntrlContainerItem : UserControl
    {
        #region Error Handling
        public frmMsg msg;
        public string errMsg;
        public string errInfo;

        public StackTrace st;
        public string msgStr;
        #endregion

        string itemcode { get; set; }
        string batch { get; set; }
        string concentration { get; set; }
        string weight { get; set; }
        string container { get; set; }
        bool manuf { get; set; }
        bool trans { get; set; }

        public cntrlContainerItem(string _itemCode, string _batch, string _concentration, string _weight, string _container, bool _manuf, bool _trans)
        {
            InitializeComponent();
            itemcode = _itemCode;
            batch = _batch;
            concentration = _concentration;
            weight = _weight;
            container = _container;
            manuf = _manuf;
            trans = _trans;
        }

        private void cntrlContainerItem_Load(object sender, EventArgs e)
        {
            lblContainer.Text = container;
            lblWeight.Text = weight;
            if (manuf == true || trans == true)
            {
                btnEdit.Visible = false;
                lblContainer.ForeColor = Color.Green;
                lblContH.ForeColor = Color.Green;
                lblWeight.ForeColor = Color.Green;
                lblWeightH.ForeColor = Color.Green;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmEditContainer edit = new frmEditContainer(container, weight, GlobalVars.manufItem, GlobalVars.manufBatch);
                edit.ShowDialog();
                DialogResult res = edit.DialogResult;
                if (res == DialogResult.OK)
                {
                    string newWeight = edit.weight;
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

                    string updated = Client.UpdateContainerQty(container + "|" + GlobalVars.manufItem + "|" + GlobalVars.manufBatch + "|" + weight + "|" + newWeight + "|" + whse);
                    if (updated != string.Empty)
                    {
                        switch (updated.Split('*')[0])
                        {
                            case "1":
                                lblWeight.Text = newWeight;
                                weight = newWeight;
                                break;
                            case "0":
                                updated = updated.Remove(0, 2);
                                msg = new frmMsg("The following server side issue was encountered:", updated, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                break;
                            case "-1":
                                updated = updated.Remove(0, 3);
                                errMsg = updated.Split('|')[0];
                                errInfo = updated.Split('|')[1];
                                ExHandler.showErrorStr(errMsg, errInfo);
                                break;
                            case "-2":
                                updated = updated.Remove(0, 2);
                                msg = new frmMsg("A connection level error has occured", updated, GlobalVars.msgState.Error);
                                msg.ShowDialog();
                                break;
                            default:
                                st = new StackTrace(0, true);
                                msgStr = "Unexpected error while updating container";
                                errInfo = "Unexpected error while updating container" + Environment.NewLine + "Data Returned:" + Environment.NewLine + updated;
                                break;
                        }
                    }
                    else
                    {
                        msg = new frmMsg("A connection level error has occured", "No data was returned from the server", GlobalVars.msgState.Error);
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
