using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace TTS
{
    class Program
    {
        static Boolean ShouldEnableVisualStyles() {
            //Get Operating system information.
            OperatingSystem os = Environment.OSVersion;
            //Get version information about the os.
            Version vs = os.Version;

            if (os.Platform == PlatformID.Win32Windows || os.Platform == PlatformID.Win32NT)
            {
                //This is a pre-NT version of Windows
                switch (vs.Major)
                {
                    case 5:
                    case 4:
                    case 90:
                        return false;
                    case 10:
                    case 6:
                        return true;
                    default:
                        return true;
                        break;
                }
            } else
            {
                return false;
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            MainForm mainForm = new MainForm();

            if (ShouldEnableVisualStyles())
                Application.EnableVisualStyles();
            Application.Run(mainForm);
        }
    }
}
