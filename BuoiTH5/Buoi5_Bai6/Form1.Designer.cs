namespace Buoi5_Bai6
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
            this.rbNhapXuat = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbListEven = new System.Windows.Forms.RadioButton();
            this.rbLastEven = new System.Windows.Forms.RadioButton();
            this.rbSumOdd = new System.Windows.Forms.RadioButton();
            this.rbSumEven = new System.Windows.Forms.RadioButton();
            this.rbCountEven = new System.Windows.Forms.RadioButton();
            this.rbCountOdd = new System.Windows.Forms.RadioButton();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblMangGoc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCountOdd);
            this.groupBox1.Controls.Add(this.rbCountEven);
            this.groupBox1.Controls.Add(this.rbSumEven);
            this.groupBox1.Controls.Add(this.rbSumOdd);
            this.groupBox1.Controls.Add(this.rbLastEven);
            this.groupBox1.Controls.Add(this.rbListEven);
            this.groupBox1.Controls.Add(this.rbMin);
            this.groupBox1.Controls.Add(this.rbNhapXuat);
            this.groupBox1.Location = new System.Drawing.Point(55, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(877, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn chức năng:";
            // 
            // rbNhapXuat
            // 
            this.rbNhapXuat.AutoSize = true;
            this.rbNhapXuat.Location = new System.Drawing.Point(43, 67);
            this.rbNhapXuat.Name = "rbNhapXuat";
            this.rbNhapXuat.Size = new System.Drawing.Size(300, 40);
            this.rbNhapXuat.TabIndex = 0;
            this.rbNhapXuat.TabStop = true;
            this.rbNhapXuat.Text = "Nhập và Xuất Mảng";
            this.rbNhapXuat.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(43, 135);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(327, 40);
            this.rbMin.TabIndex = 1;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Tìm Giá Trị Nhỏ Nhất";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbListEven
            // 
            this.rbListEven.AutoSize = true;
            this.rbListEven.Location = new System.Drawing.Point(43, 210);
            this.rbListEven.Name = "rbListEven";
            this.rbListEven.Size = new System.Drawing.Size(313, 40);
            this.rbListEven.TabIndex = 2;
            this.rbListEven.TabStop = true;
            this.rbListEven.Text = "Liệt Kê Giá Trị Chẵn";
            this.rbListEven.UseVisualStyleBackColor = true;
            // 
            // rbLastEven
            // 
            this.rbLastEven.AutoSize = true;
            this.rbLastEven.Location = new System.Drawing.Point(43, 283);
            this.rbLastEven.Name = "rbLastEven";
            this.rbLastEven.Size = new System.Drawing.Size(355, 40);
            this.rbLastEven.TabIndex = 3;
            this.rbLastEven.TabStop = true;
            this.rbLastEven.Text = "Tìm Số Chẵn Cuối Cùng";
            this.rbLastEven.UseVisualStyleBackColor = true;
            // 
            // rbSumOdd
            // 
            this.rbSumOdd.AutoSize = true;
            this.rbSumOdd.Location = new System.Drawing.Point(535, 67);
            this.rbSumOdd.Name = "rbSumOdd";
            this.rbSumOdd.Size = new System.Drawing.Size(251, 40);
            this.rbSumOdd.TabIndex = 4;
            this.rbSumOdd.TabStop = true;
            this.rbSumOdd.Text = "Tổng Giá Trị Lẻ";
            this.rbSumOdd.UseVisualStyleBackColor = true;
            // 
            // rbSumEven
            // 
            this.rbSumEven.AutoSize = true;
            this.rbSumEven.Location = new System.Drawing.Point(535, 135);
            this.rbSumEven.Name = "rbSumEven";
            this.rbSumEven.Size = new System.Drawing.Size(283, 40);
            this.rbSumEven.TabIndex = 5;
            this.rbSumEven.TabStop = true;
            this.rbSumEven.Text = "Tổng Giá Trị Chẵn";
            this.rbSumEven.UseVisualStyleBackColor = true;
            // 
            // rbCountEven
            // 
            this.rbCountEven.AutoSize = true;
            this.rbCountEven.Location = new System.Drawing.Point(535, 210);
            this.rbCountEven.Name = "rbCountEven";
            this.rbCountEven.Size = new System.Drawing.Size(312, 40);
            this.rbCountEven.TabIndex = 6;
            this.rbCountEven.TabStop = true;
            this.rbCountEven.Text = "Đếm Số Lượng Chẵn";
            this.rbCountEven.UseVisualStyleBackColor = true;
            // 
            // rbCountOdd
            // 
            this.rbCountOdd.AutoSize = true;
            this.rbCountOdd.Location = new System.Drawing.Point(535, 283);
            this.rbCountOdd.Name = "rbCountOdd";
            this.rbCountOdd.Size = new System.Drawing.Size(280, 40);
            this.rbCountOdd.TabIndex = 7;
            this.rbCountOdd.TabStop = true;
            this.rbCountOdd.Text = "Đếm Số Lượng Lẻ";
            this.rbCountOdd.UseVisualStyleBackColor = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(197, 791);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(201, 74);
            this.btnThucHien.TabIndex = 1;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(548, 791);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(201, 74);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMangGoc);
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Location = new System.Drawing.Point(28, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(952, 151);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(65, 57);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 42);
            this.lblResult.TabIndex = 0;
            // 
            // lblMangGoc
            // 
            this.lblMangGoc.AutoSize = true;
            this.lblMangGoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMangGoc.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMangGoc.Location = new System.Drawing.Point(395, 23);
            this.lblMangGoc.Name = "lblMangGoc";
            this.lblMangGoc.Size = new System.Drawing.Size(2, 44);
            this.lblMangGoc.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1001, 970);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Working With Array";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNhapXuat;
        private System.Windows.Forms.RadioButton rbCountOdd;
        private System.Windows.Forms.RadioButton rbCountEven;
        private System.Windows.Forms.RadioButton rbSumEven;
        private System.Windows.Forms.RadioButton rbSumOdd;
        private System.Windows.Forms.RadioButton rbLastEven;
        private System.Windows.Forms.RadioButton rbListEven;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblMangGoc;
    }
}

