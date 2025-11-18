using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Khởi tạo các địa chỉ trong ComboBox
            comboBoxAddress.Items.Add("An Giang");
            comboBoxAddress.Items.Add("Hà Nội");
            comboBoxAddress.Items.Add("Cần Thơ");
            comboBoxAddress.Items.Add("Đồng Tháp");
            comboBoxAddress.Items.Add("Thái Bình");
            comboBoxAddress.Items.Add("Ninh Bình");
            comboBoxAddress.Items.Add("TP Hồ Chí Minh");
            
            comboBoxAddress.SelectedIndex = 0;

            // Thiết lập chế độ xem chi tiết cho ListView

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Mã SV", 80);
            listView1.Columns.Add("Họ và tên", 150);
            listView1.Columns.Add("Ngày sinh", 100);
            listView1.Columns.Add("Phái", 60);
            listView1.Columns.Add("Điện thoại", 100);
            listView1.Columns.Add("Quê quán", 120);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thoát", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo");
                return;
            }

            string gender = radioMale.Checked ? "Nam" : radioFemale.Checked ? "Nữ" : "";

            ListViewItem item = new ListViewItem(txtID.Text);
            item.SubItems.Add(txtName.Text);
            item.SubItems.Add(dateTimePickerBirth.Value.ToShortDateString());
            item.SubItems.Add(gender);
            item.SubItems.Add(txtPhone.Text);
            item.SubItems.Add(comboBoxAddress.Text);

            listView1.Items.Add(item);
            ClearInputs();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtID.Text = item.SubItems[0].Text;
                txtName.Text = item.SubItems[1].Text;
                dateTimePickerBirth.Value = DateTime.Parse(item.SubItems[2].Text);

                if (item.SubItems[3].Text == "Nam")
                    radioMale.Checked = true;
                else
                    radioFemale.Checked = true;

                txtPhone.Text = item.SubItems[4].Text;
                comboBoxAddress.Text = item.SubItems[5].Text;
            }
        }

        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            dateTimePickerBirth.Value = DateTime.Now;
            radioMale.Checked = false;
            radioFemale.Checked = false;
            txtPhone.Clear();
            comboBoxAddress.SelectedIndex = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Cảnh báo");
                return;
            }

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            ClearInputs();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", "Cảnh báo");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Họ và tên không được để trống!", "Cảnh báo");
                return;
            }

            string gender = radioMale.Checked ? "Nam" : radioFemale.Checked ? "Nữ" : "";

            ListViewItem selectedItem = listView1.SelectedItems[0];
            selectedItem.SubItems[0].Text = txtID.Text;
            selectedItem.SubItems[1].Text = txtName.Text;
            selectedItem.SubItems[2].Text = dateTimePickerBirth.Value.ToShortDateString();
            selectedItem.SubItems[3].Text = gender;
            selectedItem.SubItems[4].Text = txtPhone.Text;
            selectedItem.SubItems[5].Text = comboBoxAddress.Text;

            ClearInputs();
        }
    }
}
