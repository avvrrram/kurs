using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Створення та показ головної форми
            Form1 mainForm = new Form1();
            Application.Run(mainForm);
        }
    }
}
