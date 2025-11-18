using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Hàm tính ước chung lớn nhất (UCLN)
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        // Hàm tính bội chung nhỏ nhất (BCNN)
        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
        // Hàm rút gọn phân số
        private void RutGon(ref int tu, ref int mau)
        {
            int ucln = UCLN(Math.Abs(tu), Math.Abs(mau));
            tu /= ucln;
            mau /= ucln;
            if (mau < 0)
            {
                mau = -mau;
                tu = -tu;
            }
        }
        // Hàm lấy phân số từ các TextBox và kiểm tra hợp lệ
        private bool LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2)
        {
            tu1 = mau1 = tu2 = mau2 = 0;

            if (!int.TryParse(txtTuSo1.Text, out tu1))
            {
                MessageBox.Show("Nhập tử số 1 hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTuSo1.Focus();
                return false;
            }

            if (!int.TryParse(txtMauSo1.Text, out mau1) || mau1 == 0)
            {
                MessageBox.Show("Nhập mẫu số 1 hợp lệ và khác 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMauSo1.Focus();
                return false;
            }

            if (!int.TryParse(txtTuSo2.Text, out tu2))
            {
                MessageBox.Show("Nhập tử số 2 hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTuSo2.Focus();
                return false;
            }

            if (!int.TryParse(txtMauSo2.Text, out mau2) || mau2 == 0)
            {
                MessageBox.Show("Nhập mẫu số 2 hợp lệ và khác 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMauSo2.Focus();
                return false;
            }

            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2))
            {
                int mauKQ = BCNN(mau1, mau2);
                int tuKQ = tu1 * (mauKQ / mau1) + tu2 * (mauKQ / mau2);

                RutGon(ref tuKQ, ref mauKQ);

                txtKetQuaTuSo.Text = tuKQ.ToString();
                txtKetQuaMauSo.Text = mauKQ.ToString();
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2))
            {
                int mauKQ = BCNN(mau1, mau2);
                int tuKQ = tu1 * (mauKQ / mau1) - tu2 * (mauKQ / mau2);

                RutGon(ref tuKQ, ref mauKQ);

                txtKetQuaTuSo.Text = tuKQ.ToString();
                txtKetQuaMauSo.Text = mauKQ.ToString();
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2))
            {
                int tuKQ = tu1 * tu2;
                int mauKQ = mau1 * mau2;

                RutGon(ref tuKQ, ref mauKQ);

                txtKetQuaTuSo.Text = tuKQ.ToString();
                txtKetQuaMauSo.Text = mauKQ.ToString();
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (LayPhanSo(out int tu1, out int mau1, out int tu2, out int mau2))
            {
                if (tu2 == 0)
                {
                    MessageBox.Show("Phân số thứ hai không được có tử số bằng 0 khi chia!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int tuKQ = tu1 * mau2;
                int mauKQ = mau1 * tu2;

                if (mauKQ == 0)
                {
                    MessageBox.Show("Mẫu số kết quả không được bằng 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RutGon(ref tuKQ, ref mauKQ);

                txtKetQuaTuSo.Text = tuKQ.ToString();
                txtKetQuaMauSo.Text = mauKQ.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // Xóa dữ liệu nhập phân số 1
            txtTuSo1.Clear();
            txtMauSo1.Clear();

            // Xóa dữ liệu nhập phân số 2
            txtTuSo2.Clear();
            txtMauSo2.Clear();

            // Xóa kết quả
            txtKetQuaTuSo.Clear();
            txtKetQuaMauSo.Clear();

            // Đặt con trỏ chuột vào ô nhập tử số phân số 1 để dễ nhập liệu
            txtTuSo1.Focus();
        }
    }
}
