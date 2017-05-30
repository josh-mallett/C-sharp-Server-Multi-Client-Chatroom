namespace p4_jwm8483_client
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
            this.StartClient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.TextBox();
            this.recieveMessages = new System.ComponentModel.BackgroundWorker();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.portBox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartClient
            // 
            this.StartClient.Location = new System.Drawing.Point(274, 383);
            this.StartClient.Name = "StartClient";
            this.StartClient.Size = new System.Drawing.Size(75, 23);
            this.StartClient.TabIndex = 0;
            this.StartClient.Text = "Start Client";
            this.StartClient.UseVisualStyleBackColor = true;
            this.StartClient.Click += new System.EventHandler(this.StartClient_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(337, 219);
            this.textBox1.TabIndex = 1;
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(274, 277);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 2;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(13, 251);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(336, 20);
            this.message.TabIndex = 3;
            // 
            // recieveMessages
            // 
            this.recieveMessages.DoWork += new System.ComponentModel.DoWorkEventHandler(this.recieveMessages_DoWork);
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(13, 308);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(100, 20);
            this.IPBox.TabIndex = 4;
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(13, 347);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(100, 20);
            this.portBox.TabIndex = 5;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(13, 386);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP (127.0.0.1) ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port (51111)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.message);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StartClient);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartClient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox message;
        private System.ComponentModel.BackgroundWorker recieveMessages;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

