using RTIS_Vulcan_PGM.Classes;
using RTIS_Vulcan_PGM.Controls;
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
    public partial class frmEditContainer : Form
    {
        public string code { get; set; }
        public string weight { get; set; }
        public string item { get; set; }
        public string batch { get; set; }
        public frmEditContainer(string _code, string _weight, string _item, string _batch)
        {
            InitializeComponent();
            code = _code;
            weight = _weight;

            item = _item;
            batch = _batch;
        }

        private void frmEditContainer_Load(object sender, EventArgs e)
        {
            lblContainer.Text = code;
            lblItem.Text = item;
            lblBatch.Text = batch;
            weight = weight.Replace(",", GlobalVars.sep).Replace(".", GlobalVars.sep);
            if (weight.Contains(GlobalVars.sep))
            {
                txtWeight1.Text = weight.Split(Convert.ToChar(GlobalVars.sep))[0];
                txtWeight2.Text = weight.Split(Convert.ToChar(GlobalVars.sep))[1];
            }
            else
            {
                txtWeight1.Text = weight;
                txtWeight2.Text = "00";
            }

            cntrlNumPad num = new cntrlNumPad();
            num.Dock = DockStyle.Right;
            pnlKeyPad.Controls.Add(num);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                weight = txtWeight1.Text + GlobalVars.sep + txtWeight2.Text;
                this.Close();
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
    }
}
