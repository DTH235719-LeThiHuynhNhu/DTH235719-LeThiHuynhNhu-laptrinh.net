using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi5_Bai7
{
    public partial class Form1 : Form
    {
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            try
            {
                arr = txtNhapMang.Text.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

                lblKetQua.Text = "Kết quả: " + string.Join("  ", arr);
            }
            catch
            {
                MessageBox.Show("Bạn nhập mảng sai định dạng!", "Lỗi");
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            txtTongMang.Text = arr.Sum().ToString();
            txtTongChan.Text = arr.Where(x => x % 2 == 0).Sum().ToString();
            txtTongLe.Text = arr.Where(x => x % 2 != 0).Sum().ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            txtMax.Text = arr.Max().ToString();
            txtMin.Text = arr.Min().ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            if (rdoTang.Checked)
                arr = arr.OrderBy(x => x).ToArray();
            else if (rdoGiam.Checked)
                arr = arr.OrderByDescending(x => x).ToArray();

            lblKetQua.Text = "Kết quả: " + string.Join("  ", arr);
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (arr == null) return;

            try
            {
                int vt = int.Parse(txtViTri.Text);
                int so = int.Parse(txtSoThayThe.Text);

                if (vt >= 0 && vt < arr.Length)
                {
                    arr[vt] = so;
                    lblKetQua.Text = "Kết quả: " + string.Join("  ", arr);
                }
                else
                {
                    MessageBox.Show("Vị trí không hợp lệ!", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng số nguyên!", "Lỗi");
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapMang.Clear();
            txtTongMang.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtMax.Clear();
            txtMin.Clear();
            txtViTri.Clear();
            txtSoThayThe.Clear();
            lblKetQua.Text = "Kết quả:";
            arr = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
