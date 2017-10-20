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
            this.buttonRand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFact = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(545, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(399, 370);
            this.textBox1.TabIndex = 0;
            // 
            // buttonRand
            // 
            this.buttonRand.Location = new System.Drawing.Point(49, 57);
            this.buttonRand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRand.Name = "buttonRand";
            this.buttonRand.Size = new System.Drawing.Size(100, 28);
            this.buttonRand.TabIndex = 1;
            this.buttonRand.Text = "Randomize";
            this.buttonRand.UseVisualStyleBackColor = true;
            this.buttonRand.Click += new System.EventHandler(this.button1_Click);
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
            // buttonFact
            // 
            this.buttonFact.Location = new System.Drawing.Point(49, 92);
            this.buttonFact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(100, 28);
            this.buttonFact.TabIndex = 3;
            this.buttonFact.Text = "Factorization";
            this.buttonFact.UseVisualStyleBackColor = true;
            this.buttonFact.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 127);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Find detA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonFact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRand);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonRand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFact;
        private System.Windows.Forms.Button button2;
    }
}

