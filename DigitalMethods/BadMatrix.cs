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
        public static Data Matrix1()
        {
            Data data = new Data();
            data.Init(20);
            double[,] a = new double[20, 20];
            for (int i = 0; i < 20; i++)
            {
                if (i != 19)
                {
                    a[i, i + 1] = 1;
                }
                a[i, i] = 1;
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
        public static Data Matrix3(int n)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j)

                        a[i - 1, j - 1] = 0.01 / (((double)n - (double)i + 1) * ((double)i + 1));
                    else if (i < j)
                    {
                        a[i - 1, j - 1] = 0;
                    }
                    else
                    {
                        a[i - 1, j - 1] = i * (n - j);
                    }
                }
            }
            data.A = a;
            return data;
        }

        public static Data Matrix4(int n)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i == j)
                        a[i - 1, j - 1] = 0.01 / (((double)n - (double)i + 1) * ((double)i + 1));
                    else if (i < j)
                    {
                        a[i - 1, j - 1] = j * (n - i);
                    }
                    else
                    {
                        a[i - 1, j - 1] = i * (n - j);
                    }
                }
            }
            data.A = a;
            return data;
        }

        public static Data Matrix5(double arg)
        {
            int n = 8;
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            double[,] T = new double[,] { { 1, 1 }, { 1, 1 } };
            double[,] R = new double[,] { { ctg(arg), cosec(arg) }, { -cosec(arg), ctg(arg) } };
            double[,] S = new double[,] { { 1 - ctg(arg), cosec(arg) }, { 1 - cosec(arg), 1 + ctg(arg) } };
            for (int i = 0; i < n; i += 2)
            {
                for (int j = 0; j < n; j += 2)
                {
                    double[,] V = null;
                    if (i == j)
                    {
                        V = R;
                    }
                    else if (i == j + 2 || i + 2 == j)
                    {
                        V = S;
                    }
                    else
                    {
                        V = T;
                    }
                    for (int k = 0; k < 2; k++)
                    {
                        for (int t = 0; t < 2; t++)
                        {
                            a[i + k, j + t] = V[k, t];
                        }
                    }
                }
            }
            data.A = a;
            return data;
        }
        static double cosec(double arg)
        {
            try
            {
                return 1 / Math.Sin(arg);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        static double ctg(double arg)
        {
            try
            {
                return Math.Sin(arg) / Math.Cos(arg);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static Data Matrix6(int n, double arg)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                a[i - 1, i - 1] = Math.Pow(arg, Math.Abs((double)n - (double)i * 2) / 2);
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i != j)
                    {
                        if (i == 1 || j == 1)
                        {
                            a[i - 1, j - 1] = a[0, 0] / Math.Pow(arg, (double)j);
                        }
                        else if (i == n || j == n)
                        {
                            a[i - 1, j - 1] = a[n - 1, n - 1] / Math.Pow(arg, (double)j);
                        }
                        else
                        {
                            a[i - 1, j - 1] = 0;
                        }
                    }
                }
            }
            data.A = a;
            return data;
        }
        public static Data Matrix7(int n, double arg)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i - 1, j - 1] = Math.Exp((double)i * (double)j * arg);
                }
            }
            data.A = a;
            return data;
        }
        public static Data Matrix8(int n, double arg)
        {
            Data data = new Data();
            data.Init(n);
            double[,] a = new double[n, n];
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    a[i - 1, j - 1] = arg + Math.Log((double)i * (double)j, 2);
                }
            }
            data.A = a;
            return data;
        }
        public static Data Matrix9()
        {
            Data data = new Data();
            data.Init(4);
            double[,] a = new double[,] { { 0.9143 * Math.Pow(10, -4), 0, 0, 0 },
                { 0.8762, 0.756 * Math.Pow(10, -4), 0, 0 }, 
                { 0.794, 0.8143, 0.9504 * Math.Pow(10, -4), 0 },
                { 0.8017, 0.6123, 0.7165, 0.7123 * Math.Pow(10, -4) } };
            data.A = a;
            return data;
        }
    }
}
