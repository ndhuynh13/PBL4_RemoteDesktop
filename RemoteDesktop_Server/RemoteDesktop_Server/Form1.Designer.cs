namespace RemoteDesktop_Server
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.Port = new MetroFramework.Controls.MetroTextBox();
            this.Password = new MetroFramework.Controls.MetroTextBox();
            this.ClearButton = new MetroFramework.Controls.MetroButton();
            this.HideButton = new MetroFramework.Controls.MetroButton();
            this.TurnOnButton = new MetroFramework.Controls.MetroButton();
            this.InfDebug = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 122);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "TCP Listen Port";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // Port
            // 
            // 
            // 
            // 
            this.Port.CustomButton.Image = null;
            this.Port.CustomButton.Location = new System.Drawing.Point(85, 2);
            this.Port.CustomButton.Name = "";
            this.Port.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Port.CustomButton.TabIndex = 1;
            this.Port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Port.CustomButton.UseSelectable = true;
            this.Port.CustomButton.Visible = false;
            this.Port.Lines = new string[] {
        "4000"};
            this.Port.Location = new System.Drawing.Point(175, 122);
            this.Port.MaxLength = 32767;
            this.Port.Name = "Port";
            this.Port.PasswordChar = '\0';
            this.Port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Port.SelectedText = "";
            this.Port.SelectionLength = 0;
            this.Port.SelectionStart = 0;
            this.Port.ShortcutsEnabled = true;
            this.Port.Size = new System.Drawing.Size(113, 30);
            this.Port.TabIndex = 2;
            this.Port.Text = "4000";
            this.Port.UseSelectable = true;
            this.Port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Password
            // 
            // 
            // 
            // 
            this.Password.CustomButton.Image = null;
            this.Password.CustomButton.Location = new System.Drawing.Point(85, 2);
            this.Password.CustomButton.Name = "";
            this.Password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Password.CustomButton.TabIndex = 1;
            this.Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Password.CustomButton.UseSelectable = true;
            this.Password.CustomButton.Visible = false;
            this.Password.Lines = new string[] {
        "letmein"};
            this.Password.Location = new System.Drawing.Point(175, 158);
            this.Password.MaxLength = 32767;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '\0';
            this.Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Password.SelectedText = "";
            this.Password.SelectionLength = 0;
            this.Password.SelectionStart = 0;
            this.Password.ShortcutsEnabled = true;
            this.Password.Size = new System.Drawing.Size(113, 30);
            this.Password.TabIndex = 3;
            this.Password.Text = "letmein";
            this.Password.UseSelectable = true;
            this.Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Red;
            this.ClearButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ClearButton.ForeColor = System.Drawing.Color.Silver;
            this.ClearButton.Location = new System.Drawing.Point(53, 252);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(92, 46);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseSelectable = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            this.ClearButton.MouseHover += new System.EventHandler(this.ClearButton_MouseHover);
            // 
            // HideButton
            // 
            this.HideButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.HideButton.Location = new System.Drawing.Point(175, 252);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(92, 46);
            this.HideButton.TabIndex = 5;
            this.HideButton.Text = "Hide";
            this.HideButton.UseSelectable = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // TurnOnButton
            // 
            this.TurnOnButton.BackColor = System.Drawing.Color.Red;
            this.TurnOnButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.TurnOnButton.ForeColor = System.Drawing.Color.Silver;
            this.TurnOnButton.Location = new System.Drawing.Point(53, 336);
            this.TurnOnButton.Name = "TurnOnButton";
            this.TurnOnButton.Size = new System.Drawing.Size(214, 46);
            this.TurnOnButton.TabIndex = 6;
            this.TurnOnButton.Text = "Turn on";
            this.TurnOnButton.UseSelectable = true;
            this.TurnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            // 
            // InfDebug
            // 
            // 
            // 
            // 
            this.InfDebug.CustomButton.Image = null;
            this.InfDebug.CustomButton.Location = new System.Drawing.Point(71, 2);
            this.InfDebug.CustomButton.Name = "";
            this.InfDebug.CustomButton.Size = new System.Drawing.Size(293, 293);
            this.InfDebug.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.InfDebug.CustomButton.TabIndex = 1;
            this.InfDebug.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.InfDebug.CustomButton.UseSelectable = true;
            this.InfDebug.CustomButton.Visible = false;
            this.InfDebug.Lines = new string[0];
            this.InfDebug.Location = new System.Drawing.Point(403, 108);
            this.InfDebug.MaxLength = 32767;
            this.InfDebug.Name = "InfDebug";
            this.InfDebug.PasswordChar = '\0';
            this.InfDebug.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.InfDebug.SelectedText = "";
            this.InfDebug.SelectionLength = 0;
            this.InfDebug.SelectionStart = 0;
            this.InfDebug.ShortcutsEnabled = true;
            this.InfDebug.Size = new System.Drawing.Size(367, 298);
            this.InfDebug.TabIndex = 7;
            this.InfDebug.UseSelectable = true;
            this.InfDebug.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.InfDebug.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(403, 76);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 20);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Infomation action:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 504);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.InfDebug);
            this.Controls.Add(this.TurnOnButton);
            this.Controls.Add(this.HideButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "Remote Desktop Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox Port;
        private MetroFramework.Controls.MetroTextBox Password;
        private MetroFramework.Controls.MetroButton ClearButton;
        private MetroFramework.Controls.MetroButton HideButton;
        private MetroFramework.Controls.MetroButton TurnOnButton;
        private MetroFramework.Controls.MetroTextBox InfDebug;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Timer timer1;
    }
}

