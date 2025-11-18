using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            int ngay, thang, nam;
            
            if (!int.TryParse(txtNgay.Text, out ngay) ||
                !int.TryParse(txtThang.Text, out thang) ||
                !int.TryParse(txtNam.Text, out nam))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!");
                return;
            }

            // Kiểm tra tháng hợp lệ
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Ngay KHONG hop le!");
                return;
            }

            int soNgayTrongThang = 31;

            // Xác định số ngày tối đa của tháng
            switch (thang)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    soNgayTrongThang = 30;
                    break;
                case 2:
                    if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0))
                        soNgayTrongThang = 29; // năm nhuận
                    else
                        soNgayTrongThang = 28;
                    break;
            }

            // Kiểm tra ngày hợp lệ
            if (ngay >= 1 && ngay <= soNgayTrongThang)
            {
                MessageBox.Show("Ngay hop le!");
            }
            else
            {
                MessageBox.Show("Ngay KHONG hop le!");
            }
        }

        private void ttxtNgay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
