using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class FormF1Results : Form
    {
        public FormF1Results()
        {
            InitializeComponent();
        }

        // Метод для встановлення результатів обчислень функції f1(x)
        public void SetResults(double[] xValues, double[] yValues)
        {
            // Очищення вмісту списку
            listBoxF1Results.Items.Clear();

            // Додавання результатів обчислень до списку
            for (int i = 0; i < xValues.Length; i++)
            {
                listBoxF1Results.Items.Add($"x = {xValues[i]}, y = {yValues[i]}");
            }
        }

        private void labelF1Count_Click(object sender, EventArgs e)
        {

        }
    }
}
