using System;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Text;
using Microsoft.Win32;

namespace RemoteDesktop_Server
{
    public class Settings
    {
        public static bool FirstTime = true;
        public static string MainProgramName = "Remote Desktop Server";
        public static string PassWord = "huynh123";
        public static Form1 FormService = null;
        public static int Port = 4000;
        public static bool Debug = false;
        public static int ScreenServerX = 1920;
        public static int ScreenServerY = 1080;
    }
}
