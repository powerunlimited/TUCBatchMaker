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
    public partial class Form_Input_User_Defined_Parameters : Form
    {
        public BatCreator BC = new BatCreator();
        int click , option; // option = 1 -> 1pass ; 2 -> 2pass

        public Form_Input_User_Defined_Parameters(BatCreator BC_in , int option_in)
        {
            InitializeComponent();
            option = option_in;
            BC = BC_in;
            click = 0;
            if (option == 1) TextBox_Parameters.Text = BC.Parameters[0].ToString();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (TextBox_Parameters.Text != "" && option == 1)
            {   
                BC.Parameters[0] = TextBox_Parameters.Text;
                Button_OK.DialogResult = DialogResult.OK;
                click++;
                if (click == 1)
                    Button_OK.PerformClick();
            }

            else if (TextBox_Parameters.Text != "" && option == 2)
            {
                BC.TwoPassParameter = TextBox_Parameters.Text;
                Button_OK.DialogResult = DialogResult.OK;
                click++;
                if (click == 1)
                    Button_OK.PerformClick();
            }

            else
                MessageBox.Show("尚未輸入自訂參數！");
        }
    }
}
