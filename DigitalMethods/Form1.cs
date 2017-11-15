using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalMethods
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        int action = 1;
        List<double> errorX;
        List<double> errorI;

        public Form1()
        {
            InitializeComponent();
            chart.Series.Clear();
            
            errorI = new List<double>();
            errorX = new List<double>();
        }

        private void butFact_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                tBResults.Clear();
                switch (action)
                {
                    case 1:
                        tBResults.Text += Processing.DoChislMethod(ref data);
                        break;
                    case 2:
                        int n = int.Parse(tBMaxSize.Text);
                        errorI.Clear();
                        errorX.Clear();
                        chart.Series.Clear();
                        chart.Series.Add("Погрешность X");
                        chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                        chart.Series.Add("Погрешность обратной матрицы");
                        chart.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                        for (int i = 5; i <= n; i += 5)
                        {
                            data = new Data();
                            data.Init(i);
                            tBResults.Text += Processing.DoChislMethod(ref data);
                            errorX.Add(data.ErrorX);
                            errorI.Add(data.ErrorI);
                        }
                        for (int i = 1; i < errorX.Count+1; i++)
                        {
                            chart.Series[0].Points.AddXY(i * 5, errorX[i-1]);
                            chart.Series[1].Points.AddXY(i * 5, errorI[i-1]);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Данные пусты");

            }
        }

        private void очиститьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBResults.Clear();
        }

        private void ввестиСКлавиатурыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FfromKeyboard form = new FfromKeyboard();
            form.ShowForm(ref data);
            action = 1;
        }

        private void случайнымОбразомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 2;
        }

        private void заданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7. LU -разложение на основе\nгауссова исключения по\nстрокам с выбором\nглавного элемента по строке");
        }
    }
}
