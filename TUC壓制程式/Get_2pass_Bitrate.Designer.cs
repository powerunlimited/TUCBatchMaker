namespace TUCEncoder
{
    partial class Form_Get_2pass_Bitrate
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
            this.Label_Message = new System.Windows.Forms.Label();
            this.Label_Bitrate = new System.Windows.Forms.Label();
            this.Textbox_Bitrate = new System.Windows.Forms.TextBox();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Message
            // 
            this.Label_Message.AutoSize = true;
            this.Label_Message.Location = new System.Drawing.Point(13, 13);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(410, 12);
            this.Label_Message.TabIndex = 0;
            this.Label_Message.Text = "2pass壓制時  第二個pass無法使用crf模式進行壓制  請輸入您要使用的位元率：";
            // 
            // Label_Bitrate
            // 
            this.Label_Bitrate.AutoSize = true;
            this.Label_Bitrate.Font = new System.Drawing.Font("新細明體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Bitrate.Location = new System.Drawing.Point(12, 56);
            this.Label_Bitrate.Name = "Label_Bitrate";
            this.Label_Bitrate.Size = new System.Drawing.Size(53, 15);
            this.Label_Bitrate.TabIndex = 1;
            this.Label_Bitrate.Text = "--bitrate";
            // 
            // Textbox_Bitrate
            // 
            this.Textbox_Bitrate.Location = new System.Drawing.Point(64, 53);
            this.Textbox_Bitrate.Name = "Textbox_Bitrate";
            this.Textbox_Bitrate.Size = new System.Drawing.Size(363, 22);
            this.Textbox_Bitrate.TabIndex = 2;
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(347, 90);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 23);
            this.Button_OK.TabIndex = 3;
            this.Button_OK.Text = "確定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Form_Get_2pass_Bitrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 125);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.Textbox_Bitrate);
            this.Controls.Add(this.Label_Bitrate);
            this.Controls.Add(this.Label_Message);
            this.Name = "Form_Get_2pass_Bitrate";
            this.Text = "請輸入位元率";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Message;
        private System.Windows.Forms.Label Label_Bitrate;
        private System.Windows.Forms.TextBox Textbox_Bitrate;
        private System.Windows.Forms.Button Button_OK;
    }
}