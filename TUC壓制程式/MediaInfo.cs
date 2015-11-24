using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace TUCEncoder
{
    public partial class MediaInfo : Form
    {
        public MediaInfo()
        {
            InitializeComponent();            
        }

        string GetMediaInfo(string FileName)
        {
            Process Pro_MediaInfo = new Process();
            Pro_MediaInfo.StartInfo.FileName = "tools\\MediaInfo\\MediaInfo.exe";
            Pro_MediaInfo.StartInfo.Arguments = String.Format("--output=HTML \"{0}\"", FileName);
            Pro_MediaInfo.StartInfo.RedirectStandardOutput = true;
            Pro_MediaInfo.StartInfo.UseShellExecute = false;
            Pro_MediaInfo.Start();
            string MediaInfo_HTML = Pro_MediaInfo.StandardOutput.ReadToEnd();
            Pro_MediaInfo.Dispose();

            return MediaInfo_HTML;
        }

        private void TSM_Open_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            string MediaInfo_HTML = GetMediaInfo(OFD.FileName);
            WebBrowser.DocumentText = MediaInfo_HTML;

            if (MediaInfo_HTML.IndexOf("Minimum frame rate ") != -1)
                MessageBox.Show("此影片為VFR(變動幀率) 壓制時請小心處理！");
        }
    }
}
