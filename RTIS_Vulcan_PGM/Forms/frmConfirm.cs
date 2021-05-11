using RTIS_Vulcan_PGM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_PGM.Forms
{
    public partial class frmConfirm : Form
    {
        string code { get; set; }
        string lot { get; set; }
        string qty { get; set; }
        string from { get; set; }
        string to { get; set; }

        GlobalVars.ApplicationStates appState { get; set; }
        public frmConfirm(string _code, string _lot, string _qty, string _from, string _to, GlobalVars.ApplicationStates _appState)
        {
            InitializeComponent();
            code = _code;
            lot = _lot;
            qty = _qty;
            from = _from;
            to = _to;
            appState = _appState;            
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            xtcMain.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            switch (appState)
            {
                case GlobalVars.ApplicationStates.None:
                    break;
                case GlobalVars.ApplicationStates.FromV:
                    xtcMain.SelectedTabPage = xtpFromVault;
                    lblFVCode.Text = code;
                    lblFVLot.Text = lot;
                    lblFVQty.Text = qty;
                    lblFVFrom.Text = from;
                    lblFVTo.Text = to;
                    break;
                case GlobalVars.ApplicationStates.Rec:
                    xtcMain.SelectedTabPage = xtpReceive;
                    lblRecCode.Text = code;
                    lblRecLot.Text = lot;
                    lblRecQty.Text = qty;
                    lblRecFrom.Text = from;
                    lblRecTo.Text = to;
                    break;
                case GlobalVars.ApplicationStates.Manuf:
                    break;
                case GlobalVars.ApplicationStates.ToWip:
                    break;
                case GlobalVars.ApplicationStates.TransView:
                    break;
                default:
                    break;
            }
        }

        private void btnFVNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnFVYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnRecNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void btnRecYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }
    }
}
