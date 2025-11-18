using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_bai3
{
    public partial class Form3 : Form
    {
        int[] b;
        public Form3(int[] a)
        {
            InitializeComponent();
            /// Tạo mảng b có kích thước bằng a
            b = new int[a.Length];
            Array.Copy(a, b, a.Length);

            // Tính tổng và hiển thị
            int tong = TinhTongMang(b);
            lblKetQua.Text = $"Tổng các phần tử trong mảng là: {tong}";
        }
        public int TinhTongMang(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
                sum += x;
            return sum;
        }
        private void btnSoLonNhat_Click(object sender, EventArgs e)
        {
            // Mở Form3 từ Form2
            Form3 f3 = new lblKetQua(b);
            DialogResult dr = MessageBox.Show("Bạn có muốn tìm số lớn nhất trong mảng không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                f3.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
