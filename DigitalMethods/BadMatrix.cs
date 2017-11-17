using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMethods
{
    static class BadMatrix
    {
        public static Data Gilbert(int n)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i - 1, j - 1] = (double)1 / (i + j - 1);
                }
            }
            data.A = a;
            return data;
        }
        public static Data Matrix1(int n)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i - 1, j - 1] = (double)1 / (i + j - 1);
                }
            }
            data.A = a;
            return data;
        }
        public static Data Matrix2()
        {
            Data data = new Data();
            data.Init(7);
            double[,] a = { { 5, 4, 7 ,5 ,6 ,7 ,5 },
                            { 4, 12, 8 ,7 ,8 ,8 ,6 },
                            { 7, 8, 10 ,9 ,8 ,7 ,7 },
                            { 5, 7, 9 ,11 ,9 ,7 ,5 },
                            { 6, 8, 8 ,9 ,10 ,8 ,9 },
                            { 7, 8, 7 ,7 ,8 ,10 ,10 },
                            { 5, 6, 7 ,5 ,9 ,10 ,10 }};

            data.A = a;
            return data;
        }
    }
}
