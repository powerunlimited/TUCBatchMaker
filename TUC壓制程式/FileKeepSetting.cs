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
    public partial class Form_Keep_Output_File_Settings : Form
    {
        BatCreator BC = new BatCreator();
        public Form_Keep_Output_File_Settings(BatCreator BC_in)
        {
            InitializeComponent();
            BC = BC_in;
            CheckBox_Keep_Audio.Checked = BC.Keep_Audio;
            CheckBox_Keep_Video.Checked = BC.Keep_Video;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            BC.Keep_Video = CheckBox_Keep_Video.Checked;
            BC.Keep_Audio = CheckBox_Keep_Audio.Checked;
        }
    }
}
