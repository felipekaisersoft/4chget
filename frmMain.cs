using System;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using HtmlAgilityPack;
using System.Drawing;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace _4chget
{
    public partial class frmMain : Form
    {
        Downloader worker;
        Settings settings;
        Language la;

        public frmMain(bool fromurl=false, string url="")
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            InitializeComponent();
            InitSettings();
            lblVisit.Text = la.VisitMyWebsite;
            lblLicense.Text = la.LicensedUnder + " MIT License";
            cbOpen.Text = la.OpenFolderAfterDownload;
            btnDownload.Text = la.Download;
            btnPaste.Text = la.Paste;
            btnSettings.Text = la.Settings;
            tslStatus.Text = la.StsReady;
            btnODLF.Text = la.OpenDownloadFolder;
            if (fromurl)
            {
                txtUrl.Text = url;
                btnDownload_Click(this, EventArgs.Empty);

            }

        }

        private bool InitSettings(uint try_=1)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                FileStream fs = new FileStream("settings.xml", FileMode.Open, FileAccess.Read);
                settings = (Settings)xs.Deserialize(fs);
                la = LanguageManager.LoadLanguage(settings.Language);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                DialogResult dr = MessageBox.Show("ERROR: \r\n" + e.Message, "4chget", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.Retry)
                {
                    bool s = InitSettings(try_ + 1);
                    if (!InitSettings())
                    {
                        MessageBox.Show("Try #" + (try_ + 1) + " failed!", "4chget", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    } else
                    {
                        return true;
                    }
                } else
                {
                    return false;
                }

            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            txtUrl.Text = Clipboard.GetText();
            if (_validateurl(txtUrl.Text))
            {
                pbOK.BackColor = Color.Green;
            } else
            {
                pbOK.BackColor = Color.Red;

            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                tslStatus.Text = la.StsDownloading;
                btnDownload.Enabled = false;
                worker = new Downloader(settings);
                worker.DownloadComplete += Worker_DownloadComplete;
                worker.ErrorOccurred += Worker_ErrorOccurred;
                string vurl = txtUrl.Text;
                Regex regex = new Regex(@"(https|http):\/\/boards\.4chan\.org\/[a-zA-Z0-9]*\/thread\/[0-9]+[a-zA-Z0-9\/\-]*");
                if (regex.IsMatch(vurl))
                {
                    worker.Download(vurl);
                    
                } else
                {
                    throw new Exception(la.ExcURLDoesntMatchRegex);
                }
                
            }
            catch (Exception ex)
            {
                frmError error = new frmError(ex, la);
                error.ShowDialog();
            }
            finally
            {
                btnDownload.Enabled = true;
            }
        }

        private void Worker_ErrorOccurred(object sender, ErrorEventArgs e)
        {
            frmError err = new frmError(e.GetException(), la);
            err.ShowDialog();

        }

        private void Worker_DownloadComplete(object sender, EventArgs e)
        {
            tslStatus.Text = la.StsReady;
            MessageBox.Show(la.MsgFinishedDownloading, "4chget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDownload.Enabled = true;
        }

        private void txtUrl_TextChanged(object sender, EventArgs e)
        {
            if (_validateurl(txtUrl.Text))
            {
                pbOK.BackColor = Color.Green;
            }
            else
            {
                pbOK.BackColor = Color.Red;
            }
        }

        private bool _validateurl(string t)
        {
            Regex regex = new Regex(@"(https|http):\/\/boards\.4chan\.org\/[a-zA-Z0-9]*\/thread\/[0-9]+[a-zA-Z0-9\/\-]*");
            if (regex.IsMatch(t))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Init();
            settings.ShowDialog();
            settings.Dispose();

        }

        private void lblVisit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://felipekaisersoft.hol.es/");

        }
        
        private void btnODLF_Click(object sender, EventArgs e)
        {
            Process.Start(settings.SavePath);

        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager man = new frmManager(settings, la, Location);
            man.Show();

        }
    }
}
