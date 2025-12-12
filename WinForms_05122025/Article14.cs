using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboxBox
{
    public partial class Article14 : Form
    {
        public Article14()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút Tính tiền
        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // 1. Lấy tên
            string hoTen = txtHoTen.Text;

            // 2. Xác định danh xưng dựa trên giới tính
            string danhXung = "";
            if (radNam.Checked)
            {
                danhXung = "Ông";
            }
            else
            {
                danhXung = "Bà";
            }

            // 3. Xác định phần trăm giảm giá
            int giamGia = 0;

            // Nếu checkbox được chọn, cố gắng lấy số từ ô text box giảm giá
            if (chkGiamGia.Checked)
            {
                // Sử dụng TryParse để tránh lỗi nếu người dùng nhập chữ
                if (!int.TryParse(txtGiamGia.Text, out giamGia))
                {
                    MessageBox.Show("Vui lòng nhập số phần trăm giảm giá hợp lệ!", "Lỗi nhập liệu");
                    return;
                }
            }
            else
            {
                // Nếu không check, mặc định là 0
                giamGia = 0;
            }

            // 4. Hiển thị kết quả ra TextBox lớn
            // Format: "Ông/Bà [Tên] được giảm [Số]%"
            txtKetQua.Text = string.Format("{0} {1} được giảm {2}%", danhXung, hoTen, giamGia);
        }

        // Sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Tùy chọn thêm: Tự động vô hiệu hóa ô nhập giảm giá nếu bỏ check (Giống UX chuẩn)
        private void chkGiamGia_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu check thì cho phép nhập, không check thì khóa lại
            txtGiamGia.Enabled = chkGiamGia.Checked;
        }

        // Load form mặc định
        private void Article14_Load(object sender, EventArgs e)
        {
            // Mặc định chọn Nam
            radNam.Checked = true;
            // Mặc định ô giảm giá có thể nhập hoặc không tùy vào trạng thái checkbox
            txtGiamGia.Enabled = chkGiamGia.Checked;
        }
    }
}