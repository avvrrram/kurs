using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class F2CountForm : Form
    {
        // Змінна для зберігання кількості обчислень для f2(x)
        public int F2Count { get; private set; }

        public F2CountForm()
        {
            InitializeComponent();
        }

        // Метод для встановлення значення кількості обчислень
        public void SetF2Count(int count)
        {
            F2Count = count;
            countLabel.Text = $"Amount for f2(x) = {F2Count}";
        }
    }
}
