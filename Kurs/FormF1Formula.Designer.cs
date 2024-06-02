namespace FunctionCalculator
{
    partial class FormF1Formula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFormulaF1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFormulaF1
            // 
            this.labelFormulaF1.AutoSize = true;
            this.labelFormulaF1.Location = new System.Drawing.Point(30, 34);
            this.labelFormulaF1.Name = "labelFormulaF1";
            this.labelFormulaF1.Size = new System.Drawing.Size(124, 17);
            this.labelFormulaF1.TabIndex = 0;
            this.labelFormulaF1.Text = "f1(x) = q * log(q * x)";
            // 
            // FormF1Formula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 87);
            this.Controls.Add(this.labelFormulaF1);
            this.Name = "FormF1Formula";
            this.Text = "Formula for f1(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormulaF1;
    }
}
