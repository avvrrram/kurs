using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FunctionCalculator
{
    public partial class FormDxInput : Form
    {
        // Змінна для зберігання введеного dx
        public double Dx { get; private set; }

        public FormDxInput()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введено коректні дані
            if (!double.TryParse(dxTextBox.Text, out double dx))
            {
                MessageBox.Show("Invalid input for dx. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Збереження введеного dx та закриття вікна
            Dx = dx;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
