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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.генерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tBResults = new System.Windows.Forms.TextBox();
            this.butFact = new System.Windows.Forms.Button();
            this.zadanie = new System.Windows.Forms.Label();
            this.butProcDet = new System.Windows.Forms.Button();
            this.butFindAnswer = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияToolStripMenuItem,
            this.очиститьОкноToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1130, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // генерацияToolStripMenuItem
            // 
            this.генерацияToolStripMenuItem.Name = "генерацияToolStripMenuItem";
            this.генерацияToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.генерацияToolStripMenuItem.Text = "Генерация";
            this.генерацияToolStripMenuItem.Click += new System.EventHandler(this.генерацияToolStripMenuItem_Click);
            // 
            // очиститьОкноToolStripMenuItem
            // 
            this.очиститьОкноToolStripMenuItem.Name = "очиститьОкноToolStripMenuItem";
            this.очиститьОкноToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.очиститьОкноToolStripMenuItem.Text = "Очистить окно";
            this.очиститьОкноToolStripMenuItem.Click += new System.EventHandler(this.очиститьОкноToolStripMenuItem_Click);
            // 
            // tBResults
            // 
            this.tBResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBResults.Location = new System.Drawing.Point(12, 101);
            this.tBResults.Multiline = true;
            this.tBResults.Name = "tBResults";
            this.tBResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBResults.Size = new System.Drawing.Size(442, 407);
            this.tBResults.TabIndex = 1;
            // 
            // butFact
            // 
            this.butFact.Location = new System.Drawing.Point(156, 514);
            this.butFact.Name = "butFact";
            this.butFact.Size = new System.Drawing.Size(138, 67);
            this.butFact.TabIndex = 3;
            this.butFact.Text = "Факторизация";
            this.butFact.UseVisualStyleBackColor = true;
            this.butFact.Click += new System.EventHandler(this.butFact_Click);
            // 
            // zadanie
            // 
            this.zadanie.AutoSize = true;
            this.zadanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zadanie.Location = new System.Drawing.Point(522, 149);
            this.zadanie.Name = "zadanie";
            this.zadanie.Size = new System.Drawing.Size(215, 72);
            this.zadanie.TabIndex = 4;
            this.zadanie.Text = "7. LU -разложение на основе\r\nгауссова исключения по \r\nстрокам с выбором \r\nглавног" +
    "о элемента по строке";
            // 
            // butProcDet
            // 
            this.butProcDet.Location = new System.Drawing.Point(12, 514);
            this.butProcDet.Name = "butProcDet";
            this.butProcDet.Size = new System.Drawing.Size(138, 67);
            this.butProcDet.TabIndex = 5;
            this.butProcDet.Text = "Подсчитать определитель";
            this.butProcDet.UseVisualStyleBackColor = true;
            this.butProcDet.Click += new System.EventHandler(this.butProcDet_Click);
            // 
            // butFindAnswer
            // 
            this.butFindAnswer.Location = new System.Drawing.Point(300, 514);
            this.butFindAnswer.Name = "butFindAnswer";
            this.butFindAnswer.Size = new System.Drawing.Size(138, 67);
            this.butFindAnswer.TabIndex = 6;
            this.butFindAnswer.Text = "Найти решение СЛАУ";
            this.butFindAnswer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 753);
            this.Controls.Add(this.butFindAnswer);
            this.Controls.Add(this.butProcDet);
            this.Controls.Add(this.zadanie);
            this.Controls.Add(this.butFact);
            this.Controls.Add(this.tBResults);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button butProcDet;
        private System.Windows.Forms.Button butFindAnswer;
    }
}

