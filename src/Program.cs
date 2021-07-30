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
        [STAThread]
        static void Main(string[] args)
        {
            MainForm mainForm = new MainForm();

            Application.Run(mainForm);
            Application.EnableVisualStyles();
        }
    }
}
