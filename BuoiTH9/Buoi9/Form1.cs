using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnLamLai.Enabled = false; // lúc mới mở, nút Làm lại không có tác dụng
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form2 f = new Form2(txtN.Text);
            f.ShowDialog();
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            btnLamLai.Enabled = true;
            Form3 f = new Form3(txtN.Text);
            f.ShowDialog();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnKiemTra.PerformClick();
        }

        private void tạoMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTaoMang.PerformClick();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
