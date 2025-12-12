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

namespace QLSV
{
    public partial class Article16 : Form
    {
        // Biến đếm số lượng sinh viên đã thêm vào danh sách
        private int studentCount = 0;

        public Article16()
        {
            InitializeComponent();
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // Thêm các khoa vào ComboBox
            cboFaculty.Items.Add("Công nghệ thông tin");
            cboFaculty.Items.Add("Kế toán");
            cboFaculty.Items.Add("Quản trị kinh doanh");
            cboFaculty.SelectedIndex = 0; // Chọn mặc định là CNTT

            // Thiết lập dữ liệu mẫu mặc định giống hình ảnh để hiển thị ngay khi chạy
            txtName.Text = "Trần Thị Học Lại";
            dtpDob.Value = new DateTime(1994, 7, 10);
            radFemale.Checked = true;

            // Thêm sẵn một sinh viên mẫu vào danh sách trạng thái để giống hình
            AddStudentToList("Nguyễn Văn Rót", new DateTime(1995, 10, 20), "Nam", "Công nghệ thông tin");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin từ giao diện
            string name = txtName.Text.Trim();
            DateTime dob = dtpDob.Value;
            string gender = radMale.Checked ? "Nam" : "Nữ";
            string faculty = cboFaculty.SelectedItem.ToString();

            // Kiểm tra nếu tên trống
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Gọi hàm thêm vào danh sách hiển thị
            AddStudentToList(name, dob, gender, faculty);
        }

        private void AddStudentToList(string name, DateTime dob, string gender, string faculty)
        {
            // Tăng biến đếm
            studentCount++;

            // Tạo chuỗi thông tin theo định dạng trong hình
            string info = $"{studentCount}. {name}\n" +
                          $"   -Giới tính: {gender}\n" +
                          $"   -Ngày Sinh:{dob:dd/MM/yyyy}\n" +
                          $"   -Khoa: {faculty}\n";

            // Thêm vào RichTextBox (Trạng thái)
            rtbStatus.AppendText(info);

            // Cuộn xuống dòng cuối cùng
            rtbStatus.ScrollToCaret();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Đóng form
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}