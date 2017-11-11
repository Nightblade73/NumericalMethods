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

        double[] x = { 1, 2, 3, 4 };
        public Form1()
        {
            InitializeComponent();
        }

        private void butFact_Click(object sender, EventArgs e)
        {
            tBResults.Text = "Начальная матрица:\r\n" + Processing.ArrayToString(data.A);
            int[] q = data.Q;
            data.LU = Processing.LUrzl(data.A, ref q);
            tBResults.Text += "Получивщаяся матрица:\r\n" + Processing.ArrayToString(data.LU);
            data.Q = q;
            tBResults.Text += "Дополнительный вектор Q:\r\n" + Processing.ArrayToString(data.Q);
            double[] b = Processing.MatrixProduct(data.A, data.X, data.Q);
            data.B = b;
            double[,] l, u;
            Processing.Division(data.LU, out l, out u, data.Q);
            data.L = l;
            data.U = u;
            double[] w = Processing.FindMatrixW(l, b, data.Q);
            data.W = w;
            data.XReady = Processing.FindMatrixX(u, w, data.Q);
            tBResults.Text += "Начальный вектор X:\r\n" + Processing.ArrayToString(data.X);
            tBResults.Text += "Получившийся вектор X:\r\n" + Processing.ArrayToString(data.XReady);
            tBResults.Text += "Детерминант: " + Processing.Determ(data.LU, data.Q) + "\r\n";
            tBResults.Text += "Погрешность X: " + string.Format("{0,10:0.###E-0}", Processing.DeltaMax(data.X, data.XReady)) + "\r\n";
            data.AInver = Processing.Inversion(data.L, data.U, data.Q);
            tBResults.Text += "Получивщаяся обратная матрица:\r\n" + Processing.ArrayToString(data.AInver);
        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //       //   string result = "";
            //       Random r = new Random();
            //       for (int i = 0; i < n; i++)
            //       {
            //           for (int j = 0; j < n; j++)
            //           {
            //               A[i, j] = (r.NextDouble() * 2 - 1) * 100;
            //           }
            //           //      result += "\r\n";
            //       }
            ////       tBResults.Text += ArrayToString();
        }

        private void очиститьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBResults.Clear();
        }
    }
}
