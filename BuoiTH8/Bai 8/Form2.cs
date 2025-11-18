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
    public partial class Form2 : Form
    {
        private double canh; // Biến nhận giá trị từ Form1

        public Form2(string canhValue)
        {
            InitializeComponent();
            double.TryParse(canhValue, out canh);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Tính chu vi và diện tích hình vuông
            double dientich = canh * canh;
            double chuvi = 4 * canh;

            // Hiển thị kết quả lên TextBox
            txtDienTich.Text = dientich.ToString();
            txtChuVi.Text = chuvi.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
