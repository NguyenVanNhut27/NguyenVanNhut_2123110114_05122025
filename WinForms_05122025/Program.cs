using caculator;
using ComboboxExample;
using ComboboxExample2;
using ComboxBox;
using DateTimePicker;
using DateTimePicker2;
using MyCalculatorProject;
using SimpleCalculator;
using System;
using System.Windows.Forms;
using QLSV;
using QLNS;
using Music;
using Music2;
using DataGridView;
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
            Application.Run(new Article20());
        }
    }
}