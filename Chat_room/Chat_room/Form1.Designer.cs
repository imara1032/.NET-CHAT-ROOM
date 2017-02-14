namespace Chat_room
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ip1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listMessages = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.port1 = new System.Windows.Forms.Label();
            this.port2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.port1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.Ip1);
            this.groupBox1.Location = new System.Drawing.Point(21, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ip2);
            this.groupBox2.Controls.Add(this.port2);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Location = new System.Drawing.Point(244, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client 2";
            // 
            // Ip1
            // 
            this.Ip1.Location = new System.Drawing.Point(99, 19);
            this.Ip1.Name = "Ip1";
            this.Ip1.Size = new System.Drawing.Size(100, 20);
            this.Ip1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(21, 277);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(236, 20);
            this.message.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(86, 45);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 19);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // listMessages
            // 
            this.listMessages.FormattingEnabled = true;
            this.listMessages.Location = new System.Drawing.Point(21, 164);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(434, 95);
            this.listMessages.TabIndex = 3;
            this.listMessages.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(478, 96);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(282, 274);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // port1
            // 
            this.port1.AutoSize = true;
            this.port1.Location = new System.Drawing.Point(17, 48);
            this.port1.Name = "port1";
            this.port1.Size = new System.Drawing.Size(37, 13);
            this.port1.TabIndex = 2;
            this.port1.Text = "PORT";
            // 
            // port2
            // 
            this.port2.AutoSize = true;
            this.port2.Location = new System.Drawing.Point(15, 48);
            this.port2.Name = "port2";
            this.port2.Size = new System.Drawing.Size(37, 13);
            this.port2.TabIndex = 6;
            this.port2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "IP";
            // 
            // ip2
            // 
            this.ip2.AutoSize = true;
            this.ip2.Location = new System.Drawing.Point(15, 22);
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(17, 13);
            this.ip2.TabIndex = 6;
            this.ip2.Text = "IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 359);
            this.Controls.Add(this.send);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listMessages);
            this.Controls.Add(this.message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Chat Room";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label port1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Ip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ip2;
        private System.Windows.Forms.Label port2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button send;
    }
}

