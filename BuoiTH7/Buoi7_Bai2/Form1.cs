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

namespace Buoi7_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Khi mở chương trình, nạp tất cả ổ đĩa vào TreeView
            LoadDrives();
        }
        // 🟢 Nạp danh sách ổ đĩa
        private void LoadDrives()
        {
            tvFolder.Nodes.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                TreeNode node = new TreeNode(drive.Name);
                node.Tag = drive.Name;
                node.Nodes.Add("..."); // nút con giả để có dấu +
                tvFolder.Nodes.Add(node);
            }
        }
        // 🟠 Khi mở rộng 1 node, nạp thư mục con
        private void tvFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            node.Nodes.Clear(); // xóa nút giả

            try
            {
                string path = node.Tag.ToString();
                string[] dirs = Directory.GetDirectories(path);

                foreach (string dir in dirs)
                {
                    TreeNode subNode = new TreeNode(Path.GetFileName(dir));
                    subNode.Tag = dir;
                    subNode.Nodes.Add("..."); // nút giả
                    node.Nodes.Add(subNode);
                }
            }
            catch { }
        }
        private void tvFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag.ToString();
            ShowImages(path);
        }
        // 🟤 Hiển thị danh sách ảnh trong thư mục
        private void ShowImages(string folderPath)
        {
            flpImage.Controls.Clear(); // xóa cũ

            string[] imageFiles;
            try
            {
                imageFiles = Directory.GetFiles(folderPath, "*.*")
                    .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".png", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase)
                             || f.EndsWith(".gif", StringComparison.OrdinalIgnoreCase))
                    .ToArray();
            }
            catch
            {
                return;
            }

            foreach (string file in imageFiles)
            {
                PictureBox pic = new PictureBox();
                pic.Width = 100;
                pic.Height = 80;
                pic.SizeMode = PictureBoxSizeMode.Zoom;
                pic.Image = Image.FromFile(file);
                pic.Tag = file;

                // Khi click vào ảnh nhỏ → hiển thị ảnh lớn
                pic.Click += (s, e) =>
                {
                    picPreview.Image = Image.FromFile((string)((PictureBox)s).Tag);
                };

                flpImage.Controls.Add(pic);
            }
        }
    }
}
