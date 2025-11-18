using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai4
{
    public partial class Form1 : Form
    {
        private const int SO_GHE = 30;
        private const int GIA_VE = 100000;

        // Danh sách ghế đã bán
        private List<int> gheDaBan = new List<int> { 1, 2, 3, 5 };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Vé xe";
            this.BackColor = Color.WhiteSmoke;
            TaoSoDoGhe();
        }

        private void TaoSoDoGhe()
        {
            flowGhe.Controls.Clear();

            for (int i = 1; i <= SO_GHE; i++)
            {
                Label ghe = new Label();
                ghe.Text = i.ToString();
                ghe.TextAlign = ContentAlignment.MiddleCenter;
                ghe.Font = new Font("Arial", 10, FontStyle.Bold);
                ghe.Width = 50;
                ghe.Height = 40;
                ghe.Margin = new Padding(5);
                ghe.BorderStyle = BorderStyle.FixedSingle;
                ghe.ForeColor = Color.Red;

                // ghế đã bán
                if (gheDaBan.Contains(i))
                    ghe.BackColor = Color.Yellow;
                else
                    ghe.BackColor = Color.White;

                ghe.Click += Ghe_Click;
                flowGhe.Controls.Add(ghe);
            }
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            Label ghe = sender as Label;

            // ghế đã bán
            if (ghe.BackColor == Color.Yellow)
            {
                MessageBox.Show($"Ghế số {ghe.Text} đã bán!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ghế đang chọn → bỏ chọn
            if (ghe.BackColor == Color.Blue)
                ghe.BackColor = Color.White;
            else
                ghe.BackColor = Color.Blue;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int soGheChon = 0;
            foreach (Label ghe in flowGhe.Controls)
            {
                if (ghe.BackColor == Color.Blue)
                {
                    ghe.BackColor = Color.Yellow; // chuyển sang đã bán
                    soGheChon++;
                    gheDaBan.Add(int.Parse(ghe.Text));
                }
            }
            int thanhTien = soGheChon * GIA_VE;
            lblThanhTien.Text = thanhTien.ToString("N0") + " VND";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            foreach (Label ghe in flowGhe.Controls)
            {
                if (ghe.BackColor == Color.Blue)
                    ghe.BackColor = Color.White;
            }
            lblThanhTien.Text = "0 VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

