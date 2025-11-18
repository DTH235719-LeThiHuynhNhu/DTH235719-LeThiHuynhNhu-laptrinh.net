using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private double GetValue(TextBox txt)
        {
            double value = 0;
            try
            {
                value = double.Parse(txt.Text);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
            }
            return value;
        }  

        private void tongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKQ.Text = (a + b).ToString();
        }

        private void hieuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKQ.Text = (a - b).ToString();
        }

        private void tichToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            txtKQ.Text = (a * b).ToString();
        }

        private void thuongToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            double a = GetValue(txtA);
            double b = GetValue(txtB);
            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }
            txtKQ.Text = (a / b).ToString();
        }
    }
}
