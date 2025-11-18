using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void picAnh_Click(object sender, EventArgs e)
        {

        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            string hoten = txtHoTen.Text;
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string ngaysinh = dtpNgaySinh.Value.ToShortDateString();
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;

            string tinhtrang = "";
            if (chkHoc.Checked) tinhtrang += "Đang đi học ";
            if (chkLam.Checked) tinhtrang += "Đang đi làm";

            string thongtin =
                "Họ tên: " + hoten + Environment.NewLine +
                "Giới tính: " + gioitinh + Environment.NewLine +
                "Ngày sinh: " + ngaysinh + Environment.NewLine +
                "Địa chỉ: " + diachi + Environment.NewLine +
                "Điện thoại: " + dienthoai + Environment.NewLine +
                "Email: " + email + Environment.NewLine +
                "Tình trạng: " + tinhtrang;

            MessageBox.Show(thongtin, "Thông tin cá nhân");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
