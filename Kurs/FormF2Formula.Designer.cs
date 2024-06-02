namespace FunctionCalculator
{
    partial class FormF2Formula
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
            this.labelF2Formula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelF2Formula
            // 
            this.labelF2Formula.AutoSize = true;
            this.labelF2Formula.Location = new System.Drawing.Point(44, 38);
            this.labelF2Formula.Name = "labelF2Formula";
            this.labelF2Formula.Size = new System.Drawing.Size(171, 17);
            this.labelF2Formula.TabIndex = 0;
            this.labelF2Formula.Text = "f2(x) = sqrt(x) / sin(x)";
            // 
            // FormF2Formula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.labelF2Formula);
            this.Name = "FormF2Formula";
            this.Text = "Formula for f2(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelF2Formula;
    }
}
