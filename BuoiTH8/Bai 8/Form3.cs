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
    public partial class Form3 : Form
    {
        private double chieuDai;  // Biến nhận chiều dài từ Form1
        private double chieuRong; // Biến nhận chiều rộng từ Form1

        // Constructor nhận 2 giá trị từ Form1
        public Form3(string daiValue, string rongValue)
        {
            InitializeComponent();
            double.TryParse(daiValue, out chieuDai);
            double.TryParse(rongValue, out chieuRong);
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // Tính diện tích và chu vi hình chữ nhật
            double dienTich = chieuDai * chieuRong;
            double chuVi = 2 * (chieuDai + chieuRong);

            // Hiển thị kết quả lên TextBox
            txtDienTich.Text = dienTich.ToString();
            txtChuVi.Text = chuVi.ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
