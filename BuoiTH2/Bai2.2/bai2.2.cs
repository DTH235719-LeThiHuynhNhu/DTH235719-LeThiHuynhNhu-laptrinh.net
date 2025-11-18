using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lblMessage = new Label();
            lblMessage.Text = "Xin chao, chuc mot ngay vui ve";
            lblMessage.Font = new Font("Segoe UI", 14, FontStyle.Regular);
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(
                (this.ClientSize.Width - lblMessage.Width) / 2,
                (this.ClientSize.Height - lblMessage.Height) / 2
            );
            this.Controls.Add(lblMessage);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
