using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class ClassMatrix
    {
        int n = 4;
        double[,] A = { { 2, 4, -4, 6 },
                        { 1, 4, 2, 1 },
                        { 3, 8, 1, 1 },
                        { 2, 5, 0, 5 }};
        double[,] UL;

        public double[,] AGetter
        {
            get { return A; }
        }
        public double[,] ULGetter
        {
            get { return UL; }
        }

        public string Randomize(int n)
        {
            Random temp = new Random();

            A = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = Convert.ToDouble(temp.Next(-100, 100));
                }

            }
            return Result();
        }
        public void Clone()
        {
            UL = new double[n, n];
            UL = (double[,])A.Clone();
        }

        public string Factorization()
        {
            Clone();
            for (int k = n - 1; k >= 0; k--)
            {
                for (int j = k - 1; j >= 0; j--)
                    UL[k, j] = UL[k, j] / UL[k, k];
                for (int i = k - 1; i >= 0; i--)
                    for (int j = k - 1; j >= 0; j--)
                        UL[i, j] = UL[i, j] - UL[i, k] * UL[k, j];
            }
            return Result();
        }

        public string Result()
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += Math.Round(UL[i, j], 2) + "\t";
                }
                s += Environment.NewLine;
            }
            return s;
        }

        public double[,] GetMinor(double[,] A, int row, int column)
        {
            if (A.GetLength(0) != A.GetLength(1)) throw new Exception(" Число строк в матрице не совпадает с числом столбцов");
            double[,] buf = new double[A.GetLength(0) - 1, A.GetLength(0) - 1];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column) buf[i - 1, j] = A[i, j];
                        if (i < row && j > column) buf[i, j - 1] = A[i, j];
                        if (i > row && j > column) buf[i - 1, j - 1] = A[i, j];
                        if (i < row && j < column) buf[i, j] = A[i, j];
                    }
                }
            return buf;
        }
        public double Determ(double[,] A)
        {
            if (A.GetLength(0) != A.GetLength(1)) throw new Exception(" Число строк в матрице не совпадает с числом столбцов");
            double det = 0;
            int Rank = A.GetLength(0);
            if (Rank == 1) det = A[0, 0];
            if (Rank == 2) det = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            if (Rank > 2)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    det += Math.Pow(-1, 0 + j) * A[0, j] * Determ(GetMinor(A, 0, j));
                }
            }
            return det;
        }

       public string HelperSolve(double[,] luMatrix, double[] b)
        {
            // Решаем luMatrix * x = b
           
            string s = "";
            double[] x = new double[n];
            b.CopyTo(x, 0);
            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= luMatrix[i,j] * x[j];
                x[i] = sum;
            }
            x[n - 1] /= luMatrix[n - 1,n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= luMatrix[i,j] * x[j];
                x[i] = sum / luMatrix[i,i];
                
            }
            for (int i = 0; i < x.Length; i++) { s += (Environment.NewLine + x[i] ); }
            return s ;
        }
    }
}
