using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n) && n > 0)
            {
                // Cách 1: Dùng vòng lặp
                int S = 0;
                for (int i = 1; i <= n; i++)
                {
                    S += 2 * i; // 2, 4, 6, ..., 2n
                }               

                // Hiển thị kết quả
                txtS.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
