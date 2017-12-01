namespace WindowsFormsApplication6
{
    partial class FormGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMatrix = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMatrix)).BeginInit();
            this.SuspendLayout();
            // 
            // chartX
            // 
            chartArea1.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartX.Legends.Add(legend1);
            this.chartX.Location = new System.Drawing.Point(55, 21);
            this.chartX.Name = "chartX";
            this.chartX.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartX.Series.Add(series1);
            this.chartX.Size = new System.Drawing.Size(730, 205);
            this.chartX.TabIndex = 0;
            this.chartX.Text = "chartX";
            // 
            // chartMatrix
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMatrix.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMatrix.Legends.Add(legend2);
            this.chartMatrix.Location = new System.Drawing.Point(55, 247);
            this.chartMatrix.Name = "chartMatrix";
            this.chartMatrix.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMatrix.Series.Add(series2);
            this.chartMatrix.Size = new System.Drawing.Size(730, 216);
            this.chartMatrix.TabIndex = 1;
            this.chartMatrix.Text = "chartMatrix";
            this.chartMatrix.Click += new System.EventHandler(this.chartMatrix_Click);
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(859, 475);
            this.Controls.Add(this.chartMatrix);
            this.Controls.Add(this.chartX);
            this.Name = "FormGraphics";
            this.Text = "FormGraphics";
            this.Load += new System.EventHandler(this.FormGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMatrix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMatrix;
    }
}