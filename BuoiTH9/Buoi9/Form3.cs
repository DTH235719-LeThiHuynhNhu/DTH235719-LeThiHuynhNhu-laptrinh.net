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
    public partial class Form3 : Form
    {
        private int N;
        private int[] arr;
        public Form3(string n)
        {
            InitializeComponent();
            if (!int.TryParse(n, out N))
            {
                MessageBox.Show("Giá trị N không hợp lệ!");
                this.Close();
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // Tạo mảng có N phần tử
            arr = new int[N];
            Random rd = new Random();
            for (int i = 0; i < N; i++)
                arr[i] = rd.Next(N, N + 13); // khoảng N -> N+12

            // Hiển thị các phần tử mảng
            txtMang.Text = string.Join(" ", arr);

            // Lấy các số chẵn
            var soChan = arr.Where(x => x % 2 == 0).ToArray();
            txtSoChan.Text = string.Join(" ", soChan);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
