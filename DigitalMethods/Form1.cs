using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DigitalMethods
{
    public partial class Form1 : Form
    {
        Data data = new Data();
        int action = 1;
        List<Data> list;

        public Form1()
        {
            InitializeComponent();
            chart.Series.Clear();
            list = new List<Data>();
        }

        private void butFact_Click(object sender, EventArgs e)
        {
            if (data != null)
            {
                tBResults.Clear();
                chart.Series.Clear();
                list.Clear();
                int count = 0;
                if (action != 1)
                    if (!tBMaxSize.Text.Equals(""))
                        count = int.Parse(tBMaxSize.Text);
                    else
                    {
                        MessageBox.Show("Введите максимальную размерность матрицы");
                        return;
                    }
                switch (action)
                {
                    case 1:
                        tBResults.Text += Processing.DoChislMethod(ref data);
                        break;
                    case 2:
                        for (int i = 5; i <= count; i += 5)
                        {
                            data = new Data();
                            data.Init(i);
                            list.Add(data);
                            tBResults.Text += Processing.DoChislMethod(ref data);
                            ChartRefresh();
                        }
                        break;
                    case 3:
                        data = BadMatrix.Gilbert(count);
                        tBResults.Text += Processing.DoChislMethod(ref data);
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        data = BadMatrix.Matrix2();
                        tBResults.Text += Processing.DoChislMethod(ref data);
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
            string str = "7. LU -разложение на основе\nгауссова исключения по\nстрокам с выбором\nглавного элемента по строке";
            MessageBox.Show(str);
        }
        public void ChartRefresh()
        {
            chart.Series.Clear();
            if (rBErrorX.Checked)
            {
                chart.Series.Add("Погрешность X");
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                for (int i = 1; i < list.Count + 1; i++)
                {
                    chart.Series[0].Points.AddXY(i * 5, list[i - 1].ErrorX);
                }
            }
            else
            {
                chart.Series.Add("Погрешность\r\nобратной\r\nматрицы");
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                for (int i = 1; i < list.Count + 1; i++)
                {
                    chart.Series[0].Points.AddXY(i * 5, list[i - 1].ErrorI);
                }
            }
        }

        private void rBErrorX_CheckedChanged(object sender, EventArgs e)
        {
            ChartRefresh();
        }

        private void rBErrorI_CheckedChanged(object sender, EventArgs e)
        {
            ChartRefresh();
        }

        private void bDataToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileManager.WriteFile(saveFileDialog.FileName, tBResults.Text);
                MessageBox.Show("Данные выгружены");
            }
        }

        private void матрицаГильбертаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 3;
        }

        private void матрица1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 4;
        }

        private void матрица2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 5;
        }

        private void матрица3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 6;
        }

        private void матрица4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 7;
        }

        private void матрица5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 8;
        }

        private void матрица6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 9;
        }

        private void матрица7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 10;
        }

        private void матрица8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 11;
        }

        private void матрица9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 12;
        }

        private void матрица10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            action = 13;
        }
    }
}
