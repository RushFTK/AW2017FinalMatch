namespace AWBW_LogCathcer
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.targetaddress_label = new System.Windows.Forms.Label();
            this.targetaddress_textbox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.task_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinese_language_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.english_language_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.help_topic_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taregtaddress_getbutton = new System.Windows.Forms.Button();
            this.playerA_name_label = new System.Windows.Forms.Label();
            this.playerA_alltime_hintlable = new System.Windows.Forms.Label();
            this.playerA_alltime_label = new System.Windows.Forms.Label();
            this.playerB_name_label = new System.Windows.Forms.Label();
            this.playerB_alltime_hintlable = new System.Windows.Forms.Label();
            this.playerB_alltime_label = new System.Windows.Forms.Label();
            this.alllog_getbutton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stateinfo_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.downloadprocess_progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.opendebugform_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // targetaddress_label
            // 
            this.targetaddress_label.AutoSize = true;
            this.targetaddress_label.Location = new System.Drawing.Point(12, 39);
            this.targetaddress_label.Name = "targetaddress_label";
            this.targetaddress_label.Size = new System.Drawing.Size(53, 12);
            this.targetaddress_label.TabIndex = 0;
            this.targetaddress_label.Text = "对局地址";
            // 
            // targetaddress_textbox
            // 
            this.targetaddress_textbox.Location = new System.Drawing.Point(71, 36);
            this.targetaddress_textbox.Name = "targetaddress_textbox";
            this.targetaddress_textbox.Size = new System.Drawing.Size(265, 21);
            this.targetaddress_textbox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.task_ToolStripMenuItem,
            this.help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(423, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // task_ToolStripMenuItem
            // 
            this.task_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reset_ToolStripMenuItem});
            this.task_ToolStripMenuItem.Name = "task_ToolStripMenuItem";
            this.task_ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.task_ToolStripMenuItem.Text = "任务(&T)";
            // 
            // reset_ToolStripMenuItem
            // 
            this.reset_ToolStripMenuItem.Name = "reset_ToolStripMenuItem";
            this.reset_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reset_ToolStripMenuItem.Text = "重置(&R)";
            // 
            // help_ToolStripMenuItem
            // 
            this.help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.help_topic_ToolStripMenuItem,
            this.about_ToolStripMenuItem1});
            this.help_ToolStripMenuItem.Name = "help_ToolStripMenuItem";
            this.help_ToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.help_ToolStripMenuItem.Text = "帮助(&H)";
            // 
            // about_ToolStripMenuItem
            // 
            this.about_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinese_language_ToolStripMenuItem,
            this.english_language_ToolStripMenuItem});
            this.about_ToolStripMenuItem.Name = "about_ToolStripMenuItem";
            this.about_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.about_ToolStripMenuItem.Text = "语言(&L)";
            // 
            // chinese_language_ToolStripMenuItem
            // 
            this.chinese_language_ToolStripMenuItem.Name = "chinese_language_ToolStripMenuItem";
            this.chinese_language_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chinese_language_ToolStripMenuItem.Text = "简体中文(&C)";
            // 
            // english_language_ToolStripMenuItem
            // 
            this.english_language_ToolStripMenuItem.Name = "english_language_ToolStripMenuItem";
            this.english_language_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.english_language_ToolStripMenuItem.Text = "&English";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // help_topic_ToolStripMenuItem
            // 
            this.help_topic_ToolStripMenuItem.Name = "help_topic_ToolStripMenuItem";
            this.help_topic_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.help_topic_ToolStripMenuItem.Text = "帮助主题(&M)";
            // 
            // about_ToolStripMenuItem1
            // 
            this.about_ToolStripMenuItem1.Name = "about_ToolStripMenuItem1";
            this.about_ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.about_ToolStripMenuItem1.Text = "关于(&A)";
            // 
            // taregtaddress_getbutton
            // 
            this.taregtaddress_getbutton.Location = new System.Drawing.Point(342, 34);
            this.taregtaddress_getbutton.Name = "taregtaddress_getbutton";
            this.taregtaddress_getbutton.Size = new System.Drawing.Size(75, 23);
            this.taregtaddress_getbutton.TabIndex = 3;
            this.taregtaddress_getbutton.Text = "获取";
            this.taregtaddress_getbutton.UseVisualStyleBackColor = true;
            this.taregtaddress_getbutton.Click += new System.EventHandler(this.taregtaddress_getbutton_Click);
            // 
            // playerA_name_label
            // 
            this.playerA_name_label.AutoSize = true;
            this.playerA_name_label.Location = new System.Drawing.Point(12, 71);
            this.playerA_name_label.Name = "playerA_name_label";
            this.playerA_name_label.Size = new System.Drawing.Size(53, 12);
            this.playerA_name_label.TabIndex = 4;
            this.playerA_name_label.Text = "Player_A";
            // 
            // playerA_alltime_hintlable
            // 
            this.playerA_alltime_hintlable.AutoSize = true;
            this.playerA_alltime_hintlable.Location = new System.Drawing.Point(12, 95);
            this.playerA_alltime_hintlable.Name = "playerA_alltime_hintlable";
            this.playerA_alltime_hintlable.Size = new System.Drawing.Size(101, 12);
            this.playerA_alltime_hintlable.TabIndex = 5;
            this.playerA_alltime_hintlable.Text = "回合持续总时间：";
            // 
            // playerA_alltime_label
            // 
            this.playerA_alltime_label.AutoSize = true;
            this.playerA_alltime_label.Location = new System.Drawing.Point(12, 118);
            this.playerA_alltime_label.Name = "playerA_alltime_label";
            this.playerA_alltime_label.Size = new System.Drawing.Size(119, 12);
            this.playerA_alltime_label.TabIndex = 6;
            this.playerA_alltime_label.Text = "00 d 00 h 00 m 00 s";
            // 
            // playerB_name_label
            // 
            this.playerB_name_label.AutoSize = true;
            this.playerB_name_label.Location = new System.Drawing.Point(223, 71);
            this.playerB_name_label.Name = "playerB_name_label";
            this.playerB_name_label.Size = new System.Drawing.Size(53, 12);
            this.playerB_name_label.TabIndex = 7;
            this.playerB_name_label.Text = "Player_B";
            // 
            // playerB_alltime_hintlable
            // 
            this.playerB_alltime_hintlable.AutoSize = true;
            this.playerB_alltime_hintlable.Location = new System.Drawing.Point(225, 95);
            this.playerB_alltime_hintlable.Name = "playerB_alltime_hintlable";
            this.playerB_alltime_hintlable.Size = new System.Drawing.Size(101, 12);
            this.playerB_alltime_hintlable.TabIndex = 8;
            this.playerB_alltime_hintlable.Text = "回合持续总时间：";
            // 
            // playerB_alltime_label
            // 
            this.playerB_alltime_label.AutoSize = true;
            this.playerB_alltime_label.Location = new System.Drawing.Point(225, 118);
            this.playerB_alltime_label.Name = "playerB_alltime_label";
            this.playerB_alltime_label.Size = new System.Drawing.Size(119, 12);
            this.playerB_alltime_label.TabIndex = 9;
            this.playerB_alltime_label.Text = "00 d 00 h 00 m 00 s";
            // 
            // alllog_getbutton
            // 
            this.alllog_getbutton.Location = new System.Drawing.Point(12, 206);
            this.alllog_getbutton.Name = "alllog_getbutton";
            this.alllog_getbutton.Size = new System.Drawing.Size(134, 23);
            this.alllog_getbutton.TabIndex = 10;
            this.alllog_getbutton.Text = "获取全部Log数据(&L)";
            this.alllog_getbutton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stateinfo_label,
            this.downloadprocess_progressbar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(423, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stateinfo_label
            // 
            this.stateinfo_label.Name = "stateinfo_label";
            this.stateinfo_label.Size = new System.Drawing.Size(32, 17);
            this.stateinfo_label.Text = "就绪";
            // 
            // downloadprocess_progressbar
            // 
            this.downloadprocess_progressbar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.downloadprocess_progressbar.Name = "downloadprocess_progressbar";
            this.downloadprocess_progressbar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.downloadprocess_progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // opendebugform_button
            // 
            this.opendebugform_button.Location = new System.Drawing.Point(152, 206);
            this.opendebugform_button.Name = "opendebugform_button";
            this.opendebugform_button.Size = new System.Drawing.Size(123, 23);
            this.opendebugform_button.TabIndex = 12;
            this.opendebugform_button.Text = "打开调试窗口...";
            this.opendebugform_button.UseVisualStyleBackColor = true;
            this.opendebugform_button.Visible = false;
            this.opendebugform_button.Click += new System.EventHandler(this.opendebugform_button_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 254);
            this.Controls.Add(this.opendebugform_button);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.alllog_getbutton);
            this.Controls.Add(this.playerB_alltime_label);
            this.Controls.Add(this.playerB_alltime_hintlable);
            this.Controls.Add(this.playerB_name_label);
            this.Controls.Add(this.playerA_alltime_label);
            this.Controls.Add(this.playerA_alltime_hintlable);
            this.Controls.Add(this.playerA_name_label);
            this.Controls.Add(this.taregtaddress_getbutton);
            this.Controls.Add(this.targetaddress_textbox);
            this.Controls.Add(this.targetaddress_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "AWBW_LogCatcher";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label targetaddress_label;
        private System.Windows.Forms.TextBox targetaddress_textbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem task_ToolStripMenuItem;
        private System.Windows.Forms.Button taregtaddress_getbutton;
        private System.Windows.Forms.Label playerA_name_label;
        private System.Windows.Forms.Label playerA_alltime_hintlable;
        private System.Windows.Forms.Label playerA_alltime_label;
        private System.Windows.Forms.Label playerB_name_label;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chinese_language_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem english_language_ToolStripMenuItem;
        private System.Windows.Forms.Label playerB_alltime_hintlable;
        private System.Windows.Forms.Label playerB_alltime_label;
        private System.Windows.Forms.Button alllog_getbutton;
        private System.Windows.Forms.ToolStripMenuItem reset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem help_topic_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stateinfo_label;
        private System.Windows.Forms.ToolStripProgressBar downloadprocess_progressbar;
        private System.Windows.Forms.Button opendebugform_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

