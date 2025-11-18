using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Phương thức tìm số lớn nhất (Max)
        public int TimMax(int so1, int so2)
        {
            if (so1 > so2)
                return so1;
            else
                return so2;
        }

        // Phương thức tìm các ước chung
        public string TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            string chuoi = "";
            for (int i = 1; i <= max; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    chuoi += i.ToString() + " ";
            }
            return chuoi;
        }

        // Phương thức tìm Ước chung lớn nhất (UCLN)
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(txtN.Text, out a) || !int.TryParse(txtM.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập đúng 2 số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rdo1.Checked)
                txtKQ.Text = TimUocChung(a, b);
            else if (rdo2.Checked)
                txtKQ.Text = timUCLN(a, b).ToString();
            else
                MessageBox.Show("Vui lòng chọn phép toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtM.Clear();
            txtKQ.Clear();
            rdo1.Checked = true; // chọn lại mặc định
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Xác nhận",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
                Application.Exit();
        }
    }
}
