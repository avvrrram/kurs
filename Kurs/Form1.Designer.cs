namespace FunctionCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxDx = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.buttonXmin = new System.Windows.Forms.Button();
            this.buttonXmax = new System.Windows.Forms.Button();
            this.buttonDx = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelXmin = new System.Windows.Forms.Label();
            this.labelDx = new System.Windows.Forms.Label();
            this.labelXmax = new System.Windows.Forms.Label();
            this.labelF1Count = new System.Windows.Forms.Label();
            this.labelF2Count = new System.Windows.Forms.Label();
            this.labelStudent = new System.Windows.Forms.Label();
            this.labelf1Formulas = new System.Windows.Forms.Label();
            this.pictureBoxStudent = new System.Windows.Forms.PictureBox();
            this.labelListBox1 = new System.Windows.Forms.Label();
            this.labelListBox2 = new System.Windows.Forms.Label();
            this.labelF1Formula = new System.Windows.Forms.Label();
            this.labelF2Formula = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Location = new System.Drawing.Point(100, 30);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(100, 22);
            this.textBoxXmin.TabIndex = 0;
            // 
            // textBoxDx
            // 
            this.textBoxDx.Location = new System.Drawing.Point(100, 60);
            this.textBoxDx.Name = "textBoxDx";
            this.textBoxDx.Size = new System.Drawing.Size(100, 22);
            this.textBoxDx.TabIndex = 1;
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Location = new System.Drawing.Point(100, 90);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(100, 22);
            this.textBoxXmax.TabIndex = 2;
            // 
            // buttonXmin
            // 
            this.buttonXmin.Location = new System.Drawing.Point(210, 30);
            this.buttonXmin.Name = "buttonXmin";
            this.buttonXmin.Size = new System.Drawing.Size(100, 23);
            this.buttonXmin.TabIndex = 3;
            this.buttonXmin.Text = "Set Xmin";
            this.buttonXmin.UseVisualStyleBackColor = true;
            this.buttonXmin.Click += new System.EventHandler(this.buttonXmin_Click);
            // 
            // buttonXmax
            // 
            this.buttonXmax.Location = new System.Drawing.Point(210, 90);
            this.buttonXmax.Name = "buttonXmax";
            this.buttonXmax.Size = new System.Drawing.Size(100, 23);
            this.buttonXmax.TabIndex = 4;
            this.buttonXmax.Text = "Set Xmax";
            this.buttonXmax.UseVisualStyleBackColor = true;
            this.buttonXmax.Click += new System.EventHandler(this.buttonXmax_Click);
            // 
            // buttonDx
            // 
            this.buttonDx.Location = new System.Drawing.Point(210, 60);
            this.buttonDx.Name = "buttonDx";
            this.buttonDx.Size = new System.Drawing.Size(100, 23);
            this.buttonDx.TabIndex = 5;
            this.buttonDx.Text = "Set Dx";
            this.buttonDx.UseVisualStyleBackColor = true;
            this.buttonDx.Click += new System.EventHandler(this.buttonDx_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(100, 120);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(320, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 148);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(480, 50);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 148);
            this.listBox2.TabIndex = 8;
            // 
            // labelXmin
            // 
            this.labelXmin.AutoSize = true;
            this.labelXmin.Location = new System.Drawing.Point(20, 33);
            this.labelXmin.Name = "labelXmin";
            this.labelXmin.Size = new System.Drawing.Size(37, 16);
            this.labelXmin.TabIndex = 9;
            this.labelXmin.Text = "xmin:";
            // 
            // labelDx
            // 
            this.labelDx.AutoSize = true;
            this.labelDx.Location = new System.Drawing.Point(20, 63);
            this.labelDx.Name = "labelDx";
            this.labelDx.Size = new System.Drawing.Size(24, 16);
            this.labelDx.TabIndex = 10;
            this.labelDx.Text = "dx:";
            // 
            // labelXmax
            // 
            this.labelXmax.AutoSize = true;
            this.labelXmax.Location = new System.Drawing.Point(20, 93);
            this.labelXmax.Name = "labelXmax";
            this.labelXmax.Size = new System.Drawing.Size(41, 16);
            this.labelXmax.TabIndex = 11;
            this.labelXmax.Text = "xmax:";
            // 
            // labelF1Count
            // 
            this.labelF1Count.AutoSize = true;
            this.labelF1Count.Location = new System.Drawing.Point(320, 220);
            this.labelF1Count.Name = "labelF1Count";
            this.labelF1Count.Size = new System.Drawing.Size(107, 16);
            this.labelF1Count.TabIndex = 12;
            this.labelF1Count.Text = "Amount for f1(x) =";
            // 
            // labelF2Count
            // 
            this.labelF2Count.AutoSize = true;
            this.labelF2Count.Location = new System.Drawing.Point(480, 220);
            this.labelF2Count.Name = "labelF2Count";
            this.labelF2Count.Size = new System.Drawing.Size(107, 16);
            this.labelF2Count.TabIndex = 13;
            this.labelF2Count.Text = "Amount for f2(x) =";
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(674, 369);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(179, 16);
            this.labelStudent.TabIndex = 14;
            this.labelStudent.Text = "Авраменко Наталія ІН-22/1";
            // 
            // labelf1Formulas
            // 
            this.labelf1Formulas.AutoSize = true;
            this.labelf1Formulas.Location = new System.Drawing.Point(331, 253);
            this.labelf1Formulas.Name = "labelf1Formulas";
            this.labelf1Formulas.Size = new System.Drawing.Size(93, 16);
            this.labelf1Formulas.TabIndex = 15;
            this.labelf1Formulas.Text = "f1(x) = qlog(qx)";
            // 
            // pictureBoxStudent
            // 
            this.pictureBoxStudent.Image = global::FunctionCalculator.Properties.Resources.image;
            this.pictureBoxStudent.InitialImage = null;
            this.pictureBoxStudent.Location = new System.Drawing.Point(660, 33);
            this.pictureBoxStudent.Name = "pictureBoxStudent";
            this.pictureBoxStudent.Size = new System.Drawing.Size(278, 324);
            this.pictureBoxStudent.TabIndex = 16;
            this.pictureBoxStudent.TabStop = false;
            // 
            // labelListBox1
            // 
            this.labelListBox1.AutoSize = true;
            this.labelListBox1.Location = new System.Drawing.Point(320, 30);
            this.labelListBox1.Name = "labelListBox1";
            this.labelListBox1.Size = new System.Drawing.Size(79, 16);
            this.labelListBox1.TabIndex = 17;
            this.labelListBox1.Text = "f1(x) Results";
            // 
            // labelListBox2
            // 
            this.labelListBox2.AutoSize = true;
            this.labelListBox2.Location = new System.Drawing.Point(480, 30);
            this.labelListBox2.Name = "labelListBox2";
            this.labelListBox2.Size = new System.Drawing.Size(79, 16);
            this.labelListBox2.TabIndex = 18;
            this.labelListBox2.Text = "f2(x) Results";
            // 
            // labelF1Formula
            // 
            this.labelF1Formula.AutoSize = true;
            this.labelF1Formula.Location = new System.Drawing.Point(320, 253);
            this.labelF1Formula.Name = "labelF1Formula";
            this.labelF1Formula.Size = new System.Drawing.Size(93, 16);
            this.labelF1Formula.TabIndex = 19;
            this.labelF1Formula.Text = "f1(x) = qlog(qx)";
            // 
            // labelF2Formula
            // 
            this.labelF2Formula.AutoSize = true;
            this.labelF2Formula.Location = new System.Drawing.Point(480, 253);
            this.labelF2Formula.Name = "labelF2Formula";
            this.labelF2Formula.Size = new System.Drawing.Size(115, 16);
            this.labelF2Formula.TabIndex = 20;
            this.labelF2Formula.Text = "f2(x) = sqrt(x)/sin(x)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 585);
            this.Controls.Add(this.labelF2Formula);
            this.Controls.Add(this.labelF1Formula);
            this.Controls.Add(this.labelListBox2);
            this.Controls.Add(this.labelListBox1);
            this.Controls.Add(this.pictureBoxStudent);
            this.Controls.Add(this.labelf1Formulas);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.labelF2Count);
            this.Controls.Add(this.labelF1Count);
            this.Controls.Add(this.labelXmax);
            this.Controls.Add(this.labelDx);
            this.Controls.Add(this.labelXmin);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonDx);
            this.Controls.Add(this.buttonXmax);
            this.Controls.Add(this.buttonXmin);
            this.Controls.Add(this.textBoxXmax);
            this.Controls.Add(this.textBoxDx);
            this.Controls.Add(this.textBoxXmin);
            this.Name = "Form1";
            this.Text = "Function Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxDx;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.Button buttonXmin;
        private System.Windows.Forms.Button buttonXmax;
        private System.Windows.Forms.Button buttonDx;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelXmin;
        private System.Windows.Forms.Label labelDx;
        private System.Windows.Forms.Label labelXmax;
        private System.Windows.Forms.Label labelF1Count;
        private System.Windows.Forms.Label labelF2Count;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Label labelf1Formulas;
        private System.Windows.Forms.PictureBox pictureBoxStudent;
        private System.Windows.Forms.Label labelListBox1;
        private System.Windows.Forms.Label labelListBox2;
        private System.Windows.Forms.Label labelF1Formula;
        private System.Windows.Forms.Label labelF2Formula;
    }
}

