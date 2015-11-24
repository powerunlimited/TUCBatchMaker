using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace TUCEncoder
{
    public partial class MP4Muxer : Form
    {
        public MP4Muxer()
        {
            InitializeComponent();
            ComboBox_FPS.Items.Add("60.000");
            ComboBox_FPS.Items.Add("59.940");
            ComboBox_FPS.Items.Add("30.000");
            ComboBox_FPS.Items.Add("29.976");
            ComboBox_FPS.Items.Add("25.000");
            ComboBox_FPS.Items.Add("24.000");
            ComboBox_FPS.Items.Add("23.976");

            ComboBox_Audio_Language.Items.Add("Chinese");
            ComboBox_Audio_Language.Items.Add("English");
            ComboBox_Audio_Language.Items.Add("Japanese");

        }

        void init_OFD(ref OpenFileDialog OFD_in, int type)
        {
            if (type == 1) //Video
                OFD_in.Filter = "所有支援格式 (*.avi, *.m4v, *.264, *.h264, *.m2v, *.mp4)|*.avi; *.m4v; *.264; *.h264; *.m2v; *.mp4|AVI影片檔(*.avi)|*.avi|M4V影片檔(*.m4v)|*.m4v|H264 RAW檔(*.264)|*.264|H264 RAW檔(*.h264)|*.h264|M2V影片檔(*.m2v)|*.m2v|MP4影片檔(*.mp4)|*.mp4";
            else if (type == 2) //Audio
                OFD_in.Filter = "所有支援格式 (*.ac3, *.aac, *.mp4, *.m4a, *.mp3)|*.ac3; *.aac; *.mp4; *.m4a; *.mp3|AC3音訊檔|*.ac3|AAC音訊檔|*.aac|MP4音訊檔|*.mp4|M4A音訊檔|*.m4a|MP3音訊檔|*.mp3";
            else //Chapter
                OFD_in.Filter = "TXT章節檔 (*.txt)|*.txt";

            OFD_in.CheckFileExists = true;
            OFD_in.Multiselect = false;
            OFD_in.RestoreDirectory = true;
            OFD_in.SupportMultiDottedExtensions = true;
        }

        private void Button_Browse_Video_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD_Video = new OpenFileDialog();
            init_OFD(ref OFD_Video, 1);
            OFD_Video.ShowDialog();
            TextBox_Video_Path.Text = OFD_Video.FileName;
            if (TextBox_Output_Path.Text == String.Empty)
            {
                try
                {
                    TextBox_Output_Path.Text = TextBox_Video_Path.Text.Remove(TextBox_Video_Path.Text.Length - 4, 4) + "-muxed.mp4";
                    SFD_Output.FileName = TextBox_Video_Path.Text.Remove(TextBox_Video_Path.Text.Length - 4, 4) + "-muxed.mp4";
                }
                catch { }
            }

            Process Pro_MediaInfo = new Process();
            Pro_MediaInfo.StartInfo.FileName = "tools\\MediaInfo\\MediaInfo.exe";
            Pro_MediaInfo.StartInfo.Arguments = String.Format("--output=XML \"{0}\"",TextBox_Video_Path.Text);
            Pro_MediaInfo.StartInfo.RedirectStandardOutput = true;
            Pro_MediaInfo.StartInfo.UseShellExecute = false;
            Pro_MediaInfo.Start();
            string MediaInfo_str = Pro_MediaInfo.StandardOutput.ReadToEnd();
            Pro_MediaInfo.Dispose();

            string FPS = String.Empty;
            try { FPS = MediaInfo_str.Substring(MediaInfo_str.IndexOf("<Frame_rate>") + "<Frame_rate>".Length, MediaInfo_str.IndexOf("</Frame_rate>") - MediaInfo_str.IndexOf("<Frame_rate>") - "</Frame_rate>".Length + 1).Replace("fps", "").Trim(); }
            catch { }
            ComboBox_FPS.Text = FPS;
        }

        private void Button_Browse_Audio_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD_Audio = new OpenFileDialog();
            init_OFD(ref OFD_Audio , 2);
            OFD_Audio.ShowDialog();
            TextBox_Audio_Path.Text = OFD_Audio.FileName;
            if (TextBox_Output_Path.Text == String.Empty)
            {
                try
                {
                    TextBox_Output_Path.Text = TextBox_Audio_Path.Text.Remove(TextBox_Audio_Path.Text.Length - 4, 4) + "-muxed.mp4";
                    SFD_Output.FileName = TextBox_Audio_Path.Text.Remove(TextBox_Audio_Path.Text.Length - 4, 4) + "-muxed.mp4";
                }
                catch { }
            }
        }

        private void Button_Browse_Chapter_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD_Chapter = new OpenFileDialog();
            init_OFD(ref OFD_Chapter , 3);
            OFD_Chapter.ShowDialog();
            TextBox_Chapter_Path.Text = OFD_Chapter.FileName;
        }

        private void Button_Browse_Output_Click(object sender, EventArgs e)
        {
            SFD_Output.ShowDialog();
            TextBox_Output_Path.Text = SFD_Output.FileName;
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            TextBox_Video_Path.Text = String.Empty;
            TextBox_Audio_Path.Text = String.Empty;
            TextBox_Chapter_Path.Text = String.Empty;
            TextBox_Output_Path.Text = String.Empty;
            ComboBox_FPS.Text = String.Empty;
            ComboBox_Audio_Language.Text = String.Empty;
            Numeric_Audio_Delay.Value = 0;
            SFD_Output.FileName = String.Empty;
        }
    }
}
