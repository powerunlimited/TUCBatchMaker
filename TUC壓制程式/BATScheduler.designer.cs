namespace TUCEncoder
{
    partial class BATScheduler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BATScheduler));
            this.Button_Add = new System.Windows.Forms.Button();
            this.CMS_Special_Action_Add = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSItem_Shutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.CMSItem_Sleep = new System.Windows.Forms.ToolStripMenuItem();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.LV_Queues = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMS_LV_RightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMSItem_Remove_SelectItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_UP = new System.Windows.Forms.Button();
            this.Button_Down = new System.Windows.Forms.Button();
            this.CMS_Special_Action_Add.SuspendLayout();
            this.CMS_LV_RightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_Add
            // 
            this.Button_Add.ContextMenuStrip = this.CMS_Special_Action_Add;
            this.Button_Add.Location = new System.Drawing.Point(12, 10);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(75, 23);
            this.Button_Add.TabIndex = 12;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // CMS_Special_Action_Add
            // 
            this.CMS_Special_Action_Add.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSItem_Shutdown,
            this.CMSItem_Sleep});
            this.CMS_Special_Action_Add.Name = "CMS_Special_Action_Add";
            this.CMS_Special_Action_Add.Size = new System.Drawing.Size(99, 48);
            this.CMS_Special_Action_Add.Text = "增加特殊指令";
            // 
            // CMSItem_Shutdown
            // 
            this.CMSItem_Shutdown.Name = "CMSItem_Shutdown";
            this.CMSItem_Shutdown.Size = new System.Drawing.Size(98, 22);
            this.CMSItem_Shutdown.Text = "關機";
            this.CMSItem_Shutdown.Click += new System.EventHandler(this.CMSItem_Shutdown_Click);
            // 
            // CMSItem_Sleep
            // 
            this.CMSItem_Sleep.Name = "CMSItem_Sleep";
            this.CMSItem_Sleep.Size = new System.Drawing.Size(98, 22);
            this.CMSItem_Sleep.Text = "睡眠";
            this.CMSItem_Sleep.Click += new System.EventHandler(this.CMSItem_Sleep_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Location = new System.Drawing.Point(93, 10);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(75, 23);
            this.Button_Remove.TabIndex = 13;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(606, 10);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 14;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(336, 10);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 23);
            this.Button_Clear.TabIndex = 15;
            this.Button_Clear.Text = "Clear";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // LV_Queues
            // 
            this.LV_Queues.AllowDrop = true;
            this.LV_Queues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LV_Queues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.LV_Queues.ContextMenuStrip = this.CMS_LV_RightClickMenu;
            this.LV_Queues.FullRowSelect = true;
            this.LV_Queues.Location = new System.Drawing.Point(12, 39);
            this.LV_Queues.Name = "LV_Queues";
            this.LV_Queues.Size = new System.Drawing.Size(669, 183);
            this.LV_Queues.TabIndex = 21;
            this.LV_Queues.UseCompatibleStateImageBehavior = false;
            this.LV_Queues.View = System.Windows.Forms.View.Details;
            this.LV_Queues.DragDrop += new System.Windows.Forms.DragEventHandler(this.LV_Queues_DragDrop);
            this.LV_Queues.DragEnter += new System.Windows.Forms.DragEventHandler(this.LV_Queues_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "狀態";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bat";
            this.columnHeader2.Width = 594;
            // 
            // CMS_LV_RightClickMenu
            // 
            this.CMS_LV_RightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CMSItem_Remove_SelectItem});
            this.CMS_LV_RightClickMenu.Name = "CMS_LV_RightClickMenu";
            this.CMS_LV_RightClickMenu.Size = new System.Drawing.Size(122, 26);
            // 
            // CMSItem_Remove_SelectItem
            // 
            this.CMSItem_Remove_SelectItem.Name = "CMSItem_Remove_SelectItem";
            this.CMSItem_Remove_SelectItem.Size = new System.Drawing.Size(121, 22);
            this.CMSItem_Remove_SelectItem.Text = "Remove";
            this.CMSItem_Remove_SelectItem.Click += new System.EventHandler(this.CMSItem_Remove_SelectItem_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(525, 10);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 23);
            this.Button_Stop.TabIndex = 22;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_UP
            // 
            this.Button_UP.Location = new System.Drawing.Point(174, 10);
            this.Button_UP.Name = "Button_UP";
            this.Button_UP.Size = new System.Drawing.Size(75, 23);
            this.Button_UP.TabIndex = 23;
            this.Button_UP.Text = "UP";
            this.Button_UP.UseVisualStyleBackColor = true;
            this.Button_UP.Click += new System.EventHandler(this.Button_UP_Click);
            // 
            // Button_Down
            // 
            this.Button_Down.Location = new System.Drawing.Point(255, 10);
            this.Button_Down.Name = "Button_Down";
            this.Button_Down.Size = new System.Drawing.Size(75, 23);
            this.Button_Down.TabIndex = 23;
            this.Button_Down.Text = "Down";
            this.Button_Down.UseVisualStyleBackColor = true;
            this.Button_Down.Click += new System.EventHandler(this.Button_Down_Click);
            // 
            // BATScheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 234);
            this.Controls.Add(this.Button_Down);
            this.Controls.Add(this.Button_UP);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.LV_Queues);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BATScheduler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BAT排程器 - By TUCaptions (sfan & 爆頭專家)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BATScheduler_FormClosing);
            this.CMS_Special_Action_Add.ResumeLayout(false);
            this.CMS_LV_RightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.ListView LV_Queues;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ContextMenuStrip CMS_Special_Action_Add;
        private System.Windows.Forms.ToolStripMenuItem CMSItem_Shutdown;
        private System.Windows.Forms.ContextMenuStrip CMS_LV_RightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem CMSItem_Remove_SelectItem;
        private System.Windows.Forms.ToolStripMenuItem CMSItem_Sleep;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_UP;
        private System.Windows.Forms.Button Button_Down;

    }
}

