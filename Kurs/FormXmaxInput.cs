using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class FormXmaxInput : Form
    {
        // Змінна для зберігання введеного xmax
        public double Xmax { get; private set; }

        public FormXmaxInput()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введено коректні дані
            if (!double.TryParse(xmaxTextBox.Text, out double xmax))
            {
                MessageBox.Show("Invalid input for xmax. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження введеного xmax та закриття вікна
            Xmax = xmax;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
