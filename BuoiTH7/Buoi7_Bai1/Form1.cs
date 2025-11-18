using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi7_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(char c = 'A'; c <= 'Z'; c++)
            {
                TreeNode node = new TreeNode(c.ToString());
                treeView1.Nodes.Add(node);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten =txtTen.Text.Trim();
            string ho =txtHo.Text.Trim();
            if (string.IsNullOrEmpty(ten)) {
                MessageBox.Show("Vui lòng nhập tên!", "Thông báo");
                return; 
            }

            string hoten = ten;
            if (!string.IsNullOrEmpty(ho)) { hoten += ", " + ho; }

            char firstChar = char.ToUpper(ten[0]);

            foreach (TreeNode node in treeView1.Nodes)
            {
                if (node.Text == firstChar.ToString())
                {
                    node.Nodes.Add(hoten);
                    node.Expand();
                    txtTen.Clear();
                    txtHo.Clear();
                    txtTen.Focus();
                    return;
                }
            }

            MessageBox.Show("Khong tim thay nhom phu hop cho ky tu dau ten!!!");
        }
    }
}
