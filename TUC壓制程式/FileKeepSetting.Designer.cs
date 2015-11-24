namespace TUCEncoder
{
    partial class Form_Keep_Output_File_Settings
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
            this.Button_OK = new System.Windows.Forms.Button();
            this.CheckBox_Keep_Video = new System.Windows.Forms.CheckBox();
            this.CheckBox_Keep_Audio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_OK.Location = new System.Drawing.Point(205, 81);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 0;
            this.Button_OK.Text = "確定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // CheckBox_Keep_Video
            // 
            this.CheckBox_Keep_Video.AutoSize = true;
            this.CheckBox_Keep_Video.Location = new System.Drawing.Point(13, 13);
            this.CheckBox_Keep_Video.Name = "CheckBox_Keep_Video";
            this.CheckBox_Keep_Video.Size = new System.Drawing.Size(143, 16);
            this.CheckBox_Keep_Video.TabIndex = 1;
            this.CheckBox_Keep_Video.Text = "保留純影片檔 (無音訊)";
            this.CheckBox_Keep_Video.UseVisualStyleBackColor = true;
            // 
            // CheckBox_Keep_Audio
            // 
            this.CheckBox_Keep_Audio.AutoSize = true;
            this.CheckBox_Keep_Audio.Location = new System.Drawing.Point(13, 36);
            this.CheckBox_Keep_Audio.Name = "CheckBox_Keep_Audio";
            this.CheckBox_Keep_Audio.Size = new System.Drawing.Size(84, 16);
            this.CheckBox_Keep_Audio.TabIndex = 2;
            this.CheckBox_Keep_Audio.Text = "保留音訊檔";
            this.CheckBox_Keep_Audio.UseVisualStyleBackColor = true;
            // 
            // Form_Keep_Output_File_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 116);
            this.Controls.Add(this.CheckBox_Keep_Audio);
            this.Controls.Add(this.CheckBox_Keep_Video);
            this.Controls.Add(this.Button_OK);
            this.Name = "Form_Keep_Output_File_Settings";
            this.Text = "輸出檔保留設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.CheckBox CheckBox_Keep_Video;
        private System.Windows.Forms.CheckBox CheckBox_Keep_Audio;
    }
}