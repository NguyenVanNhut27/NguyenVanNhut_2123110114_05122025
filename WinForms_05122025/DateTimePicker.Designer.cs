namespace DateTimePicker
{
    // ĐÃ SỬA: Đổi tên class thành FormDateTimePicker
    partial class FormDateTimePicker
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dtpLong = new System.Windows.Forms.DateTimePicker();
            this.dtpShort = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dtpCustomShort = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dtpLong
            // 
            this.dtpLong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLong.Location = new System.Drawing.Point(30, 25);
            this.dtpLong.Name = "dtpLong";
            this.dtpLong.Size = new System.Drawing.Size(260, 22);
            this.dtpLong.TabIndex = 0;
            // 
            // dtpShort
            // 
            this.dtpShort.CustomFormat = "dd/MM/yyyy";
            this.dtpShort.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpShort.Location = new System.Drawing.Point(30, 65);
            this.dtpShort.Name = "dtpShort";
            this.dtpShort.Size = new System.Drawing.Size(260, 22);
            this.dtpShort.TabIndex = 1;
            // 
            // dtpTime
            // 
            this.dtpTime.CustomFormat = "h:mm:ss tt";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(30, 105);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(260, 22);
            this.dtpTime.TabIndex = 2;
            // 
            // dtpCustomShort
            // 
            this.dtpCustomShort.CustomFormat = "dd/MM/yy";
            this.dtpCustomShort.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCustomShort.Location = new System.Drawing.Point(30, 145);
            this.dtpCustomShort.Name = "dtpCustomShort";
            this.dtpCustomShort.Size = new System.Drawing.Size(260, 22);
            this.dtpCustomShort.TabIndex = 3;
            // 
            // FormDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 203);
            this.Controls.Add(this.dtpCustomShort);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpShort);
            this.Controls.Add(this.dtpLong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDateTimePicker"; // Tên form ở đây
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker"; // Tiêu đề cửa sổ vẫn giữ nguyên được
            this.Load += new System.EventHandler(this.FormDateTimePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLong;
        private System.Windows.Forms.DateTimePicker dtpShort;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DateTimePicker dtpCustomShort;
    }
}