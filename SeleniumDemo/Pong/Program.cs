using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WMPLib;

namespace Pong
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mp = new WindowsMediaPlayer();
            mp.URL = @"C:\Users\ronyu\Desktop\Alarm01.wav";
            mp.settings.setMode("loop", true); 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MinForm());
        }
    }
}
