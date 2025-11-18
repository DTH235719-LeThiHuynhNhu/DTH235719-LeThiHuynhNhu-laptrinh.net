namespace Buoi5_Bai7
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNhapMang = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.TextBox();
            this.btnXuatMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongMang = new System.Windows.Forms.TextBox();
            this.txtTongChan = new System.Windows.Forms.TextBox();
            this.txtTongLe = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThayThe = new System.Windows.Forms.Button();
            this.txtSoThayThe = new System.Windows.Forms.TextBox();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.rdoTang = new System.Windows.Forms.RadioButton();
            this.rdoGiam = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(403, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "MẢNG SỐ NGUYÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mảng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // txtNhapMang
            // 
            this.txtNhapMang.Location = new System.Drawing.Point(284, 117);
            this.txtNhapMang.Name = "txtNhapMang";
            this.txtNhapMang.Size = new System.Drawing.Size(713, 44);
            this.txtNhapMang.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Location = new System.Drawing.Point(284, 185);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(713, 44);
            this.lblKetQua.TabIndex = 4;
            // 
            // btnXuatMang
            // 
            this.btnXuatMang.Location = new System.Drawing.Point(1053, 101);
            this.btnXuatMang.Name = "btnXuatMang";
            this.btnXuatMang.Size = new System.Drawing.Size(178, 72);
            this.btnXuatMang.TabIndex = 5;
            this.btnXuatMang.Text = "Xuất Mảng";
            this.btnXuatMang.UseVisualStyleBackColor = true;
            this.btnXuatMang.Click += new System.EventHandler(this.btnXuatMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(1053, 191);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(178, 72);
            this.btnLamLai.TabIndex = 6;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTong);
            this.groupBox1.Controls.Add(this.txtTongLe);
            this.groupBox1.Controls.Add(this.txtTongChan);
            this.groupBox1.Controls.Add(this.txtTongMang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(48, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 267);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng Mảng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng Chẵn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tổng Lẻ:";
            // 
            // txtTongMang
            // 
            this.txtTongMang.Location = new System.Drawing.Point(197, 68);
            this.txtTongMang.Name = "txtTongMang";
            this.txtTongMang.Size = new System.Drawing.Size(141, 44);
            this.txtTongMang.TabIndex = 3;
            // 
            // txtTongChan
            // 
            this.txtTongChan.Location = new System.Drawing.Point(197, 124);
            this.txtTongChan.Name = "txtTongChan";
            this.txtTongChan.Size = new System.Drawing.Size(141, 44);
            this.txtTongChan.TabIndex = 4;
            // 
            // txtTongLe
            // 
            this.txtTongLe.Location = new System.Drawing.Point(197, 193);
            this.txtTongLe.Name = "txtTongLe";
            this.txtTongLe.Size = new System.Drawing.Size(141, 44);
            this.txtTongLe.TabIndex = 5;
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(383, 68);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(92, 164);
            this.btnTong.TabIndex = 6;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtMin);
            this.groupBox2.Controls.Add(this.txtMax);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(644, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 267);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Max Min:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(380, 63);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(92, 164);
            this.btnTim.TabIndex = 6;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(140, 157);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(198, 44);
            this.txtMin.TabIndex = 4;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(140, 68);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(198, 44);
            this.txtMax.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 36);
            this.label8.TabIndex = 1;
            this.label8.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "Max:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThayThe);
            this.groupBox3.Controls.Add(this.txtSoThayThe);
            this.groupBox3.Controls.Add(this.txtViTri);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(644, 608);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 238);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thay Thế:";
            // 
            // btnThayThe
            // 
            this.btnThayThe.Location = new System.Drawing.Point(380, 48);
            this.btnThayThe.Name = "btnThayThe";
            this.btnThayThe.Size = new System.Drawing.Size(92, 164);
            this.btnThayThe.TabIndex = 6;
            this.btnThayThe.Text = "Thay Thế";
            this.btnThayThe.UseVisualStyleBackColor = true;
            this.btnThayThe.Click += new System.EventHandler(this.btnThayThe_Click);
            // 
            // txtSoThayThe
            // 
            this.txtSoThayThe.Location = new System.Drawing.Point(188, 157);
            this.txtSoThayThe.Name = "txtSoThayThe";
            this.txtSoThayThe.Size = new System.Drawing.Size(150, 44);
            this.txtSoThayThe.TabIndex = 4;
            // 
            // txtViTri
            // 
            this.txtViTri.Location = new System.Drawing.Point(221, 68);
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(117, 44);
            this.txtViTri.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số thay thế:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(200, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "Vị trí thay thế:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoGiam);
            this.groupBox4.Controls.Add(this.rdoTang);
            this.groupBox4.Controls.Add(this.btnSapXep);
            this.groupBox4.Location = new System.Drawing.Point(48, 608);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(501, 238);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sắp xếp:";
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(383, 48);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(92, 164);
            this.btnSapXep.TabIndex = 6;
            this.btnSapXep.Text = "Sắp Xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // rdoTang
            // 
            this.rdoTang.AutoSize = true;
            this.rdoTang.Location = new System.Drawing.Point(59, 74);
            this.rdoTang.Name = "rdoTang";
            this.rdoTang.Size = new System.Drawing.Size(208, 40);
            this.rdoTang.TabIndex = 7;
            this.rdoTang.TabStop = true;
            this.rdoTang.Text = "Sắp xếp tăng";
            this.rdoTang.UseVisualStyleBackColor = true;
            // 
            // rdoGiam
            // 
            this.rdoGiam.AutoSize = true;
            this.rdoGiam.Location = new System.Drawing.Point(59, 156);
            this.rdoGiam.Name = "rdoGiam";
            this.rdoGiam.Size = new System.Drawing.Size(216, 40);
            this.rdoGiam.TabIndex = 8;
            this.rdoGiam.TabStop = true;
            this.rdoGiam.Text = "Sắp xếp giảm";
            this.rdoGiam.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(525, 884);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(167, 88);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 987);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXuatMang);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtNhapMang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Mảng Số Nguyên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNhapMang;
        private System.Windows.Forms.TextBox lblKetQua;
        private System.Windows.Forms.Button btnXuatMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.TextBox txtTongLe;
        private System.Windows.Forms.TextBox txtTongChan;
        private System.Windows.Forms.TextBox txtTongMang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThayThe;
        private System.Windows.Forms.TextBox txtSoThayThe;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoGiam;
        private System.Windows.Forms.RadioButton rdoTang;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
    }
}

