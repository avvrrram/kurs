using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class FormXminInput : Form
    {
        // Змінна для зберігання введеного xmin
        public double Xmin { get; private set; }

        public FormXminInput()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введено коректні дані
            if (!double.TryParse(xminTextBox.Text, out double xmin))
            {
                MessageBox.Show("Invalid input for xmin. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження введеного xmin та закриття вікна
            Xmin = xmin;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
