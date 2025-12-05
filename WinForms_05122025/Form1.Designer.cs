namespace caculator // Thay thế bằng Namespace của dự án bạn
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
            this.components = new System.ComponentModel.Container();
            this.labelSoX = new System.Windows.Forms.Label();
            this.labelSoY = new System.Windows.Forms.Label();
            this.labelKetQua = new System.Windows.Forms.Label();
            this.txtSoX = new System.Windows.Forms.TextBox();
            this.txtSoY = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSoX
            // 
            this.labelSoX.AutoSize = true;
            this.labelSoX.Location = new System.Drawing.Point(30, 30);
            this.labelSoX.Name = "labelSoX";
            this.labelSoX.Size = new System.Drawing.Size(32, 16);
            this.labelSoX.TabIndex = 0;
            this.labelSoX.Text = "Số x";
            // 
            // labelSoY
            // 
            this.labelSoY.AutoSize = true;
            this.labelSoY.Location = new System.Drawing.Point(30, 70);
            this.labelSoY.Name = "labelSoY";
            this.labelSoY.Size = new System.Drawing.Size(33, 16);
            this.labelSoY.TabIndex = 1;
            this.labelSoY.Text = "Số y";
            // 
            // labelKetQua
            // 
            this.labelKetQua.AutoSize = true;
            this.labelKetQua.Location = new System.Drawing.Point(30, 110);
            this.labelKetQua.Name = "labelKetQua";
            this.labelKetQua.Size = new System.Drawing.Size(53, 16);
            this.labelKetQua.TabIndex = 2;
            this.labelKetQua.Text = "Kết quả";
            // 
            // txtSoX
            // 
            this.txtSoX.Location = new System.Drawing.Point(100, 27);
            this.txtSoX.Name = "txtSoX";
            this.txtSoX.Size = new System.Drawing.Size(180, 22);
            this.txtSoX.TabIndex = 3;
            // 
            // txtSoY
            // 
            this.txtSoY.Location = new System.Drawing.Point(100, 67);
            this.txtSoY.Name = "txtSoY";
            this.txtSoY.Size = new System.Drawing.Size(180, 22);
            this.txtSoY.TabIndex = 4;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(100, 107);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true; // Kết quả thường chỉ để hiển thị
            this.txtKetQua.Size = new System.Drawing.Size(180, 22);
            this.txtKetQua.TabIndex = 5;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(30, 150);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 30);
            this.btnCong.TabIndex = 6;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click); // Liên kết sự kiện
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(115, 150);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(75, 30);
            this.btnNhan.TabIndex = 7;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click); // Liên kết sự kiện
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(205, 150);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click); // Liên kết sự kiện
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 200); // Kích thước form
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoY);
            this.Controls.Add(this.txtSoX);
            this.Controls.Add(this.labelKetQua);
            this.Controls.Add(this.labelSoY);
            this.Controls.Add(this.labelSoX);
            this.Name = "Form1";
            this.Text = "Caculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Khai báo các biến Control để truy cập từ Form1.cs
        private System.Windows.Forms.Label labelSoX;
        private System.Windows.Forms.Label labelSoY;
        private System.Windows.Forms.Label labelKetQua;
        public System.Windows.Forms.TextBox txtSoX; // Public để có thể truy cập
        public System.Windows.Forms.TextBox txtSoY;
        public System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}