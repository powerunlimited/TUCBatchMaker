using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TUCEncoder
{
    public partial class BatCreator : Form
    {
        string AVS_File_Path, Audio_File_path , Audio_AVS_Path, Video_Output_Path;
        public string TwoPassParameter;
        public ListDictionary Parameters = new ListDictionary();
        public ListDictionary Parameters_CRF = new ListDictionary();
        public int Res_X = 0, Res_Y = 0, TwoPass_Bitrate = 5000;
        public bool Set_Resolution_Finished = false , Keep_Audio = false , Keep_Video = false;

        public BatCreator()
        {
            InitializeComponent();
            Add_Parameters();
            ComboBox_Video_Output_Format.Items.Add("MP4");
            ComboBox_Video_Output_Format.Items.Add("MKV");
            ComboBox_Video_Output_Format.Items.Add("RAWAVC");

            ComboBox_Audio_Output_Format.Items.Add("AAC");
            ComboBox_Audio_Output_Format.Items.Add("FLAC");

            ComboBox_Color_Depth.Items.Add("8bit");
            ComboBox_Color_Depth.Items.Add("10bit");

            ComboBox_AVS_Inputer.Items.Add("avs4x264mod");
            ComboBox_AVS_Inputer.Items.Add("avs2yuv");

            ComboBox_FPS.Items.Add("30");
            ComboBox_FPS.Items.Add("29.976");
            ComboBox_FPS.Items.Add("24");
            ComboBox_FPS.Items.Add("23.976");
            ComboBox_FPS.Items.Add("Auto");

            ComboBox_Audio_Output_Format.SelectedIndex = 0;
            ComboBox_AVS_Inputer.SelectedIndex = 0;
            ComboBox_Color_Depth.SelectedIndex = 0;
            ComboBox_Parameter.SelectedIndex = 1;
            ComboBox_Video_Output_Format.SelectedIndex = 0;
            ComboBox_FPS.SelectedIndex = 4;
            Numeric_Quality.DecimalPlaces = 1;
            CheckBox_2pass_ON.Checked = false;
            CheckBox_2pass_SameParameter.Enabled = false;
            Button_2pass_InputParameter.Enabled = false;
            
        }

        private void BatCreator_Load(object sender, EventArgs e)
        {
            MessageBox.Show("這是一個初心者向的BAT產生器，畫面上你看得到的基本上都是給新(ㄌㄢˇ)手(ㄖㄣˊ)使用的\n眾老手或有多音軌等特殊需求的使用者們可以僅輸入AVS，產生輸出MP4的BAT檔，再自行封裝", "致使用本產生器的使用者們");
            BATScheduler Form_BATScheduler = new BATScheduler();
            Form_BATScheduler.Show();
        }

        private void TSM_MMG_Click(object sender, EventArgs e)
        {
            Process Pro = new Process();
            Pro.StartInfo.FileName = "mmg.exe";
            Pro.StartInfo.WorkingDirectory = Environment.CurrentDirectory + "\\tools";
            try { Pro.Start(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Browse_AVS_File_Path_Click(object sender, EventArgs e)
        {
            //Clear_All();
            string temp;
            OFD_AVS.ShowDialog();
            AVS_File_Path = OFD_AVS.FileName;
            TextBox_AVS_File_Path.Text = AVS_File_Path;
            if (File.Exists(AVS_File_Path))
            {
                StreamReader SR = new StreamReader(AVS_File_Path);
                temp = SR.ReadToEnd();
                if (temp.IndexOf("AudioDub") != -1)
                {
                    TextBox_Audio_File_Path.Text = AVS_File_Path;
                    Audio_File_path = AVS_File_Path;
                    OFD_Audio = OFD_AVS;
                }
                SR.Dispose();
            }
            try 
            {
                TextBox_Video_Output_Path.Text = OFD_AVS.FileName.Replace(".avs" , ".mp4");
                if (OFD_Audio.FileName != String.Empty)
                    TextBox_Audio_Output_Path.Text = OFD_Audio.FileName.Replace(".avs", ".aac");
            }
            catch { }
            ComboBox_Video_Output_Format_SelectedIndexChanged(null, null);
        }

        private void Button_Browse_AVS_Audio_Path_Click(object sender, EventArgs e)
        {
            OFD_Audio.Filter = "支援的音訊檔案 (*.aac;*.m4a;*.flac)|*.aac;*.m4a;*.flac|AVS腳本 (*.avs)|*.avs|AAC音訊檔案 (*.aac)|*.aac|FLAC音訊檔案 (*.flac)|*.flac";
            OFD_Audio.ShowDialog();
            Audio_File_path = OFD_Audio.FileName;
            TextBox_Audio_File_Path.Text = Audio_File_path;
        }

        private void Button_Browse_Subtitle_Path_Click(object sender, EventArgs e)
        {
            TextBox_Subtitle_Path.Text = String.Empty;
            OFD_Subtitles.Filter = "ASS字幕檔 (*.ass)|*.ass";
            OFD_Subtitles.ShowDialog();
            OFD_Subtitles.Multiselect = true;
            foreach (string path in OFD_Subtitles.FileNames)
                TextBox_Subtitle_Path.Text += path + "; ";
        }

        private void Button_Browse_Chap_File_Click(object sender, EventArgs e)
        {
            TextBox_Chap_File_Path.Text = String.Empty;
            if (ComboBox_Video_Output_Format.SelectedIndex == 0)
                OFD_Chap_File.Filter = "TXT章節檔案 (*.txt)|*.txt";
            else
                OFD_Chap_File.Filter = "TXT章節檔案 (*.txt)|*.txt|XML章節檔案 (*.xml)|*.xml";
            OFD_Chap_File.ShowDialog();
            TextBox_Chap_File_Path.Text = OFD_Chap_File.FileName;
        }

        private void TextBox_AVS_File_Path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TextBox_AVS_File_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] DragDropFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            TextBox_AVS_File_Path.Text = DragDropFiles[0];
            foreach (string File in DragDropFiles)
            {
                if (File.IndexOf(".avs") != -1)
                {
                    TextBox_AVS_File_Path.Text = File; break;
                }
            }

        }

        private void TextBox_Chap_File_Path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TextBox_Chap_File_Path_DragDrop(object sender, DragEventArgs e)
        {
            string[] DragDropFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            TextBox_AVS_File_Path.Text = DragDropFiles[0];
            foreach (string File in DragDropFiles)
            {
                if (File.IndexOf(".txt") != -1 || File.IndexOf(".xml") != -1)
                {
                    TextBox_AVS_File_Path.Text = File; break;
                }
            }

        }

        private void ComboBox_Parameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!IsUsingDefaultParameter()) //自訂參數
            {
                RButton_ABR.Enabled = false;
                RButton_CRF.Enabled = false;
                Numeric_Quality.Enabled = false;
                if (ComboBox_Parameter.SelectedIndex == 0) Button_Input_User_Defined_Parameters.Enabled = true;
            }
            else
            {
                RButton_ABR.Enabled = true;
                RButton_CRF.Enabled = true;
                Numeric_Quality.Enabled = true;
                Button_Input_User_Defined_Parameters.Enabled = false;
            }
            if (ComboBox_Parameter.SelectedIndex == 9) //BDmini
            {
                RButton_ABR.Checked = true;
                RButton_CRF.Checked = false;
            }
            else
            {
                RButton_CRF.Checked = true;
                RButton_ABR.Checked = false;
            }
            if (RButton_CRF.Checked && IsUsingDefaultParameter())
                Numeric_Quality.Value = Convert.ToDecimal(Parameters_CRF[ComboBox_Parameter.SelectedIndex]);
        }

        private void Button_Input_User_Defined_Parameters_Click(object sender, EventArgs e)
        {
            Form_Input_User_Defined_Parameters F = new Form_Input_User_Defined_Parameters(this , 1); // 1 for 1pass / Normal Parameter
            F.ShowDialog();

        }

        private void RButton_CRF_CheckedChanged(object sender, EventArgs e)
        {
            if (RButton_CRF.Checked == true && ComboBox_Parameter.SelectedIndex == 9) //BDmini
            {
                Numeric_Quality.Value = 23.0M;
                Numeric_Quality.DecimalPlaces = 1;
                Numeric_Quality.Increment = 0.1M;
            }
            else if (RButton_CRF.Checked == true)
            {
                Numeric_Quality.Value = Convert.ToDecimal(Parameters_CRF[ComboBox_Parameter.SelectedIndex]);
                Numeric_Quality.DecimalPlaces = 1;
                Numeric_Quality.Increment = 0.1M;
            }

        }

        private void RButton_ABR_CheckedChanged(object sender, EventArgs e)
        {
            if (RButton_ABR.Checked == true)
            {
                Numeric_Quality.Value = 1200;
                Numeric_Quality.Increment = 100;
                Numeric_Quality.DecimalPlaces = 0;
            }

        }

        private void ComboBox_Video_Output_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                TextBox_Video_Output_Path.Text = TextBox_Video_Output_Path.Text.Remove(TextBox_Video_Output_Path.Text.Length - 3, 3);
                string temp = ComboBox_Video_Output_Format.SelectedItem.ToString();
                temp = temp.Trim().ToLower();
                if (temp == "rawavc")  temp = "264";
                TextBox_Video_Output_Path.Text += temp;
                temp = null;
                GC.Collect();
            }
            catch
            { /*MessageBox.Show(E.Message); */}
            switch (ComboBox_Video_Output_Format.SelectedIndex)
            {
                case 0: Button_Browse_Subtitle_Path.Enabled = false; Button_Browse_Chap_File.Enabled = true;  break;
                case 1: Button_Browse_Subtitle_Path.Enabled = true;  Button_Browse_Chap_File.Enabled = true;  break;
                case 2: Button_Browse_Subtitle_Path.Enabled = false; Button_Browse_Chap_File.Enabled = false; break;
            }
        }

        /*private void ComboBox_FPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_FPS.SelectedIndex == 1) //Auto
            {
                ComboBox_AVS_Inputer.SelectedIndex = 0;
                ComboBox_AVS_Inputer.Enabled = false;
            }
            else       
                if (ComboBox_Color_Depth.SelectedIndex != 1)
                    ComboBox_AVS_Inputer.Enabled = true;
                    
        }
*/

        private void ComboBox_Audio_Output_Format_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Audio_Output_Path.Text.IndexOf(".flac") != -1)
                    TextBox_Audio_Output_Path.Text = TextBox_Audio_Output_Path.Text.Remove(TextBox_Audio_Output_Path.Text.Length - 4, 4);
                else
                    TextBox_Audio_Output_Path.Text = TextBox_Audio_Output_Path.Text.Remove(TextBox_Audio_Output_Path.Text.Length - 3, 3);
                string temp = ComboBox_Audio_Output_Format.SelectedItem.ToString();
                temp = temp.ToLower();
                TextBox_Audio_Output_Path.Text += temp;
                temp = null;
                GC.Collect();
            }
            catch
            { /*MessageBox.Show(E.Message); */}
        }

        /*private void ComboBox_Color_Depth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_Color_Depth.SelectedIndex == 1) //10bit
            {
                /*if (ComboBox_AVS_Inputer.SelectedIndex == 1) //avs2yuv selected
                {
                    if (ComboBox_FPS.Items.Contains("自動偵測(限用avs4x264mod)")) ComboBox_AVS_Inputer.Items.RemoveAt(2);
                }
                ComboBox_FPS.Enabled = true;
                ComboBox_AVS_Inputer.SelectedIndex = 1;
                ComboBox_AVS_Inputer.Enabled = false;
                if (ComboBox_FPS.SelectedIndex == 2)
                    ComboBox_FPS.SelectedIndex = 1;
                ComboBox_FPS.Items.RemoveAt(2);

            }

            else //8bit
            {
                ComboBox_AVS_Inputer.Enabled = false;
                ComboBox_FPS.Enabled = false;
                ComboBox_AVS_Inputer.SelectedIndex = 0;
                if (!ComboBox_FPS.Items.Contains("自動偵測(限用avs4x264mod)") && ComboBox_Color_Depth.SelectedIndex != 1)
                {
                    ComboBox_FPS.Items.Add("自動偵測(限用avs4x264mod)");
                    ComboBox_AVS_Inputer.Enabled = true;
                    ComboBox_FPS.SelectedIndex = 2;
                }
            }
        }*/

        private void Button_Keep_Output_File_Settings_Click(object sender, EventArgs e)
        {
            Form_Keep_Output_File_Settings F = new Form_Keep_Output_File_Settings(this);
            F.ShowDialog();
        }

        private void Button_Browse_Video_Output_Path_Click(object sender, EventArgs e)
        {
            if (ComboBox_Video_Output_Format.SelectedIndex == 0)
                SFD_Output_Video.Filter = "MP4 視訊檔案|*.mp4";
            else if (ComboBox_Video_Output_Format.SelectedIndex == 1)
                SFD_Output_Video.Filter = "MKV 視訊檔案|*.mkv";
            SFD_Output_Video.ShowDialog();
            TextBox_Video_Output_Path.Text = SFD_Output_Video.FileName;
            try { if (TextBox_Audio_File_Path.Text != "") TextBox_Audio_Output_Path.Text = SFD_Output_Video.FileName.Remove(SFD_Output_Video.FileName.Length - 4, 4); }
            catch { }
            switch (ComboBox_Audio_Output_Format.SelectedIndex)
            {
                case 0: if (TextBox_Audio_Output_Path.Text != "" ) TextBox_Audio_Output_Path.Text += ".aac"; break;
                case 1: if (TextBox_Audio_Output_Path.Text != "")  TextBox_Audio_Output_Path.Text += ".flac"; break;
            }
        }

        private void Button_Browse_Audio_Save_Path_Click(object sender, EventArgs e)
        {
            if (TextBox_Audio_File_Path.Text != "")
            {
                //if (ComboBox_Video_Output_Format.SelectedIndex == 0)
                SFD_Output_Audio.Filter = "AAC 音訊檔案|*.aac";
                /*else*/
                if (ComboBox_Video_Output_Format.SelectedIndex == 1)
                    SFD_Output_Audio.Filter = "FLAC 音訊檔案|*.flac";
                SFD_Output_Audio.ShowDialog();
                TextBox_Audio_Output_Path.Text = SFD_Output_Audio.FileName;
            }
            else
                MessageBox.Show("尚未選取音訊檔案！");
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        void Add_Parameters()
        {
            #region 加參數
            Parameters.Add(0, " ");
            Parameters.Add(1, "--profile high --deblock -2:-2 --scenecut 40 --b-pyramid normal --level 4.1 --preset medium --ref 4 --merange 32 --me umh --direct auto --trellis 2");
            Parameters.Add(2, "--profile high --deblock -2:-2 --scenecut 40 --b-pyramid normal --level 4.1 --preset medium --ref 3 --no-chroma-me --merange 32 --me umh --direct auto --trellis 2");
            Parameters.Add(3, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --rc-lookahead 250 --b-adapt 2 --b-pyramid none --preset medium --opencl --thread-input  --keyint infinite --min-keyint 1 --bframes 5 --ref 6 --weightp 3 --qpmax 36 --aq-mode 4 --aq-strength 0.6  --merange 24 --me tesa --direct auto --subme 11 --sliced-threads --partitions all --fgo 3 --trellis 2 --psy-rd 0.40:0.00");
            Parameters.Add(4, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --b-pyramid strict --preset medium --opencl --thread-input  --bframes 5 --ref 6 --qpmax 51 --aq-mode 4 --aq-strength 0.6  --me umh --direct auto --subme 8 --sliced-threads --fgo 3 --psy-rd 0.40:0.00");
            Parameters.Add(5, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --rc-lookahead 250 --b-adapt 2 --b-pyramid none --preset medium --opencl --thread-input  --keyint infinite --min-keyint 1 --bframes 16 --ref 16 --weightp 3 --qpmax 36 --aq-mode 4 --aq-strength 0.6  --merange 24 --me tesa --direct auto --subme 11 --sliced-threads --partitions all --fgo 3 --trellis 2 --psy-rd 0.40:0.00");
            Parameters.Add(6, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --b-pyramid strict --preset medium --opencl --thread-input  --bframes 16 --ref 16 --qpmax 51 --aq-mode 4 --aq-strength 0.6  --merange 24 --me umh --direct auto --subme 8 --sliced-threads --fgo 3 --psy-rd 0.40:0.00");
            Parameters.Add(7, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --rc-lookahead 250 --no-mbtree --no-mixed-refs --b-adapt 2 --b-pyramid none --level 4.1 --preset medium --opencl --thread-input --keyint infinite --min-keyint 1 --bframes 2 --ref 1 --weightp 3 --qpmax 36 --ipratio 2.1 --pbratio 1.0 --aq-mode 4 --merange 32 --me tesa --direct auto --subme 11 --fgo 15 --trellis 2 --psy-rd 0.60:0.15");
            Parameters.Add(8, "--profile high --no-fast-pskip --deblock 1:1 --scenecut 40 --no-mbtree --no-mixed-refs --b-pyramid strict --level 4.1 --preset medium --opencl --thread-input --keyint infinite --min-keyint 12 --bframes 16 --ref 4 --weightp 3 --qpmax 36 --ipratio 2.1 --pbratio 1.0 --aq-mode 4 --merange 24 --me umh --direct auto --subme 8 --fgo 4 --trellis 2 --psy-rd 0.60:0.15");
            Parameters.Add(9, "--profile high --level 5.1 --preset placebo --keyint infinite --min-keyint 1 --bframes 3 --ref 3 --rc-lookahead 40 --merange 16 --me hex --direct spatial --subme 1 --trellis 1");
            #endregion
            #region 參數建議CRF值
            Parameters_CRF.Add(0, 17.0M);
            Parameters_CRF.Add(1, 21.0M);
            Parameters_CRF.Add(2, 21.0M);
            Parameters_CRF.Add(3, 23.0M);
            Parameters_CRF.Add(4, 23.0M);
            Parameters_CRF.Add(5, 23.0M);
            Parameters_CRF.Add(6, 23.0M);
            Parameters_CRF.Add(7, 17.0M);
            Parameters_CRF.Add(8, 17.0M);
            Parameters_CRF.Add(9, 1000M); //bitrate
            #endregion
            #region 新增參數至清單
            ComboBox_Parameter.Items.Add("自訂");
            ComboBox_Parameter.Items.Add("Lazypack");
            ComboBox_Parameter.Items.Add("Rion");
            ComboBox_Parameter.Items.Add("Midium BEST");
            ComboBox_Parameter.Items.Add("Midium FAST");
            ComboBox_Parameter.Items.Add("Normal BEST");
            ComboBox_Parameter.Items.Add("Normal FAST");
            ComboBox_Parameter.Items.Add("RAW BEST");
            ComboBox_Parameter.Items.Add("RAW FAST");
            ComboBox_Parameter.Items.Add("BD MINI");
            #endregion
            Load_Parameters();
        }

        void Load_Parameters()
        {
            string[] Parameter_Files = Directory.GetFiles("parameters", "*.txt", SearchOption.TopDirectoryOnly);
            foreach (string Parameter_FileName in Parameter_Files)
            {
                string tmp, para_tmp;
                tmp = Parameter_FileName.Replace("parameters\\", "");
                tmp = tmp.Replace(".txt", "");
                ComboBox_Parameter.Items.Add(tmp);
                StreamReader SR = new StreamReader(Parameter_FileName);
                para_tmp = SR.ReadToEnd();
                Parameters.Add(Parameters.Count, para_tmp);
                Parameters_CRF.Add(Parameters_CRF.Count, 19.0M);
            }
        }

        void init_OFDs() //OpenFileDialog
        {
            OFD_Audio = new OpenFileDialog();
            OFD_AVS = new OpenFileDialog();
            OFD_Chap_File = new OpenFileDialog();
            OFD_Subtitles = new OpenFileDialog();
            OFD_Audio.Filter = "AAC音訊檔案 (*.aac)|*.aac|FLAC音訊檔案 (*.flac)|*.flac";
            OFD_Audio.RestoreDirectory = true;
            OFD_AVS.Filter = "AVS腳本 (*.avs)|*.avs";
            OFD_AVS.RestoreDirectory = true;
            OFD_Subtitles.Multiselect = true;
            OFD_Subtitles.RestoreDirectory = true;
            OFD_Chap_File.Filter = "章節檔案 (*.txt)|*.txt";
            OFD_Chap_File.RestoreDirectory = true;
        }

        void Clear_All()
        {
            TextBox_Audio_File_Path.Text = String.Empty;
            TextBox_Audio_Output_Path.Text = String.Empty;
            TextBox_AVS_File_Path.Text = String.Empty;
            TextBox_Subtitle_Path.Text = String.Empty;
            TextBox_Video_Output_Path.Text = String.Empty;

            string tmp = Parameters[0].ToString();
            int SelectedParameter = ComboBox_Parameter.SelectedIndex;
            ComboBox_Parameter.Items.Clear();
            Parameters.Clear();
            Parameters_CRF.Clear();
            Add_Parameters();
            Parameters[0] = tmp;
            ComboBox_Parameter.SelectedIndex = SelectedParameter; //原本忘了這行w
            init_OFDs();

            SFD_Output_Audio.FileName = String.Empty;
            SFD_Output_Video.FileName = String.Empty;
            GC.Collect();
        }

        string Get_Path_By_OFD (string FileName , string Title)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = String.Format("{0}|{1}" , FileName , FileName);
            OFD.Title = Title;
            OFD.Multiselect = false;
            OFD.ShowDialog();
            return OFD.FileName;
        }
        
        string Get_AVS_Inputer_Path(int option)
        {
            string AVS_Inputer_Path;
            if (ComboBox_AVS_Inputer.SelectedIndex == 0)
            {
                AVS_Inputer_Path = String.Format("{0}\\{1}", Environment.CurrentDirectory, "tools\\avs4x264mod.exe");
                if (File.Exists("tools\\avs4x264mod.exe") == false)
                    AVS_Inputer_Path = Get_Path_By_OFD ("avs4x264mod.exe" , "請選取 avs4x264mod.exe 的位置");
            }
/*            else if (ComboBox_AVS_Inputer.SelectedIndex == 1)
            {
                AVS_Inputer_Path = String.Format("{0}\\{1}", Environment.CurrentDirectory, "tools\\vfw4x264.exe");
                if (File.Exists("tools\\vfw4x264.exe") == false)
                    AVS_Inputer_Path = Get_Path_By_OFD ("vfw4x264.exe" , "請選取 vfw4x264.exe 的位置");
            }
 */
            else
            {
                AVS_Inputer_Path = String.Format("{0}\\{1}", Environment.CurrentDirectory, "tools\\avs2yuv.exe");
                if (File.Exists("tools\\avs2yuv.exe") == false)
                    AVS_Inputer_Path = Get_Path_By_OFD ("avs2yuv.exe" , "請選取 avs2yuv.exe 的位置");
            }

            return AVS_Inputer_Path;
        }

        string Get_x264_Encoder_Path ()
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            if (Environment.Is64BitOperatingSystem == true)
            {
                if (ComboBox_Color_Depth.SelectedIndex == 0) //8bit
                {
                    if (File.Exists("tools\\x264_64_tMod-8bit-all.exe") == true)
                        return CurrentDirectory + "\\tools\\x264_64_tMod-8bit-all.exe";
                    else
                        return Get_Path_By_OFD ("x264_64_tMod-8bit-all.exe" , "請選取 x264_64_tMod-8bit-all.exe 的位置");
                }

                else //10bit
                {
                    if (File.Exists("tools\\x264_64_tMod-10bit-all.exe") == true)
                        return CurrentDirectory + "\\tools\\x264_64_tMod-10bit-all.exe";
                    else
                        return Get_Path_By_OFD ("x264_64_tMod-10bit-all.exe" , "請選取 x264_64_tMod-10bit-all.exe 的位置");
                }

            }

            else //32bit OS
            {
                if (ComboBox_Color_Depth.SelectedIndex == 0) //8bit
                {
                    if (File.Exists("tools\\x264_32_tMod-8bit-all.exe") == true)
                        return CurrentDirectory + "\\tools\\x264_32_tMod-8bit-all.exe";
                    else
                        return Get_Path_By_OFD("x264_32_tMod-8bit-all.exe", "請選取 x264_32_tMod-8bit-all.exe 的位置");
                }

                else //10bit
                {
                    if (File.Exists("tools\\x264_32_tMod-10bit-all.exe") == true)
                        return CurrentDirectory + "\\tools\\x264_32_tMod-10bit-all.exe";
                    else
                        return Get_Path_By_OFD("x264_32_tMod-10bit-all.exe", "請選取 x264_32_tMod-10bit-all.exe 的位置");
                }
            }
            
        }

        string Get_AVS_Inputer_Command(int option , string AVS_Path)
        {
            if (option == 0) //avs4x264mod
                return String.Format("\"{0}\" --x264-binary  \"{1}\" ", Get_AVS_Inputer_Path(0), Get_x264_Encoder_Path());
/*            else if (option == 1)
                return String.Format("\"{0}\"  \"{1}\" ", Get_AVS_Inputer_Path(1), Get_x264_Encoder_Path());*/
            else
                return String.Format("\"{0}\" -raw  \"{1}\" -o - | ", Get_AVS_Inputer_Path(1), AVS_File_Path);
        }

        string Create_Audio_AVS()
        {
            #region 檔案檢查
            string FFMS_Path = Environment.CurrentDirectory + "\\tools\\ffms2.dll";
            string FFMS_Index_Path = Environment.CurrentDirectory + "\\tools\\ffmsindex.exe";
            if (File.Exists("tools\\ffms2.dll") == false)
                FFMS_Path = Get_Path_By_OFD("ffms2.dll", "請選取 ffms2.dll 的位置");
            if (File.Exists("tools\\ffmsindex.exe") == false)
                FFMS_Index_Path = Get_Path_By_OFD("ffmsindex.exe", "請選取 ffmsindex.exe 的位置");
            #endregion
            string AVS = String.Format("LoadPlugin (\"{0}\")\nFFAudioSource(\"{1}\")", FFMS_Path, TextBox_Audio_File_Path.Text);
            Audio_AVS_Path = TextBox_Audio_Output_Path.Text;
            if (TextBox_Audio_Output_Path.Text.IndexOf(".flac") != -1)
            {
                try { Audio_AVS_Path = TextBox_Audio_Output_Path.Text.Remove(TextBox_Audio_Output_Path.Text.Length - 4, 4); }
                catch { }
            }
            else
            {
                try { Audio_AVS_Path = TextBox_Audio_Output_Path.Text.Remove(TextBox_Audio_Output_Path.Text.Length - 3, 3); }
                catch { }
            }
            Audio_AVS_Path += "avs";
            StreamWriter SW = new StreamWriter(Audio_AVS_Path);
            SW.WriteLine(AVS);
            SW.Close();
            SW.Dispose();
            return Audio_AVS_Path;
        }

        string Get_Audio_Process_Command()
        {
            string Wavi_Path = Environment.CurrentDirectory + "\\tools\\wavi.exe";
            string FLAC_Path = Environment.CurrentDirectory + "\\tools\\flac.exe";
            string AAC_Path = Environment.CurrentDirectory + "\\tools\\neroaacenc.exe";
            #region 檔案檢查
            if (File.Exists("tools\\wavi.exe") == false)
                Wavi_Path = Get_Path_By_OFD("wavi.exe", "請選取 wavi.exe 的位置");
            if (ComboBox_Audio_Output_Format.SelectedIndex == 0) // AAC
            {
                if (File.Exists("tools\\neroaacenc.exe") == false)
                    AAC_Path = Get_Path_By_OFD("neroaacenc.exe", "請選取 neroaacenc.exe 的位置");
            }
            else
            {
                if (File.Exists("tools\\flac.exe") == false)
                    AAC_Path = Get_Path_By_OFD("flac.exe", "請選取 flac.exe 的位置");
            }
            #endregion
            string Audio_Output_Path = TextBox_Audio_Output_Path.Text;
            string Audio_AVS_Path = TextBox_Audio_File_Path.Text;
            if (TextBox_Audio_File_Path.Text.IndexOf(".avs") == -1)
                Audio_AVS_Path = Create_Audio_AVS();

            if (ComboBox_Audio_Output_Format.SelectedIndex == 0)
                return String.Format("\"{0}\" \"{1}\" - | \"{2}\" -if - -he -q 0.6 -of \"{3}\"" , Wavi_Path , Audio_AVS_Path , AAC_Path , Audio_Output_Path);
            else
                return String.Format("\"{0}\" \"{1}\" - | \"{2}\" -V -6 -o \"{3}\" -", Wavi_Path, Audio_AVS_Path, FLAC_Path, Audio_Output_Path);
        }

        bool Check()
        {
            bool OK = true;
            if (TextBox_AVS_File_Path.Text == String.Empty) { MessageBox.Show("尚未輸入AVS檔！"); OK = false; }
            if (TextBox_Video_Output_Path.Text == String.Empty) {MessageBox.Show("視訊輸出路徑為空！"); OK = false;}
            if (TextBox_Audio_File_Path.Text != String.Empty && TextBox_Audio_Output_Path.Text == String.Empty) { MessageBox.Show("音訊輸出路徑為空！"); OK = false; }
            if (ComboBox_Parameter.SelectedIndex == 0 && Parameters[9].ToString() == String.Empty) { MessageBox.Show("尚未輸入自訂參數！"); OK = false;}
            if (!CheckBox_2pass_SameParameter.Checked && TwoPassParameter == String.Empty) { MessageBox.Show("尚未輸入2pass參數！"); OK = false; }
            if (OK) return true;
            return false;
        }

        bool IsUsingDefaultParameter()
        {
            if (ComboBox_Parameter.SelectedIndex == 0 || ComboBox_Parameter.SelectedIndex > 9)
                return false;
            return true;
        }

        private void Button_CreatBAT_Click(object sender, EventArgs e)
        {
            string Output = "", Parameter = "";
            if (Check())
            {
                #region 輸出LOGO
            Output += "echo off" + Environment.NewLine + "cls" + Environment.NewLine + "echo." + Environment.NewLine + "echo 　　█████████　　　 █                █              ████" + Environment.NewLine + "echo 　　　　　　█　　　　　　   █                █           ██      ██" + Environment.NewLine + "echo 　　　　　　█               █                █         ██          " + Environment.NewLine + "echo 　　　　　　█　      　　   █                █         █    " + Environment.NewLine + "echo 　　　　　　█　BAT產生器     █              █          ██           " + Environment.NewLine + "echo 　　　　　　█　　    　　     ██        ██             ██      ██  " + Environment.NewLine + "echo 　　　　　　█ 2013.08.26         █████                  ████ " + Environment.NewLine + "echo." + Environment.NewLine + "echo ●●●●●●●●　%date% %time% 壓制開始  　●●●●●●●●" + Environment.NewLine + "echo.";
            Output += Environment.NewLine;
            #endregion
                #region 視訊部分
            #region 1st pass OR 1 pass only
                Output += Get_AVS_Inputer_Command(ComboBox_AVS_Inputer.SelectedIndex, AVS_File_Path);

                switch (ComboBox_AVS_Inputer.SelectedIndex)
                {
                    case 0: Parameter = Parameters[ComboBox_Parameter.SelectedIndex].ToString(); break;
                    case 1: Parameter = String.Format("\"{0}\" {1} ", Get_x264_Encoder_Path(), Parameters[ComboBox_Parameter.SelectedIndex].ToString()); break;
                }

                if (RButton_CRF.Checked && ComboBox_Parameter.SelectedIndex != 0 && IsUsingDefaultParameter()) //預設參數
                    Parameter += " --crf " + Numeric_Quality.Value.ToString() + " ";
                if (RButton_ABR.Checked && ComboBox_Parameter.SelectedIndex != 0 && IsUsingDefaultParameter()) //預設參數
                    Parameter += " --bitrate " + Numeric_Quality.Value.ToString() + " ";

                if (!IsUsingDefaultParameter())
                {
                    if (ComboBox_Color_Depth.SelectedIndex == 1) //10bit
                        Parameter = Parameter.Replace("--profile high", "--profile high10");
                    else 
                        Parameter = Parameter.Replace("--profile high10", "--profile high");

                    if (CheckBox_2pass_ON.Checked)
                    {
                        Regex Regex_Pattern = new Regex("--pass\\s+\\d");
                        Parameter = Regex_Pattern.Replace(Parameter, ""); //參數內只要有--pass N就都先拿掉 以策安全
                        Parameter += " --pass 1 ";
                    }
                }
                else //使用預設參數時 --stats要自動加上去
                {
                    if (CheckBox_2pass_ON.Checked)
                    {
                        Regex Regex_Pattern = new Regex("--pass\\s+\\d");
                        Parameter = Regex_Pattern.Replace(Parameter, ""); //參數內只要有--pass N就都先拿掉 以策安全
                        Parameter += " --pass 1 --stats \".stats\"";
                    }
                }

                if (ComboBox_AVS_Inputer.SelectedIndex == 1) //avs2yuv selected
                {
                    Form_Get_Resolution F = new Form_Get_Resolution(this);
                    F.ShowDialog(this);
                    Parameter += String.Format(" --input-res {0}x{1}", Res_X, Res_Y);
                }
                if (ComboBox_FPS.Text.Trim().ToLower() != "auto")
                    Parameter += String.Format(" --fps {0} ", ComboBox_FPS.Text);
                Output += Parameter;

                try { Video_Output_Path = TextBox_Video_Output_Path.Text.Remove(TextBox_Video_Output_Path.Text.Length - 4, 4) + "-video.264"; }
                catch { }
                if (CheckBox_2pass_ON.Checked)
                {
                    switch (ComboBox_AVS_Inputer.SelectedIndex)
                    {
                        case 0: Output += " --output NUL \"" + TextBox_AVS_File_Path.Text + "\""; break;
                        case 1: Output += " --output NUL - "; break;
                    }
                }
                else
                {
                    switch (ComboBox_AVS_Inputer.SelectedIndex)
                    {
                        case 0: Output += "  --output \"" + Video_Output_Path + "\" \"" + TextBox_AVS_File_Path.Text + "\""; break;
                        case 1: Output += "  --output \"" + Video_Output_Path + "\" -"; break;
                    }
                }

                Output += Environment.NewLine;
            #endregion

                #region 2nd pass
                if (CheckBox_2pass_ON.Checked)
                {
                    Output += Get_AVS_Inputer_Command(ComboBox_AVS_Inputer.SelectedIndex, AVS_File_Path);

                    if (CheckBox_2pass_SameParameter.Checked)
                    {
                        switch (ComboBox_AVS_Inputer.SelectedIndex)
                        {
                            case 0: Parameter = Parameters[ComboBox_Parameter.SelectedIndex].ToString(); break;
                            case 1: Parameter = String.Format("\"{0}\" {1} ", Get_x264_Encoder_Path(), Parameters[ComboBox_Parameter.SelectedIndex].ToString()); break;
                        }
                    }
                    else
                    {
                        switch (ComboBox_AVS_Inputer.SelectedIndex)
                        {
                            case 0: Parameter = TwoPassParameter; break;
                            case 1: Parameter = String.Format("\"{0}\" {1}", Get_x264_Encoder_Path(), TwoPassParameter); break;
                        }
                    }

                    if (!IsUsingDefaultParameter())
                    {
                        if (CheckBox_2pass_SameParameter.Checked && Parameters[ComboBox_Parameter.SelectedIndex].ToString().IndexOf("--crf") != -1) //1pass自訂參數使用crf 且2pass使用同參數
                        {
                            Regex Regex_Pattern = new Regex("--crf\\s\\d*\\.\\d*");
                            Parameter = Regex_Pattern.Replace(Parameter, String.Empty);
                            Form_Get_2pass_Bitrate FG2B = new Form_Get_2pass_Bitrate(this);
                            FG2B.ShowDialog();
                            Parameter += " --bitrate " + TwoPass_Bitrate.ToString();
                        }
                        else if (!CheckBox_2pass_SameParameter.Checked && TwoPassParameter.IndexOf("--crf") != -1) //雖然是自訂 不過還是檢查一下吧..
                        {
                            Regex Regex_Pattern = new Regex("--crf\\s\\d*\\.\\d*");
                            Parameter = Regex_Pattern.Replace(Parameter, String.Empty);
                            Form_Get_2pass_Bitrate FG2B = new Form_Get_2pass_Bitrate(this);
                            FG2B.ShowDialog();
                            Parameter += " --bitrate " + TwoPass_Bitrate.ToString();
                        }
                    }
                    else
                    {
                        if (CheckBox_2pass_SameParameter.Checked && RButton_CRF.Checked) //1pass使用預設參數 且為crf模式
                        {
                            Form_Get_2pass_Bitrate FG2B = new Form_Get_2pass_Bitrate(this);
                            FG2B.ShowDialog();
                            Parameter += " --bitrate " + TwoPass_Bitrate.ToString();
                        }
                    }

                    if (!IsUsingDefaultParameter()) //使用自訂參數時 執行參數檢查
                    {
                        if (ComboBox_Color_Depth.SelectedIndex == 1) //10bit
                            { Parameter = Parameter.Replace("--profile high", "--profile high10"); }
                        else
                            { Parameter = Parameter.Replace("--profile high10", "--profile high"); }
                        
                        Regex Regex_Pattern = new Regex("--pass\\s+\\d");
                        Parameter = Regex_Pattern.Replace(Parameter, ""); //參數內只要有--pass N就都先拿掉 以策安全
                        Parameter += " --pass 2 ";
                    }
                    else //使用預設參數時 --stats要自動加上去
                    {
                        Regex Regex_Pattern = new Regex("--pass\\s+\\d");
                        Parameter = Regex_Pattern.Replace(Parameter, ""); //參數內只要有--pass N就都先拿掉 以策安全
                        Parameter += " --pass 2 --stats \".stats\"";
                    }

                    if (ComboBox_AVS_Inputer.SelectedIndex == 1) //avs2yuv selected
                    {
                        //Form_Get_Resolution F = new Form_Get_Resolution(this);
                        //F.ShowDialog(this);
                        Parameter += String.Format(" --input-res {0}x{1}", Res_X, Res_Y);
                    }
                    if (ComboBox_FPS.Text.Trim().ToLower() != "auto")
                        Parameter += String.Format(" --fps {0} ", ComboBox_FPS.Text);


                    Output += Parameter;

                    Video_Output_Path = TextBox_Video_Output_Path.Text;
                    try { Video_Output_Path = TextBox_Video_Output_Path.Text.Remove(TextBox_Video_Output_Path.Text.Length - 4, 4) + "-video.264"; }
                    catch { }

                    switch (ComboBox_AVS_Inputer.SelectedIndex)
                        {
                            case 0: Output += " --output \"" + Video_Output_Path + "\" \"" + TextBox_AVS_File_Path.Text + "\""; break;
                            case 1: Output += " --output \"" + Video_Output_Path + "\" -"; break;
                        }

                    Output += Environment.NewLine;
                }
                #endregion
                #endregion
                #region 音訊部分
                if (TextBox_Audio_File_Path.Text != "")
                {
                    Output += Get_Audio_Process_Command();
                    Output += Environment.NewLine;
                }
                #endregion
                #region 封裝部分
                string MP4Box_Path = Environment.CurrentDirectory + "\\tools\\mp4box.exe";
                string MKVMerge_Path = Environment.CurrentDirectory + "\\tools\\mkvmerge.exe";

                if (ComboBox_Video_Output_Format.SelectedIndex != 2) //RAWAVC
                    Output += String.Format("IF EXIST \"{0}\" (DEL \"{1}\"){2}", TextBox_Video_Output_Path.Text, TextBox_Video_Output_Path.Text, Environment.NewLine);
                if (ComboBox_Video_Output_Format.SelectedIndex == 0) //MP4
                {
                    if (File.Exists("tools\\mp4box.exe") == false)
                        Get_Path_By_OFD("mp4box.exe", "請輸入 mp4box.exe 的位置");
                    Output += String.Format("\"{0}\" -add \"{1}\" ", MP4Box_Path, Video_Output_Path);
                    if(TextBox_Audio_File_Path.Text != "" ) Output += String.Format(" -add \"{0}\" ", TextBox_Audio_Output_Path.Text);
                    if (TextBox_Chap_File_Path.Text != "") Output += String.Format(" -chap \"{0}\"", TextBox_Chap_File_Path.Text);
                    Output += String.Format(" \"{0}\" ", TextBox_Video_Output_Path.Text);
                }
                else if (ComboBox_Video_Output_Format.SelectedIndex == 1)
                {
                    if (File.Exists("tools\\mkvmerge.exe") == false)
                        Get_Path_By_OFD("mkvmerge.exe", "請輸入 mkvmerge.exe 的位置");
                    if (TextBox_Chap_File_Path.Text == "")
                        Output += String.Format("\"{0}\" -o \"{1}\" \"{2}\" \"{3}\"", MKVMerge_Path, TextBox_Video_Output_Path.Text, Video_Output_Path, TextBox_Audio_Output_Path.Text);
                    else
                        Output += String.Format("\"{0}\" -o \"{1}\" --chapters \"{2}\" \"{3}\" \"{4}\" ", MKVMerge_Path, TextBox_Video_Output_Path.Text,TextBox_Chap_File_Path.Text, Video_Output_Path, TextBox_Audio_Output_Path.Text);

                    if (TextBox_Subtitle_Path.Text != String.Empty)
                    {
                        foreach (string Sub_Path in OFD_Subtitles.FileNames)
                            Output += String.Format(" \"{0}\"", Sub_Path);
                    }
                }

                Output += Environment.NewLine;
                #endregion
                #region 清理殘渣
                if (Keep_Video == false && ComboBox_Video_Output_Format.SelectedIndex != 2) Output += String.Format("del /F /Q \"{0}\"{1}", Video_Output_Path,Environment.NewLine);
                if (Keep_Audio == false && TextBox_Audio_File_Path.Text != "") Output += String.Format("del /F /Q \"{0}\"{1}", TextBox_Audio_Output_Path.Text, Environment.NewLine);
                //if (CheckBox_Output_Audio_Independnet.Checked == false && TextBox_Audio_File_Path.Text != "") Output += String.Format("del /F /Q \"{0}\"{1}", TextBox_Audio_Output_Path.Text,Environment.NewLine);
                if (File.Exists(Audio_AVS_Path) == true) Output += String.Format("del /F /Q \"{0}\"{1}", Audio_AVS_Path,Environment.NewLine);
                #endregion
                #region 輸出BAT
                //string BAT_Output_Path = TextBox_Video_Output_Path.Text;
                bool Write_Success = true;
                /*try { BAT_Output_Path = TextBox_Video_Output_Path.Text.Remove(TextBox_Video_Output_Path.Text.Length - 3, 3) + "bat"; }
                catch { }*/
                try
                {
                    SaveFileDialog SFD = new SaveFileDialog();
                    SFD.Filter = "BAT批次檔|*.bat";
                    SFD.ShowDialog();
                    StreamWriter SW = new StreamWriter(SFD.FileName, false, Encoding.GetEncoding(950));
                    SW.WriteLine(Output);
                    SW.Close();
                    SW.Dispose();
                }
                catch (UnauthorizedAccessException) { MessageBox.Show("BAT寫入失敗 存取被拒！"); Write_Success = false; }
                catch (IOException) { MessageBox.Show("檔案名稱、目錄名稱或磁碟標籤語法不正確或語法無效"); Write_Success = false; }
                catch (Exception E) { MessageBox.Show("BAT寫入失敗 錯誤訊息：" + E.Message); Write_Success = false; }
                if (Write_Success == true) { MessageBox.Show("BAT檔寫入成功！"); }
                #endregion
                Clear_All();
            }
            GC.Collect();
        }

        private void CheckBox_2pass_ON_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_2pass_ON.Checked) 
            {
                CheckBox_2pass_SameParameter.Enabled = true;
                CheckBox_2pass_SameParameter.Checked = true;
                if(!CheckBox_2pass_SameParameter.Checked) Button_2pass_InputParameter.Enabled = true;
            }
            else
            {
                CheckBox_2pass_SameParameter.Enabled = false;
                Button_2pass_InputParameter.Enabled = false;
            }
        }

        private void CheckBox_2pass_SameParameter_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckBox_2pass_SameParameter.Checked) Button_2pass_InputParameter.Enabled = true;
            else Button_2pass_InputParameter.Enabled = false;
        }

        private void Button_2pass_InputParameter_Click(object sender, EventArgs e)
        {
            Form_Input_User_Defined_Parameters FIUDP = new Form_Input_User_Defined_Parameters(this, 2);
            FIUDP.ShowDialog();
        }

        private void ComboBox_AVS_Inputer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_AVS_Inputer.SelectedIndex == 0) //avs4x264mod
            {
                if (!ComboBox_FPS.Items.Contains("Auto"))
                    ComboBox_FPS.Items.Add("Auto");
                ComboBox_FPS.SelectedIndex = 4;
            }
            else
            {
                if (ComboBox_FPS.Items.Contains("Auto"))
                    ComboBox_FPS.Items.Remove("Auto");
                ComboBox_FPS.SelectedIndex = 3;
            }
        }

        private void TSM_MP4Muxer_Click(object sender, EventArgs e)
        {
            Process mp4boxGUI = new Process();
            mp4boxGUI.StartInfo.FileName = "tools\\My MP4Box GUI\\My MP4Box GUI.exe";
            mp4boxGUI.Start();
        }

        private void TSM_MediaInfo_Click(object sender, EventArgs e)
        {
            MediaInfo Form_MediaInfo = new MediaInfo();
            Form_MediaInfo.Show();
        }
    }
}