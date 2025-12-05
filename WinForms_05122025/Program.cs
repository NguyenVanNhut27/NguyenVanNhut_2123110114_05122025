using caculator;
using SimpleCalculator;
using System;
using System.Windows.Forms;
// ... các using khác ...

namespace SimpleCalculator// <-- Tên Namespace của Program.cs
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lỗi xảy ra ở dòng này:
            Application.Run(new Form2());
        }
    }
}