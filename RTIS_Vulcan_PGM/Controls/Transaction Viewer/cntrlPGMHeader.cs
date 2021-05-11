using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTIS_Vulcan_PGM.Classes;

namespace RTIS_Vulcan_PGM.Controls.Transaction_Viewer
{
    public partial class cntrlPGMHeader : UserControl
    {
        public string lot { get; set; }
        public string concentration { get; set; }
        public string qtyIn { get; set; }
        public string qtyOut { get; set; }
        public string qtyBal { get; set; }
        public bool selected { get; set; }
        frmMain main { get; set; }
        Panel parent { get; set; }

        public cntrlPGMHeader(string _lot, string _concentration, string _qtyIn, string _qtyOut, string _qtyBal, frmMain _main, Panel _parent)
        {
            InitializeComponent();
            lot = _lot;
            concentration = _concentration;
            qtyIn = _qtyIn;
            qtyOut = _qtyOut;
            qtyBal = _qtyBal;

            main = _main;
            parent = _parent;
        }

        private void cntrlPGMHeader_Load(object sender, EventArgs e)
        {
            lblLot.Text = lot;
            lblConcen.Text = concentration;
            lblIn.Text = qtyIn;
            lblOut.Text = qtyOut;
            lblBalance.Text = qtyBal;

            if (lot == "Batch" && concentration == "Concentration" && qtyIn == "Qty In" && qtyOut == "Qty Out" && qtyBal == "Qty Balance")
            {
                btnView.Visible = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVars.TransactionBatch = lot;
                ucItemTransactions trans = new ucItemTransactions(parent, main);
                main.pnlMain.Controls.Clear();
                main.pnlMain.Controls.Add(trans);
            }
            catch (Exception ex)
            {
                ExHandler.showErrorEx(ex);
            }
        }
    }
}
