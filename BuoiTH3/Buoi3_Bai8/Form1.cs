using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            if (cboHoTen.SelectedItem != null)
            {
                string ten = cboHoTen.SelectedItem.ToString();
                MessageBox.Show("Chao " + ten + ". Chuc mot ngay vui ve.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn họ tên trước!");
            }
        }
    }
}
