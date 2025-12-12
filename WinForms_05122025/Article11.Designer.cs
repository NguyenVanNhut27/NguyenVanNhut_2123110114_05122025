namespace MyCalculatorProject
{
    partial class Article11 // Tên lớp đã được đổi thành Article11
    {
        private System.ComponentModel.IContainer components = null;
        // Khai báo tất cả các control để Article11.cs có thể truy cập
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnAdd;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(10, 10);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(434, 53);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btnMC, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMS, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMMinus, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSign, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSqrt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPercent, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnReciprocal, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtract, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnDecimal, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 4, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 320);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnMC
            // 
            this.btnMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMC.Location = new System.Drawing.Point(3, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(80, 47);
            this.btnMC.TabIndex = 0;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnMR
            // 
            this.btnMR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMR.Location = new System.Drawing.Point(89, 3);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(80, 47);
            this.btnMR.TabIndex = 1;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMS
            // 
            this.btnMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMS.Location = new System.Drawing.Point(175, 3);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(80, 47);
            this.btnMS.TabIndex = 2;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMPlus.Location = new System.Drawing.Point(261, 3);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(80, 47);
            this.btnMPlus.TabIndex = 3;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = true;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMMinus.Location = new System.Drawing.Point(347, 3);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(84, 47);
            this.btnMMinus.TabIndex = 4;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = true;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(3, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 47);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCE
            // 
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Location = new System.Drawing.Point(89, 56);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(80, 47);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Location = new System.Drawing.Point(175, 56);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(80, 47);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnSign
            // 
            this.btnSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSign.Location = new System.Drawing.Point(261, 56);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(80, 47);
            this.btnSign.TabIndex = 8;
            this.btnSign.Text = "±";
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSqrt.Location = new System.Drawing.Point(347, 56);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(84, 47);
            this.btnSqrt.TabIndex = 9;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btn7
            // 
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 109);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(80, 47);
            this.btn7.TabIndex = 10;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn8
            // 
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(89, 109);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 47);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn9
            // 
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(175, 109);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(80, 47);
            this.btn9.TabIndex = 12;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDivide.Location = new System.Drawing.Point(261, 109);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(80, 47);
            this.btnDivide.TabIndex = 13;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnPhepToan_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPercent.Location = new System.Drawing.Point(347, 109);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(84, 47);
            this.btnPercent.TabIndex = 14;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // btn4
            // 
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 162);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(80, 47);
            this.btn4.TabIndex = 15;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn5
            // 
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(89, 162);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(80, 47);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn6
            // 
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(175, 162);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 47);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMultiply.Location = new System.Drawing.Point(261, 162);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(80, 47);
            this.btnMultiply.TabIndex = 18;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnPhepToan_Click);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReciprocal.Location = new System.Drawing.Point(347, 162);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(84, 47);
            this.btnReciprocal.TabIndex = 19;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.UseVisualStyleBackColor = true;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 215);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(80, 47);
            this.btn1.TabIndex = 20;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(89, 215);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(80, 47);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(175, 215);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(80, 47);
            this.btn3.TabIndex = 22;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubtract.Location = new System.Drawing.Point(261, 215);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(80, 47);
            this.btnSubtract.TabIndex = 23;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnPhepToan_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.SetColumnSpan(this.btnEquals, 1);
            this.btnEquals.Location = new System.Drawing.Point(347, 215);
            this.btnEquals.Name = "btnEquals";
            this.tableLayoutPanel1.SetRowSpan(this.btnEquals, 2);
            this.btnEquals.Size = new System.Drawing.Size(84, 102);
            this.btnEquals.TabIndex = 24;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btn0
            // 
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.SetColumnSpan(this.btn0, 2);
            this.btn0.Location = new System.Drawing.Point(3, 268);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(171, 49);
            this.btn0.TabIndex = 25;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDecimal.Location = new System.Drawing.Point(175, 268);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(80, 49);
            this.btnDecimal.TabIndex = 26;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnSo_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(261, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 49);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnPhepToan_Click);
            // 
            // Article11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Article11"; // Tên Form được đặt là Article11
            this.Text = "My Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}