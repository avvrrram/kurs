namespace FunctionCalculator
{
    partial class FormXmaxInput
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
            this.xmaxLabel = new System.Windows.Forms.Label();
            this.xmaxTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmaxLabel
            // 
            this.xmaxLabel.AutoSize = true;
            this.xmaxLabel.Location = new System.Drawing.Point(12, 22);
            this.xmaxLabel.Name = "xmaxLabel";
            this.xmaxLabel.Size = new System.Drawing.Size(43, 16);
            this.xmaxLabel.TabIndex = 0;
            this.xmaxLabel.Text = "Xmax:";
            // 
            // xmaxTextBox
            // 
            this.xmaxTextBox.Location = new System.Drawing.Point(65, 19);
            this.xmaxTextBox.Name = "xmaxTextBox";
            this.xmaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.xmaxTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(65, 55);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авраменко Наталія ІН-22/1";
            // 
            // FormXmaxInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.xmaxTextBox);
            this.Controls.Add(this.xmaxLabel);
            this.Name = "FormXmaxInput";
            this.Text = "Xmax Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xmaxLabel;
        private System.Windows.Forms.TextBox xmaxTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label1;
    }
}
