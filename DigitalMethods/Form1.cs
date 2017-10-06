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
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
            }
            tBResults.Text = ArrayToString();

        }
        int k = 0;
        int[] q = new int[n];
        static int n = 4;
        //   int[,] A = new int[n, n];
        double[,] A = { { 2, 4, -4, 6 },
                     { 1, 4, 2, 1 },
                     { 3, 8, 1, 1 },
                     { 2, 5, 0, 5 }};
        private bool key = false;

        private void butSelectMainElement_Click(object sender, EventArgs e)
        {
            key = true;
            //// Массивы перестановок: p - массив номеров строк, // q - массив номеров столбцов 
            ////       int[] p = new int[n];
            //int[] q = new int[n];
            ////вспомогательные переменные 
            ////   int imax = 0;
            //int jmax = 0;
            //int buf = 0; // Заполняем массивы перестановок начальными значениями 
            //// перед началом факторизации

            //for (int i = 0; i < n; i++)
            //{
            //    //         p[i] = i;
            //    q[i] = i;
            //} // Этот фрагмент вставляем в алгоритм факторизации 
            //  // n - размер задачи, k - номер текущего шага алгоритма 
            //  //    imax = k;
            //jmax = k;
            //for (int i = k; i < n; i++)
            //    for (int j = k; j < n; j++)
            //        if (Math.Abs(A[i, q[j]]) > Math.Abs(A[i, q[jmax]]))
            //        {
            //            //  imax = i;
            //            jmax = j;
            //        }
            //// Обмен 
            ////if (imax != k)
            ////{
            ////    buf = p[k];
            ////    p[k] = p[imax];
            ////    p[imax] = buf;
            ////}
            //if (jmax != k)
            //{
            //    buf = q[k];
            //    q[k] = q[jmax];
            //    q[jmax] = buf;
            //}
            //tBResults.Text += ArrayToString();
        }
        public void ChangeColumns(int k)
        {
            //вспомогательные переменные 
            int jmax = 0;
            int buf = 0; // Заполняем массивы перестановок начальными значениями 
            // перед началом факторизации


            // Этот фрагмент вставляем в алгоритм факторизации 
            // n - размер задачи, k - номер текущего шага алгоритма 
            jmax = k;
            for (int j = k; j < n; j++)
                if (Math.Abs(A[k, q[j]]) > Math.Abs(A[k, q[jmax]]))
                {
                    jmax = j;
                }
            if (jmax != k)
            {
                buf = q[k];
                q[k] = q[jmax];
                q[jmax] = buf;
            }
        }
        public string ArrayToString()
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result += Math.Round(A[i, j], 3) + "\t";
                }
                result += "\r\n";
            }
            if (key)
            {
                for (int i = 0; i < n; i++)
                {
                    result += q[i] + "\t";
                }
                result += "\r\n";
            }

            return result + "\r\n";
        }

        private void butFact_Click(object sender, EventArgs e)
        {
            //for (int j = k; j < n; j++)
            //    A[k, j] = A[k, j] / A[k, k];
            //for (int i = k + 1; i < n; i++)
            //    for (int j = k; j < n; j++)
            //        A[i, j] = A[i, j] - A[i, k] * A[k, j];

            //for (int k = 0; k < n; k++)
            //{
            //    for (int i = k + 1; i < n; i++)
            //        A[i, k] = A[i, k] / A[k, k];
            //    for (int j = k + 1; j < n; j++)
            //        for (int i = k + 1; i < n; i++)
            //            A[i, j] = A[i, j] - A[k, j] * A[i, k];
            //    tBResults.Text += ArrayToString();
            //}

            //for (int k = 0; k < n - 1; k++)
            //{
            //    for (int j = k + 1; j < n; j++)
            //        A[k, j] = A[k, ]] / A[k, k];
            //    for (int i = k + 1; i < n; i++)
            //        for (int j = k + 1; j < n; j++)
            //            A[i, j] = A[i, j] - A[i, k] * A[k, j];
            //    tBResults.Text += ArrayToString();
            //}
            for (int k = 0; k < n - 1; k++)
            {
                if (key)
                    ChangeColumns(k);
                for (int j = k + 1; j < n; j++)
                    A[k, q[j]] = A[k, q[j]] / A[k, q[k]];
                for (int i = k + 1; i < n; i++)
                    for (int j = k + 1; j < n; j++)
                        A[i, q[j]] = A[i, q[j]] - A[i, q[k]] * A[k, q[j]];
                tBResults.Text += ArrayToString();
            }
        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //   string result = "";
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = (r.NextDouble() * 2 - 1) * 100;
                }
                //      result += "\r\n";
            }
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
            }
            tBResults.Text += ArrayToString();
        }

        private void очиститьОкноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tBResults.Clear();
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
            }
        }
    }
}
