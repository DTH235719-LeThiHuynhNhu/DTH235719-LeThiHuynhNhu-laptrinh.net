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
    public partial class Form1 : Form
    {
        //khai báo biến 
        int[] a;
        int n;
        public Form1()
        {
            InitializeComponent();
            btnSUM.Enabled = false;
            btnMAX.Enabled = false;
        }
        //phuong thuc tao mang 
        public void TaoMang(int n)
        {
            //khai báo mảng có n phần tử nhập từ Textbox 
            a = new int[n];
            //khởi tạo giá tri ngẫu nhiên cho mảng 
            int num1;
            Random rd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                //tạo số ngẫu nhiên nằm giữa so1 và so2 
                num1 = rd.Next(-10, 100);
                a[i] = num1;
            }
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            // Kiểm tra nhập dữ liệu
            if (string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập số phần tử mảng!", "Thông báo");
                txtNhap.Focus();
                return;
            }

            if (!int.TryParse(txtNhap.Text, out n) || n <= 0)
            {
                MessageBox.Show("Giá trị nhập không hợp lệ! Vui lòng nhập số nguyên > 0", "Thông báo");
                txtNhap.Focus();
                return;
            }

            // Tạo mảng a với n phần tử, random từ -10 đến 100
            a = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rand.Next(-10, 101);  // từ -10 đến 100

            // In mảng vừa tạo lên MessageBox
            string mangStr = string.Join(" ", a);
            MessageBox.Show("Mảng vừa tạo là:\n" + mangStr, "Thông báo");

            // Bật btnSum, btnMax
            btnSUM.Enabled = true;
            btnMAX.Enabled = true;
        }

        private void btnSUM_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                MessageBox.Show("Mảng chưa được tạo!", "Thông báo");
                return;
            }

            // Tạo Form2, chuyền mảng a sang Form2
            Form3 f2 = new lblKetQua(a);

            // Hỏi có muốn tiếp tục tính tổng mảng không
            DialogResult dr = MessageBox.Show("Bạn có muốn tính tổng mảng không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                f2.ShowDialog();
            }
        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            if (a == null || a.Length == 0)
            {
                MessageBox.Show("Mảng chưa được tạo!", "Thông báo");
                return;
            }

            // Tạo Form3, chuyền mảng a sang Form3
            Form3 f3 = new lblKetQua(a);

            // Hỏi có muốn tiếp tục tìm số lớn nhất không
            DialogResult dr = MessageBox.Show("Bạn có muốn tìm số lớn nhất trong mảng không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                f3.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
