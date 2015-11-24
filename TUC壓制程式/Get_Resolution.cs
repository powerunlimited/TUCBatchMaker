using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TUCEncoder
{
    public partial class Form_Get_Resolution : Form
    {
        int Res_X, Res_Y , Clicked_Times;
        BatCreator BC = new BatCreator();
        public Form_Get_Resolution(BatCreator BC_in)
        {
            Clicked_Times = 0;
            InitializeComponent();
            BC = BC_in;
            Res_X = Res_Y = 0;
            Combobox_Resolutions.Items.Add("1920x1080");
            Combobox_Resolutions.Items.Add("1280x720");
            Combobox_Resolutions.Items.Add("848x480");
            Combobox_Resolutions.Items.Add("自定義");
            TextBox_User_Define_Resolution_X.Enabled = false;
            TextBox_User_Define_Resolution_Y.Enabled = false;
            Combobox_Resolutions.SelectedIndex = 0;
        }

        int Convert_Resolution(string input)
        {
            int output;
            bool success = int.TryParse(input,out output);
            return success ? output : -1;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
            switch (Combobox_Resolutions.SelectedIndex)
            {
                case 0: Res_X = 1920; Res_Y = 1080; break;
                case 1: Res_X = 1280; Res_Y = 720; break;
                case 2: Res_X = 848; Res_Y = 480; break;
                case 3: Res_X = Convert_Resolution(TextBox_User_Define_Resolution_X.Text); Res_Y = Convert_Resolution(TextBox_User_Define_Resolution_Y.Text); break;
            }
            if (Res_X == -1 || Res_Y == -1)
                MessageBox.Show("解析度有誤 (；ﾟωﾟ)?");
                
            if (Res_X > 0 && Res_Y > 0)
            {
                BC.Res_X = Res_X;
                BC.Res_Y = Res_Y;
                Button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            Clicked_Times++;
            if (Clicked_Times == 1)
                //MessageBox.Show("ヽ（。∀°）ノ這個按鈕有BUG 請再點一下" + Environment.NewLine + "(；ﾟωﾟ)つ(月工程濕正在邊吃維力炸醬麵邊思考如何解決這個BUG");
                Button_OK.PerformClick();
        }

        private void Combobox_Resolutions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combobox_Resolutions.SelectedIndex == 3)
            {
                TextBox_User_Define_Resolution_X.Enabled = true;
                TextBox_User_Define_Resolution_Y.Enabled = true;
            }
            else
            {
                TextBox_User_Define_Resolution_X.Enabled = false;
                TextBox_User_Define_Resolution_Y.Enabled = false;
            }
        }
    }
}
