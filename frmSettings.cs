using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace _4chget
{
    public partial class frmSettings : Form
    {
        Settings sett;
        Language la;
        bool optinstall;
        public frmSettings()
        {
            InitializeComponent();
        }

        public void Init()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Settings));
            FileStream fs = new FileStream("settings.xml", FileMode.Open, FileAccess.Read);
            sett = (Settings)xs.Deserialize(fs);
            fs.Close();
            txtSavePath.Text = sett.SavePath;
            cbSaveOP.Checked = sett.SaveOP;
            la = LanguageManager.LoadLanguage(sett.Language);
            btnDiscard.Text = la.Discard;
            btnSave.Text = la.Save;
            cbSaveOP.Text = la.SaveOP;
            label1.Text = la.SavePath;
            btnHelp.Text = la.Help;
            label2.Text = la._Language;
            btnOSL.Text = la.OpenSourceLicenses;
            if (File.Exists("urlhdlinst"))
            {
                btnInstallURLHandler.Text = la.UninstallURLHandler;
                optinstall = false;

            } else
            {
                btnInstallURLHandler.Text = la.InstallURLHandler;
                optinstall = true;

            }
            Regex regex = new Regex(@"[a-zA-Z0-9\.]*\.lang");
            cobLanguage.Text = sett.Language;
            foreach (string s in Directory.GetFiles(Environment.CurrentDirectory))
            {
                if (regex.IsMatch(s))
                {
                    cobLanguage.Items.Add(Path.GetFileName(s));
                }

            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings news = new Settings();
            news.SaveOP = cbSaveOP.Checked;
            news.SavePath = txtSavePath.Text;
            news.Language = cobLanguage.Text;
            File.Delete("settings.xml");
            FileStream fs = new FileStream("settings.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Settings));
            xs.Serialize(fs, news);
            fs.Close();
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(Environment.CurrentDirectory + "\\hlp\\index.html");
            
        }

        private void btnCreateTemplate_Click(object sender, EventArgs e)
        {
            Settings news = new Settings();
            news.SaveOP = cbSaveOP.Checked;
            news.SavePath = txtSavePath.Text;
            FileStream fs = new FileStream("settings.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Settings));
            xs.Serialize(fs, news);
            fs.Close();

        }

        private void btnOSL_Click(object sender, EventArgs e)
        {
            frmOSL osl = new frmOSL(la);
            osl.ShowDialog();
            osl.Dispose();

        }

        private void btnInstallURLHandler_Click(object sender, EventArgs e)
        {
            if (optinstall)
            {
                RegistryKey Key = Registry.ClassesRoot.CreateSubKey("4chget");
                Key.CreateSubKey("DefaultIcon").SetValue("", "4chget.exe,1");
                Key.SetValue("", "4chget:Protocol");
                Key.SetValue("URL Protocol", "");
                string apppath = Application.ExecutablePath;
                Key.CreateSubKey(@"shell\open\command").SetValue("", apppath + " \"%1\"");
                File.WriteAllText("urlhdlinst", "1");
                MessageBox.Show("Installed URL protocol handler for 4chget!", "4chget", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                Registry.ClassesRoot.DeleteSubKeyTree("4chget");
                File.Delete("urlhdlinst");
                MessageBox.Show("Uninstalled URL protocol handler for 4chget!", "4chget", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
