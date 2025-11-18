using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Khởi tạo các lớp trong ComboBox
            cboLop.Items.Add("Lớp A");
            cboLop.Items.Add("Lớp B");
            cboLop.Items.Add("Lớp C");
            cboLop.Items.Add("Lớp D");
            cboLop.Items.Add("Lớp E");
            cboLop.Items.Add("Lớp G");

            cboLop.SelectedIndex = 0; // mặc định chọn Lớp A

            // Tạo tiêu đề cột cho DataGridView
            dgvSinhVien.ColumnCount = 5;
            dgvSinhVien.Columns[0].Name = "Mã SV";
            dgvSinhVien.Columns[1].Name = "Họ Tên SV";
            dgvSinhVien.Columns[2].Name = "Địa Chỉ";
            dgvSinhVien.Columns[3].Name = "Ngày Sinh";
            dgvSinhVien.Columns[4].Name = "Lớp";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "" || txtHoTen.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvSinhVien.Rows.Add(
                txtMaSV.Text,
                txtHoTen.Text,
                txtDiaChi.Text,
                dtNgaySinh.Value.ToShortDateString(),
                cboLop.Text
            );

            // Xóa trống ô nhập
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            cboLop.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        private void btnXoaItem_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvSinhVien.SelectedRows)
                {
                    dgvSinhVien.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
