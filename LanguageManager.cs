using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace _4chget
{
    public class LanguageManager
    {
        public static Language LoadLanguage(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Language));
            Language lang = (Language)xs.Deserialize(fs);
            fs.Close();
            return lang;
        }

    }

    public class Language
    {
        // Main window
        public string OpenFolderAfterDownload;
        public string Paste;
        public string Download;
        public string Settings;
        public string VisitMyWebsite;
        public string LicensedUnder;
        public string OpenDownloadFolder;
        // Settings window
        public string SavePath;
        public string SaveOP;
        public string Save;
        public string Discard;
        public string Help;
        public string _Language;
        public string OpenSourceLicenses;
        // Error window
        public string AnErrorOccurred;
        public string OK;
        // Manager window
        public string DownloadedThreads;
        public string OP;
        public string Refresh;
        public string TotalFiles;
        public string TotalSize;
        public string OpenFolder;
        // Misc messages
        public string MsgFinishedDownloading;
        public string StsReady;
        public string StsDownloading;
        public string ExcURLDoesntMatchRegex;
        public string Details; // Error Window and Manager window
        public string InstallURLHandler;
        public string UninstallURLHandler;

    }

}
