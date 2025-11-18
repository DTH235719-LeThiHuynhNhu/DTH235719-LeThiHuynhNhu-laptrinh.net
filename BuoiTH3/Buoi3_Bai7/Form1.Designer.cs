namespace Buoi3_Bai7
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHEP TOAN DON GIAN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(434, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 207);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "b:";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(88, 52);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(230, 44);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(88, 112);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(230, 44);
            this.txtB.TabIndex = 3;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(522, 458);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(230, 44);
            this.txtKQ.TabIndex = 4;
            this.txtKQ.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kết quả:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 42);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1200, 42);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "Tính toán";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tongToolStripMenuItem,
            this.hieuToolStripMenuItem,
            this.tichToolStripMenuItem,
            this.thuongToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(136, 38);
            this.ToolStripMenuItem.Text = "Tính toán";
            // 
            // tongToolStripMenuItem
            // 
            this.tongToolStripMenuItem.Name = "tongToolStripMenuItem";
            this.tongToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.tongToolStripMenuItem.Text = "Tổng";
            this.tongToolStripMenuItem.Click += new System.EventHandler(this.tongToolStripMenuItem_Click_1);
            // 
            // hieuToolStripMenuItem
            // 
            this.hieuToolStripMenuItem.Name = "hieuToolStripMenuItem";
            this.hieuToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.hieuToolStripMenuItem.Text = "Hiệu";
            this.hieuToolStripMenuItem.Click += new System.EventHandler(this.hieuToolStripMenuItem_Click_1);
            // 
            // tichToolStripMenuItem
            // 
            this.tichToolStripMenuItem.Name = "tichToolStripMenuItem";
            this.tichToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.tichToolStripMenuItem.Text = "Tích";
            this.tichToolStripMenuItem.Click += new System.EventHandler(this.tichToolStripMenuItem_Click_1);
            // 
            // thuongToolStripMenuItem
            // 
            this.thuongToolStripMenuItem.Name = "thuongToolStripMenuItem";
            this.thuongToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.thuongToolStripMenuItem.Text = "Thương";
            this.thuongToolStripMenuItem.Click += new System.EventHandler(this.thuongToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 648);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Bai 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuongToolStripMenuItem;
    }
}

