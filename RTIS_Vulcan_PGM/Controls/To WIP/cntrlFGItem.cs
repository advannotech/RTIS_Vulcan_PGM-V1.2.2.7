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
    public partial class cntrlFGItem : UserControl
    {
        public string code { get; set; }
        public bool selected { get; set; }
        ucSelectProductToManuf parent { get; set; }
        public cntrlFGItem(string _code, ucSelectProductToManuf _parent)
        {
            InitializeComponent();
            code = _code;
            parent = _parent;
        }

        private void cntrlFGItem_Load(object sender, EventArgs e)
        {
            lblCode.Text = code;
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblCode.BackColor = Color.LightBlue;
                foreach (cntrlFGItem item in parent.pnlFG.Controls)
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

        private void lblCode_Click(object sender, EventArgs e)
        {
            try
            {
                selected = true;
                pnlBack.BackColor = Color.LightBlue;
                lblCode.BackColor = Color.LightBlue;
                foreach (cntrlFGItem item in parent.pnlFG.Controls)
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
