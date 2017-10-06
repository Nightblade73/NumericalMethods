using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class ClassMatrix
    {
        int n = 5;
        double[,] A;

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

        public string Factorization()
        {
            //for (int k = 0; k < n; k++)
            //{
            //    for (int j = k + 1; j < n; j++)
            //        A[k, j] = A[k, j] / A[k, k];
            //    for (int i = k + 1; i < n; i++)
            //        for (int j = k + 1; j < n; j++)
            //            A[i, j] = A[i, j] - A[i, k] * A[k, j];
            //}


            for (int k = n - 1; k >= 0; k--)
            {
                for (int j = k - 1; j >= 0; j--)
                    A[k, j] = A[k, j] / A[k, k];
                for (int i = k - 1; i >= 0; i--)
                    for (int j = k - 1; j >= 0; j--)
                        A[i, j] = A[i, j] - A[i, k] * A[k, j];
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
                    s += Math.Round(A[i, j], 2) + "\t";

                }
                s += Environment.NewLine;
            }

            return s;
        }
    }
}
