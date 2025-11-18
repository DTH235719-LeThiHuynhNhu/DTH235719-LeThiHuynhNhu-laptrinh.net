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

namespace Buoi10_QLNV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            string strConn = @"Data Source=TraMy\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            // Load dữ liệu bảng Chức Vụ
            daChucVu = new SqlDataAdapter("SELECT * FROM ChucVu", conn);
            daChucVu.Fill(ds, "tblChucVu");
            // Load dữ liệu bảng Nhân Viên
            daNhanVien = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            // Thiết lập quan hệ giữa 2 bảng
            ds.Relations.Add("FK_ChucVu_NhanVien",
                ds.Tables["ChucVu"].Columns["MaCV"],
                ds.Tables["NhanVien"].Columns["MaCV"]);
            // Hiển thị dữ liệu lên ComboBox Chức Vụ
            cboChucVu.DataSource = ds.Tables["ChucVu"];
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
            // Hiển thị dữ liệu lên DataGridView Nhân Viên
            dgvNhanVien.DataSource = ds.Tables["NhanVien"];

            // Command Thêm nhân viên 
            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, 
@NgaySinh, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,
            "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");

            daNhanVien.InsertCommand = cmThemNV;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();       
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // 1️⃣ Kiểm tra dữ liệu hợp lệ
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Mã nhân viên không được để trống!", "Thông báo");
                txtMaNV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoLot.Text) || string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Họ lót và tên không được để trống!", "Thông báo");
                return;
            }

            if (cboChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chức vụ!", "Thông báo");
                return;
            }

            // 2️⃣ Kiểm tra mã nhân viên trùng trong DataTable
            DataTable tbl = ds.Tables["tblDSNhanVien"];
            string maNV = txtMaNV.Text.Trim();

            foreach (DataRow r in tbl.Rows)
            {
                if (r.RowState != DataRowState.Deleted && r["manv"].ToString() == maNV)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại!", "Lỗi");
                    txtMaNV.Focus();
                    return;
                }
            }

            // 3️⃣ Thêm dòng mới vào DataTable
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaNV.Text.Trim();
            row["holot"] = txtHoLot.Text.Trim();
            row["tennv"] = txtTen.Text.Trim();
            row["phai"] = radNu.Checked ? "Nữ" : "Nam";
            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;
            row["tencv"] = cboChucVu.Text;   // tên chức vụ hiển thị

            ds.Tables["tblDSNhanVien"].Rows.Add(row);

            // 4️⃣ Thông báo và reset form
            MessageBox.Show("Đã thêm nhân viên mới (chưa lưu vào CSDL)!", "Thông báo");
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            radNam.Checked = true;
            cboChucVu.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Today;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(daNhanVien);
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Đã lưu thay đổi xuống cơ sở dữ liệu!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgvNhanVien.SelectedRows[0];
                dgvNhanVien.Rows.Remove(r); // Xóa dòng trong DataGridView + DataTable
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
                dr.Cells["holot"].Value = txtHoLot.Text;
                dr.Cells["tennv"].Value = txtTen.Text;
                dr.Cells["phai"].Value = radNu.Checked ? "Nữ" : "Nam";
                dr.Cells["ngaysinh"].Value = dtpNgaySinh.Value;
                dr.Cells["macv"].Value = cboChucVu.SelectedValue;
                dr.Cells["tencv"].Value = cboChucVu.Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hỏi người dùng có chắc chắn muốn hủy thay đổi không
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy các thay đổi chưa lưu không?",
                                                  "Xác nhận", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            // Hủy bỏ mọi thay đổi trên DataSet (nếu chưa Update xuống DB)
            ds.Tables["tblDSNhanVien"].RejectChanges();

            // Xóa dữ liệu hiện tại trên DataSet
            ds.Tables["tblDSNhanVien"].Clear();

            // Nạp lại dữ liệu gốc từ CSDL
            SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=QLNV;Integrated Security=True");
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");

            // Gán lại DataSource cho DataGrid
            dgvNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

            MessageBox.Show("Đã hủy các thay đổi và tải lại dữ liệu ban đầu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
