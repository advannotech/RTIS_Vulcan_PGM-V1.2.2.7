using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Q183543
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vScrollBar1.Maximum = panelControl2.Height - panelControl1.Height;
        }
        
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Point p = panelControl2.Location;
            p.Y = 0 - e.NewValue;
            panelControl2.Location = p;
            Text = e.OldValue.ToString() + " " + e.NewValue.ToString();
        }
    }
}