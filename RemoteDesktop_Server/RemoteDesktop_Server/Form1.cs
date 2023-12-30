using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemoteDesktop_Server
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void printDebug(string Msg, bool Force)
        {//This will be called on this forms thread
            if (Settings.Debug || Force)
            {
                InfDebug.Text = Msg + Environment.NewLine + InfDebug.Text;
                if (InfDebug.Text.Length > 20000) InfDebug.Text = InfDebug.Text.Substring(10000);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Settings.MainProgramName;
            bool B = Control.IsKeyLocked(Keys.CapsLock);
            this.WindowState = FormWindowState.Normal;
            Settings.FormService = this;
            if (!Helper.IsUserAdministrator())
                printDebug("This program should be started with administrator rights to allow control of windows system forms and settings." + Environment.NewLine, true);
            if (Settings.FirstTime)
            {
                Password.Text = Settings.PassWord;
                Port.Text = Settings.Port.ToString();
            }
            else
                Server.ListenStart();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.ListenStop(true);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InfDebug.Text = "";
        }

        private void ClearButton_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.SizeAll;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Cursor.Current != null)

            {

                this.InfDebug.Text ="X:"+ Cursor.Current.ToString() + " " + System.Windows.Forms.Cursor.Position.X;
                this.InfDebug.Text = "Y:" + Cursor.Current.ToString() + " " + System.Windows.Forms.Cursor.Position.Y;

            }

            else

            {

                this.InfDebug.Text = "No cursor available " + System.Windows.Forms.Cursor.Position.X;

            }
            
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            if (Helper.IsUserAdministrator())
            {
                FireWall.ProgramName = Settings.MainProgramName;
                if (FireWall.AllowThisProgram("TCP", Settings.Port.ToString(), "", "IN"))
                {
                    MessageBox.Show("New firewall rule added for TCP port " + Settings.Port, Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Server.ListenStart(); return;
                }
            }
            MessageBox.Show("Da khoi dong server", Settings.MainProgramName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Server.ListenStart();

        }
    }
}
