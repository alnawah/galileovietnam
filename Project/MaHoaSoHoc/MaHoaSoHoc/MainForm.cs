using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MaHoaSoHoc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string[] args)
        {
            InitializeComponent();

            string s = "";
            if (args[0] == "-encipher")
            {
                for (int i = 1; i < args.Length; i++)
                {
                    s += args[i] + " ";
                }
                s = s.Trim();
                txtFileIn.Text = s;
                txtFileOut.Text = s + ".blf";
            }
            else if (args[0] == "-decipher")
            {
                for (int i = 1; i < args.Length; i++)
                    s += args[i] + " ";
                s = s.Trim();
                txtFileIn.Text = s;
                txtFileOut.Text = s.Substring(0, s.Length - 4);
            }
            tabControl1.SelectedIndex = 1;
            //txFKey.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenInputFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Files (*.*)|*.*|Enciphered Files (*.MHS)|*.MHS";
            dlg.Multiselect = false;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string fn = txtFileIn.Text = dlg.FileName;
                progress.Value = 0;
                if (fn.Substring(fn.Length - 4).ToLower() == ".mhs")
                {
                    txtFileOut.Text = fn.Substring(0, fn.Length - 4);
                }
                else
                {
                    txtFileOut.Text = fn + ".MHS";
                }
            }
        }

        private void btnOpenOutputFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "All Files (*.*)|*.*|Enciphered Files (*.BLF)|*.BLF";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtFileOut.Text = dlg.FileName;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnEncodeText_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text.Length > 0)
            {
                byte[] key = GetBytes("nqminh").Clone() as byte[];
                MaHoa objMahoa = new MaHoa(key);
                byte[] plain = GetBytes(txtInputText.Text).Clone() as byte[];
                byte[] tmp = FixBytes(plain);
                txtOutputText.Text = GetString(objMahoa.Encipher(tmp));
            }
        }

        public static byte[] GetBytes(string s)
        {
            byte[] bs = new byte[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                bs[i] = (byte)s[i];
            }
            return bs;
        }

        public static string GetString(byte[] bs)
        {
            string s = "";
            for (int i = 0; i < bs.Length; i++)
            {
                s += (char)bs[i];
            }
            return s;
        }

        public static byte[] FixBytes(byte[] bs)
        {
            int len = (bs.Length / 8 + 1) * 8;
            byte[] tmp = new byte[len];
            for (int i = 0; i < len; i++)
            {
                if (i < bs.Length)
                {
                    tmp[i] = bs[i];
                }
                else
                {
                    tmp[i] = 0x20;
                }
            }
            return tmp;
        }

        private void btnDecodeText_Click(object sender, EventArgs e)
        {
            if (txtInputText.Text.Length > 0)
            {
                byte[] key = GetBytes("nqminh").Clone() as byte[];
                MaHoa objMahoa = new MaHoa(key);
                byte[] plain = GetBytes(txtInputText.Text).Clone() as byte[];
                txtOutputText.Text = GetString(objMahoa.Decipher(plain));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtInputText.Text = "";
            txtOutputText.Text = "";
        }

        private void btnEncodeFile_Click(object sender, EventArgs e)
        {
            string fi = txtFileIn.Text;
            string fo = txtFileOut.Text;

            byte[] key = GetBytes("mahoademo");
            MaHoa objMahoa = new MaHoa(this);
            objMahoa.InitBoxes(key);
            objMahoa.Encipher(fi, fo);
        }

        private void btnDecodeFile_Click(object sender, EventArgs e)
        {
            string fi = txtFileIn.Text;
            string fo = txtFileOut.Text;
            byte[] key = GetBytes("mahoademo");

            MaHoa objMahoa = new MaHoa(this);
            objMahoa.InitBoxes(key);
            objMahoa.Decipher(fi, fo);
        }
    }
}
