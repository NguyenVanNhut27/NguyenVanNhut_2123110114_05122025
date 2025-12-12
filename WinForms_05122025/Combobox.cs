using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxExample
{
    public partial class Combobox : Form
    {
        public Combobox()
        {
            InitializeComponent();

            // Thiết lập giá trị mặc định được chọn là "Điện" giống trong hình
            // "Điện" nằm ở vị trí thứ 3 (tính từ 0: CNTT=0, Kế toán=1, Cơ khí=2, Điện=3)
            this.comboBox1.SelectedIndex = 3;
        }

        // Bạn có thể thêm các sự kiện xử lý ở đây nếu cần (ví dụ: SelectedIndexChanged)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ví dụ: MessageBox.Show("Bạn đã chọn: " + comboBox1.Text);
        }
    }
}
