namespace FunctionCalculator
{
    partial class FormF1Results
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
            this.listBoxF1Results = new System.Windows.Forms.ListBox();
            this.labelF1Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxF1Results
            // 
            this.listBoxF1Results.FormattingEnabled = true;
            this.listBoxF1Results.ItemHeight = 16;
            this.listBoxF1Results.Location = new System.Drawing.Point(12, 12);
            this.listBoxF1Results.Name = "listBoxF1Results";
            this.listBoxF1Results.Size = new System.Drawing.Size(385, 372);
            this.listBoxF1Results.TabIndex = 0;
            // 
            // labelF1Count
            // 
            this.labelF1Count.AutoSize = true;
            this.labelF1Count.Location = new System.Drawing.Point(12, 397);
            this.labelF1Count.Name = "labelF1Count";
            this.labelF1Count.Size = new System.Drawing.Size(179, 16);
            this.labelF1Count.TabIndex = 1;
            this.labelF1Count.Text = "Авраменко Наталія ІН-22/1";
            this.labelF1Count.Click += new System.EventHandler(this.labelF1Count_Click);
            // 
            // FormF1Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.labelF1Count);
            this.Controls.Add(this.listBoxF1Results);
            this.Name = "FormF1Results";
            this.Text = "F1 Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxF1Results;
        private System.Windows.Forms.Label labelF1Count;
    }
}
