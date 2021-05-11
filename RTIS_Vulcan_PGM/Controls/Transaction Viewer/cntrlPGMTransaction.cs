using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTIS_Vulcan_PGM.Controls
{
    public partial class cntrlPGMTransaction : UserControl
    {
        public string username { get; set; }
        public string date { get; set; }
        public string container { get; set; }
        public string concentration { get; set; }
        public string qtyIn { get; set; }
        public string qtyOut { get; set; }
        public string lotNumber { get; set; }
        public cntrlPGMTransaction(string _username, string _date, string _container, string _concentration, string _qtyIn, string _qtyOut, string _lotNumber)
        {
            InitializeComponent();
            username = _username;
            date = _date;
            container = _container;
            concentration = _concentration;
            qtyIn = _qtyIn;
            qtyOut = _qtyOut;
            lotNumber = _lotNumber;
        }

        private void cntrlPGMTransaction_Load(object sender, EventArgs e)
        {
            lblUser.Text = username;
            lblDT.Text = date;
            lblCont.Text = container;
            lblConcen.Text = concentration;
            lblIn.Text = qtyIn;
            lblOut.Text = qtyOut;
            lblLot.Text = lotNumber;
        }
    }
}
