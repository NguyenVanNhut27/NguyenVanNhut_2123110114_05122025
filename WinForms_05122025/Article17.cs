using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class Article17 : Form
    {
        public Article17()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Thêm dữ liệu mẫu vào danh sách bên trái
            lstSource.Items.Add("Giấc mơ Chapi");
            lstSource.Items.Add("Đôi Mắt Pleiku");
            lstSource.Items.Add("Em Muốn Sống Bên Anh Trọn Đời");
            lstSource.Items.Add("H'Zen Lên Rẫy");
            lstSource.Items.Add("Ly Cà Phê Ban Mê");
            lstSource.Items.Add("Đi tìm lời ru mặt trời");

            // Chọn mặc định 1 bài giống hình
            lstSource.SelectedIndex = 2;

            // Thêm dữ liệu mẫu vào danh sách bên phải
            lstDest.Items.Add("Còn Thương Nhau Thì Về Buôn Mê Thuột");
            lstDest.SelectedIndex = 0;
        }

        // Chuyển các mục ĐANG CHỌN từ Trái sang Phải (>)
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            // Duyệt ngược từ cuối lên đầu để tránh lỗi index khi xóa
            for (int i = lstSource.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstSource.SelectedIndices[i];
                // Thêm vào list đích
                lstDest.Items.Add(lstSource.Items[index]);
                // Xóa khỏi list nguồn
                lstSource.Items.RemoveAt(index);
            }
        }

        // Chuyển các mục ĐANG CHỌN từ Phải sang Trái (<)
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            for (int i = lstDest.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstDest.SelectedIndices[i];
                lstSource.Items.Add(lstDest.Items[index]);
                lstDest.Items.RemoveAt(index);
            }
        }

        // Chuyển TẤT CẢ từ Trái sang Phải (>>)
        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            // Thêm toàn bộ item của nguồn vào đích
            lstDest.Items.AddRange(lstSource.Items);
            // Xóa sạch nguồn
            lstSource.Items.Clear();
        }

        // Chuyển TẤT CẢ từ Phải sang Trái (<<)
        private void btnMoveAllLeft_Click(object sender, EventArgs e)
        {
            lstSource.Items.AddRange(lstDest.Items);
            lstDest.Items.Clear();
        }
    }
}