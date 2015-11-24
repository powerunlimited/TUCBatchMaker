using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace TUCEncoder
{
    public partial class BATScheduler : Form
    {
        System.ComponentModel.BackgroundWorker Worker = null;
        string ProcessingBATName = String.Empty, ProcessingBATStatus = String.Empty;
        delegate void Get_FileName_From_ListView_CallBack(int index);
        Process p = null;
        bool StopProcess = false;

        public BATScheduler()
        {
            InitializeComponent();
            OFD.FileName = "";
            button_ChangeStatus();
            BAT_Check();
        }

        private void InitWorker()
        {
            Worker = new BackgroundWorker();
            Worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            Worker.ProgressChanged += new ProgressChangedEventHandler(Worker_ProgressChanged);
            Worker.WorkerSupportsCancellation = true;
        }

        private void button_ChangeStatus()
        {
            if (LV_Queues.Items.Count == 0)
            {
                Button_Remove.Enabled = false;
                Button_Run.Enabled = false;
                Button_Clear.Enabled = false;
                Button_Down.Enabled = false;
                Button_UP.Enabled = false;
                Button_Stop.Enabled = false;
            }
            else
            {
                Button_Remove.Enabled = true;
                Button_UP.Enabled = true;
                Button_Down.Enabled = true;
                Button_Clear.Enabled = true;

                bool Finished = true;
                foreach (ListViewItem item in LV_Queues.Items)
                {
                    if (!item.Text.Equals("Finish"))
                    {
                        Finished = false;
                        break;
                    }
                }
                if (Finished)
                {
                    Button_Run.Enabled = false;
                    Button_Stop.Enabled = false;
                }

                bool Running = false;
                foreach (ListViewItem LVI in LV_Queues.Items)
                {
                    if (LVI.Text.Equals("Running"))
                    {
                        Running = true;
                    }
                }
                if (!Running)
                    Button_Run.Enabled = true;
            }
        }

        private void Create_BAT(string command , string filename)
        {
            try
            {
                StreamWriter SW = new StreamWriter("BATs\\"+filename);
                SW.WriteLine(command);
                SW.Close();
                SW.Dispose();
                GC.Collect();
            }
            catch (Exception E) { MessageBox.Show (filename + "寫入失敗！" + Environment.NewLine + "錯誤訊息：" + E.Message); }
        }

        private void BAT_Check()
        {
            if (!File.Exists ("BATs\\shutdown.bat"))
                Create_BAT ("shutdown -f -s -t 0" , "shutdown.bat");
            if (!File.Exists ("BATs\\sleep.bat"))
                Create_BAT("%windir%\\System32\\rundll32.exe powrprof.dll,SetSuspendState", "sleep.bat");
        }

        private string Replace_Special_Action_Command (string command)
        {
            if (command == "關機")
                return Environment.CurrentDirectory + "\\BATs\\shutdown.bat";
            else if (command == "睡眠")
                return Environment.CurrentDirectory + "\\BATs\\sleep.bat";
            return command;
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            OFD.Multiselect = true;
            OFD.Filter = "BAT批次檔|*.bat|所有檔案|*.*";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in OFD.FileNames)
                {
                    ListViewItem item = new ListViewItem("Queue");
                    item.SubItems.Add(filename);
                    LV_Queues.Items.Add(item);
                }
            }

            button_ChangeStatus();
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in LV_Queues.Items)
                if (item.Selected)
                    item.Remove();

            button_ChangeStatus();
        }

        private void Button_Run_Click(object sender, EventArgs e)
        {
            Button_Stop.Enabled = true; StopProcess = false; Button_Run.Enabled = false;
            InitWorker();
            Worker.RunWorkerAsync(LV_Queues.Items);
            button_ChangeStatus();
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in LV_Queues.Items)
                LVI.Remove();
            button_ChangeStatus();
        }

        private void BATScheduler_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; 
        }

        private void CMSItem_Shutdown_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Queue");
            item.SubItems.Add(Environment.CurrentDirectory + "\\BATs\\shutdown.bat");
            LV_Queues.Items.Add(item);
            button_ChangeStatus();
        }

        private void CMSItem_Remove_SelectItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem LVI in LV_Queues.Items)
            {
                if (LVI.Selected)
                    LVI.Remove();
            }
        }

        private void CMSItem_Sleep_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem("Queue");
            item.SubItems.Add(Environment.CurrentDirectory + "\\BATs\\sleep.bat");
            LV_Queues.Items.Add(item);
            button_ChangeStatus();
        }

        private void LV_Queues_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void LV_Queues_DragDrop(object sender, DragEventArgs e)
        {
            string[] DragDropFiles = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string File in DragDropFiles)
            {
                if (File.IndexOf(".bat") != -1)
                {
                    ListViewItem item = new ListViewItem("Queue");
                    item.SubItems.Add(File);
                    LV_Queues.Items.Add(item);
                    button_ChangeStatus();
                }
            }

        }
        private void RunProcess(string FileName)
        {
            p = new Process();
            p.StartInfo.FileName = FileName;
            p.Start();
            try { p.WaitForExit(); }
            catch (InvalidOperationException) { }
        }
        private void Get_FileName_From_ListView(int index)
        {
            string FileName = String.Empty;
            if (this.LV_Queues.InvokeRequired)
            {
                Get_FileName_From_ListView_CallBack G = Get_FileName_From_ListView;
                this.Invoke(G , new object[] {index});
            }
            else
            {
                ProcessingBATName = LV_Queues.Items[(int)index].SubItems[1].Text;
                ProcessingBATStatus = LV_Queues.Items[(int)index].Text;
            }
        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker BW = sender as BackgroundWorker;
            BW.WorkerReportsProgress = true;
            ListView.ListViewItemCollection Queues = e.Argument as ListView.ListViewItemCollection;

            int i = 0;
            while (i < Queues.Count)
            {
                Get_FileName_From_ListView(i);
                if (!StopProcess)
                {
                    if (ProcessingBATStatus == "Queue")
                    {
                        BW.ReportProgress(i); //Queue -> Running
                        RunProcess(ProcessingBATName);
                    }
                    BW.ReportProgress(i); //Running -> Finished
                    i++;
                }
            }
        }
        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (this.LV_Queues.Items[e.ProgressPercentage].Text == "Queue")
            {
                this.LV_Queues.Items[e.ProgressPercentage].ForeColor = System.Drawing.Color.White;
                this.LV_Queues.Items[e.ProgressPercentage].BackColor = System.Drawing.Color.DarkOrange;
                this.LV_Queues.Items[e.ProgressPercentage].Text = "Running";
            }
            else if (this.LV_Queues.Items[e.ProgressPercentage].Text == "Running")
            {
                this.LV_Queues.Items[e.ProgressPercentage].ForeColor = System.Drawing.Color.White;
                this.LV_Queues.Items[e.ProgressPercentage].BackColor = System.Drawing.Color.DarkGreen;
                this.LV_Queues.Items[e.ProgressPercentage].Text = "Finished";
            }
            button_ChangeStatus();
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            StopProcess = true; Button_Stop.Enabled = false;
            if (p != null) { try { p.Kill(); p.Dispose(); } catch (InvalidOperationException) { } }
            if(Worker != null) Worker.Dispose();           
        }

        private void SwapListViewItem(int index1, int index2)
        {
            ListViewItem temp = LV_Queues.Items[index1];
            LV_Queues.Items.Remove(temp);
            LV_Queues.Items.Insert(index2, temp);
        }

        private void Button_UP_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < LV_Queues.SelectedItems.Count; i++)
            {
                if (LV_Queues.SelectedItems[i].Index == 0) continue;
                int ProcessingIndex = LV_Queues.SelectedItems[i].Index;
                SwapListViewItem(ProcessingIndex, ProcessingIndex - 1);
                LV_Queues.Items[ProcessingIndex - 1].Selected = true;
                LV_Queues.Items[ProcessingIndex].Selected = false;
                LV_Queues.Refresh();
                LV_Queues.Focus();
            }
        }

        private void Button_Down_Click(object sender, EventArgs e)
        {
            for (int i = LV_Queues.SelectedItems.Count-1; i >= 0; i--)
            {
                if (LV_Queues.SelectedItems[i].Index == LV_Queues.Items.Count-1) continue;
                int ProcessingIndex = LV_Queues.SelectedItems[i].Index;
                SwapListViewItem(ProcessingIndex, ProcessingIndex + 1);
                LV_Queues.Items[ProcessingIndex + 1].Selected = true;
                LV_Queues.Items[ProcessingIndex].Selected = false;
                LV_Queues.Refresh();
                LV_Queues.Focus();
            }
        }
    }
}
