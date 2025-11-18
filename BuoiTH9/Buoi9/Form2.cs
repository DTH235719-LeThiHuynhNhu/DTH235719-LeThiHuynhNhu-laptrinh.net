using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi9
{
    public partial class Form2 : Form
    {
        private int N;
        public Form2(string n)
        {
            InitializeComponent();
            if (!int.TryParse(n, out N))
            {
                MessageBox.Show("Vui lòng nhập số N hợp lệ!");
                this.Close();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblKetQua.Text = $"Số {N} {(LaSoHoanHao(N) ? "là" : "không phải")} số hoàn hảo.";
        }

        private bool LaSoHoanHao(int n)
        {
            if (n < 2) return false;
            int tong = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) tong += i;
            return tong == n;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
