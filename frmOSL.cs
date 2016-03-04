using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4chget
{
    public partial class frmOSL : Form
    {
        Language la;
        public frmOSL(Language lang)
        {
            InitializeComponent();
            la = lang;
            Text = la.OpenSourceLicenses;
            button1.Text = la.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
