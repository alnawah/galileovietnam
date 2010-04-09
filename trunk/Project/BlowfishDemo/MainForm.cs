/*
 * Created by SharpDevelop.
 * User: Quang Vinh
 * Date: 4/7/2008
 * Time: 11:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BlowfishDemo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public enum ProcessState {Finish, Enciphering, Deciphering, Free};
		
		//---
		public MainForm()
		{
			InitializeComponent();
		}
		//---
		public MainForm(string[] args)
		{
			InitializeComponent();
			string s = "";
			if (args[0] == "-encipher")
			{
				for (int i=1; i<args.Length; i++)
					s += args[i] + " ";
				s = s.Trim();
				txFIn.Text = s;
				txFOut.Text = s + ".blf";
			}
			else if (args[0] == "-decipher")
			{
				for (int i=1; i<args.Length; i++)
					s += args[i] + " ";
				s = s.Trim();
				txFIn.Text = s;
				txFOut.Text = s.Substring(0, s.Length-4);
			}
			ctrtab.SelectedIndex = 1;
			txFKey.Focus();
		}
		//---
		void MainFormLoad(object sender, EventArgs e)
		{
			lbAlgorithm.Text = Blowfish.Message;
			lbAuthor.Text = "signup8x\nBlowfish Crypter Demo V1.0.2";
		}
		//---
		void TxKeyTextChanged(object sender, EventArgs e)
		{
		}
		//---
		void BtEncipherClick(object sender, EventArgs e)
		{
			if (txKey.Text.Length > 0 && txInput.Text.Length > 0)
			{
				byte[] key = GetBytes(txKey.Text).Clone() as byte[];
				Blowfish bl = new Blowfish(key);
				byte[] plain = GetBytes(txInput.Text).Clone() as byte[];
				byte[] tmp = FixBytes(plain);
				txOutput.Text = GetString(bl.Encipher(tmp));
			}
		}
		//---
		void BtDecipherClick(object sender, EventArgs e)
		{
			if (txKey.Text.Length > 0 && txInput.Text.Length > 0)
			{
				byte[] key = GetBytes(txKey.Text).Clone() as byte[];
				Blowfish bl = new Blowfish(key);
				byte[] plain = GetBytes(txInput.Text).Clone() as byte[];
				
				txOutput.Text = GetString(bl.Decipher(plain));
			}
		}
		//---
		void BtFInClick(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "All Files (*.*)|*.*|Enciphered Files (*.BLF)|*.BLF";
			dlg.Multiselect = false;
			
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				string fn = txFIn.Text = dlg.FileName;
				progress.Value = 0;
				if (fn.Substring(fn.Length-4).ToLower() == ".blf")
					txFOut.Text = fn.Substring(0, fn.Length-4);
				else
					txFOut.Text = fn + ".BLF";
			}
		}
		//---
		void BtFOutClick(object sender, EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.Filter = "All Files (*.*)|*.*|Enciphered Files (*.BLF)|*.BLF";
			if (dlg.ShowDialog(this) == DialogResult.OK)
			{
				txFOut.Text = dlg.FileName;
			}
		}
		
		void BtFEncipherClick(object sender, EventArgs e)
		{
			string fi = txFIn.Text;
			string fo = txFOut.Text;
			
			byte[] key = GetBytes(txFKey.Text);
			Blowfish bl = new Blowfish(this);
			bl.InitBoxes(key);
			bl.Encipher(fi, fo);
		}
		
		void BtFDecipherClick(object sender, EventArgs e)
		{
			string fi = txFIn.Text;
			string fo = txFOut.Text;
			byte[] key = GetBytes(txFKey.Text);
			
			Blowfish bl = new Blowfish(this);
			bl.InitBoxes(key);
			bl.Decipher(fi, fo);
		}
		//---
		public static byte[] GetBytes(string s)
		{
			byte[] bs = new byte[s.Length];
			for (int i = 0; i<s.Length; i++)
				bs[i] = (byte)s[i];
			return bs;
		}
		//---
		public static string GetString(byte[] bs)
		{
			string s = "";
			for (int i = 0; i<bs.Length; i++)
				s += (char)bs[i];
			return s;
		}
		//--- Fix the bytes length to multiple of 8.
		public static byte[] FixBytes(byte[] bs)
		{
			int len = (bs.Length/8 + 1)*8;
			byte[] tmp = new byte[len];
			for (int i = 0; i < len; i++)
			{
				if (i < bs.Length) tmp[i] = bs[i];
				else tmp[i] = 0x20;
			}
			return tmp;
		}
		//---
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Application.Exit();
			}
		}

        private void tpInfo_Click(object sender, EventArgs e)
        {

        }

        private void tpCText_Click(object sender, EventArgs e)
        {

        }

        private void tpEDFile_Click(object sender, EventArgs e)
        {

        }
	}
}
