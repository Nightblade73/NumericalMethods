﻿namespace DigitalMethods
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.генерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиСКлавиатурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.случайнымОбразомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плохоОбусловленныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.плохоОбусловленныеToolStripMenuItem.Name = "плохоОбусловленныеToolStripMenuItem";
            this.плохоОбусловленныеToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.плохоОбусловленныеToolStripMenuItem.Text = "Плохо обусловленные";
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
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(12, 416);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(962, 395);
            this.chart.TabIndex = 7;
            this.chart.Text = "chart";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBErrorI);
            this.groupBox1.Controls.Add(this.rBErrorX);
            this.groupBox1.Location = new System.Drawing.Point(980, 166);
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
            this.bDataToFile.Location = new System.Drawing.Point(983, 310);
            this.bDataToFile.Name = "bDataToFile";
            this.bDataToFile.Size = new System.Drawing.Size(135, 57);
            this.bDataToFile.TabIndex = 9;
            this.bDataToFile.Text = "Выгрузить данные в файл";
            this.bDataToFile.UseVisualStyleBackColor = true;
            this.bDataToFile.Click += new System.EventHandler(this.bDataToFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text Files | *.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 803);
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
    }
}

