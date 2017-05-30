namespace p4_jwm8483_server
{
    partial class Form1
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
            this.ServerStart = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListenerThread = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ServerStart
            // 
            this.ServerStart.Location = new System.Drawing.Point(100, 203);
            this.ServerStart.Name = "ServerStart";
            this.ServerStart.Size = new System.Drawing.Size(75, 23);
            this.ServerStart.TabIndex = 0;
            this.ServerStart.Text = "Start Server";
            this.ServerStart.UseVisualStyleBackColor = true;
            this.ServerStart.Click += new System.EventHandler(this.ServerStart_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 159);
            this.textBox1.TabIndex = 1;
            // 
            // ListenerThread
            // 
            this.ListenerThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ListenerThread_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ServerStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ServerStart;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker ListenerThread;
    }
}

