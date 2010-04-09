using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int x, y, sum = 0;
            x = int.Parse(txtValue1.Text);
            y = int.Parse(txtValue2.Text);
            ServiceReference1.Service1SoapClient ws = new ServiceReference1.Service1SoapClient();
            sum = ws.Add(x, y);
            MessageBox.Show("Sum is = " + sum.ToString());
        }
    }
}
