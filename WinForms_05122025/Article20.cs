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

namespace DataGridView
{
    public partial class Article20 : Form
    {
        public Article20()
        {
            InitializeComponent();
            LoadSampleData();
        }

        // Hàm nạp dữ liệu mẫu vào lưới (Grid) giống trong hình ảnh
        private void LoadSampleData()
        {
            // Các ô nhập liệu txtId, txtName, txtAge sẽ MẶC ĐỊNH TRỐNG do không gán giá trị ở đây.

            // Thêm vài dòng dữ liệu mẫu vào DataGridView
            dgvEmployee.Rows.Add("53418", "Trần Tiến", "20", true);
            dgvEmployee.Rows.Add("53416", "Nguyễn Cường", "25", false);
            dgvEmployee.Rows.Add("53417", "Nguyễn Hào", "23", true);
        }

        // Sự kiện nút THÊM
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string name = txtName.Text.Trim();
            string age = txtAge.Text.Trim();
            bool isMale = chkGender.Checked;

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(age))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm dòng mới vào Grid
            dgvEmployee.Rows.Add(id, name, age, isMale);

            // Xóa trắng các ô nhập sau khi thêm xong
            ClearInputs();
        }

        // Sự kiện nút XÓA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    // Xóa dòng đang chọn
                    foreach (DataGridViewRow row in dgvEmployee.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dgvEmployee.Rows.Remove(row);
                        }
                    }
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa!", "Thông báo");
            }
        }

        // Sự kiện nút THOÁT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện khi CLICK vào một dòng trong Grid -> Đổ dữ liệu xuống ô nhập
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                // Lấy dữ liệu từ Grid đưa vào TextBox
                txtId.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtAge.Text = row.Cells[2].Value?.ToString();

                // Lấy giá trị checkbox (true/false)
                bool isMale = false;
                if (row.Cells[3].Value != null)
                {
                    bool.TryParse(row.Cells[3].Value.ToString(), out isMale);
                }
                chkGender.Checked = isMale;
            }
        }

        // Hàm xóa trắng ô nhập liệu
        private void ClearInputs()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            chkGender.Checked = false;
            txtId.Focus(); // Đưa con trỏ chuột về ô Mã
        }
    }
}