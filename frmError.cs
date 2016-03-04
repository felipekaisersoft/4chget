using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _4chget
{
    public partial class frmError : Form
    {
        public frmError(object exc, Language la)
        {
            InitializeComponent();
            lblAEO.Text = la.AnErrorOccurred;
            lblDetails.Text = la.Details;
            btnOK.Text = la.OK;
            string etxt = "";
            etxt += "Type: \r\n" + exc.GetType().Name;
            etxt += "\r\nMessage: \r\n" + ((Exception)exc).Message;
            etxt += "\r\nSource: \r\n" + ((Exception)exc).Source;
            etxt += "\r\nStack Trace: \r\n" + ((Exception)exc).StackTrace;
            txtError.Text = etxt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
