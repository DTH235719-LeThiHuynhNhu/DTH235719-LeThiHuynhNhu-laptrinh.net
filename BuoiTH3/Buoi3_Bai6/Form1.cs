using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNhap.Text))
            {
                lstTen.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên trước khi thêm!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndex != -1)
            {
                lstTen.Items.RemoveAt(lstTen.SelectedIndex);
                txtHienThi.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tên để xóa!");
            }
        }

        private void lstTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTen.SelectedIndex != -1)
            {
                txtHienThi.Text = lstTen.SelectedItem.ToString();
            }
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.ForeColor = cd.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.BackColor = cd.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtHienThi.Font = fd.Font;
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
