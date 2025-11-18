using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_bai1
{
    public partial class Form1 : Form
    {
        //khai bao báo biến 
        int[] a = new int[10];
        int sopt = 0;
        int n = 10;
        public Form1()
        {
            InitializeComponent();
        }
        //CAC PHUONG THUC 
        //phuong thuc in mang 
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
                chuoi += a[i] + " ";
            return chuoi;
        }
        //phuong thuc tim max 
        public int TimMax()
        {
            int max = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] > max)
                    max = a[i];
            return max;
        }
        //phuong thuc tim so nho nhat
        public int TimMin()
        {
            int min = a[0];
            for (int i = 1; i < sopt; i++)
                if (a[i] < min)
                    min = a[i];
            return min;
        }
        //phuong thuc tinh trung binh 
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < sopt; i++)
                sum += a[i];
            tb = (double)sum / (double)sopt;
            return tb;
        }
        //phuong thuc sap xep tang 
        public void SapXepTang()
        {
            Array.Sort(a, 0, sopt);
        }
        //phuong thuc sx giam
        public void SapXepGiam()
        {
            Array.Sort(a, 0, sopt);
            Array.Reverse(a, 0, sopt);
        }
        //phuong thuc tim UCLN cua 2 so 
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //phuong thuc kiem tra so nguyen to 
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }
        //phuong thuc dem SNT 
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    dem++;
            }
            return dem;
        }
        //phuong thuc in SNT 
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < sopt; i++)
            {
                if (kiemTraSNT(a[i]))
                    chuoi += a[i] + " ";
            }
            return chuoi;
        }
        //phuong thuc dem so chan
        public int DemSoChan()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
                if (a[i] % 2 == 0)
                    dem++;
            return dem;
        }
        //phuong thuc dem so le
        public int DemSoLe()
        {
            int dem = 0;
            for (int i = 0; i < sopt; i++)
                if (a[i] % 2 != 0)
                    dem++;
            return dem;
        }
        //phuong thuc tong mang
        public int TongMang()
        {
            int tong = 0;
            for (int i = 0; i < sopt; i++)
                tong += a[i];
            return tong;
        }
        //kiem tra shh
        public bool IsSoHoanHao(int n)
        {
            int tong = 0;
            for (int i = 1; i < n; i++)
                if (n % i == 0)
                    tong += i;
            return tong == n;
        }
        //phuong thuc in shh
        public string InSoHoanHao()
        {
            string chuoi = "";
            for (int i = 0; i < sopt; i++)
                if (IsSoHoanHao(a[i]))
                    chuoi += a[i] + " ";
            return chuoi.Trim();
        }
        

        //CAC SU KIEN
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sopt == n)
            {
                txtNhap.Text = "";
                MessageBox.Show("Mảng đã đầy", "Thông báo");
            }
            else
            {
                if (txtNhap.Text == "")
                {
                    MessageBox.Show("Hãy nhập phần tử mảng", "Thông báo");
                }
                else
                {
                    a[sopt] = int.Parse(txtNhap.Text);
                    sopt++;
                    lblKQ.Text += txtNhap.Text + " ";
                    txtNhap.Clear();
                    txtNhap.Focus();
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag 
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Xóa mảng bằng cách đặt lại số phần tử về 0
            sopt = 0;

            // Xóa dữ liệu hiển thị
            lblKQ.Text = "";
            txtNhap.Clear();
            txtNhap.Focus();

            MessageBox.Show("Đã xóa toàn bộ mảng!", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepGiam();
                lblKQ.Text = "Mảng sau khi sắp xếp giảm: " + InMang();
            }
        }

        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                lblKQ.Text = "Mảng sau khi sắp xếp tăng: " + InMang();
            }
        }

        private void btnSUM_Click(object sender, EventArgs e)
        {           
                if (sopt == 0)
                    lblKQ.Text = "Mảng rỗng!";
                else
                    lblKQ.Text = $"Tổng các phần tử trong mảng: {TongMang()}";
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = $"Số lượng số chẵn trong mảng: {DemSoChan()}";
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = $"Số lượng số lẻ trong mảng: {DemSoLe()}";
        }

        private void btnMIN_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = $"Số nhỏ nhất trong mảng là: {TimMin()}";
        }

        private void btnMAX_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = $"Số lớn nhất trong mảng là: {TimMax()}";
        }

        private void btnTBMang_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = $"Giá trị trung bình của mảng là: {TrungBinhMang():F2}";
        }

        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                string kq = InSoHoanHao();
                if (kq == "")
                    lblKQ.Text = "Không có số hoàn hảo nào trong mảng.";
                else
                    lblKQ.Text = "Các số hoàn hảo trong mảng là: " + kq;
            }
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + a[0] + " và " + a[1] + " là " +
            timUCLN(a[0], a[1]).ToString();
        }

        private void btnUCLN_Click_1(object sender, EventArgs e)
        {
            if (sopt < 2)
                lblKQ.Text = "Cần ít nhất 2 phần tử để tính ƯCLN!";
            else
                lblKQ.Text = $"Ước chung lớn nhất của {a[0]} và {a[1]} là {timUCLN(a[0], a[1])}";
        }
    }
}
