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
    public partial class cntrlWhse : UserControl
    {
        public string name { get; set; }
        public string code { get; set; }
        public bool selected { get; set; }
        ucWarehouseFrom parent { get; set; }
        public cntrlWhse(string _name, string _code, ucWarehouseFrom _parent)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            name = _name;
            code = _code;
            parent = _parent;
        }

        private void cntrlWhse_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
            selected = false;
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            selected = true;
            pnlBack.BackColor = Color.LightBlue;
            foreach (cntrlWhse item in parent.pnlWhses.Controls)
            {
                if (item != this)
                {
                    item.selected = false;
                    item.pnlBack.BackColor = Color.White;
                }

            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            selected = true;
            pnlBack.BackColor = Color.LightBlue;
            foreach (cntrlWhse item in parent.pnlWhses.Controls)
            {
                if (item != this)
                {
                    item.selected = false;
                    item.pnlBack.BackColor = Color.White;
                }

            }
        }
    }
}
