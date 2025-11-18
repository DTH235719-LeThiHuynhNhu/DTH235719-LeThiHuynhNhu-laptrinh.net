using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Buoi11_QLHS
{
    public partial class Form1 : Form
    {
        string connStr = "Data Source=TraMy\\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";
        SqlConnection conn;
        DataSet ds;
        SqlDataAdapter daHocSinh, daQueQuan;
        bool themMoi = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connStr);
            ds = new DataSet();

            // Nạp dữ liệu bảng quequan
            daQueQuan = new SqlDataAdapter("SELECT * FROM quequan", conn);
            daQueQuan.Fill(ds, "quequan");
            cboQueQuan.DataSource = ds.Tables["quequan"];
            cboQueQuan.DisplayMember = "tenqq";
            cboQueQuan.ValueMember = "maqq";

            // Nạp dữ liệu bảng hocsinh
            daHocSinh = new SqlDataAdapter("SELECT * FROM hocsinh", conn);
            daHocSinh.Fill(ds, "hocsinh");
            dgvHocSinh.DataSource = ds.Tables["hocsinh"];

            dgvHocSinh.SelectionChanged += dgvHocSinh_SelectionChanged;

            // Hiển thị dòng đầu tiên
            if (dgvHocSinh.Rows.Count > 0)
                dgvHocSinh.Rows[0].Selected = true;

            // Khởi tạo trạng thái nút
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        // Khi chọn 1 dòng trên DataGridView
        private void dgvHocSinh_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHocSinh.CurrentRow != null)
            {
                DataRowView drv = (DataRowView)dgvHocSinh.CurrentRow.DataBoundItem;
                txtMaHS.Text = drv["mahs"].ToString();
                txtHoLot.Text = drv["holot"].ToString();
                txtTenHS.Text = drv["tenhs"].ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(drv["ngaysinh"]);
                cboQueQuan.SelectedValue = drv["maqq"];
                rdbNam.Checked = drv["phai"].ToString() == "Nam";
                rdbNu.Checked = drv["phai"].ToString() == "Nữ";
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themMoi = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)dgvHocSinh.CurrentRow.DataBoundItem;
                drv.Row.Delete();

                SqlCommandBuilder builder = new SqlCommandBuilder(daHocSinh);
                daHocSinh.Update(ds, "hocsinh");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (themMoi)
            {
                DataRow row = ds.Tables["hocsinh"].NewRow();
                row["mahs"] = txtMaHS.Text;
                row["holot"] = txtHoLot.Text;
                row["tenhs"] = txtTenHS.Text;
                row["phai"] = rdbNam.Checked ? "Nam" : "Nữ";
                row["ngaysinh"] = dtpNgaySinh.Value;
                row["maqq"] = cboQueQuan.SelectedValue;
                ds.Tables["hocsinh"].Rows.Add(row);
            }
            else
            {
                DataRowView drv = (DataRowView)dgvHocSinh.CurrentRow.DataBoundItem;
                drv["holot"] = txtHoLot.Text;
                drv["tenhs"] = txtTenHS.Text;
                drv["phai"] = rdbNam.Checked ? "Nam" : "Nữ";
                drv["ngaysinh"] = dtpNgaySinh.Value;
                drv["maqq"] = cboQueQuan.SelectedValue;
            }

            SqlCommandBuilder builder = new SqlCommandBuilder(daHocSinh);
            daHocSinh.Update(ds, "hocsinh");

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            themMoi = false;

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["hocsinh"].RejectChanges();
            if (dgvHocSinh.Rows.Count > 0)
                dgvHocSinh.Rows[0].Selected = true;

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            themMoi = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themMoi = true;
            txtMaHS.Clear();
            txtHoLot.Clear();
            txtTenHS.Clear();
            rdbNam.Checked = true;
            dtpNgaySinh.Value = DateTime.Now;
            if (cboQueQuan.Items.Count > 0)
                cboQueQuan.SelectedIndex = 0;

            txtMaHS.Focus();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
    }
}
