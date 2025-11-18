namespace Buoi6_Bai2
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.grpLop = new System.Windows.Forms.GroupBox();
            this.rdbLopA = new System.Windows.Forms.RadioButton();
            this.rdbLopB = new System.Windows.Forms.RadioButton();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnSangB = new System.Windows.Forms.Button();
            this.btnSangA = new System.Windows.Forms.Button();
            this.btnAllSangB = new System.Windows.Forms.Button();
            this.btnAllSangA = new System.Windows.Forms.Button();
            this.btnTongSV = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpLop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(160, 68);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(656, 31);
            this.txtHoTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(909, 56);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 54);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grpLop
            // 
            this.grpLop.Controls.Add(this.rdbLopB);
            this.grpLop.Controls.Add(this.rdbLopA);
            this.grpLop.Location = new System.Drawing.Point(326, 151);
            this.grpLop.Name = "grpLop";
            this.grpLop.Size = new System.Drawing.Size(403, 100);
            this.grpLop.TabIndex = 3;
            this.grpLop.TabStop = false;
            this.grpLop.Text = "Chọn lớp";
            // 
            // rdbLopA
            // 
            this.rdbLopA.AutoSize = true;
            this.rdbLopA.Location = new System.Drawing.Point(22, 45);
            this.rdbLopA.Name = "rdbLopA";
            this.rdbLopA.Size = new System.Drawing.Size(99, 29);
            this.rdbLopA.TabIndex = 0;
            this.rdbLopA.TabStop = true;
            this.rdbLopA.Text = "Lớp A";
            this.rdbLopA.UseVisualStyleBackColor = true;
            // 
            // rdbLopB
            // 
            this.rdbLopB.AutoSize = true;
            this.rdbLopB.Location = new System.Drawing.Point(233, 45);
            this.rdbLopB.Name = "rdbLopB";
            this.rdbLopB.Size = new System.Drawing.Size(99, 29);
            this.rdbLopB.TabIndex = 1;
            this.rdbLopB.TabStop = true;
            this.rdbLopB.Text = "Lớp B";
            this.rdbLopB.UseVisualStyleBackColor = true;
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 25;
            this.lstLopA.Location = new System.Drawing.Point(49, 281);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopA.Size = new System.Drawing.Size(346, 304);
            this.lstLopA.TabIndex = 4;
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 25;
            this.lstLopB.Location = new System.Drawing.Point(712, 281);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLopB.Size = new System.Drawing.Size(346, 304);
            this.lstLopB.TabIndex = 5;
            // 
            // btnSangB
            // 
            this.btnSangB.Location = new System.Drawing.Point(491, 300);
            this.btnSangB.Name = "btnSangB";
            this.btnSangB.Size = new System.Drawing.Size(122, 51);
            this.btnSangB.TabIndex = 6;
            this.btnSangB.Text = ">";
            this.btnSangB.UseVisualStyleBackColor = true;
            this.btnSangB.Click += new System.EventHandler(this.btnSangB_Click);
            // 
            // btnSangA
            // 
            this.btnSangA.Location = new System.Drawing.Point(491, 368);
            this.btnSangA.Name = "btnSangA";
            this.btnSangA.Size = new System.Drawing.Size(122, 51);
            this.btnSangA.TabIndex = 7;
            this.btnSangA.Text = "<";
            this.btnSangA.UseVisualStyleBackColor = true;
            this.btnSangA.Click += new System.EventHandler(this.btnSangA_Click);
            // 
            // btnAllSangB
            // 
            this.btnAllSangB.Location = new System.Drawing.Point(491, 442);
            this.btnAllSangB.Name = "btnAllSangB";
            this.btnAllSangB.Size = new System.Drawing.Size(122, 51);
            this.btnAllSangB.TabIndex = 8;
            this.btnAllSangB.Text = ">>";
            this.btnAllSangB.UseVisualStyleBackColor = true;
            this.btnAllSangB.Click += new System.EventHandler(this.btnAllSangB_Click);
            // 
            // btnAllSangA
            // 
            this.btnAllSangA.Location = new System.Drawing.Point(491, 509);
            this.btnAllSangA.Name = "btnAllSangA";
            this.btnAllSangA.Size = new System.Drawing.Size(122, 51);
            this.btnAllSangA.TabIndex = 9;
            this.btnAllSangA.Text = "<<";
            this.btnAllSangA.UseVisualStyleBackColor = true;
            this.btnAllSangA.Click += new System.EventHandler(this.btnAllSangA_Click);
            // 
            // btnTongSV
            // 
            this.btnTongSV.Location = new System.Drawing.Point(254, 629);
            this.btnTongSV.Name = "btnTongSV";
            this.btnTongSV.Size = new System.Drawing.Size(236, 63);
            this.btnTongSV.TabIndex = 10;
            this.btnTongSV.Text = "Tống số sinh viên";
            this.btnTongSV.UseVisualStyleBackColor = true;
            this.btnTongSV.Click += new System.EventHandler(this.btnTongSV_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(650, 629);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(166, 63);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1152, 756);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTongSV);
            this.Controls.Add(this.btnAllSangA);
            this.Controls.Add(this.btnAllSangB);
            this.Controls.Add(this.btnSangA);
            this.Controls.Add(this.btnSangB);
            this.Controls.Add(this.lstLopB);
            this.Controls.Add(this.lstLopA);
            this.Controls.Add(this.grpLop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.grpLop.ResumeLayout(false);
            this.grpLop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grpLop;
        private System.Windows.Forms.RadioButton rdbLopB;
        private System.Windows.Forms.RadioButton rdbLopA;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnSangB;
        private System.Windows.Forms.Button btnSangA;
        private System.Windows.Forms.Button btnAllSangB;
        private System.Windows.Forms.Button btnAllSangA;
        private System.Windows.Forms.Button btnTongSV;
        private System.Windows.Forms.Button btnThoat;
    }
}

