namespace FunctionCalculator
{
    partial class FormF2Results
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
            this.listBoxResultsF2 = new System.Windows.Forms.ListBox();
            this.labelF2Results = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxResultsF2
            // 
            this.listBoxResultsF2.FormattingEnabled = true;
            this.listBoxResultsF2.ItemHeight = 16;
            this.listBoxResultsF2.Location = new System.Drawing.Point(39, 61);
            this.listBoxResultsF2.Name = "listBoxResultsF2";
            this.listBoxResultsF2.Size = new System.Drawing.Size(282, 276);
            this.listBoxResultsF2.TabIndex = 0;
            // 
            // labelF2Results
            // 
            this.labelF2Results.AutoSize = true;
            this.labelF2Results.Location = new System.Drawing.Point(36, 28);
            this.labelF2Results.Name = "labelF2Results";
            this.labelF2Results.Size = new System.Drawing.Size(106, 17);
            this.labelF2Results.TabIndex = 1;
            this.labelF2Results.Text = "Results for f2(x)";
            // 
            // FormF2Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 373);
            this.Controls.Add(this.labelF2Results);
            this.Controls.Add(this.listBoxResultsF2);
            this.Name = "FormF2Results";
            this.Text = "Results for f2(x)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultsF2;
        private System.Windows.Forms.Label labelF2Results;
    }
}
