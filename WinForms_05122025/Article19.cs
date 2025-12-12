using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLNS
{
    public partial class Article19 : Form
    {
        public Article19()
        {
            InitializeComponent();
        }

        // Hàm điền dữ liệu mẫu giống như trong hình
     

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại mở file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập tiêu đề hộp thoại
            openFileDialog.Title = "Chọn ảnh đại diện";

            // Chỉ cho phép chọn các file ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Nếu người dùng chọn file và nhấn OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lấy đường dẫn file ảnh
                    string filePath = openFileDialog.FileName;

                    // Tải ảnh vào PictureBox
                    // Sử dụng Image.FromFile để load ảnh từ đường dẫn
                    picAvatar.Image = Image.FromFile(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải ảnh này: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
