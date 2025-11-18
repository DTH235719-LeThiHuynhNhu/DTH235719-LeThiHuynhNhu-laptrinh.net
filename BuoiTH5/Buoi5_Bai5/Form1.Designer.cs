namespace Buoi5_Bai5
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
            this.grpArray = new System.Windows.Forms.GroupBox();
            this.lblArray = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnIncrease2 = new System.Windows.Forms.Button();
            this.btnCountOdd = new System.Windows.Forms.Button();
            this.btnSortAsc = new System.Windows.Forms.Button();
            this.btnSumOdd = new System.Windows.Forms.Button();
            this.btnSortDesc = new System.Windows.Forms.Button();
            this.grpArray.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpArray
            // 
            this.grpArray.Controls.Add(this.lblArray);
            this.grpArray.Location = new System.Drawing.Point(57, 37);
            this.grpArray.Name = "grpArray";
            this.grpArray.Size = new System.Drawing.Size(1088, 100);
            this.grpArray.TabIndex = 0;
            this.grpArray.TabStop = false;
            this.grpArray.Text = "Mảng Gốc:";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray.Location = new System.Drawing.Point(44, 40);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 36);
            this.lblArray.TabIndex = 0;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(57, 183);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(1088, 100);
            this.grpResult.TabIndex = 1;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Kết Quả:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(44, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 36);
            this.lblResult.TabIndex = 2;
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(134, 319);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(338, 60);
            this.btnRandom.TabIndex = 2;
            this.btnRandom.Text = "Xuất mảng ngẫu nhiên";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(682, 319);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(338, 60);
            this.btnMin.TabIndex = 3;
            this.btnMin.Text = "Tìm phần tử nhỏ nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(134, 411);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(338, 60);
            this.btnSum.TabIndex = 4;
            this.btnSum.Text = "Tính tổng giá trị mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnIncrease2
            // 
            this.btnIncrease2.Location = new System.Drawing.Point(682, 411);
            this.btnIncrease2.Name = "btnIncrease2";
            this.btnIncrease2.Size = new System.Drawing.Size(341, 60);
            this.btnIncrease2.TabIndex = 5;
            this.btnIncrease2.Text = "Tăng mỗi Ptử mảng lên 2";
            this.btnIncrease2.UseVisualStyleBackColor = true;
            this.btnIncrease2.Click += new System.EventHandler(this.btnIncrease2_Click);
            // 
            // btnCountOdd
            // 
            this.btnCountOdd.Location = new System.Drawing.Point(134, 499);
            this.btnCountOdd.Name = "btnCountOdd";
            this.btnCountOdd.Size = new System.Drawing.Size(338, 60);
            this.btnCountOdd.TabIndex = 6;
            this.btnCountOdd.Text = "Đếm số phần tử lẻ";
            this.btnCountOdd.UseVisualStyleBackColor = true;
            this.btnCountOdd.Click += new System.EventHandler(this.btnCountOdd_Click);
            // 
            // btnSortAsc
            // 
            this.btnSortAsc.Location = new System.Drawing.Point(682, 499);
            this.btnSortAsc.Name = "btnSortAsc";
            this.btnSortAsc.Size = new System.Drawing.Size(338, 60);
            this.btnSortAsc.TabIndex = 7;
            this.btnSortAsc.Text = "Sắp xếp mảng tăng";
            this.btnSortAsc.UseVisualStyleBackColor = true;
            this.btnSortAsc.Click += new System.EventHandler(this.btnSortAsc_Click);
            // 
            // btnSumOdd
            // 
            this.btnSumOdd.Location = new System.Drawing.Point(134, 603);
            this.btnSumOdd.Name = "btnSumOdd";
            this.btnSumOdd.Size = new System.Drawing.Size(338, 60);
            this.btnSumOdd.TabIndex = 8;
            this.btnSumOdd.Text = "Tổng giá trị phần tử lẻ";
            this.btnSumOdd.UseVisualStyleBackColor = true;
            this.btnSumOdd.Click += new System.EventHandler(this.btnSumOdd_Click);
            // 
            // btnSortDesc
            // 
            this.btnSortDesc.Location = new System.Drawing.Point(682, 593);
            this.btnSortDesc.Name = "btnSortDesc";
            this.btnSortDesc.Size = new System.Drawing.Size(338, 60);
            this.btnSortDesc.TabIndex = 9;
            this.btnSortDesc.Text = "Sắp xếp mảng giảm";
            this.btnSortDesc.UseVisualStyleBackColor = true;
            this.btnSortDesc.Click += new System.EventHandler(this.btnSortDesc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 712);
            this.Controls.Add(this.btnSortDesc);
            this.Controls.Add(this.btnSumOdd);
            this.Controls.Add(this.btnSortAsc);
            this.Controls.Add(this.btnCountOdd);
            this.Controls.Add(this.btnIncrease2);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpArray);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Working With Array";
            this.grpArray.ResumeLayout(false);
            this.grpArray.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpArray;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnIncrease2;
        private System.Windows.Forms.Button btnCountOdd;
        private System.Windows.Forms.Button btnSortAsc;
        private System.Windows.Forms.Button btnSumOdd;
        private System.Windows.Forms.Button btnSortDesc;
    }
}

