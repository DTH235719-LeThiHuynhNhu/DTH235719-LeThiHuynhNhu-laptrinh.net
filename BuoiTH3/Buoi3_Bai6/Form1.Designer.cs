namespace Buoi3_Bai6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstTen = new System.Windows.Forms.ListBox();
            this.txtHienThi = new System.Windows.Forms.TextBox();
            this.btnMau = new System.Windows.Forms.Button();
            this.btnChonNen = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập chuỗi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(3, 22);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(191, 44);
            this.txtNhap.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(16, 85);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(131, 85);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstTen
            // 
            this.lstTen.FormattingEnabled = true;
            this.lstTen.ItemHeight = 36;
            this.lstTen.Location = new System.Drawing.Point(15, 145);
            this.lstTen.Name = "lstTen";
            this.lstTen.Size = new System.Drawing.Size(191, 76);
            this.lstTen.TabIndex = 3;
            this.lstTen.SelectedIndexChanged += new System.EventHandler(this.lstTen_SelectedIndexChanged);
            // 
            // txtHienThi
            // 
            this.txtHienThi.Location = new System.Drawing.Point(261, 21);
            this.txtHienThi.Multiline = true;
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(388, 131);
            this.txtHienThi.TabIndex = 4;
            // 
            // btnMau
            // 
            this.btnMau.Location = new System.Drawing.Point(273, 166);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(109, 39);
            this.btnMau.TabIndex = 5;
            this.btnMau.Text = "Chọn màu chữ";
            this.btnMau.UseVisualStyleBackColor = true;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnChonNen
            // 
            this.btnChonNen.Location = new System.Drawing.Point(405, 166);
            this.btnChonNen.Name = "btnChonNen";
            this.btnChonNen.Size = new System.Drawing.Size(109, 39);
            this.btnChonNen.TabIndex = 6;
            this.btnChonNen.Text = "Chọn màu nền";
            this.btnChonNen.UseVisualStyleBackColor = true;
            this.btnChonNen.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(537, 166);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(112, 39);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Chọn Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(405, 211);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 33);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 418);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnChonNen);
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.lstTen);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Controls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lstTen;
        private System.Windows.Forms.TextBox txtHienThi;
        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.Button btnChonNen;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnDong;
    }
}

