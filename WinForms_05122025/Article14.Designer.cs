namespace ComboxBox
{
    partial class Article14
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
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.grpGioiTinh = new System.Windows.Forms.GroupBox();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.chkGiamGia = new System.Windows.Forms.CheckBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grpGioiTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(30, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 22);
            this.txtHoTen.TabIndex = 0;
            this.txtHoTen.Text = "Nguyễn Văn A";
            // 
            // grpGioiTinh
            // 
            this.grpGioiTinh.Controls.Add(this.radNu);
            this.grpGioiTinh.Controls.Add(this.radNam);
            this.grpGioiTinh.Location = new System.Drawing.Point(30, 65);
            this.grpGioiTinh.Name = "grpGioiTinh";
            this.grpGioiTinh.Size = new System.Drawing.Size(320, 80);
            this.grpGioiTinh.TabIndex = 1;
            this.grpGioiTinh.TabStop = false;
            this.grpGioiTinh.Text = "Giới tính";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(200, 35);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 21);
            this.radNu.TabIndex = 1;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Location = new System.Drawing.Point(60, 35);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(58, 21);
            this.radNam.TabIndex = 0;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // chkGiamGia
            // 
            this.chkGiamGia.AutoSize = true;
            this.chkGiamGia.Location = new System.Drawing.Point(35, 165);
            this.chkGiamGia.Name = "chkGiamGia";
            this.chkGiamGia.Size = new System.Drawing.Size(86, 21);
            this.chkGiamGia.TabIndex = 2;
            this.chkGiamGia.Text = "Giảm giá";
            this.chkGiamGia.UseVisualStyleBackColor = true;
            this.chkGiamGia.CheckedChanged += new System.EventHandler(this.chkGiamGia_CheckedChanged);
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(130, 163);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(220, 22);
            this.txtGiamGia.TabIndex = 3;
            this.txtGiamGia.Text = "7";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(30, 200);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.ReadOnly = true;
            this.txtKetQua.Size = new System.Drawing.Size(320, 80);
            this.txtKetQua.TabIndex = 4;
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(140, 300);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(100, 35);
            this.btnTinhTien.TabIndex = 5;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Article14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.chkGiamGia);
            this.Controls.Add(this.grpGioiTinh);
            this.Controls.Add(this.txtHoTen);
            this.Name = "Article14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Article14_Load);
            this.grpGioiTinh.ResumeLayout(false);
            this.grpGioiTinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox grpGioiTinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.CheckBox chkGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnThoat;
    }
}