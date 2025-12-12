using System;
using System.Windows.Forms;
using System.Drawing; // Thêm thư viện này để tránh lỗi liên quan đến Size/Point

namespace MyCalculatorProject
{
    public partial class Article11 : Form // Tên lớp đã được đổi thành Article11
    {
        // Biến trạng thái
        double ketQua = 0;
        string phepToan = "";
        bool dangNhapSo = true; // Cờ theo dõi người dùng đang nhập số hay đã nhập toán tử
        double memoryValue = 0; // Bộ nhớ (M)

        public Article11()
        {
            InitializeComponent();
        }

        // --- Xử lý các Nút Số (0-9) và Dấu chấm (.) ---
        private void btnSo_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;

            if (dangNhapSo)
            {
                // Xóa màn hình nếu đang nhập số mới
                txtDisplay.Text = (nut.Text == ".") ? "0." : nut.Text;
                dangNhapSo = false;
            }
            else if (nut.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += ".";
                }
            }
            else
            {
                // Xử lý trường hợp số 0 ở đầu
                if (txtDisplay.Text == "0" && nut.Text != "0")
                {
                    txtDisplay.Text = nut.Text;
                }
                else if (txtDisplay.Text != "0")
                {
                    txtDisplay.Text += nut.Text;
                }
            }
        }

        // --- Xử lý các Nút Phép Toán Cơ bản (+, -, *, /) ---
        private void btnPhepToan_Click(object sender, EventArgs e)
        {
            Button nut = (Button)sender;

            // Nếu đang nhập số, tính toán phép toán trước nếu có
            if (!dangNhapSo && phepToan != "")
            {
                btnBang_Click(sender, e);
            }

            // Lưu số hiện tại và phép toán
            if (txtDisplay.Text != "")
            {
                ketQua = double.Parse(txtDisplay.Text);
            }

            phepToan = nut.Text;
            dangNhapSo = true;
        }

        // --- Xử lý Nút Bằng (=) ---
        private void btnBang_Click(object sender, EventArgs e)
        {
            if (phepToan == "") return;

            double soHienTai = double.Parse(txtDisplay.Text);
            double ketQuaCuoi;

            try
            {
                switch (phepToan)
                {
                    case "+": ketQuaCuoi = ketQua + soHienTai; break;
                    case "-": ketQuaCuoi = ketQua - soHienTai; break;
                    case "*": ketQuaCuoi = ketQua * soHienTai; break;
                    case "/":
                        if (soHienTai == 0) throw new DivideByZeroException();
                        ketQuaCuoi = ketQua / soHienTai;
                        break;
                    default: return;
                }
                txtDisplay.Text = ketQuaCuoi.ToString();
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Cannot divide by zero";
            }

            ketQua = double.Parse(txtDisplay.Text); // Lưu kết quả hiện tại
            phepToan = "";
            dangNhapSo = true;
        }

        // --- Xử lý các Nút Xóa/Điều chỉnh (C, CE, Backspace, +/-) ---

        // Nút Clear (C): Xóa tất cả
        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            ketQua = 0;
            phepToan = "";
            dangNhapSo = true;
        }

        // Nút Clear Entry (CE): Xóa số hiện tại trên màn hình
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            dangNhapSo = true;
        }

        // Nút Backspace (←): Xóa một ký tự
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
        }

        // Nút Đổi dấu (±)
        private void btnSign_Click(object sender, EventArgs e)
        {
            double so = double.Parse(txtDisplay.Text);
            so *= -1;
            txtDisplay.Text = so.ToString();
        }

        // --- Xử lý các Phép toán một ngôi (√, %, 1/x) ---

        // Căn bậc hai (√)
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double so = double.Parse(txtDisplay.Text);
            if (so >= 0)
            {
                txtDisplay.Text = Math.Sqrt(so).ToString();
            }
            else
            {
                txtDisplay.Text = "Error";
            }
            dangNhapSo = true;
        }

        // Nghịch đảo (1/x)
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double so = double.Parse(txtDisplay.Text);
            if (so != 0)
            {
                txtDisplay.Text = (1 / so).ToString();
            }
            else
            {
                txtDisplay.Text = "Error";
            }
            dangNhapSo = true;
        }

        // Phần trăm (%)
        private void btnPercent_Click(object sender, EventArgs e)
        {
            double so = double.Parse(txtDisplay.Text);

            // Xử lý logic tính phần trăm: (Số đầu tiên * Số hiện tại) / 100
            if (phepToan != "")
            {
                double phanTram = ketQua * (so / 100);
                txtDisplay.Text = phanTram.ToString();
            }
            else
            {
                // Nếu không có phép toán, chỉ chuyển số hiện tại thành phần trăm (chia cho 100)
                txtDisplay.Text = (so / 100).ToString();
            }
            dangNhapSo = true;
        }

        // --- Xử lý các Nút Bộ nhớ (MC, MR, MS, M+, M-) ---
        private void btnMC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
        }
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = memoryValue.ToString();
            dangNhapSo = false;
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            memoryValue = double.Parse(txtDisplay.Text);
            dangNhapSo = true;
        }
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            memoryValue += double.Parse(txtDisplay.Text);
            dangNhapSo = true;
        }
        private void btnMMinus_Click(object sender, EventArgs e)
        {
            memoryValue -= double.Parse(txtDisplay.Text);
            dangNhapSo = true;
        }
    }
}