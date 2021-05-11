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
    public partial class cntrlPGMItem : UserControl
    {
        public string code { get; set; }
        public bool selected { get; set; }
        ucSelectItem parent { get; set; }
        public cntrlPGMItem(string _code, ucSelectItem _parent)
        {
            InitializeComponent();
            code = _code;
            parent = _parent;
        }

        private void cntrlPGMItem_Load(object sender, EventArgs e)
        {
            lblCode.Text = code;
        }

        private void lblCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblCode.BackColor = Color.LightBlue;
                foreach (cntrlPGMItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblCode.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblCode.BackColor = Color.LightBlue;
                foreach (cntrlPGMItem item in parent.pnlItems.Controls)
                {
                    if (item != this)
                    {
                        item.selected = false;
                        item.pnlBack.BackColor = Color.White;
                        item.lblCode.BackColor = Color.White;
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
