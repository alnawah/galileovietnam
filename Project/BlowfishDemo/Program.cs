/*
 * Created by SharpDevelop.
 * User: Quang Vinh
 * Date: 4/7/2008
 * Time: 11:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace BlowfishDemo
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			
			if (Registry.ClassesRoot.OpenSubKey(".blf", false) == null)
				FileShellExtension.RegisterBLF();
			
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
