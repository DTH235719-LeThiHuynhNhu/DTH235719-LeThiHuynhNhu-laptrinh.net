using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._7
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
            if (int.TryParse(txtN.Text, out n) && n >= 0)
            {
                long S = 1;
                for (int i = 1; i <= n; i++)
                {
                    S *= i;   // Nhân lần lượt từ 1 tới n
                }

                txtS.Text = $"{n}! = {S}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên không âm!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
