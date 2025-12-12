using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimePicker2
{
    public partial class Article15 : Form
    {
        public Article15()
        {
            InitializeComponent();

            // Thiết lập ngày mặc định giống hệt trong hình ảnh (30/09/2017)
            // Trong thực tế bạn có thể bỏ dòng này để nó lấy ngày hiện tại.
            dtpDate.Value = new DateTime(2017, 9, 30);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Xử lý khi nhấn nút OK
            // Ở đây tôi hiển thị thông báo ngày đã chọn và đóng form
            string selectedDate = dtpDate.Value.ToString("dd/MM/yyyy");
            MessageBox.Show("Bạn đã chọn ngày: " + selectedDate, "Thông báo");

            this.Close(); // Đóng form
        }
    }
}
