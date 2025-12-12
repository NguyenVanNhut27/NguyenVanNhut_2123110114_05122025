using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music2
{
    public partial class Article18 : Form
    {
        public Article18()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Nạp danh sách bài hát giống hệt hình ảnh mẫu (Article 18)
            lstSource.Items.Add("Giấc mơ Chapi");
            lstSource.Items.Add("Đôi Mắt Pleiku");
            lstSource.Items.Add("Em Muốn Sống Bên Anh Trọn Đời");
            lstSource.Items.Add("H'Zen Lên Rẫy");
            lstSource.Items.Add("Còn Thương Nhau Thì Về Buôn Mê Thuột");
            lstSource.Items.Add("Ly Cà Phê Ban Mê");
            lstSource.Items.Add("Đi tìm lời ru mặt trời");
        }

        // Chuyển bài hát ĐANG CHỌN từ Trái sang Phải (>)
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            // Duyệt từ dưới lên để xóa không bị lỗi index
            for (int i = lstSource.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstSource.SelectedIndices[i];
                // Thêm vào danh sách phải
                lstDest.Items.Add(lstSource.Items[index]);
                // Xóa khỏi danh sách trái
                lstSource.Items.RemoveAt(index);
            }
        }

        // Chuyển bài hát ĐANG CHỌN từ Phải sang Trái (<)
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            // Duyệt từ dưới lên
            for (int i = lstDest.SelectedIndices.Count - 1; i >= 0; i--)
            {
                int index = lstDest.SelectedIndices[i];
                // Thêm về danh sách trái
                lstSource.Items.Add(lstDest.Items[index]);
                // Xóa khỏi danh sách phải
                lstDest.Items.RemoveAt(index);
            }
        }
    }
}
