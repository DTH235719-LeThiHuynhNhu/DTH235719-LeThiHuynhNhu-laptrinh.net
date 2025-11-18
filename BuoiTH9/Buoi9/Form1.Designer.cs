namespace Buoi9
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mởFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraSốHoànHảoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số N:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởFormToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mởFormToolStripMenuItem
            // 
            this.mởFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kiểmTraSốHoànHảoToolStripMenuItem,
            this.tạoMảngToolStripMenuItem});
            this.mởFormToolStripMenuItem.Name = "mởFormToolStripMenuItem";
            this.mởFormToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.mởFormToolStripMenuItem.Text = "Mở Form";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(95, 38);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // kiểmTraSốHoànHảoToolStripMenuItem
            // 
            this.kiểmTraSốHoànHảoToolStripMenuItem.Name = "kiểmTraSốHoànHảoToolStripMenuItem";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Size = new System.Drawing.Size(375, 44);
            this.kiểmTraSốHoànHảoToolStripMenuItem.Text = "Kiểm tra số hoàn hảo";
            this.kiểmTraSốHoànHảoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraSốHoànHảoToolStripMenuItem_Click);
            // 
            // tạoMảngToolStripMenuItem
            // 
            this.tạoMảngToolStripMenuItem.Name = "tạoMảngToolStripMenuItem";
            this.tạoMảngToolStripMenuItem.Size = new System.Drawing.Size(375, 44);
            this.tạoMảngToolStripMenuItem.Text = "Tạo mảng";
            this.tạoMảngToolStripMenuItem.Click += new System.EventHandler(this.tạoMảngToolStripMenuItem_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(281, 118);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(305, 31);
            this.txtN.TabIndex = 2;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(70, 225);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(282, 49);
            this.btnKiemTra.TabIndex = 3;
            this.btnKiemTra.Text = "Kiểm Tra Số Hoàn Hảo";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.Location = new System.Drawing.Point(415, 225);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(282, 49);
            this.btnTaoMang.TabIndex = 4;
            this.btnTaoMang.Text = "Tạo Mảng";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(105, 309);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(201, 56);
            this.btnLamLai.TabIndex = 5;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(478, 309);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 56);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form Chính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mởFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraSốHoànHảoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMảngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
    }
}

