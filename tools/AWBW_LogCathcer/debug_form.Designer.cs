namespace AWBW_LogCathcer
{
    partial class debug_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_hide
            // 
            this.button_hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_hide.Location = new System.Drawing.Point(13, 13);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(91, 23);
            this.button_hide.TabIndex = 0;
            this.button_hide.Text = "隐藏窗口(&H)";
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "show things here";
            // 
            // debug_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_hide;
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_hide);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "debug_form";
            this.Opacity = 0.75D;
            this.Text = "debug_form";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Label label1;
    }
}