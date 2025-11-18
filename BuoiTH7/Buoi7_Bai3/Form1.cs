using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai3
{
    public partial class Form1 : Form
    {
        string[] dsAnh;          // Mảng chứa danh sách đường dẫn ảnh
        int chiSoHienTai = 0;    // Vị trí ảnh hiện tại
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 2000; // đổi ảnh mỗi 2 giây
            timer.Tick += Timer_Tick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void btnMoDanhSach_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string path = dlg.SelectedPath;

                    dsAnh = Directory.GetFiles(path)
                        .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                                 || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                                 || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                                 || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                                 || f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                        .ToArray();

                    if (dsAnh.Length == 0)
                    {
                        MessageBox.Show("Thư mục không chứa hình ảnh!", "Thông báo");
                        return;
                    }

                    chiSoHienTai = 0;
                    picAnh.Image = Image.FromFile(dsAnh[chiSoHienTai]);
                }
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (dsAnh == null || dsAnh.Length == 0) return;

            chiSoHienTai++;
            if (chiSoHienTai >= dsAnh.Length) chiSoHienTai = 0;

            picAnh.Image = Image.FromFile(dsAnh[chiSoHienTai]);
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (dsAnh == null || dsAnh.Length == 0) return;

            chiSoHienTai--;
            if (chiSoHienTai < 0) chiSoHienTai = dsAnh.Length - 1;

            picAnh.Image = Image.FromFile(dsAnh[chiSoHienTai]);
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (dsAnh == null || dsAnh.Length == 0)
            {
                MessageBox.Show("Vui lòng mở danh sách hình trước!", "Thông báo");
                return;
            }

            timer.Start();
        }
        // 🔴 Tự động đổi ảnh
        private void Timer_Tick(object sender, EventArgs e)
        {
            btnSau.PerformClick(); // Gọi lại sự kiện “Sau >>”
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
