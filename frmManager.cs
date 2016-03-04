using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _4chget
{
    public partial class frmManager : Form
    {
        Language la;
        Settings sett;
        string cSel = "";

        public frmManager(Settings settings, Language lang, Point appWndPos)
        {
            InitializeComponent();
            la = lang;
            sett = settings;
            lblDetails.Text = la.Details;
            lblDLT.Text = la.DownloadedThreads;
            lblOP.Text = la.OP;
            btnRefresh.Text = la.Refresh;
            btnOpenFolder.Text = la.OpenFolder;
            //505; 228
            Location = new Point(appWndPos.X + 505, appWndPos.Y + 228);

        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            string[] threads = Directory.GetDirectories(sett.SavePath);
            lbThreads.Items.AddRange(threads);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lbThreads.Items.Clear();
            string[] threads = Directory.GetDirectories(sett.SavePath);
            lbThreads.Items.AddRange(threads);

        }

        private void lbThreads_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = lbThreads.SelectedIndex;
            string s = (string)lbThreads.Items[idx];
            DirectoryInfo di = new DirectoryInfo(s);
            string filestotal = di.GetFiles().Length.ToString();
            FileInfo[] sizetotal = di.GetFiles();
            long size = 0;
            string szsffx = "B";
            string op = "N/A";
            foreach (FileInfo fi in sizetotal)
            {
                size += fi.Length;
                if (fi.Name == "OP.txt")
                {
                    op = fi.OpenText().ReadToEnd();
                }
            }
            if (size > 1024)
            {
                szsffx = "KB";
                size = size / 1024;
            } else if ((size / 1024) > 1024)
            {
                szsffx = "MB";
                size = size / 1024 / 1024;
            } else if (((size / 1024 / 1024) > 1024))
            {
                szsffx = "GB";
                size = size / 1024 / 1024 / 1024;
            }
            txtOP.Text = op;
            txtDetails.Text = la.TotalFiles + filestotal + "\r\n" +
                              la.TotalSize + size + szsffx;
            cSel = s;

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (cSel != "")
                Process.Start(cSel);
                
        }
    }
}
