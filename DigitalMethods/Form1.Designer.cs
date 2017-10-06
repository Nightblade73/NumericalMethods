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
            this.butSelectMainElement = new System.Windows.Forms.Button();
            this.butFact = new System.Windows.Forms.Button();
            this.zadanie = new System.Windows.Forms.Label();
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
            this.menuStrip1.Size = new System.Drawing.Size(701, 28);
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
            this.tBResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBResults.Location = new System.Drawing.Point(12, 27);
            this.tBResults.Multiline = true;
            this.tBResults.Name = "tBResults";
            this.tBResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBResults.Size = new System.Drawing.Size(442, 407);
            this.tBResults.TabIndex = 1;
            // 
            // butSelectMainElement
            // 
            this.butSelectMainElement.Location = new System.Drawing.Point(460, 31);
            this.butSelectMainElement.Name = "butSelectMainElement";
            this.butSelectMainElement.Size = new System.Drawing.Size(138, 64);
            this.butSelectMainElement.TabIndex = 2;
            this.butSelectMainElement.Text = "Выбор главного элемента";
            this.butSelectMainElement.UseVisualStyleBackColor = true;
            this.butSelectMainElement.Click += new System.EventHandler(this.butSelectMainElement_Click);
            // 
            // butFact
            // 
            this.butFact.Location = new System.Drawing.Point(460, 101);
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
            this.zadanie.Location = new System.Drawing.Point(460, 362);
            this.zadanie.Name = "zadanie";
            this.zadanie.Size = new System.Drawing.Size(215, 72);
            this.zadanie.TabIndex = 4;
            this.zadanie.Text = "7. LU -разложение на основе\r\nгауссова исключения по \r\nстрокам с выбором \r\nглавног" +
    "о элемента по строке";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 446);
            this.Controls.Add(this.zadanie);
            this.Controls.Add(this.butFact);
            this.Controls.Add(this.butSelectMainElement);
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
        private System.Windows.Forms.Button butSelectMainElement;
        private System.Windows.Forms.Button butFact;
        private System.Windows.Forms.ToolStripMenuItem очиститьОкноToolStripMenuItem;
        private System.Windows.Forms.Label zadanie;
    }
}

