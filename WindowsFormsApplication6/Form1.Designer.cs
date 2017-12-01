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
            this.buttonGraphics = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.radioButtonBadMatrix = new System.Windows.Forms.RadioButton();
            this.comboBoxBadMatrix = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxArg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 198);
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
            this.buttonCompute.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonCompute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCompute.Enabled = false;
            this.buttonCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCompute.Location = new System.Drawing.Point(621, 59);
            this.buttonCompute.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(214, 71);
            this.buttonCompute.TabIndex = 3;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rBkeys
            // 
            this.rBkeys.AutoSize = true;
            this.rBkeys.BackColor = System.Drawing.Color.SkyBlue;
            this.rBkeys.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.rBrand.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.buttonInputMatrix.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonInputMatrix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInputMatrix.Enabled = false;
            this.buttonInputMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInputMatrix.Location = new System.Drawing.Point(230, 51);
            this.buttonInputMatrix.Name = "buttonInputMatrix";
            this.buttonInputMatrix.Size = new System.Drawing.Size(195, 37);
            this.buttonInputMatrix.TabIndex = 10;
            this.buttonInputMatrix.Text = "Input Matrix";
            this.buttonInputMatrix.UseVisualStyleBackColor = false;
            this.buttonInputMatrix.Click += new System.EventHandler(this.buttonInputMatrix_Click);
            // 
            // buttonGraphics
            // 
            this.buttonGraphics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGraphics.Enabled = false;
            this.buttonGraphics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphics.Location = new System.Drawing.Point(143, 574);
            this.buttonGraphics.Name = "buttonGraphics";
            this.buttonGraphics.Size = new System.Drawing.Size(261, 33);
            this.buttonGraphics.TabIndex = 11;
            this.buttonGraphics.Text = "Построить графики";
            this.buttonGraphics.UseVisualStyleBackColor = true;
            this.buttonGraphics.Click += new System.EventHandler(this.buttonGraphics_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Location = new System.Drawing.Point(578, 574);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(257, 33);
            this.buttonFile.TabIndex = 12;
            this.buttonFile.Text = "Сохранить в файл";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // radioButtonBadMatrix
            // 
            this.radioButtonBadMatrix.AutoSize = true;
            this.radioButtonBadMatrix.Location = new System.Drawing.Point(24, 135);
            this.radioButtonBadMatrix.Name = "radioButtonBadMatrix";
            this.radioButtonBadMatrix.Size = new System.Drawing.Size(176, 38);
            this.radioButtonBadMatrix.TabIndex = 13;
            this.radioButtonBadMatrix.TabStop = true;
            this.radioButtonBadMatrix.Text = "Плохо обусловленные\r\nматрицы";
            this.radioButtonBadMatrix.UseVisualStyleBackColor = true;
            this.radioButtonBadMatrix.CheckedChanged += new System.EventHandler(this.radioButtonBadMatrix_CheckedChanged);
            // 
            // comboBoxBadMatrix
            // 
            this.comboBoxBadMatrix.FormattingEnabled = true;
            this.comboBoxBadMatrix.Items.AddRange(new object[] {
            "Матрица Гильберта",
            "Матрица 1",
            "Матрица 2",
            "Матрица 3",
            "Матрица 4",
            "Матрица 5",
            "Матрица 6",
            "Матрица 7",
            "Матрица 8",
            "Матрица 9"});
            this.comboBoxBadMatrix.Location = new System.Drawing.Point(230, 135);
            this.comboBoxBadMatrix.Name = "comboBoxBadMatrix";
            this.comboBoxBadMatrix.Size = new System.Drawing.Size(195, 24);
            this.comboBoxBadMatrix.TabIndex = 14;
            this.comboBoxBadMatrix.SelectedIndexChanged += new System.EventHandler(this.comboBoxBadMatrix_SelectedIndexChanged);
            // 
            // textBoxArg
            // 
            this.textBoxArg.Enabled = false;
            this.textBoxArg.Location = new System.Drawing.Point(359, 165);
            this.textBoxArg.Name = "textBoxArg";
            this.textBoxArg.Size = new System.Drawing.Size(66, 22);
            this.textBoxArg.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Аргумент";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(968, 622);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxArg);
            this.Controls.Add(this.comboBoxBadMatrix);
            this.Controls.Add(this.radioButtonBadMatrix);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.buttonGraphics);
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
        private System.Windows.Forms.Button buttonGraphics;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.RadioButton radioButtonBadMatrix;
        private System.Windows.Forms.ComboBox comboBoxBadMatrix;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxArg;
        private System.Windows.Forms.Label label4;
    }
}

