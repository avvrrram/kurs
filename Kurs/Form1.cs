using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FunctionCalculator
{
    public partial class Form1 : Form
    {
        // Змінні для зберігання введених значень xmin, xmax та dx
        private double xmin;
        private double xmax;
        private double dx;

        public Form1()
        {
            InitializeComponent();
            LoadStudentImage();
        }

        private void LoadStudentImage()
        {
            pictureBoxStudent.Image = Image.FromFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "image.jpg"));
        }

        // Обробник натискання кнопки "Calculate"
        private void button1_Click(object sender, EventArgs e)
        {
            // Перевірка, чи введені всі параметри
            if (xmin == 0 || xmax == 0 || dx == 0)
            {
                MessageBox.Show("Please enter values for xmin, xmax, and dx.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Очистка списків перед обчисленням
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            int countF1 = 0;
            int countF2 = 0;

            Random random = new Random();

            for (double x = xmin; x <= xmax; x += dx)
            {
                double q = random.NextDouble();

                if (0 < q && q <= 0.2)
                {
                    try
                    {
                        double y = F1(x);
                        listBox1.Items.Add($"x = {x}, y = {y}");
                        countF1++;
                    }
                    catch (Exception ex)
                    {
                        listBox1.Items.Add($"x = {x}, Error: {ex.Message}");
                    }
                }
                else if (0.2 < q && q <= 1)
                {
                    try
                    {
                        double y = F2(x);
                        listBox2.Items.Add($"x = {x}, y = {y}");
                        countF2++;
                    }
                    catch (Exception ex)
                    {
                        listBox2.Items.Add($"x = {x}, Error: {ex.Message}");
                    }
                }
            }

            // Оновлення лейблів з кількістю обчислень
            labelF1Count.Text = $"Amount for f1(x) = {countF1}";
            labelF2Count.Text = $"Amount for f2(x) = {countF2}";
        }

        // Метод для обчислення значення функції f1(x)
        private double F1(double x)
        {
            double q = 0.1;
            if (q * x <= 0)
                throw new Exception("Invalid input for log function");
            return q * Math.Log(q * x);
        }

        // Метод для обчислення значення функції f2(x)
        private double F2(double x)
        {
            if (x < 0)
                throw new Exception("Invalid input for sqrt function");
            double sinX = Math.Sin(x);
            if (sinX == 0)
                throw new Exception("Invalid input for sin function");
            return Math.Sqrt(x) / sinX;
        }

        // Обробник натискання кнопки для введення xmin
        private void inputXminButton_Click(object sender, EventArgs e)
        {
            using (var form = new FormXminInput())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    xmin = form.Xmin;
                    textBoxXmin.Text = xmin.ToString();
                }
            }
        }

        // Обробник натискання кнопки для введення xmax
        private void inputXmaxButton_Click(object sender, EventArgs e)
        {
            using (var form = new FormXmaxInput())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    xmax = form.Xmax;
                    textBoxXmax.Text = xmax.ToString();
                }
            }
        }

        // Обробник натискання кнопки для введення dx
        private void inputDxButton_Click(object sender, EventArgs e)
        {
            using (var form = new FormDxInput())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    dx = form.Dx;
                    textBoxDx.Text = dx.ToString();
                }
            }
        }

        // Метод для обробки події натискання на фото студента
        private void pictureBoxStudent_Click(object sender, EventArgs e)
        {
            // Додайте код, якщо потрібно
        }

        // Метод для обробки події натискання на мітку з формулами
        private void labelFormulas_Click(object sender, EventArgs e)
        {
            // Додайте код, якщо потрібно
        }
    }
}
