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

namespace Buoi5_Bai5
{
    public partial class Form1 : Form
    {
        int[] arr;   // mảng lưu dữ liệu
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1, 101);  // giá trị từ 1–100

            lblArray.Text = string.Join("  ", arr);
            lblResult.Text = "";
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int sum = arr.Sum();
            lblResult.Text = "Tổng mảng = " + sum;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int min = arr.Min();
            lblResult.Text = "Phần tử nhỏ nhất = " + min;
        }

        private void btnIncrease2_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++)
                arr[i] += 2;

            lblArray.Text = string.Join("  ", arr);
            lblResult.Text = "Đã tăng mỗi phần tử lên 2";
        }

        private void btnCountOdd_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int count = arr.Count(x => x % 2 != 0);
            lblResult.Text = "Số phần tử lẻ = " + count;
        }

        private void btnSumOdd_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            int sumOdd = arr.Where(x => x % 2 != 0).Sum();
            lblResult.Text = "Tổng phần tử lẻ = " + sumOdd;
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            lblArray.Text = string.Join("  ", arr);
            lblResult.Text = "Mảng đã sắp xếp tăng dần";
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            if (arr == null) return;
            Array.Sort(arr);
            Array.Reverse(arr);
            lblArray.Text = string.Join("  ", arr);
            lblResult.Text = "Mảng đã sắp xếp giảm dần";
        }
    }
}
