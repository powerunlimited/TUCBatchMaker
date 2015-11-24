namespace TUCEncoder
{
    partial class MP4Muxer
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
            this.TextBox_Video_Path = new System.Windows.Forms.TextBox();
            this.Label_Video_Path = new System.Windows.Forms.Label();
            this.GroupBox_Video = new System.Windows.Forms.GroupBox();
            this.Button_Browse_Video = new System.Windows.Forms.Button();
            this.ComboBox_FPS = new System.Windows.Forms.ComboBox();
            this.Label_FPS = new System.Windows.Forms.Label();
            this.GroupBox_Audio = new System.Windows.Forms.GroupBox();
            this.Label_Audio_Path = new System.Windows.Forms.Label();
            this.TextBox_Audio_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_Audio = new System.Windows.Forms.Button();
            this.ComboBox_Audio_Language = new System.Windows.Forms.ComboBox();
            this.Label_Audio_Language = new System.Windows.Forms.Label();
            this.Label_Audio_Delay = new System.Windows.Forms.Label();
            this.Numeric_Audio_Delay = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Label_Chapter_Path = new System.Windows.Forms.Label();
            this.TextBox_Chapter_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_Chapter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Label_Output_Path = new System.Windows.Forms.Label();
            this.TextBox_Output_Path = new System.Windows.Forms.TextBox();
            this.Button_Browse_Output = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.SFD_Output = new System.Windows.Forms.SaveFileDialog();
            this.GroupBox_Video.SuspendLayout();
            this.GroupBox_Audio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Audio_Delay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox_Video_Path
            // 
            this.TextBox_Video_Path.Location = new System.Drawing.Point(17, 32);
            this.TextBox_Video_Path.Name = "TextBox_Video_Path";
            this.TextBox_Video_Path.Size = new System.Drawing.Size(415, 22);
            this.TextBox_Video_Path.TabIndex = 0;
            // 
            // Label_Video_Path
            // 
            this.Label_Video_Path.AutoSize = true;
            this.Label_Video_Path.Location = new System.Drawing.Point(15, 18);
            this.Label_Video_Path.Name = "Label_Video_Path";
            this.Label_Video_Path.Size = new System.Drawing.Size(41, 12);
            this.Label_Video_Path.TabIndex = 1;
            this.Label_Video_Path.Text = "路徑：";
            // 
            // GroupBox_Video
            // 
            this.GroupBox_Video.Controls.Add(this.Label_FPS);
            this.GroupBox_Video.Controls.Add(this.ComboBox_FPS);
            this.GroupBox_Video.Controls.Add(this.Button_Browse_Video);
            this.GroupBox_Video.Controls.Add(this.TextBox_Video_Path);
            this.GroupBox_Video.Controls.Add(this.Label_Video_Path);
            this.GroupBox_Video.Location = new System.Drawing.Point(12, 12);
            this.GroupBox_Video.Name = "GroupBox_Video";
            this.GroupBox_Video.Size = new System.Drawing.Size(469, 120);
            this.GroupBox_Video.TabIndex = 2;
            this.GroupBox_Video.TabStop = false;
            this.GroupBox_Video.Text = "視訊";
            // 
            // Button_Browse_Video
            // 
            this.Button_Browse_Video.Location = new System.Drawing.Point(438, 30);
            this.Button_Browse_Video.Name = "Button_Browse_Video";
            this.Button_Browse_Video.Size = new System.Drawing.Size(25, 24);
            this.Button_Browse_Video.TabIndex = 2;
            this.Button_Browse_Video.Text = "...";
            this.Button_Browse_Video.UseVisualStyleBackColor = true;
            this.Button_Browse_Video.Click += new System.EventHandler(this.Button_Browse_Video_Click);
            // 
            // ComboBox_FPS
            // 
            this.ComboBox_FPS.FormattingEnabled = true;
            this.ComboBox_FPS.Location = new System.Drawing.Point(17, 85);
            this.ComboBox_FPS.Name = "ComboBox_FPS";
            this.ComboBox_FPS.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_FPS.TabIndex = 3;
            // 
            // Label_FPS
            // 
            this.Label_FPS.AutoSize = true;
            this.Label_FPS.Location = new System.Drawing.Point(17, 70);
            this.Label_FPS.Name = "Label_FPS";
            this.Label_FPS.Size = new System.Drawing.Size(35, 12);
            this.Label_FPS.TabIndex = 4;
            this.Label_FPS.Text = "FPS：";
            // 
            // GroupBox_Audio
            // 
            this.GroupBox_Audio.Controls.Add(this.Numeric_Audio_Delay);
            this.GroupBox_Audio.Controls.Add(this.Label_Audio_Delay);
            this.GroupBox_Audio.Controls.Add(this.Label_Audio_Language);
            this.GroupBox_Audio.Controls.Add(this.ComboBox_Audio_Language);
            this.GroupBox_Audio.Controls.Add(this.TextBox_Audio_Path);
            this.GroupBox_Audio.Controls.Add(this.Label_Audio_Path);
            this.GroupBox_Audio.Controls.Add(this.Button_Browse_Audio);
            this.GroupBox_Audio.Location = new System.Drawing.Point(12, 139);
            this.GroupBox_Audio.Name = "GroupBox_Audio";
            this.GroupBox_Audio.Size = new System.Drawing.Size(469, 128);
            this.GroupBox_Audio.TabIndex = 3;
            this.GroupBox_Audio.TabStop = false;
            this.GroupBox_Audio.Text = "音訊";
            // 
            // Label_Audio_Path
            // 
            this.Label_Audio_Path.AutoSize = true;
            this.Label_Audio_Path.Location = new System.Drawing.Point(17, 23);
            this.Label_Audio_Path.Name = "Label_Audio_Path";
            this.Label_Audio_Path.Size = new System.Drawing.Size(41, 12);
            this.Label_Audio_Path.TabIndex = 0;
            this.Label_Audio_Path.Text = "路徑：";
            // 
            // TextBox_Audio_Path
            // 
            this.TextBox_Audio_Path.Location = new System.Drawing.Point(17, 38);
            this.TextBox_Audio_Path.Name = "TextBox_Audio_Path";
            this.TextBox_Audio_Path.Size = new System.Drawing.Size(415, 22);
            this.TextBox_Audio_Path.TabIndex = 1;
            // 
            // Button_Browse_Audio
            // 
            this.Button_Browse_Audio.Location = new System.Drawing.Point(438, 38);
            this.Button_Browse_Audio.Name = "Button_Browse_Audio";
            this.Button_Browse_Audio.Size = new System.Drawing.Size(25, 22);
            this.Button_Browse_Audio.TabIndex = 2;
            this.Button_Browse_Audio.Text = "...";
            this.Button_Browse_Audio.UseVisualStyleBackColor = true;
            this.Button_Browse_Audio.Click += new System.EventHandler(this.Button_Browse_Audio_Click);
            // 
            // ComboBox_Audio_Language
            // 
            this.ComboBox_Audio_Language.FormattingEnabled = true;
            this.ComboBox_Audio_Language.Location = new System.Drawing.Point(17, 91);
            this.ComboBox_Audio_Language.Name = "ComboBox_Audio_Language";
            this.ComboBox_Audio_Language.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_Audio_Language.TabIndex = 3;
            // 
            // Label_Audio_Language
            // 
            this.Label_Audio_Language.AutoSize = true;
            this.Label_Audio_Language.Location = new System.Drawing.Point(17, 73);
            this.Label_Audio_Language.Name = "Label_Audio_Language";
            this.Label_Audio_Language.Size = new System.Drawing.Size(41, 12);
            this.Label_Audio_Language.TabIndex = 4;
            this.Label_Audio_Language.Text = "語言：";
            // 
            // Label_Audio_Delay
            // 
            this.Label_Audio_Delay.AutoSize = true;
            this.Label_Audio_Delay.Location = new System.Drawing.Point(179, 72);
            this.Label_Audio_Delay.Name = "Label_Audio_Delay";
            this.Label_Audio_Delay.Size = new System.Drawing.Size(41, 12);
            this.Label_Audio_Delay.TabIndex = 5;
            this.Label_Audio_Delay.Text = "延遲：";
            // 
            // Numeric_Audio_Delay
            // 
            this.Numeric_Audio_Delay.Location = new System.Drawing.Point(181, 88);
            this.Numeric_Audio_Delay.Name = "Numeric_Audio_Delay";
            this.Numeric_Audio_Delay.Size = new System.Drawing.Size(120, 22);
            this.Numeric_Audio_Delay.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBox_Chapter_Path);
            this.groupBox3.Controls.Add(this.Label_Chapter_Path);
            this.groupBox3.Controls.Add(this.Button_Browse_Chapter);
            this.groupBox3.Location = new System.Drawing.Point(12, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 80);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "章節";
            // 
            // Label_Chapter_Path
            // 
            this.Label_Chapter_Path.AutoSize = true;
            this.Label_Chapter_Path.Location = new System.Drawing.Point(17, 22);
            this.Label_Chapter_Path.Name = "Label_Chapter_Path";
            this.Label_Chapter_Path.Size = new System.Drawing.Size(41, 12);
            this.Label_Chapter_Path.TabIndex = 0;
            this.Label_Chapter_Path.Text = "路徑：";
            // 
            // TextBox_Chapter_Path
            // 
            this.TextBox_Chapter_Path.Location = new System.Drawing.Point(17, 38);
            this.TextBox_Chapter_Path.Name = "TextBox_Chapter_Path";
            this.TextBox_Chapter_Path.Size = new System.Drawing.Size(415, 22);
            this.TextBox_Chapter_Path.TabIndex = 1;
            // 
            // Button_Browse_Chapter
            // 
            this.Button_Browse_Chapter.Location = new System.Drawing.Point(438, 36);
            this.Button_Browse_Chapter.Name = "Button_Browse_Chapter";
            this.Button_Browse_Chapter.Size = new System.Drawing.Size(25, 24);
            this.Button_Browse_Chapter.TabIndex = 2;
            this.Button_Browse_Chapter.Text = "...";
            this.Button_Browse_Chapter.UseVisualStyleBackColor = true;
            this.Button_Browse_Chapter.Click += new System.EventHandler(this.Button_Browse_Chapter_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TextBox_Output_Path);
            this.groupBox4.Controls.Add(this.Label_Output_Path);
            this.groupBox4.Controls.Add(this.Button_Browse_Output);
            this.groupBox4.Location = new System.Drawing.Point(12, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(469, 76);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "輸出";
            // 
            // Label_Output_Path
            // 
            this.Label_Output_Path.AutoSize = true;
            this.Label_Output_Path.Location = new System.Drawing.Point(17, 22);
            this.Label_Output_Path.Name = "Label_Output_Path";
            this.Label_Output_Path.Size = new System.Drawing.Size(41, 12);
            this.Label_Output_Path.TabIndex = 0;
            this.Label_Output_Path.Text = "路徑：";
            // 
            // TextBox_Output_Path
            // 
            this.TextBox_Output_Path.Location = new System.Drawing.Point(17, 38);
            this.TextBox_Output_Path.Name = "TextBox_Output_Path";
            this.TextBox_Output_Path.Size = new System.Drawing.Size(415, 22);
            this.TextBox_Output_Path.TabIndex = 1;
            // 
            // Button_Browse_Output
            // 
            this.Button_Browse_Output.Location = new System.Drawing.Point(438, 36);
            this.Button_Browse_Output.Name = "Button_Browse_Output";
            this.Button_Browse_Output.Size = new System.Drawing.Size(25, 24);
            this.Button_Browse_Output.TabIndex = 2;
            this.Button_Browse_Output.Text = "...";
            this.Button_Browse_Output.UseVisualStyleBackColor = true;
            this.Button_Browse_Output.Click += new System.EventHandler(this.Button_Browse_Output_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Start.Location = new System.Drawing.Point(412, 443);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(69, 46);
            this.Button_Start.TabIndex = 6;
            this.Button_Start.Text = "開始";
            this.Button_Start.UseVisualStyleBackColor = true;
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_Clear.Location = new System.Drawing.Point(337, 443);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(69, 46);
            this.Button_Clear.TabIndex = 6;
            this.Button_Clear.Text = "清除";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // SFD_Output
            // 
            this.SFD_Output.DefaultExt = "mp4";
            this.SFD_Output.RestoreDirectory = true;
            this.SFD_Output.SupportMultiDottedExtensions = true;
            // 
            // MP4Muxer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 497);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox_Audio);
            this.Controls.Add(this.GroupBox_Video);
            this.Name = "MP4Muxer";
            this.Text = "MP4封裝器";
            this.GroupBox_Video.ResumeLayout(false);
            this.GroupBox_Video.PerformLayout();
            this.GroupBox_Audio.ResumeLayout(false);
            this.GroupBox_Audio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric_Audio_Delay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Video_Path;
        private System.Windows.Forms.Label Label_Video_Path;
        private System.Windows.Forms.GroupBox GroupBox_Video;
        private System.Windows.Forms.Label Label_FPS;
        private System.Windows.Forms.ComboBox ComboBox_FPS;
        private System.Windows.Forms.Button Button_Browse_Video;
        private System.Windows.Forms.GroupBox GroupBox_Audio;
        private System.Windows.Forms.NumericUpDown Numeric_Audio_Delay;
        private System.Windows.Forms.Label Label_Audio_Delay;
        private System.Windows.Forms.Label Label_Audio_Language;
        private System.Windows.Forms.ComboBox ComboBox_Audio_Language;
        private System.Windows.Forms.TextBox TextBox_Audio_Path;
        private System.Windows.Forms.Label Label_Audio_Path;
        private System.Windows.Forms.Button Button_Browse_Audio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBox_Chapter_Path;
        private System.Windows.Forms.Label Label_Chapter_Path;
        private System.Windows.Forms.Button Button_Browse_Chapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TextBox_Output_Path;
        private System.Windows.Forms.Label Label_Output_Path;
        private System.Windows.Forms.Button Button_Browse_Output;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.SaveFileDialog SFD_Output;
    }
}