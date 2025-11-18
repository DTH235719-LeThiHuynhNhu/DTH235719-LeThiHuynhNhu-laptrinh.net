using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class Form4 : Form
    {
        private double banKinh;  // Biến nhận bán kính từ Form1

        // Constructor nhận giá trị bán kính
        public Form4(string bkValue)
        {
            InitializeComponent();
            double.TryParse(bkValue, out banKinh);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Tính diện tích và chu vi hình tròn
            double dienTich = Math.PI * banKinh * banKinh;
            double chuVi = 2 * Math.PI * banKinh;

            // Hiển thị kết quả lên TextBox
            txtDienTich.Text = dienTich.ToString("F2"); // Format 2 chữ số thập phân
            txtChuVi.Text = chuVi.ToString("F2");
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
