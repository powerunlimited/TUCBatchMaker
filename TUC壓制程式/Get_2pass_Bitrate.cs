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
    public partial class Form_Get_2pass_Bitrate : Form
    {
        BatCreator BC;
        public Form_Get_2pass_Bitrate(BatCreator BC_in)
        {
            BC = BC_in;
            InitializeComponent();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            bool OK = true;
            int bitrate = 5000;
            try { bitrate = Convert.ToInt32(Textbox_Bitrate.Text); }
            catch (FormatException) { MessageBox.Show("您輸入的數值有誤！"); OK = false; }
            catch (Exception ex) { MessageBox.Show("發生錯誤！ 錯誤訊息：" + ex.Message); OK = false; }

            if (OK)
            {
                BC.TwoPass_Bitrate = bitrate;
                this.Dispose();
            }

        }

    }
}
