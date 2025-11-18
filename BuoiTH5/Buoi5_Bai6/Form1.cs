using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Buoi5_Bai6
{
    public partial class Form1 : Form
    {
        int[] arr;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        // Tạo mảng ngẫu nhiên ban đầu
        private void TaoMang()
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 100);

            // Hiển thị mảng gốc trong GroupBox2
            lblMangGoc.Text = "Mảng gốc: " + string.Join("  ", arr);

            // Reset kết quả
            lblResult.Text = "Kết quả: ";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (arr == null) TaoMang(); // lần đầu tạo mảng

            if (rbNhapXuat.Checked)
                lblResult.Text = "Kết quả: " + string.Join("  ", arr);

            else if (rbMin.Checked)
                lblResult.Text = "Kết quả: Min = " + arr.Min();

            else if (rbListEven.Checked)
                lblResult.Text = "Kết quả: " + string.Join("  ", arr.Where(x => x % 2 == 0));

            else if (rbLastEven.Checked)
            {
                int chanCuoi = arr.LastOrDefault(x => x % 2 == 0);
                lblResult.Text = chanCuoi == 0 ? "Không có số chẵn nào!" : "Kết quả: " + chanCuoi;
            }

            else if (rbSumOdd.Checked)
                lblResult.Text = "Kết quả: Tổng lẻ = " + arr.Where(x => x % 2 != 0).Sum();

            else if (rbSumEven.Checked)
                lblResult.Text = "Kết quả: Tổng chẵn = " + arr.Where(x => x % 2 == 0).Sum();

            else if (rbCountEven.Checked)
                lblResult.Text = "Kết quả: Có " + arr.Count(x => x % 2 == 0) + " số chẵn";

            else if (rbCountOdd.Checked)
                lblResult.Text = "Kết quả: Có " + arr.Count(x => x % 2 != 0) + " số lẻ";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
