using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int thang;
            
            if (!int.TryParse(txtThang.Text, out thang))
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 1 đến 12!");
                return;
            }

            string mua;

            // Xác định mùa dựa trên tháng
            switch (thang)
            {
                case 1:
                case 2:
                case 3:
                    mua = "Mua xuan";
                    break;
                case 4:
                case 5:
                case 6:
                    mua = "Mua ha";
                    break;
                case 7:
                case 8:
                case 9:
                    mua = "Mua thu";
                    break;
                case 10:
                case 11:
                case 12:
                    mua = "Mua dong";
                    break;
                default:
                    mua = "Thang khong hop le";
                    break;
            }

            MessageBox.Show(mua);
        }
    }
}
