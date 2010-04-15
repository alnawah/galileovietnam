using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;
using BlowfishDemo;

namespace MaHoaSoHoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //if (Registry.ClassesRoot.OpenSubKey(".mhs", false) == null)
                //FileShellExtension.RegisterBLF();

            if (args.Length < 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            else if (args[0] == "-register")
                FileShellExtension.RegisterBLF();
            else if (args[0] == "-unregister")
                FileShellExtension.UnregisterBLF();
            else if (args[0] == "-encipher" || args[0] == "-decipher")
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm(args));
            }
        }
    }
}
