using System;
using System.Windows.Forms;

namespace FunctionCalculator
{
    public partial class F1CountForm : Form
    {
        public int F1Count { get; set; }

        public F1CountForm()
        {
            InitializeComponent();
        }

        public F1CountForm(int count)
        {
            InitializeComponent();
            F1Count = count;
        }

        private void F1CountForm_Load(object sender, EventArgs e)
        {
            f1CountLabel.Text = $"Amount for f1(x) = {F1Count}";
        }
    }
}
