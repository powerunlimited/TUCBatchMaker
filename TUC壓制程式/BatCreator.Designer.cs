namespace TUCEncoder
{
    partial class BatCreator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BatCreator));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSM_tools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_MMG = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_MP4Muxer = new System.Windows.Forms.ToolStripMenuItem();
            this.TSM_MediaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Label_AVS_File_Path = new System.Windows.Forms.Label();
            this.TextBox_AVS_File_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_AVS_File_Path = new System.Windows.Forms.Button();
            this.Label_Audio_File_Path = new System.Windows.Forms.Label();
            this.TextBox_Audio_File_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_AVS_Audio_Path = new System.Windows.Forms.Button();
            this.Label_parameter = new System.Windows.Forms.Label();
            this.ComboBox_Parameter = new System.Windows.Forms.ComboBox();
            this.Label_Video_Output_Format = new System.Windows.Forms.Label();
            this.ComboBox_Video_Output_Format = new System.Windows.Forms.ComboBox();
            this.Label_Audio_Output_Format = new System.Windows.Forms.Label();
            this.ComboBox_Audio_Output_Format = new System.Windows.Forms.ComboBox();
            this.OFD_AVS = new System.Windows.Forms.OpenFileDialog();
            this.OFD_Audio = new System.Windows.Forms.OpenFileDialog();
            this.Button_CreatBAT = new System.Windows.Forms.Button();
            this.ComboBox_Color_Depth = new System.Windows.Forms.ComboBox();
            this.Label_Color_Depth = new System.Windows.Forms.Label();
            this.ComboBox_AVS_Inputer = new System.Windows.Forms.ComboBox();
            this.Label_AVS_Inputer = new System.Windows.Forms.Label();
            this.TextBox_Video_Output_Path = new System.Windows.Forms.TextBox();
            this.Label_Video_Output_Path = new System.Windows.Forms.Label();
            this.Button_Browse_Video_Output_Path = new System.Windows.Forms.Button();
            this.SFD_Output_Video = new System.Windows.Forms.SaveFileDialog();
            this.TextBox_Audio_Output_Path = new System.Windows.Forms.TextBox();
            this.Label_Audio_Output_Path = new System.Windows.Forms.Label();
            this.Button_Browse_Audio_Save_Path = new System.Windows.Forms.Button();
            this.SFD_Output_Audio = new System.Windows.Forms.SaveFileDialog();
            this.Label_FPS = new System.Windows.Forms.Label();
            this.ComboBox_FPS = new System.Windows.Forms.ComboBox();
            this.OFD_Subtitles = new System.Windows.Forms.OpenFileDialog();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.RButton_CRF = new System.Windows.Forms.RadioButton();
            this.RButton_ABR = new System.Windows.Forms.RadioButton();
            this.Numeric_Quality = new System.Windows.Forms.NumericUpDown();
            this.Button_Input_User_Defined_Parameters = new System.Windows.Forms.Button();
            this.Button_Browse_Chap_File = new System.Windows.Forms.Button();
            this.Label_Chap_File = new System.Windows.Forms.Label();
            this.TextBox_Chap_File_Path = new System.Windows.Forms.TextBox();
            this.OFD_Chap_File = new System.Windows.Forms.OpenFileDialog();
            this.Button_Browse_Subtitle_Path = new System.Windows.Forms.Button();
            this.Label_Subtitles_Path = new System.Windows.Forms.Label();
            this.TextBox_Subtitle_Path = new System.Windows.Forms.TextBox();
            this.Button_Keep_Output_File_Settings = new System.Windows.Forms.Button();
            this.CheckBox_2pass_ON = new System.Windows.Forms.CheckBox();
            this.CheckBox_2pass_SameParameter = new System.Windows.Forms.CheckBox();
            this.Button_2pass_InputParameter = new System.Windows.Forms.Button();
            this.MS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Quality)).BeginInit();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.BackColor = System.Drawing.SystemColors.Control;
            this.MS_Main.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_tools});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(671, 24);
            this.MS_Main.TabIndex = 24;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSM_tools
            // 
            this.TSM_tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_MMG,
            this.TSM_MP4Muxer,
            this.TSM_MediaInfo});
            this.TSM_tools.Name = "TSM_tools";
            this.TSM_tools.Size = new System.Drawing.Size(44, 20);
            this.TSM_tools.Text = "工具";
            // 
            // TSM_MMG
            // 
            this.TSM_MMG.Name = "TSM_MMG";
            this.TSM_MMG.Size = new System.Drawing.Size(168, 22);
            this.TSM_MMG.Text = "MKVMerge";
            this.TSM_MMG.Click += new System.EventHandler(this.TSM_MMG_Click);
            // 
            // TSM_MP4Muxer
            // 
            this.TSM_MP4Muxer.Name = "TSM_MP4Muxer";
            this.TSM_MP4Muxer.Size = new System.Drawing.Size(168, 22);
            this.TSM_MP4Muxer.Text = "My MP4Box GUI";
            this.TSM_MP4Muxer.Click += new System.EventHandler(this.TSM_MP4Muxer_Click);
            // 
            // TSM_MediaInfo
            // 
            this.TSM_MediaInfo.Name = "TSM_MediaInfo";
            this.TSM_MediaInfo.Size = new System.Drawing.Size(168, 22);
            this.TSM_MediaInfo.Text = "媒體訊息";
            this.TSM_MediaInfo.Click += new System.EventHandler(this.TSM_MediaInfo_Click);
            // 
            // Label_AVS_File_Path
            // 
            this.Label_AVS_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_AVS_File_Path.Location = new System.Drawing.Point(8, 30);
            this.Label_AVS_File_Path.Name = "Label_AVS_File_Path";
            this.Label_AVS_File_Path.Size = new System.Drawing.Size(123, 17);
            this.Label_AVS_File_Path.TabIndex = 0;
            this.Label_AVS_File_Path.Text = "AVS檔案路徑 (必需):";
            // 
            // TextBox_AVS_File_Path
            // 
            this.TextBox_AVS_File_Path.AllowDrop = true;
            this.TextBox_AVS_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_AVS_File_Path.Location = new System.Drawing.Point(10, 51);
            this.TextBox_AVS_File_Path.Name = "TextBox_AVS_File_Path";
            this.TextBox_AVS_File_Path.ReadOnly = true;
            this.TextBox_AVS_File_Path.Size = new System.Drawing.Size(510, 23);
            this.TextBox_AVS_File_Path.TabIndex = 1;
            this.TextBox_AVS_File_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_AVS_File_Path_DragDrop);
            this.TextBox_AVS_File_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_AVS_File_Path_DragEnter);
            // 
            // Button_Browse_AVS_File_Path
            // 
            this.Button_Browse_AVS_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_AVS_File_Path.Location = new System.Drawing.Point(539, 51);
            this.Button_Browse_AVS_File_Path.Name = "Button_Browse_AVS_File_Path";
            this.Button_Browse_AVS_File_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_AVS_File_Path.TabIndex = 2;
            this.Button_Browse_AVS_File_Path.Text = "Browse";
            this.Button_Browse_AVS_File_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_AVS_File_Path.Click += new System.EventHandler(this.Button_Browse_AVS_File_Path_Click);
            // 
            // Label_Audio_File_Path
            // 
            this.Label_Audio_File_Path.AutoSize = true;
            this.Label_Audio_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Audio_File_Path.Location = new System.Drawing.Point(10, 80);
            this.Label_Audio_File_Path.Name = "Label_Audio_File_Path";
            this.Label_Audio_File_Path.Size = new System.Drawing.Size(92, 16);
            this.Label_Audio_File_Path.TabIndex = 3;
            this.Label_Audio_File_Path.Text = "音訊檔案路徑：";
            // 
            // TextBox_Audio_File_Path
            // 
            this.TextBox_Audio_File_Path.AllowDrop = true;
            this.TextBox_Audio_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Audio_File_Path.Location = new System.Drawing.Point(10, 106);
            this.TextBox_Audio_File_Path.Name = "TextBox_Audio_File_Path";
            this.TextBox_Audio_File_Path.ReadOnly = true;
            this.TextBox_Audio_File_Path.Size = new System.Drawing.Size(510, 23);
            this.TextBox_Audio_File_Path.TabIndex = 4;
            // 
            // Button_Browse_AVS_Audio_Path
            // 
            this.Button_Browse_AVS_Audio_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_AVS_Audio_Path.Location = new System.Drawing.Point(539, 104);
            this.Button_Browse_AVS_Audio_Path.Name = "Button_Browse_AVS_Audio_Path";
            this.Button_Browse_AVS_Audio_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_AVS_Audio_Path.TabIndex = 2;
            this.Button_Browse_AVS_Audio_Path.Text = "Browse";
            this.Button_Browse_AVS_Audio_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_AVS_Audio_Path.Click += new System.EventHandler(this.Button_Browse_AVS_Audio_Path_Click);
            // 
            // Label_parameter
            // 
            this.Label_parameter.AutoSize = true;
            this.Label_parameter.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_parameter.Location = new System.Drawing.Point(12, 251);
            this.Label_parameter.Name = "Label_parameter";
            this.Label_parameter.Size = new System.Drawing.Size(44, 16);
            this.Label_parameter.TabIndex = 6;
            this.Label_parameter.Text = "參數：";
            // 
            // ComboBox_Parameter
            // 
            this.ComboBox_Parameter.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_Parameter.FormattingEnabled = true;
            this.ComboBox_Parameter.Location = new System.Drawing.Point(73, 248);
            this.ComboBox_Parameter.Name = "ComboBox_Parameter";
            this.ComboBox_Parameter.Size = new System.Drawing.Size(97, 24);
            this.ComboBox_Parameter.TabIndex = 7;
            this.ComboBox_Parameter.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Parameter_SelectedIndexChanged);
            // 
            // Label_Video_Output_Format
            // 
            this.Label_Video_Output_Format.AutoSize = true;
            this.Label_Video_Output_Format.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Video_Output_Format.Location = new System.Drawing.Point(202, 251);
            this.Label_Video_Output_Format.Name = "Label_Video_Output_Format";
            this.Label_Video_Output_Format.Size = new System.Drawing.Size(92, 16);
            this.Label_Video_Output_Format.TabIndex = 8;
            this.Label_Video_Output_Format.Text = "視訊輸出格式：";
            // 
            // ComboBox_Video_Output_Format
            // 
            this.ComboBox_Video_Output_Format.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_Video_Output_Format.FormattingEnabled = true;
            this.ComboBox_Video_Output_Format.Location = new System.Drawing.Point(297, 248);
            this.ComboBox_Video_Output_Format.Name = "ComboBox_Video_Output_Format";
            this.ComboBox_Video_Output_Format.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Video_Output_Format.TabIndex = 9;
            this.ComboBox_Video_Output_Format.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Video_Output_Format_SelectedIndexChanged);
            // 
            // Label_Audio_Output_Format
            // 
            this.Label_Audio_Output_Format.AutoSize = true;
            this.Label_Audio_Output_Format.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Audio_Output_Format.Location = new System.Drawing.Point(434, 251);
            this.Label_Audio_Output_Format.Name = "Label_Audio_Output_Format";
            this.Label_Audio_Output_Format.Size = new System.Drawing.Size(92, 16);
            this.Label_Audio_Output_Format.TabIndex = 10;
            this.Label_Audio_Output_Format.Text = "音訊輸出格式：";
            // 
            // ComboBox_Audio_Output_Format
            // 
            this.ComboBox_Audio_Output_Format.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_Audio_Output_Format.FormattingEnabled = true;
            this.ComboBox_Audio_Output_Format.Location = new System.Drawing.Point(530, 247);
            this.ComboBox_Audio_Output_Format.Name = "ComboBox_Audio_Output_Format";
            this.ComboBox_Audio_Output_Format.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Audio_Output_Format.TabIndex = 11;
            this.ComboBox_Audio_Output_Format.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Audio_Output_Format_SelectedIndexChanged);
            // 
            // OFD_AVS
            // 
            this.OFD_AVS.Filter = "AVS腳本 (*.avs)|*.avs";
            this.OFD_AVS.RestoreDirectory = true;
            // 
            // OFD_Audio
            // 
            this.OFD_Audio.Filter = "AAC音訊檔案 (*.aac)|*.aac|FLAC音訊檔案 (*.flac)|*.flac";
            this.OFD_Audio.RestoreDirectory = true;
            // 
            // Button_CreatBAT
            // 
            this.Button_CreatBAT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_CreatBAT.Location = new System.Drawing.Point(530, 358);
            this.Button_CreatBAT.Name = "Button_CreatBAT";
            this.Button_CreatBAT.Size = new System.Drawing.Size(124, 48);
            this.Button_CreatBAT.TabIndex = 12;
            this.Button_CreatBAT.Text = "產生BAT檔案";
            this.Button_CreatBAT.UseVisualStyleBackColor = true;
            this.Button_CreatBAT.Click += new System.EventHandler(this.Button_CreatBAT_Click);
            // 
            // ComboBox_Color_Depth
            // 
            this.ComboBox_Color_Depth.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_Color_Depth.FormattingEnabled = true;
            this.ComboBox_Color_Depth.Location = new System.Drawing.Point(530, 273);
            this.ComboBox_Color_Depth.Name = "ComboBox_Color_Depth";
            this.ComboBox_Color_Depth.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_Color_Depth.TabIndex = 13;
            // 
            // Label_Color_Depth
            // 
            this.Label_Color_Depth.AutoSize = true;
            this.Label_Color_Depth.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Color_Depth.Location = new System.Drawing.Point(446, 276);
            this.Label_Color_Depth.Name = "Label_Color_Depth";
            this.Label_Color_Depth.Size = new System.Drawing.Size(68, 16);
            this.Label_Color_Depth.TabIndex = 14;
            this.Label_Color_Depth.Text = "色彩深度：";
            // 
            // ComboBox_AVS_Inputer
            // 
            this.ComboBox_AVS_Inputer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_AVS_Inputer.FormattingEnabled = true;
            this.ComboBox_AVS_Inputer.Location = new System.Drawing.Point(297, 276);
            this.ComboBox_AVS_Inputer.Name = "ComboBox_AVS_Inputer";
            this.ComboBox_AVS_Inputer.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_AVS_Inputer.TabIndex = 15;
            this.ComboBox_AVS_Inputer.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AVS_Inputer_SelectedIndexChanged);
            // 
            // Label_AVS_Inputer
            // 
            this.Label_AVS_Inputer.AutoSize = true;
            this.Label_AVS_Inputer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_AVS_Inputer.Location = new System.Drawing.Point(216, 279);
            this.Label_AVS_Inputer.Name = "Label_AVS_Inputer";
            this.Label_AVS_Inputer.Size = new System.Drawing.Size(79, 16);
            this.Label_AVS_Inputer.TabIndex = 16;
            this.Label_AVS_Inputer.Text = "AVS輸入器：";
            // 
            // TextBox_Video_Output_Path
            // 
            this.TextBox_Video_Output_Path.AllowDrop = true;
            this.TextBox_Video_Output_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Video_Output_Path.Location = new System.Drawing.Point(10, 372);
            this.TextBox_Video_Output_Path.Name = "TextBox_Video_Output_Path";
            this.TextBox_Video_Output_Path.ReadOnly = true;
            this.TextBox_Video_Output_Path.Size = new System.Drawing.Size(408, 23);
            this.TextBox_Video_Output_Path.TabIndex = 4;
            // 
            // Label_Video_Output_Path
            // 
            this.Label_Video_Output_Path.AutoSize = true;
            this.Label_Video_Output_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Video_Output_Path.Location = new System.Drawing.Point(8, 347);
            this.Label_Video_Output_Path.Name = "Label_Video_Output_Path";
            this.Label_Video_Output_Path.Size = new System.Drawing.Size(92, 16);
            this.Label_Video_Output_Path.TabIndex = 3;
            this.Label_Video_Output_Path.Text = "影像輸出路徑：";
            // 
            // Button_Browse_Video_Output_Path
            // 
            this.Button_Browse_Video_Output_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_Video_Output_Path.Location = new System.Drawing.Point(436, 370);
            this.Button_Browse_Video_Output_Path.Name = "Button_Browse_Video_Output_Path";
            this.Button_Browse_Video_Output_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Video_Output_Path.TabIndex = 2;
            this.Button_Browse_Video_Output_Path.Text = "Browse";
            this.Button_Browse_Video_Output_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_Video_Output_Path.Click += new System.EventHandler(this.Button_Browse_Video_Output_Path_Click);
            // 
            // SFD_Output_Video
            // 
            this.SFD_Output_Video.RestoreDirectory = true;
            // 
            // TextBox_Audio_Output_Path
            // 
            this.TextBox_Audio_Output_Path.AllowDrop = true;
            this.TextBox_Audio_Output_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Audio_Output_Path.Location = new System.Drawing.Point(12, 425);
            this.TextBox_Audio_Output_Path.Name = "TextBox_Audio_Output_Path";
            this.TextBox_Audio_Output_Path.ReadOnly = true;
            this.TextBox_Audio_Output_Path.Size = new System.Drawing.Size(406, 23);
            this.TextBox_Audio_Output_Path.TabIndex = 4;
            // 
            // Label_Audio_Output_Path
            // 
            this.Label_Audio_Output_Path.AutoSize = true;
            this.Label_Audio_Output_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Audio_Output_Path.Location = new System.Drawing.Point(8, 410);
            this.Label_Audio_Output_Path.Name = "Label_Audio_Output_Path";
            this.Label_Audio_Output_Path.Size = new System.Drawing.Size(92, 16);
            this.Label_Audio_Output_Path.TabIndex = 3;
            this.Label_Audio_Output_Path.Text = "音訊輸出路徑：";
            // 
            // Button_Browse_Audio_Save_Path
            // 
            this.Button_Browse_Audio_Save_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_Audio_Save_Path.Location = new System.Drawing.Point(436, 425);
            this.Button_Browse_Audio_Save_Path.Name = "Button_Browse_Audio_Save_Path";
            this.Button_Browse_Audio_Save_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Audio_Save_Path.TabIndex = 2;
            this.Button_Browse_Audio_Save_Path.Text = "Browse";
            this.Button_Browse_Audio_Save_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_Audio_Save_Path.Click += new System.EventHandler(this.Button_Browse_Audio_Save_Path_Click);
            // 
            // SFD_Output_Audio
            // 
            this.SFD_Output_Audio.RestoreDirectory = true;
            // 
            // Label_FPS
            // 
            this.Label_FPS.AutoSize = true;
            this.Label_FPS.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_FPS.Location = new System.Drawing.Point(256, 307);
            this.Label_FPS.Name = "Label_FPS";
            this.Label_FPS.Size = new System.Drawing.Size(40, 16);
            this.Label_FPS.TabIndex = 17;
            this.Label_FPS.Text = "FPS：";
            // 
            // ComboBox_FPS
            // 
            this.ComboBox_FPS.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ComboBox_FPS.FormattingEnabled = true;
            this.ComboBox_FPS.Location = new System.Drawing.Point(297, 304);
            this.ComboBox_FPS.Name = "ComboBox_FPS";
            this.ComboBox_FPS.Size = new System.Drawing.Size(121, 24);
            this.ComboBox_FPS.TabIndex = 18;
            // 
            // OFD_Subtitles
            // 
            this.OFD_Subtitles.Multiselect = true;
            this.OFD_Subtitles.RestoreDirectory = true;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Clear.Location = new System.Drawing.Point(530, 412);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(124, 48);
            this.Button_Clear.TabIndex = 19;
            this.Button_Clear.Text = "全部重來\n";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // RButton_CRF
            // 
            this.RButton_CRF.AutoSize = true;
            this.RButton_CRF.Checked = true;
            this.RButton_CRF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RButton_CRF.Location = new System.Drawing.Point(14, 273);
            this.RButton_CRF.Name = "RButton_CRF";
            this.RButton_CRF.Size = new System.Drawing.Size(48, 20);
            this.RButton_CRF.TabIndex = 20;
            this.RButton_CRF.TabStop = true;
            this.RButton_CRF.Text = "CRF";
            this.RButton_CRF.UseVisualStyleBackColor = true;
            this.RButton_CRF.CheckedChanged += new System.EventHandler(this.RButton_CRF_CheckedChanged);
            // 
            // RButton_ABR
            // 
            this.RButton_ABR.AutoSize = true;
            this.RButton_ABR.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RButton_ABR.Location = new System.Drawing.Point(14, 295);
            this.RButton_ABR.Name = "RButton_ABR";
            this.RButton_ABR.Size = new System.Drawing.Size(49, 20);
            this.RButton_ABR.TabIndex = 20;
            this.RButton_ABR.Text = "ABR";
            this.RButton_ABR.UseVisualStyleBackColor = true;
            this.RButton_ABR.CheckedChanged += new System.EventHandler(this.RButton_ABR_CheckedChanged);
            // 
            // Numeric_Quality
            // 
            this.Numeric_Quality.DecimalPlaces = 1;
            this.Numeric_Quality.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Numeric_Quality.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Numeric_Quality.Location = new System.Drawing.Point(73, 289);
            this.Numeric_Quality.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Numeric_Quality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Numeric_Quality.Name = "Numeric_Quality";
            this.Numeric_Quality.Size = new System.Drawing.Size(120, 23);
            this.Numeric_Quality.TabIndex = 22;
            this.Numeric_Quality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Numeric_Quality.Value = new decimal(new int[] {
            210,
            0,
            0,
            65536});
            // 
            // Button_Input_User_Defined_Parameters
            // 
            this.Button_Input_User_Defined_Parameters.Enabled = false;
            this.Button_Input_User_Defined_Parameters.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Input_User_Defined_Parameters.Location = new System.Drawing.Point(173, 248);
            this.Button_Input_User_Defined_Parameters.Name = "Button_Input_User_Defined_Parameters";
            this.Button_Input_User_Defined_Parameters.Size = new System.Drawing.Size(25, 20);
            this.Button_Input_User_Defined_Parameters.TabIndex = 23;
            this.Button_Input_User_Defined_Parameters.Text = "...";
            this.Button_Input_User_Defined_Parameters.UseVisualStyleBackColor = true;
            this.Button_Input_User_Defined_Parameters.Click += new System.EventHandler(this.Button_Input_User_Defined_Parameters_Click);
            // 
            // Button_Browse_Chap_File
            // 
            this.Button_Browse_Chap_File.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_Chap_File.Location = new System.Drawing.Point(539, 207);
            this.Button_Browse_Chap_File.Name = "Button_Browse_Chap_File";
            this.Button_Browse_Chap_File.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Chap_File.TabIndex = 2;
            this.Button_Browse_Chap_File.Text = "Browse";
            this.Button_Browse_Chap_File.UseVisualStyleBackColor = true;
            this.Button_Browse_Chap_File.Click += new System.EventHandler(this.Button_Browse_Chap_File_Click);
            // 
            // Label_Chap_File
            // 
            this.Label_Chap_File.AutoSize = true;
            this.Label_Chap_File.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Chap_File.Location = new System.Drawing.Point(10, 194);
            this.Label_Chap_File.Name = "Label_Chap_File";
            this.Label_Chap_File.Size = new System.Drawing.Size(68, 16);
            this.Label_Chap_File.TabIndex = 3;
            this.Label_Chap_File.Text = "章節檔案：";
            // 
            // TextBox_Chap_File_Path
            // 
            this.TextBox_Chap_File_Path.AllowDrop = true;
            this.TextBox_Chap_File_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Chap_File_Path.Location = new System.Drawing.Point(10, 209);
            this.TextBox_Chap_File_Path.Name = "TextBox_Chap_File_Path";
            this.TextBox_Chap_File_Path.ReadOnly = true;
            this.TextBox_Chap_File_Path.Size = new System.Drawing.Size(510, 23);
            this.TextBox_Chap_File_Path.TabIndex = 4;
            this.TextBox_Chap_File_Path.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox_Chap_File_Path_DragDrop);
            this.TextBox_Chap_File_Path.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox_Chap_File_Path_DragEnter);
            // 
            // OFD_Chap_File
            // 
            this.OFD_Chap_File.Filter = "章節檔案 (*.txt)|*.txt";
            this.OFD_Chap_File.RestoreDirectory = true;
            // 
            // Button_Browse_Subtitle_Path
            // 
            this.Button_Browse_Subtitle_Path.Enabled = false;
            this.Button_Browse_Subtitle_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Browse_Subtitle_Path.Location = new System.Drawing.Point(539, 153);
            this.Button_Browse_Subtitle_Path.Name = "Button_Browse_Subtitle_Path";
            this.Button_Browse_Subtitle_Path.Size = new System.Drawing.Size(75, 23);
            this.Button_Browse_Subtitle_Path.TabIndex = 2;
            this.Button_Browse_Subtitle_Path.Text = "Browse";
            this.Button_Browse_Subtitle_Path.UseVisualStyleBackColor = true;
            this.Button_Browse_Subtitle_Path.Click += new System.EventHandler(this.Button_Browse_Subtitle_Path_Click);
            // 
            // Label_Subtitles_Path
            // 
            this.Label_Subtitles_Path.AutoSize = true;
            this.Label_Subtitles_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Subtitles_Path.Location = new System.Drawing.Point(8, 136);
            this.Label_Subtitles_Path.Name = "Label_Subtitles_Path";
            this.Label_Subtitles_Path.Size = new System.Drawing.Size(166, 16);
            this.Label_Subtitles_Path.TabIndex = 3;
            this.Label_Subtitles_Path.Text = "字幕檔案路徑 (僅MKV可用)：";
            // 
            // TextBox_Subtitle_Path
            // 
            this.TextBox_Subtitle_Path.AllowDrop = true;
            this.TextBox_Subtitle_Path.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox_Subtitle_Path.Location = new System.Drawing.Point(10, 155);
            this.TextBox_Subtitle_Path.Name = "TextBox_Subtitle_Path";
            this.TextBox_Subtitle_Path.ReadOnly = true;
            this.TextBox_Subtitle_Path.Size = new System.Drawing.Size(510, 23);
            this.TextBox_Subtitle_Path.TabIndex = 4;
            // 
            // Button_Keep_Output_File_Settings
            // 
            this.Button_Keep_Output_File_Settings.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Keep_Output_File_Settings.Location = new System.Drawing.Point(530, 304);
            this.Button_Keep_Output_File_Settings.Name = "Button_Keep_Output_File_Settings";
            this.Button_Keep_Output_File_Settings.Size = new System.Drawing.Size(121, 23);
            this.Button_Keep_Output_File_Settings.TabIndex = 25;
            this.Button_Keep_Output_File_Settings.Text = "輸出檔保留設定";
            this.Button_Keep_Output_File_Settings.UseVisualStyleBackColor = true;
            this.Button_Keep_Output_File_Settings.Click += new System.EventHandler(this.Button_Keep_Output_File_Settings_Click);
            // 
            // CheckBox_2pass_ON
            // 
            this.CheckBox_2pass_ON.AutoSize = true;
            this.CheckBox_2pass_ON.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckBox_2pass_ON.Location = new System.Drawing.Point(14, 323);
            this.CheckBox_2pass_ON.Name = "CheckBox_2pass_ON";
            this.CheckBox_2pass_ON.Size = new System.Drawing.Size(59, 20);
            this.CheckBox_2pass_ON.TabIndex = 26;
            this.CheckBox_2pass_ON.Text = "2pass";
            this.CheckBox_2pass_ON.UseVisualStyleBackColor = true;
            this.CheckBox_2pass_ON.CheckedChanged += new System.EventHandler(this.CheckBox_2pass_ON_CheckedChanged);
            // 
            // CheckBox_2pass_SameParameter
            // 
            this.CheckBox_2pass_SameParameter.AutoSize = true;
            this.CheckBox_2pass_SameParameter.Location = new System.Drawing.Point(73, 323);
            this.CheckBox_2pass_SameParameter.Name = "CheckBox_2pass_SameParameter";
            this.CheckBox_2pass_SameParameter.Size = new System.Drawing.Size(96, 16);
            this.CheckBox_2pass_SameParameter.TabIndex = 27;
            this.CheckBox_2pass_SameParameter.Text = "使用相同參數";
            this.CheckBox_2pass_SameParameter.UseVisualStyleBackColor = true;
            this.CheckBox_2pass_SameParameter.CheckedChanged += new System.EventHandler(this.CheckBox_2pass_SameParameter_CheckedChanged);
            // 
            // Button_2pass_InputParameter
            // 
            this.Button_2pass_InputParameter.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_2pass_InputParameter.Location = new System.Drawing.Point(168, 318);
            this.Button_2pass_InputParameter.Name = "Button_2pass_InputParameter";
            this.Button_2pass_InputParameter.Size = new System.Drawing.Size(25, 20);
            this.Button_2pass_InputParameter.TabIndex = 28;
            this.Button_2pass_InputParameter.Text = "...";
            this.Button_2pass_InputParameter.UseVisualStyleBackColor = true;
            this.Button_2pass_InputParameter.Click += new System.EventHandler(this.Button_2pass_InputParameter_Click);
            // 
            // BatCreator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 472);
            this.Controls.Add(this.Button_2pass_InputParameter);
            this.Controls.Add(this.CheckBox_2pass_SameParameter);
            this.Controls.Add(this.CheckBox_2pass_ON);
            this.Controls.Add(this.Button_Keep_Output_File_Settings);
            this.Controls.Add(this.Button_Input_User_Defined_Parameters);
            this.Controls.Add(this.Numeric_Quality);
            this.Controls.Add(this.RButton_ABR);
            this.Controls.Add(this.RButton_CRF);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.ComboBox_FPS);
            this.Controls.Add(this.Label_FPS);
            this.Controls.Add(this.Label_AVS_Inputer);
            this.Controls.Add(this.ComboBox_AVS_Inputer);
            this.Controls.Add(this.Label_Color_Depth);
            this.Controls.Add(this.ComboBox_Color_Depth);
            this.Controls.Add(this.Button_CreatBAT);
            this.Controls.Add(this.ComboBox_Audio_Output_Format);
            this.Controls.Add(this.Label_Audio_Output_Format);
            this.Controls.Add(this.ComboBox_Video_Output_Format);
            this.Controls.Add(this.Label_Video_Output_Format);
            this.Controls.Add(this.ComboBox_Parameter);
            this.Controls.Add(this.Label_parameter);
            this.Controls.Add(this.TextBox_Audio_Output_Path);
            this.Controls.Add(this.TextBox_Video_Output_Path);
            this.Controls.Add(this.TextBox_Chap_File_Path);
            this.Controls.Add(this.TextBox_Subtitle_Path);
            this.Controls.Add(this.TextBox_Audio_File_Path);
            this.Controls.Add(this.Label_Chap_File);
            this.Controls.Add(this.Label_Audio_Output_Path);
            this.Controls.Add(this.Label_Subtitles_Path);
            this.Controls.Add(this.Label_Video_Output_Path);
            this.Controls.Add(this.Label_Audio_File_Path);
            this.Controls.Add(this.Button_Browse_Chap_File);
            this.Controls.Add(this.Button_Browse_Audio_Save_Path);
            this.Controls.Add(this.Button_Browse_Subtitle_Path);
            this.Controls.Add(this.Button_Browse_Video_Output_Path);
            this.Controls.Add(this.Button_Browse_AVS_Audio_Path);
            this.Controls.Add(this.Button_Browse_AVS_File_Path);
            this.Controls.Add(this.TextBox_AVS_File_Path);
            this.Controls.Add(this.Label_AVS_File_Path);
            this.Controls.Add(this.MS_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BatCreator";
            this.Text = "壓制BAT產生器 - By TUcaptions (爆頭專家)";
            this.Load += new System.EventHandler(this.BatCreator_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Quality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_AVS_File_Path;
        private System.Windows.Forms.TextBox TextBox_AVS_File_Path;
        private System.Windows.Forms.Button Button_Browse_AVS_File_Path;
        private System.Windows.Forms.Label Label_Audio_File_Path;
        private System.Windows.Forms.TextBox TextBox_Audio_File_Path;
        private System.Windows.Forms.Button Button_Browse_AVS_Audio_Path;
        private System.Windows.Forms.Label Label_parameter;
        private System.Windows.Forms.ComboBox ComboBox_Parameter;
        private System.Windows.Forms.Label Label_Video_Output_Format;
        private System.Windows.Forms.ComboBox ComboBox_Video_Output_Format;
        private System.Windows.Forms.Label Label_Audio_Output_Format;
        private System.Windows.Forms.ComboBox ComboBox_Audio_Output_Format;
        private System.Windows.Forms.OpenFileDialog OFD_AVS;
        private System.Windows.Forms.OpenFileDialog OFD_Audio;
        private System.Windows.Forms.Button Button_CreatBAT;
        private System.Windows.Forms.ComboBox ComboBox_Color_Depth;
        private System.Windows.Forms.Label Label_Color_Depth;
        private System.Windows.Forms.ComboBox ComboBox_AVS_Inputer;
        private System.Windows.Forms.Label Label_AVS_Inputer;
        private System.Windows.Forms.TextBox TextBox_Video_Output_Path;
        private System.Windows.Forms.Label Label_Video_Output_Path;
        private System.Windows.Forms.Button Button_Browse_Video_Output_Path;
        private System.Windows.Forms.SaveFileDialog SFD_Output_Video;
        private System.Windows.Forms.TextBox TextBox_Audio_Output_Path;
        private System.Windows.Forms.Label Label_Audio_Output_Path;
        private System.Windows.Forms.Button Button_Browse_Audio_Save_Path;
        private System.Windows.Forms.SaveFileDialog SFD_Output_Audio;
        private System.Windows.Forms.Label Label_FPS;
        private System.Windows.Forms.ComboBox ComboBox_FPS;
        public System.Windows.Forms.OpenFileDialog OFD_Subtitles;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.RadioButton RButton_CRF;
        private System.Windows.Forms.RadioButton RButton_ABR;
        private System.Windows.Forms.NumericUpDown Numeric_Quality;
        private System.Windows.Forms.Button Button_Input_User_Defined_Parameters;
        private System.Windows.Forms.Button Button_Browse_Chap_File;
        private System.Windows.Forms.Label Label_Chap_File;
        private System.Windows.Forms.TextBox TextBox_Chap_File_Path;
        private System.Windows.Forms.OpenFileDialog OFD_Chap_File;
        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSM_tools;
        private System.Windows.Forms.ToolStripMenuItem TSM_MMG;
        private System.Windows.Forms.Button Button_Browse_Subtitle_Path;
        private System.Windows.Forms.Label Label_Subtitles_Path;
        private System.Windows.Forms.TextBox TextBox_Subtitle_Path;
        private System.Windows.Forms.Button Button_Keep_Output_File_Settings;
        private System.Windows.Forms.CheckBox CheckBox_2pass_ON;
        private System.Windows.Forms.CheckBox CheckBox_2pass_SameParameter;
        private System.Windows.Forms.Button Button_2pass_InputParameter;
        private System.Windows.Forms.ToolStripMenuItem TSM_MP4Muxer;
        private System.Windows.Forms.ToolStripMenuItem TSM_MediaInfo;
    }
}

