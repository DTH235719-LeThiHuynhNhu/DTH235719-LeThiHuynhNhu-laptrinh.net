using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;

            rb1.Checked = true;
            txtCanh.Focus();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtCanh.Enabled = true;
            txtDai.Enabled = txtRong.Enabled = txtBanKinh.Enabled = false;
            txtCanh.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtDai.Enabled = txtRong.Enabled = true;
            txtCanh.Enabled = txtBanKinh.Enabled = false;
            txtDai.Focus();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            ClearTextBoxes();
            txtBanKinh.Enabled = true;
            txtCanh.Enabled = txtDai.Enabled = txtRong.Enabled = false;
            txtBanKinh.Focus();

        }

        private void ClearTextBoxes()
        {
            txtCanh.Clear();
            txtDai.Clear();
            txtRong.Clear();
            txtBanKinh.Clear();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                Form2 f = new Form2(txtCanh.Text);
                f.ShowDialog();
            }
            else if (rb2.Checked)
            {
                Form3 f = new Form3(txtDai.Text, txtRong.Text);
                f.ShowDialog();
            }
            else if (rb3.Checked)
            {
                Form4 f = new Form4(txtBanKinh.Text);
                f.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình không?",
                                      "Xác nhận",
                                      MessageBoxButtons.OKCancel,
                                      MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
                Application.Exit();
        }
    }
}
