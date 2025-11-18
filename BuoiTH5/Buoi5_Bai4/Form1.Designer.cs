namespace Buoi5_Bai4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbTriangle = new System.Windows.Forms.RadioButton();
            this.rbSquare = new System.Windows.Forms.RadioButton();
            this.rbCircle = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReSet = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCircle = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCircleR = new System.Windows.Forms.TextBox();
            this.txtCirclePerim = new System.Windows.Forms.TextBox();
            this.txtCircleArea = new System.Windows.Forms.TextBox();
            this.grpSquare = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSquareA = new System.Windows.Forms.TextBox();
            this.txtSquarePerim = new System.Windows.Forms.TextBox();
            this.txtSquareArea = new System.Windows.Forms.TextBox();
            this.grpRectangle = new System.Windows.Forms.GroupBox();
            this.txtRectArea = new System.Windows.Forms.TextBox();
            this.txtRectPerim = new System.Windows.Forms.TextBox();
            this.txtRectW = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRectH = new System.Windows.Forms.TextBox();
            this.grpTriangle = new System.Windows.Forms.GroupBox();
            this.txtTriB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTriArea = new System.Windows.Forms.TextBox();
            this.txtTriPerim = new System.Windows.Forms.TextBox();
            this.txtTriA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTriC = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTriType = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpCircle.SuspendLayout();
            this.grpSquare.SuspendLayout();
            this.grpRectangle.SuspendLayout();
            this.grpTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(152, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm Chu Vi và Diện Tích";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(206, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 43);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hình Tròn - Hình Vuông";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(168, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(557, 43);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hình Tam Giác - Hình Chữ Nhật";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbTriangle);
            this.groupBox1.Controls.Add(this.rbSquare);
            this.groupBox1.Controls.Add(this.rbCircle);
            this.groupBox1.Location = new System.Drawing.Point(142, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn:";
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(160, 54);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(223, 40);
            this.rbRectangle.TabIndex = 3;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Hình chữ nhật";
            this.rbRectangle.UseVisualStyleBackColor = true;
            this.rbRectangle.CheckedChanged += new System.EventHandler(this.rbRectangle_CheckedChanged);
            // 
            // rbTriangle
            // 
            this.rbTriangle.AutoSize = true;
            this.rbTriangle.Location = new System.Drawing.Point(160, 25);
            this.rbTriangle.Name = "rbTriangle";
            this.rbTriangle.Size = new System.Drawing.Size(222, 40);
            this.rbTriangle.TabIndex = 2;
            this.rbTriangle.TabStop = true;
            this.rbTriangle.Text = "Hình tam giác";
            this.rbTriangle.UseVisualStyleBackColor = true;
            this.rbTriangle.CheckedChanged += new System.EventHandler(this.rbTriangle_CheckedChanged);
            // 
            // rbSquare
            // 
            this.rbSquare.AutoSize = true;
            this.rbSquare.Location = new System.Drawing.Point(30, 54);
            this.rbSquare.Name = "rbSquare";
            this.rbSquare.Size = new System.Drawing.Size(192, 40);
            this.rbSquare.TabIndex = 1;
            this.rbSquare.TabStop = true;
            this.rbSquare.Text = "Hình vuông";
            this.rbSquare.UseVisualStyleBackColor = true;
            this.rbSquare.CheckedChanged += new System.EventHandler(this.rbSquare_CheckedChanged);
            // 
            // rbCircle
            // 
            this.rbCircle.AutoSize = true;
            this.rbCircle.Location = new System.Drawing.Point(30, 25);
            this.rbCircle.Name = "rbCircle";
            this.rbCircle.Size = new System.Drawing.Size(167, 40);
            this.rbCircle.TabIndex = 0;
            this.rbCircle.TabStop = true;
            this.rbCircle.Text = "Hình tròn";
            this.rbCircle.UseVisualStyleBackColor = true;
            this.rbCircle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(91, 289);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 33);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Thực Hiện";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReSet
            // 
            this.btnReSet.Location = new System.Drawing.Point(245, 289);
            this.btnReSet.Name = "btnReSet";
            this.btnReSet.Size = new System.Drawing.Size(110, 33);
            this.btnReSet.TabIndex = 8;
            this.btnReSet.Text = "ReSet";
            this.btnReSet.UseVisualStyleBackColor = true;
            this.btnReSet.Click += new System.EventHandler(this.btnReSet_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(399, 289);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 33);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpCircle
            // 
            this.grpCircle.Controls.Add(this.txtCircleArea);
            this.grpCircle.Controls.Add(this.txtCirclePerim);
            this.grpCircle.Controls.Add(this.txtCircleR);
            this.grpCircle.Controls.Add(this.label6);
            this.grpCircle.Controls.Add(this.label4);
            this.grpCircle.Controls.Add(this.label5);
            this.grpCircle.Location = new System.Drawing.Point(53, 347);
            this.grpCircle.Name = "grpCircle";
            this.grpCircle.Size = new System.Drawing.Size(472, 212);
            this.grpCircle.TabIndex = 10;
            this.grpCircle.TabStop = false;
            this.grpCircle.Text = "Hình Tròn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập bán kính R:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chu vi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "Diện tích:";
            // 
            // txtCircleR
            // 
            this.txtCircleR.Location = new System.Drawing.Point(249, 32);
            this.txtCircleR.Name = "txtCircleR";
            this.txtCircleR.Size = new System.Drawing.Size(195, 44);
            this.txtCircleR.TabIndex = 1;
            // 
            // txtCirclePerim
            // 
            this.txtCirclePerim.Location = new System.Drawing.Point(163, 87);
            this.txtCirclePerim.Name = "txtCirclePerim";
            this.txtCirclePerim.ReadOnly = true;
            this.txtCirclePerim.Size = new System.Drawing.Size(281, 44);
            this.txtCirclePerim.TabIndex = 2;
            // 
            // txtCircleArea
            // 
            this.txtCircleArea.Location = new System.Drawing.Point(163, 142);
            this.txtCircleArea.Name = "txtCircleArea";
            this.txtCircleArea.ReadOnly = true;
            this.txtCircleArea.Size = new System.Drawing.Size(281, 44);
            this.txtCircleArea.TabIndex = 3;
            this.txtCircleArea.TextChanged += new System.EventHandler(this.txtCircleArea_TextChanged);
            // 
            // grpSquare
            // 
            this.grpSquare.Controls.Add(this.txtSquareArea);
            this.grpSquare.Controls.Add(this.txtSquarePerim);
            this.grpSquare.Controls.Add(this.txtSquareA);
            this.grpSquare.Controls.Add(this.label9);
            this.grpSquare.Controls.Add(this.label8);
            this.grpSquare.Controls.Add(this.label7);
            this.grpSquare.Location = new System.Drawing.Point(53, 330);
            this.grpSquare.Name = "grpSquare";
            this.grpSquare.Size = new System.Drawing.Size(472, 224);
            this.grpSquare.TabIndex = 12;
            this.grpSquare.TabStop = false;
            this.grpSquare.Text = "Hình Vuông:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nhập cạnh A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 36);
            this.label8.TabIndex = 13;
            this.label8.Text = "Chu vi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 36);
            this.label9.TabIndex = 13;
            this.label9.Text = "Diện tích:";
            // 
            // txtSquareA
            // 
            this.txtSquareA.Location = new System.Drawing.Point(208, 49);
            this.txtSquareA.Name = "txtSquareA";
            this.txtSquareA.Size = new System.Drawing.Size(235, 44);
            this.txtSquareA.TabIndex = 4;
            // 
            // txtSquarePerim
            // 
            this.txtSquarePerim.Location = new System.Drawing.Point(162, 110);
            this.txtSquarePerim.Name = "txtSquarePerim";
            this.txtSquarePerim.ReadOnly = true;
            this.txtSquarePerim.Size = new System.Drawing.Size(281, 44);
            this.txtSquarePerim.TabIndex = 4;
            // 
            // txtSquareArea
            // 
            this.txtSquareArea.Location = new System.Drawing.Point(162, 171);
            this.txtSquareArea.Name = "txtSquareArea";
            this.txtSquareArea.ReadOnly = true;
            this.txtSquareArea.Size = new System.Drawing.Size(281, 44);
            this.txtSquareArea.TabIndex = 14;
            // 
            // grpRectangle
            // 
            this.grpRectangle.Controls.Add(this.txtRectH);
            this.grpRectangle.Controls.Add(this.label13);
            this.grpRectangle.Controls.Add(this.txtRectArea);
            this.grpRectangle.Controls.Add(this.txtRectPerim);
            this.grpRectangle.Controls.Add(this.txtRectW);
            this.grpRectangle.Controls.Add(this.label10);
            this.grpRectangle.Controls.Add(this.label11);
            this.grpRectangle.Controls.Add(this.label12);
            this.grpRectangle.Location = new System.Drawing.Point(52, 331);
            this.grpRectangle.Name = "grpRectangle";
            this.grpRectangle.Size = new System.Drawing.Size(472, 293);
            this.grpRectangle.TabIndex = 15;
            this.grpRectangle.TabStop = false;
            this.grpRectangle.Text = "Hình Chữ Nhật:";
            // 
            // txtRectArea
            // 
            this.txtRectArea.Location = new System.Drawing.Point(177, 220);
            this.txtRectArea.Name = "txtRectArea";
            this.txtRectArea.ReadOnly = true;
            this.txtRectArea.Size = new System.Drawing.Size(256, 44);
            this.txtRectArea.TabIndex = 14;
            // 
            // txtRectPerim
            // 
            this.txtRectPerim.Location = new System.Drawing.Point(177, 159);
            this.txtRectPerim.Name = "txtRectPerim";
            this.txtRectPerim.ReadOnly = true;
            this.txtRectPerim.Size = new System.Drawing.Size(257, 44);
            this.txtRectPerim.TabIndex = 4;
            // 
            // txtRectW
            // 
            this.txtRectW.Location = new System.Drawing.Point(244, 49);
            this.txtRectW.Name = "txtRectW";
            this.txtRectW.Size = new System.Drawing.Size(192, 44);
            this.txtRectW.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 36);
            this.label10.TabIndex = 13;
            this.label10.Text = "Diện tích:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 36);
            this.label11.TabIndex = 13;
            this.label11.Text = "Chu vi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 36);
            this.label12.TabIndex = 4;
            this.label12.Text = "Nhập chiều rộng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(214, 36);
            this.label13.TabIndex = 15;
            this.label13.Text = "Nhập chiều dài:";
            // 
            // txtRectH
            // 
            this.txtRectH.Location = new System.Drawing.Point(244, 104);
            this.txtRectH.Name = "txtRectH";
            this.txtRectH.Size = new System.Drawing.Size(189, 44);
            this.txtRectH.TabIndex = 16;
            // 
            // grpTriangle
            // 
            this.grpTriangle.Controls.Add(this.txtTriType);
            this.grpTriangle.Controls.Add(this.label19);
            this.grpTriangle.Controls.Add(this.txtTriC);
            this.grpTriangle.Controls.Add(this.label18);
            this.grpTriangle.Controls.Add(this.txtTriB);
            this.grpTriangle.Controls.Add(this.label14);
            this.grpTriangle.Controls.Add(this.txtTriArea);
            this.grpTriangle.Controls.Add(this.txtTriPerim);
            this.grpTriangle.Controls.Add(this.txtTriA);
            this.grpTriangle.Controls.Add(this.label15);
            this.grpTriangle.Controls.Add(this.label16);
            this.grpTriangle.Controls.Add(this.label17);
            this.grpTriangle.Location = new System.Drawing.Point(52, 331);
            this.grpTriangle.Name = "grpTriangle";
            this.grpTriangle.Size = new System.Drawing.Size(472, 393);
            this.grpTriangle.TabIndex = 17;
            this.grpTriangle.TabStop = false;
            this.grpTriangle.Text = "Hình Tam Giác:";
            // 
            // txtTriB
            // 
            this.txtTriB.Location = new System.Drawing.Point(192, 104);
            this.txtTriB.Name = "txtTriB";
            this.txtTriB.Size = new System.Drawing.Size(258, 44);
            this.txtTriB.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(182, 36);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nhập cạnh b:";
            // 
            // txtTriArea
            // 
            this.txtTriArea.Location = new System.Drawing.Point(177, 265);
            this.txtTriArea.Name = "txtTriArea";
            this.txtTriArea.ReadOnly = true;
            this.txtTriArea.Size = new System.Drawing.Size(273, 44);
            this.txtTriArea.TabIndex = 14;
            // 
            // txtTriPerim
            // 
            this.txtTriPerim.Location = new System.Drawing.Point(149, 214);
            this.txtTriPerim.Name = "txtTriPerim";
            this.txtTriPerim.ReadOnly = true;
            this.txtTriPerim.Size = new System.Drawing.Size(301, 44);
            this.txtTriPerim.TabIndex = 4;
            // 
            // txtTriA
            // 
            this.txtTriA.Location = new System.Drawing.Point(192, 49);
            this.txtTriA.Name = "txtTriA";
            this.txtTriA.Size = new System.Drawing.Size(258, 44);
            this.txtTriA.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 36);
            this.label15.TabIndex = 13;
            this.label15.Text = "Diện tích:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 36);
            this.label16.TabIndex = 13;
            this.label16.Text = "Chu vi:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(180, 36);
            this.label17.TabIndex = 4;
            this.label17.Text = "Nhập cạnh a:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 157);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(180, 36);
            this.label18.TabIndex = 17;
            this.label18.Text = "Nhập cạnh c:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txtTriC
            // 
            this.txtTriC.Location = new System.Drawing.Point(192, 154);
            this.txtTriC.Name = "txtTriC";
            this.txtTriC.Size = new System.Drawing.Size(258, 44);
            this.txtTriC.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 325);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(196, 36);
            this.label19.TabIndex = 19;
            this.label19.Text = "Loại tam giác:";
            // 
            // txtTriType
            // 
            this.txtTriType.Location = new System.Drawing.Point(218, 325);
            this.txtTriType.Name = "txtTriType";
            this.txtTriType.ReadOnly = true;
            this.txtTriType.Size = new System.Drawing.Size(232, 44);
            this.txtTriType.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(979, 1007);
            this.Controls.Add(this.grpRectangle);
            this.Controls.Add(this.grpTriangle);
            this.Controls.Add(this.grpSquare);
            this.Controls.Add(this.grpCircle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReSet);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Tìm Chu Vi và Diện Tích";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCircle.ResumeLayout(false);
            this.grpCircle.PerformLayout();
            this.grpSquare.ResumeLayout(false);
            this.grpSquare.PerformLayout();
            this.grpRectangle.ResumeLayout(false);
            this.grpRectangle.PerformLayout();
            this.grpTriangle.ResumeLayout(false);
            this.grpTriangle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCircle;
        private System.Windows.Forms.RadioButton rbSquare;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbTriangle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReSet;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpCircle;
        private System.Windows.Forms.TextBox txtCircleArea;
        private System.Windows.Forms.TextBox txtCirclePerim;
        private System.Windows.Forms.TextBox txtCircleR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpSquare;
        private System.Windows.Forms.TextBox txtSquareArea;
        private System.Windows.Forms.TextBox txtSquarePerim;
        private System.Windows.Forms.TextBox txtSquareA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpRectangle;
        private System.Windows.Forms.TextBox txtRectH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRectArea;
        private System.Windows.Forms.TextBox txtRectPerim;
        private System.Windows.Forms.TextBox txtRectW;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpTriangle;
        private System.Windows.Forms.TextBox txtTriType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTriC;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtTriB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTriArea;
        private System.Windows.Forms.TextBox txtTriPerim;
        private System.Windows.Forms.TextBox txtTriA;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

