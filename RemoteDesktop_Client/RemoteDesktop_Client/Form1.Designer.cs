namespace RemoteDesktop_Client
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.theImage = new System.Windows.Forms.PictureBox();
            this.GroupConnect = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdConnect = new System.Windows.Forms.Button();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.TxtIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).BeginInit();
            this.GroupConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // theImage
            // 
            this.theImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theImage.BackgroundImage")));
            this.theImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.theImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theImage.Location = new System.Drawing.Point(0, 0);
            this.theImage.Margin = new System.Windows.Forms.Padding(0);
            this.theImage.Name = "theImage";
            this.theImage.Size = new System.Drawing.Size(1106, 492);
            this.theImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.theImage.TabIndex = 55;
            this.theImage.TabStop = false;
            this.theImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseClick);
            this.theImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseDown);
            this.theImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseMove);
            this.theImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.theImage_MouseUp);
            // 
            // GroupConnect
            // 
            this.GroupConnect.BackColor = System.Drawing.Color.Transparent;
            this.GroupConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GroupConnect.Controls.Add(this.txtPassword);
            this.GroupConnect.Controls.Add(this.label3);
            this.GroupConnect.Controls.Add(this.CmdConnect);
            this.GroupConnect.Controls.Add(this.TxtPort);
            this.GroupConnect.Controls.Add(this.TxtIPAddress);
            this.GroupConnect.Controls.Add(this.label2);
            this.GroupConnect.Controls.Add(this.label1);
            this.GroupConnect.Location = new System.Drawing.Point(364, 130);
            this.GroupConnect.Name = "GroupConnect";
            this.GroupConnect.Size = new System.Drawing.Size(378, 232);
            this.GroupConnect.TabIndex = 56;
            this.GroupConnect.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Silver;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Red;
            this.txtPassword.Location = new System.Drawing.Point(149, 90);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 27);
            this.txtPassword.TabIndex = 48;
            this.txtPassword.Text = "huynh123";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Password";
            // 
            // CmdConnect
            // 
            this.CmdConnect.Location = new System.Drawing.Point(136, 150);
            this.CmdConnect.Name = "CmdConnect";
            this.CmdConnect.Size = new System.Drawing.Size(96, 30);
            this.CmdConnect.TabIndex = 46;
            this.CmdConnect.Text = "Connect";
            this.CmdConnect.UseVisualStyleBackColor = true;
            this.CmdConnect.Click += new System.EventHandler(this.CmdConnect_Click);
            this.CmdConnect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CmdConnect_MouseClick);
            // 
            // TxtPort
            // 
            this.TxtPort.BackColor = System.Drawing.Color.Silver;
            this.TxtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPort.ForeColor = System.Drawing.Color.Red;
            this.TxtPort.Location = new System.Drawing.Point(149, 55);
            this.TxtPort.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(173, 27);
            this.TxtPort.TabIndex = 7;
            this.TxtPort.Text = "4000";
            this.TxtPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPort_KeyDown);
            // 
            // TxtIPAddress
            // 
            this.TxtIPAddress.BackColor = System.Drawing.Color.Silver;
            this.TxtIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIPAddress.ForeColor = System.Drawing.Color.Red;
            this.TxtIPAddress.Location = new System.Drawing.Point(149, 25);
            this.TxtIPAddress.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIPAddress.Name = "TxtIPAddress";
            this.TxtIPAddress.Size = new System.Drawing.Size(173, 27);
            this.TxtIPAddress.TabIndex = 6;
            this.TxtIPAddress.Text = "10.10.10.25";
            this.TxtIPAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtIPAddress_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 492);
            this.Controls.Add(this.GroupConnect);
            this.Controls.Add(this.theImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.theImage)).EndInit();
            this.GroupConnect.ResumeLayout(false);
            this.GroupConnect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox theImage;
        private System.Windows.Forms.GroupBox GroupConnect;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdConnect;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.TextBox TxtIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

