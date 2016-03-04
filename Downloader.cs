using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;

namespace _4chget
{
    public class Downloader
    {
        Settings sett;
        public event EventHandler DownloadComplete;
        public event ErrorEventHandler ErrorOccurred;

        public Downloader(Settings set)
        {
            sett = set;
        }

        public void Download(string vurl)
        {
            string FolderName = "";
            try
            {
                string[] urlsplitted = ((string)vurl).Split('/');
                FolderName = urlsplitted[3] + "-" + urlsplitted[5];
                string url = (string)vurl;
                WebClient wc = new WebClient();
                string pgsrc = wc.DownloadString(url);
                if (pgsrc != null)
                {
                    HtmlDocument htdoc = new HtmlDocument();
                    htdoc.LoadHtml(pgsrc);
                    if (!Directory.Exists(FolderName))
                        Directory.CreateDirectory(sett.SavePath + "\\" + FolderName);

                    foreach (HtmlNode node in htdoc.DocumentNode.SelectNodes("//a[@class=\"fileThumb\"]"))
                    {
                        string murl = node.Attributes["href"].Value;
                        if (murl.StartsWith("//"))
                            murl = murl.Replace("//", "http://");
                        Uri uri = new Uri(murl);
                        WebClient mwc = new WebClient();
                        mwc.DownloadFile(murl, sett.SavePath + "\\" + FolderName + "\\" +
                            Path.GetFileName(uri.LocalPath));

                    }

                    if (sett.SaveOP)
                    {
                        string op = "null122314534532453245346gbfrg45twgaer3eq2daysefrg46h5zbtgfv3d4qwa<yfsyvr 5z4wevgfsdygr";
                        foreach (HtmlNode opnode in htdoc.DocumentNode.SelectNodes("//blockquote[@class=\"postMessage\"]"))
                        {
                            if (op == "null122314534532453245346gbfrg45twgaer3eq2daysefrg46h5zbtgfv3d4qwa<yfsyvr 5z4wevgfsdygr")
                            {
                                op = opnode.InnerText;
                            }
                        }
                        File.WriteAllText(sett.SavePath + "\\" + FolderName + "\\" + "OP.txt", op);

                    }
                }
                if (DownloadComplete != null)
                DownloadComplete(this, EventArgs.Empty);
                return;
            }
            catch (Exception e)
            {
                if (ErrorOccurred != null)
                    ErrorOccurred(this, new ErrorEventArgs(e));
                return;
            }
        }
    }
}
