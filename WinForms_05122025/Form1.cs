using System;
using System.Windows.Forms; // Đảm bảo thư viện này đã được thêm

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- Đặt hàm LayGiaTri() ở đây ---
        private bool LayGiaTri(out double soX, out double soY)
        {
            // 1. Khắc phục lỗi 'out parameter must be assigned': Khởi tạo giá trị mặc định
            soX = 0;
            soY = 0;

            // 2. Kiểm tra Số x
            if (!double.TryParse(this.txtSoX.Text, out soX))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Số x.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSoX.Focus();
                return false;
            }

            // 3. Kiểm tra Số y
            if (!double.TryParse(this.txtSoY.Text, out soY))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho Số y.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtSoY.Focus();
                return false;
            }

            // 4. Thành công
            return true;
        }

        // --- Đặt hàm xử lý nút Cộng ở đây ---
        private void btnCong_Click(object sender, EventArgs e)
        {
            double soX, soY;

            // Chỉ thực hiện phép tính nếu lấy giá trị thành công
            if (LayGiaTri(out soX, out soY))
            {
                double ketQua = soX + soY;
                // Hiển thị kết quả trong txtKetQua
                this.txtKetQua.Text = ketQua.ToString();
            }
        }

        // --- Đặt hàm xử lý nút Nhân ở đây ---
        private void btnNhan_Click(object sender, EventArgs e)
        {
            double soX, soY;

            if (LayGiaTri(out soX, out soY))
            {
                double ketQua = soX * soY;
                // Hiển thị kết quả trong txtKetQua
                this.txtKetQua.Text = ketQua.ToString();
            }
        }

        // --- Đặt hàm xử lý nút Thoát ở đây ---
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}