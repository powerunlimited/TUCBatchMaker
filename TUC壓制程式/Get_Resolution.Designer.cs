namespace TUCEncoder
{
    partial class Form_Get_Resolution
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
            this.Label_Please_Input_Resolution = new System.Windows.Forms.Label();
            this.Combobox_Resolutions = new System.Windows.Forms.ComboBox();
            this.TextBox_User_Define_Resolution_X = new System.Windows.Forms.TextBox();
            this.Label_Cross = new System.Windows.Forms.Label();
            this.TextBox_User_Define_Resolution_Y = new System.Windows.Forms.TextBox();
            this.Label_User_Define = new System.Windows.Forms.Label();
            this.Button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Please_Input_Resolution
            // 
            this.Label_Please_Input_Resolution.AutoSize = true;
            this.Label_Please_Input_Resolution.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Please_Input_Resolution.Location = new System.Drawing.Point(13, 13);
            this.Label_Please_Input_Resolution.Name = "Label_Please_Input_Resolution";
            this.Label_Please_Input_Resolution.Size = new System.Drawing.Size(121, 20);
            this.Label_Please_Input_Resolution.TabIndex = 0;
            this.Label_Please_Input_Resolution.Text = "請輸入解析度：";
            // 
            // Combobox_Resolutions
            // 
            this.Combobox_Resolutions.FormattingEnabled = true;
            this.Combobox_Resolutions.Location = new System.Drawing.Point(140, 16);
            this.Combobox_Resolutions.Name = "Combobox_Resolutions";
            this.Combobox_Resolutions.Size = new System.Drawing.Size(154, 20);
            this.Combobox_Resolutions.TabIndex = 1;
            this.Combobox_Resolutions.SelectedIndexChanged += new System.EventHandler(this.Combobox_Resolutions_SelectedIndexChanged);
            // 
            // TextBox_User_Define_Resolution_X
            // 
            this.TextBox_User_Define_Resolution_X.Location = new System.Drawing.Point(76, 65);
            this.TextBox_User_Define_Resolution_X.Name = "TextBox_User_Define_Resolution_X";
            this.TextBox_User_Define_Resolution_X.Size = new System.Drawing.Size(100, 22);
            this.TextBox_User_Define_Resolution_X.TabIndex = 2;
            // 
            // Label_Cross
            // 
            this.Label_Cross.AutoSize = true;
            this.Label_Cross.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Cross.Location = new System.Drawing.Point(182, 65);
            this.Label_Cross.Name = "Label_Cross";
            this.Label_Cross.Size = new System.Drawing.Size(19, 20);
            this.Label_Cross.TabIndex = 0;
            this.Label_Cross.Text = "X";
            // 
            // TextBox_User_Define_Resolution_Y
            // 
            this.TextBox_User_Define_Resolution_Y.Location = new System.Drawing.Point(207, 65);
            this.TextBox_User_Define_Resolution_Y.Name = "TextBox_User_Define_Resolution_Y";
            this.TextBox_User_Define_Resolution_Y.Size = new System.Drawing.Size(100, 22);
            this.TextBox_User_Define_Resolution_Y.TabIndex = 3;
            // 
            // Label_User_Define
            // 
            this.Label_User_Define.AutoSize = true;
            this.Label_User_Define.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_User_Define.Location = new System.Drawing.Point(13, 66);
            this.Label_User_Define.Name = "Label_User_Define";
            this.Label_User_Define.Size = new System.Drawing.Size(57, 20);
            this.Label_User_Define.TabIndex = 0;
            this.Label_User_Define.Text = "自訂：";
            // 
            // Button_OK
            // 
            this.Button_OK.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Button_OK.Location = new System.Drawing.Point(352, 46);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 53);
            this.Button_OK.TabIndex = 4;
            this.Button_OK.Text = "確定";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Form_Get_Resolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 110);
            this.Controls.Add(this.Button_OK);
            this.Controls.Add(this.TextBox_User_Define_Resolution_Y);
            this.Controls.Add(this.TextBox_User_Define_Resolution_X);
            this.Controls.Add(this.Combobox_Resolutions);
            this.Controls.Add(this.Label_Cross);
            this.Controls.Add(this.Label_User_Define);
            this.Controls.Add(this.Label_Please_Input_Resolution);
            this.MaximizeBox = false;
            this.Name = "Form_Get_Resolution";
            this.Text = "10bit壓制程式不會自己判斷解析度Orz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Please_Input_Resolution;
        private System.Windows.Forms.ComboBox Combobox_Resolutions;
        private System.Windows.Forms.TextBox TextBox_User_Define_Resolution_X;
        private System.Windows.Forms.Label Label_Cross;
        private System.Windows.Forms.TextBox TextBox_User_Define_Resolution_Y;
        private System.Windows.Forms.Label Label_User_Define;
        private System.Windows.Forms.Button Button_OK;
    }
}