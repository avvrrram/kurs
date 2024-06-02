using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class F1CountForm : Form
    {
        // Змінна для зберігання кількості обчислень для f1(x)
        public int F1Count { get; private set; }

        public F1CountForm()
        {
            InitializeComponent();
        }

        // Метод для встановлення значення кількості обчислень f1(x)
        public void SetF1Count(int count)
        {
            F1Count = count;
            labelF1Count.Text = $"Amount for f1(x) = {F1Count}";
        }
    }
}
