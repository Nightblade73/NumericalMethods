namespace WindowsFormsApplication6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.rBkeys = new System.Windows.Forms.RadioButton();
            this.rBrand = new System.Windows.Forms.RadioButton();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.buttonInputMatrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 161);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(868, 355);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "UḸ -разложение на основе гауссова исключения по столбцам с выбором главного элеме" +
    "нта по столбцу";
            // 
            // buttonCompute
            // 
            this.buttonCompute.Enabled = false;
            this.buttonCompute.Location = new System.Drawing.Point(630, 52);
            this.buttonCompute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(214, 70);
            this.buttonCompute.TabIndex = 3;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rBkeys
            // 
            this.rBkeys.AutoSize = true;
            this.rBkeys.BackColor = System.Drawing.SystemColors.Control;
            this.rBkeys.Location = new System.Drawing.Point(24, 59);
            this.rBkeys.Name = "rBkeys";
            this.rBkeys.Size = new System.Drawing.Size(125, 21);
            this.rBkeys.TabIndex = 4;
            this.rBkeys.TabStop = true;
            this.rBkeys.Text = "Keyboard Input";
            this.rBkeys.UseVisualStyleBackColor = false;
            this.rBkeys.CheckedChanged += new System.EventHandler(this.rBkeys_CheckedChanged);
            // 
            // rBrand
            // 
            this.rBrand.AutoSize = true;
            this.rBrand.Location = new System.Drawing.Point(24, 100);
            this.rBrand.Name = "rBrand";
            this.rBrand.Size = new System.Drawing.Size(82, 21);
            this.rBrand.TabIndex = 5;
            this.rBrand.TabStop = true;
            this.rBrand.Text = "Random";
            this.rBrand.UseVisualStyleBackColor = true;
            this.rBrand.CheckedChanged += new System.EventHandler(this.rBrand_CheckedChanged);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Enabled = false;
            this.textBoxFrom.Location = new System.Drawing.Point(230, 100);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(64, 22);
            this.textBoxFrom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Enabled = false;
            this.textBoxTo.Location = new System.Drawing.Point(359, 100);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(66, 22);
            this.textBoxTo.TabIndex = 9;
            // 
            // buttonInputMatrix
            // 
            this.buttonInputMatrix.Enabled = false;
            this.buttonInputMatrix.Location = new System.Drawing.Point(214, 57);
            this.buttonInputMatrix.Name = "buttonInputMatrix";
            this.buttonInputMatrix.Size = new System.Drawing.Size(111, 23);
            this.buttonInputMatrix.TabIndex = 10;
            this.buttonInputMatrix.Text = "Input Matrix";
            this.buttonInputMatrix.UseVisualStyleBackColor = true;
            this.buttonInputMatrix.Click += new System.EventHandler(this.buttonInputMatrix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 544);
            this.Controls.Add(this.buttonInputMatrix);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.rBrand);
            this.Controls.Add(this.rBkeys);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.RadioButton rBkeys;
        private System.Windows.Forms.RadioButton rBrand;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonInputMatrix;
    }
}

