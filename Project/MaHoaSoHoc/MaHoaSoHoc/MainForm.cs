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
                byte[] key = GetBytes("masohoc").Clone() as byte[];
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
                byte[] key = GetBytes("masohoc").Clone() as byte[];
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

            byte[] key = GetBytes("masohoc");
            MaHoa objMahoa = new MaHoa(this);
            objMahoa.InitBoxes(key);
            objMahoa.Encipher(fi, fo);
        }

        private void btnDecodeFile_Click(object sender, EventArgs e)
        {
            string fi = txtFileIn.Text;
            string fo = txtFileOut.Text;
            byte[] key = GetBytes("masohoc");

            MaHoa objMahoa = new MaHoa(this);
            objMahoa.InitBoxes(key);
            objMahoa.Decipher(fi, fo);
        }

        //Thuat toan ma hoa
        protected string MaHoa()
        {
            //Khai bao cac bien
            string strMaHoa = "";
            string P = txtInputText.Text;
            int n = P.Length;
            int D = n * 1000;
            string low_range = "";
            string hi_range = "";
            string T = "";
            string ch = "";
            char[] low_code = new char[99999];
            char[] hi_code = new char[99999];

            //Khoi tao gia tri
            low_code[1] = low_range[1];
            hi_code[1] = hi_range[1];

            //Lap
            for (int i = 2; i <= n; i++)
            {
                low_code[i] = (char)(low_code[i - 1] + low_range[(int)ch[i]] * (hi_code[i - 1] - low_code[i - 1]) / D);
                hi_code[i] = (char)(low_code[i - 1] + hi_range[(int)ch[i]] * (hi_code[i - 1] - low_code[i - 1]) / D);
                T.ToCharArray()[i] = P[i];
            }

            //Tra ve chuoi ma hoa
            strMaHoa = T;
            return strMaHoa;
        }

        //Thuạt toan giai ma
        protected string GiaiMa()
        {
            //Khai bao cac bien
            string strGiaiMa = "";
            string P = txtInputText.Text;
            int n = P.Length;
            int D = n * 1000;
            string x = "";
            string low_range = "";
            string hi_range = "";
            char[] ch = new char[99999];
            char[] low_code = new char[99999];
            char[] hi_code = new char[99999];
            int number_code = 0;

            //Khoi tao gia tri
            low_code[1] = low_range[1];
            hi_code[1] = hi_range[1];

            //Lap de tim ban goc
            for (int i = 1; i <= n; i++)
            {
                if (low_range[(int)ch[i]] != x.ToCharArray()[i] && hi_range[(int)ch[i]] != x.ToCharArray()[i])
                {
                    ch[i] = ch[0];
                    number_code = (number_code - low_range[(int)ch[i]]) * D / (hi_range[(int)ch[i]] - low_range[(int)ch[i]]);
                    strGiaiMa.ToCharArray()[i] = ch[i];
                }
            }

            //Tra ve gia tri ban goc
            return strGiaiMa;
        }


    }
}
