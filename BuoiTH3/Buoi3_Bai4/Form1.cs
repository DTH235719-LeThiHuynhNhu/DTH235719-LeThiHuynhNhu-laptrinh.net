using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtNhapht.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtNhapht.Focus();
            }
            else
            {
                string hoten = this.txtNhapht.Text;
                if (this.rdbChuthuong.Checked == true)
                {
                    this.txtKq.Text = hoten.ToLower();
                }
                if (this.rdbChuhoa.Checked == true)
                {
                    this.txtKq.Text = hoten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapht.Clear();
            txtKq.Clear();
            rdbChuthuong.Checked = true; // chọn lại mặc định
            txtNhapht.Focus();            // con trỏ về ô họ tên
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
