namespace DigitalMethods
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.генерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиСКлавиатурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнымОбразомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плохоОбусловленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрицаГильбертаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матрица9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBResults = new System.Windows.Forms.TextBox();
            this.butFact = new System.Windows.Forms.Button();
            this.zadanie = new System.Windows.Forms.Label();
            this.tBMaxSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBErrorI = new System.Windows.Forms.RadioButton();
            this.rBErrorX = new System.Windows.Forms.RadioButton();
            this.bDataToFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tBArg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBMinSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBStep = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияToolStripMenuItem,
            this.очиститьОкноToolStripMenuItem,
            this.заданиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // генерацияToolStripMenuItem
            // 
            this.генерацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ввестиСКлавиатурыToolStripMenuItem,
            this.случайнымОбразомToolStripMenuItem,
            this.плохоОбусловленныеToolStripMenuItem});
            this.генерацияToolStripMenuItem.Name = "генерацияToolStripMenuItem";
            this.генерацияToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.генерацияToolStripMenuItem.Text = "Генерация";
            // 
            // ввестиСКлавиатурыToolStripMenuItem
            // 
            this.ввестиСКлавиатурыToolStripMenuItem.Name = "ввестиСКлавиатурыToolStripMenuItem";
            this.ввестиСКлавиатурыToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.ввестиСКлавиатурыToolStripMenuItem.Text = "Ввести с клавиатуры";
            this.ввестиСКлавиатурыToolStripMenuItem.Click += new System.EventHandler(this.ввестиСКлавиатурыToolStripMenuItem_Click);
            // 
            // случайнымОбразомToolStripMenuItem
            // 
            this.случайнымОбразомToolStripMenuItem.Name = "случайнымОбразомToolStripMenuItem";
            this.случайнымОбразомToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.случайнымОбразомToolStripMenuItem.Text = "Случайным образом";
            this.случайнымОбразомToolStripMenuItem.Click += new System.EventHandler(this.случайнымОбразомToolStripMenuItem_Click);
            // 
            // плохоОбусловленныеToolStripMenuItem
            // 
            this.плохоОбусловленныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.матрицаГильбертаToolStripMenuItem,
            this.матрица1ToolStripMenuItem,
            this.матрица2ToolStripMenuItem,
            this.матрица3ToolStripMenuItem,
            this.матрица4ToolStripMenuItem,
            this.матрица5ToolStripMenuItem,
            this.матрица6ToolStripMenuItem,
            this.матрица7ToolStripMenuItem,
            this.матрица8ToolStripMenuItem,
            this.матрица9ToolStripMenuItem});
            this.плохоОбусловленныеToolStripMenuItem.Name = "плохоОбусловленныеToolStripMenuItem";
            this.плохоОбусловленныеToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.плохоОбусловленныеToolStripMenuItem.Text = "Плохо обусловленные";
            // 
            // матрицаГильбертаToolStripMenuItem
            // 
            this.матрицаГильбертаToolStripMenuItem.Name = "матрицаГильбертаToolStripMenuItem";
            this.матрицаГильбертаToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрицаГильбертаToolStripMenuItem.Text = "Матрица Гильберта";
            this.матрицаГильбертаToolStripMenuItem.Click += new System.EventHandler(this.матрицаГильбертаToolStripMenuItem_Click);
            // 
            // матрица1ToolStripMenuItem
            // 
            this.матрица1ToolStripMenuItem.Name = "матрица1ToolStripMenuItem";
            this.матрица1ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица1ToolStripMenuItem.Text = "Матрица 1";
            this.матрица1ToolStripMenuItem.Click += new System.EventHandler(this.матрица1ToolStripMenuItem_Click);
            // 
            // матрица2ToolStripMenuItem
            // 
            this.матрица2ToolStripMenuItem.Name = "матрица2ToolStripMenuItem";
            this.матрица2ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица2ToolStripMenuItem.Text = "Матрица 2";
            this.матрица2ToolStripMenuItem.Click += new System.EventHandler(this.матрица2ToolStripMenuItem_Click);
            // 
            // матрица3ToolStripMenuItem
            // 
            this.матрица3ToolStripMenuItem.Name = "матрица3ToolStripMenuItem";
            this.матрица3ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица3ToolStripMenuItem.Text = "Матрица 3";
            this.матрица3ToolStripMenuItem.Click += new System.EventHandler(this.матрица3ToolStripMenuItem_Click);
            // 
            // матрица4ToolStripMenuItem
            // 
            this.матрица4ToolStripMenuItem.Name = "матрица4ToolStripMenuItem";
            this.матрица4ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица4ToolStripMenuItem.Text = "Матрица 4";
            this.матрица4ToolStripMenuItem.Click += new System.EventHandler(this.матрица4ToolStripMenuItem_Click);
            // 
            // матрица5ToolStripMenuItem
            // 
            this.матрица5ToolStripMenuItem.Name = "матрица5ToolStripMenuItem";
            this.матрица5ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица5ToolStripMenuItem.Text = "Матрица 5";
            this.матрица5ToolStripMenuItem.Click += new System.EventHandler(this.матрица5ToolStripMenuItem_Click);
            // 
            // матрица6ToolStripMenuItem
            // 
            this.матрица6ToolStripMenuItem.Name = "матрица6ToolStripMenuItem";
            this.матрица6ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица6ToolStripMenuItem.Text = "Матрица 6";
            this.матрица6ToolStripMenuItem.Click += new System.EventHandler(this.матрица6ToolStripMenuItem_Click);
            // 
            // матрица7ToolStripMenuItem
            // 
            this.матрица7ToolStripMenuItem.Name = "матрица7ToolStripMenuItem";
            this.матрица7ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица7ToolStripMenuItem.Text = "Матрица 7";
            this.матрица7ToolStripMenuItem.Click += new System.EventHandler(this.матрица7ToolStripMenuItem_Click);
            // 
            // матрица8ToolStripMenuItem
            // 
            this.матрица8ToolStripMenuItem.Name = "матрица8ToolStripMenuItem";
            this.матрица8ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица8ToolStripMenuItem.Text = "Матрица 8";
            this.матрица8ToolStripMenuItem.Click += new System.EventHandler(this.матрица8ToolStripMenuItem_Click);
            // 
            // матрица9ToolStripMenuItem
            // 
            this.матрица9ToolStripMenuItem.Name = "матрица9ToolStripMenuItem";
            this.матрица9ToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.матрица9ToolStripMenuItem.Text = "Матрица 9";
            this.матрица9ToolStripMenuItem.Click += new System.EventHandler(this.матрица9ToolStripMenuItem_Click);
            // 
            // очиститьОкноToolStripMenuItem
            // 
            this.очиститьОкноToolStripMenuItem.Name = "очиститьОкноToolStripMenuItem";
            this.очиститьОкноToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.очиститьОкноToolStripMenuItem.Text = "Очистить окно";
            this.очиститьОкноToolStripMenuItem.Click += new System.EventHandler(this.очиститьОкноToolStripMenuItem_Click);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.заданиеToolStripMenuItem.Text = "Задание";
            this.заданиеToolStripMenuItem.Click += new System.EventHandler(this.заданиеToolStripMenuItem_Click);
            // 
            // tBResults
            // 
            this.tBResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBResults.Location = new System.Drawing.Point(12, 31);
            this.tBResults.Multiline = true;
            this.tBResults.Name = "tBResults";
            this.tBResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBResults.Size = new System.Drawing.Size(962, 379);
            this.tBResults.TabIndex = 1;
            this.tBResults.WordWrap = false;
            // 
            // butFact
            // 
            this.butFact.Location = new System.Drawing.Point(980, 31);
            this.butFact.Name = "butFact";
            this.butFact.Size = new System.Drawing.Size(138, 67);
            this.butFact.TabIndex = 3;
            this.butFact.Text = "Произвести расчёт";
            this.butFact.UseVisualStyleBackColor = true;
            this.butFact.Click += new System.EventHandler(this.butFact_Click);
            // 
            // zadanie
            // 
            this.zadanie.AutoSize = true;
            this.zadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zadanie.Location = new System.Drawing.Point(886, 482);
            this.zadanie.Name = "zadanie";
            this.zadanie.Size = new System.Drawing.Size(0, 18);
            this.zadanie.TabIndex = 4;
            // 
            // tBMaxSize
            // 
            this.tBMaxSize.Location = new System.Drawing.Point(980, 138);
            this.tBMaxSize.Name = "tBMaxSize";
            this.tBMaxSize.Size = new System.Drawing.Size(138, 22);
            this.tBMaxSize.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Максимальный\r\nразмер матрицы\r\n";
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.SystemColors.Menu;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(12, 416);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(962, 395);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBErrorI);
            this.groupBox1.Controls.Add(this.rBErrorX);
            this.groupBox1.Location = new System.Drawing.Point(980, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Погрешность на графике:";
            // 
            // rBErrorI
            // 
            this.rBErrorI.AutoSize = true;
            this.rBErrorI.Location = new System.Drawing.Point(3, 65);
            this.rBErrorI.Name = "rBErrorI";
            this.rBErrorI.Size = new System.Drawing.Size(120, 72);
            this.rBErrorI.TabIndex = 10;
            this.rBErrorI.Text = "Погрешность \r\nобратной \r\nматрицы\r\n\r\n";
            this.rBErrorI.UseVisualStyleBackColor = true;
            this.rBErrorI.CheckedChanged += new System.EventHandler(this.rBErrorI_CheckedChanged);
            // 
            // rBErrorX
            // 
            this.rBErrorX.AutoSize = true;
            this.rBErrorX.Checked = true;
            this.rBErrorX.Location = new System.Drawing.Point(3, 38);
            this.rBErrorX.Name = "rBErrorX";
            this.rBErrorX.Size = new System.Drawing.Size(129, 21);
            this.rBErrorX.TabIndex = 9;
            this.rBErrorX.TabStop = true;
            this.rBErrorX.Text = "Погрешность Х";
            this.rBErrorX.UseVisualStyleBackColor = true;
            this.rBErrorX.CheckedChanged += new System.EventHandler(this.rBErrorX_CheckedChanged);
            // 
            // bDataToFile
            // 
            this.bDataToFile.Location = new System.Drawing.Point(983, 472);
            this.bDataToFile.Name = "bDataToFile";
            this.bDataToFile.Size = new System.Drawing.Size(135, 66);
            this.bDataToFile.TabIndex = 9;
            this.bDataToFile.Text = "Выгрузить данные в файл";
            this.bDataToFile.UseVisualStyleBackColor = true;
            this.bDataToFile.Click += new System.EventHandler(this.bDataToFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files | *.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(980, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Угол для матрицы";
            // 
            // tBArg
            // 
            this.tBArg.Location = new System.Drawing.Point(980, 294);
            this.tBArg.Name = "tBArg";
            this.tBArg.Size = new System.Drawing.Size(138, 22);
            this.tBArg.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(980, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "Минимальный\r\nразмер матрицы\r\n";
            // 
            // tBMinSize
            // 
            this.tBMinSize.Location = new System.Drawing.Point(980, 200);
            this.tBMinSize.Name = "tBMinSize";
            this.tBMinSize.Size = new System.Drawing.Size(138, 22);
            this.tBMinSize.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Шаг";
            // 
            // tBStep
            // 
            this.tBStep.Location = new System.Drawing.Point(980, 245);
            this.tBStep.Name = "tBStep";
            this.tBStep.Size = new System.Drawing.Size(138, 22);
            this.tBStep.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 803);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBStep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBMinSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBArg);
            this.Controls.Add(this.bDataToFile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBMaxSize);
            this.Controls.Add(this.zadanie);
            this.Controls.Add(this.butFact);
            this.Controls.Add(this.tBResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem генерацияToolStripMenuItem;
        private System.Windows.Forms.TextBox tBResults;
        private System.Windows.Forms.Button butFact;
        private System.Windows.Forms.ToolStripMenuItem очиститьОкноToolStripMenuItem;
        private System.Windows.Forms.Label zadanie;
        private System.Windows.Forms.ToolStripMenuItem ввестиСКлавиатурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem случайнымОбразомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плохоОбусловленныеToolStripMenuItem;
        private System.Windows.Forms.TextBox tBMaxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBErrorI;
        private System.Windows.Forms.RadioButton rBErrorX;
        private System.Windows.Forms.Button bDataToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem матрицаГильбертаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матрица9ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBArg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBMinSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBStep;
    }
}

