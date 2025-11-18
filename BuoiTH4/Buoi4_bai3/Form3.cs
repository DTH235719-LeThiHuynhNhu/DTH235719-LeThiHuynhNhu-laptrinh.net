using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_bai3
{
    public partial class Form3 : Form
    {
        int[] c;
        public Form3(int[] a)
        {
            InitializeComponent();
            c = new int[a.Length];
            Array.Copy(a, c, a.Length);

            int max = TimSoLonNhat(c);
            lblKetQua.Text = $"Số lớn nhất trong mảng là: {max}";
        }
        public int TimSoLonNhat(int[] arr)
        {
            int max = arr[0];
            foreach (int x in arr)
                if (x > max)
                    max = x;
            return max;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
