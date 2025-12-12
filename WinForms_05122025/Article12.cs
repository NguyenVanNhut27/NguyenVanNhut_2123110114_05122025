using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxExample2
{
    public partial class Article12 : Form
    {
        public Article12()
        {
            InitializeComponent();

            // Thiết lập giá trị mặc định là "Điện" (index = 3)
            this.comboBox1.SelectedIndex = 3;
        }

        // Sự kiện khi nhấn nút OK
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lấy item đang chọn
            var selectedItem = comboBox1.SelectedItem;

            if (selectedItem != null)
            {
                // Thêm nội dung vào khung hiển thị (txtDisplay)
                // Environment.NewLine dùng để xuống dòng
                txtDisplay.AppendText("Bạn đã chọn: " + selectedItem.ToString() + Environment.NewLine);
            }
        }

        // Sự kiện khi nhấn nút Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa hết nội dung trong khung hiển thị
            txtDisplay.Clear();

            // Đưa con trỏ chuột về lại ComboBox (tùy chọn)
            comboBox1.Focus();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Có thể xử lý khi thay đổi lựa chọn nếu cần
        }
    }
}