using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class FormGraphics : Form 
    {
        List<double> xDeltaList;
        List<double> matrixList;
        int i;
        public FormGraphics(List<double> xDeltaList, List<double> matrixList, int i)
        {
            InitializeComponent();
            this.xDeltaList = xDeltaList;
            this.matrixList = matrixList;
            this.i = i;
            ChartRefresh();
        }

        private void FormGraphics_Load(object sender, EventArgs e)
        {

        }
        public void ChartRefresh()
        {
            chartX.Series.Clear();
            chartX.Series.Add("Погрешность X");
            chartX.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            for (int i = 0; i < xDeltaList.Count; i++)
            {
                chartX.Series[0].Points.AddXY(i * 5 + this.i, xDeltaList[i]);
            }
            chartMatrix.Series.Clear();
            chartMatrix.Series.Add("Погрешность\r\nобратной\r\nматрицы");
            chartMatrix.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
        
            for (int i = 0; i < matrixList.Count; i++)
            {
                chartMatrix.Series[0].Points.AddXY(i * 5 + this.i, matrixList[i]);
            }

        }

        private void chartMatrix_Click(object sender, EventArgs e)
        {

        }
    }
}
