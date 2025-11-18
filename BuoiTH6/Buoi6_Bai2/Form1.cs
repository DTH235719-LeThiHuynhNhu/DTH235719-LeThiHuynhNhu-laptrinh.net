using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text.Trim();
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập dữ liệu", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdbLopA.Checked)
            {
                lstLopA.Items.Add(ten);
            }
            else if (rdbLopB.Checked)
            {
                lstLopB.Items.Add(ten);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp A hoặc B", "Thông báo");
            }

            txtHoTen.Clear();
            txtHoTen.Focus();
        }

        private void btnSangB_Click(object sender, EventArgs e)
        {
            var selected = lstLopA.SelectedItems;
            for (int i = selected.Count - 1; i >= 0; i--)
            {
                lstLopB.Items.Add(selected[i]);
                lstLopA.Items.Remove(selected[i]);
            }
        }

        private void btnSangA_Click(object sender, EventArgs e)
        {
            var selected = lstLopB.SelectedItems;
            for (int i = selected.Count - 1; i >= 0; i--)
            {
                lstLopA.Items.Add(selected[i]);
                lstLopB.Items.Remove(selected[i]);
            }
        }

        private void btnAllSangB_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopA.Items)
            {
                lstLopB.Items.Add(item);
            }
            lstLopA.Items.Clear();
        }

        private void btnAllSangA_Click(object sender, EventArgs e)
        {
            foreach (var item in lstLopB.Items)
            {
                lstLopA.Items.Add(item);
            }
            lstLopB.Items.Clear();
        }

        private void btnTongSV_Click(object sender, EventArgs e)
        {
            int tong = lstLopA.Items.Count + lstLopB.Items.Count;
            MessageBox.Show("Tổng số sinh viên 2 lớp là: " + tong, "Số sinh viên");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
