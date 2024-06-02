using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class FormF2Results : Form
    {
        public FormF2Results()
        {
            InitializeComponent();
        }

        // Метод для встановлення результатів обчислень функції f2(x)
        public void SetResults(double[] xValues, double[] yValues)
        {
            // Очищення списку результатів
            resultsListBox.Items.Clear();

            // Додавання результатів до списку
            for (int i = 0; i < xValues.Length; i++)
            {
                resultsListBox.Items.Add($"x = {xValues[i]}, y = {yValues[i]}");
            }
        }

        // Метод для встановлення кількості обчислень функції f2(x)
        public void SetCalculationCount(int count)
        {
            calculationCountLabel.Text = $"Amount of calculations for f2(x) = {count}";
        }
    }
}
