using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form2 : Form // Đảm bảo lớp là Form2
    {
        // Biến trạng thái
        double ketQua = 0;
        string phepToan = "";
        bool dangNhapSo = false;

        public Form2()
        {
            InitializeComponent();
        }

        // --- Xử lý các Nút Số (0, 1, 2, 3) ---
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;

            // Nếu đây là lúc bắt đầu nhập số mới (sau khi nhấn phép toán hoặc =)
            if (dangNhapSo)
            {
                txtDisplay.Text = nut.Text;
                dangNhapSo = false;
            }
            // Nếu đang tiếp tục nhập số
            else
            {
                // Xử lý trường hợp số 0 ở đầu
                if (txtDisplay.Text == "0")
                {
                    txtDisplay.Text = nut.Text;
                }
                else
                {
                    txtDisplay.Text += nut.Text;
                }
            }
        }

        // --- Xử lý Nút Dấu Thập phân (.) ---
        private void btnCham_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        // --- Xử lý các Nút Phép Toán (+, *) ---
        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;

            // Nếu người dùng nhấn toán tử liên tiếp, tự động tính kết quả hiện tại
            if (ketQua != 0 && !dangNhapSo)
            {
                btnBang_Click(sender, e);
            }

            // Nếu đây là phép toán đầu tiên
            if (txtDisplay.Text != "")
            {
                ketQua = double.Parse(txtDisplay.Text);
            }

            phepToan = nut.Text; // Lưu phép toán mới
            dangNhapSo = true; // Sẵn sàng nhập số thứ hai
        }

        // --- Xử lý Nút Bằng (=) ---
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (phepToan == "")
            {
                return; // Không có phép toán để tính
            }

            // Lấy số thứ hai
            double soHienTai = double.Parse(txtDisplay.Text);
            double ketQuaCuoi;

            switch (phepToan)
            {
                case "+":
                    ketQuaCuoi = ketQua + soHienTai;
                    break;
                case "*":
                    ketQuaCuoi = ketQua * soHienTai;
                    break;
                default:
                    return;
            }

            txtDisplay.Text = ketQuaCuoi.ToString();
            ketQua = ketQuaCuoi; // Đặt kết quả hiện tại làm số đầu tiên cho lần tính tiếp theo
            phepToan = "";
            dangNhapSo = true;
        }
    }
}