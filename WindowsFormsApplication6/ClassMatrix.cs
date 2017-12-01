using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication6
{
    class ClassMatrix
    {
        int n;
        //double[] x = { 1, 2, 3, 4 };
        //double[,] A = { { 2, 4, -4, 6 },
        //                { 1, 4, 2, 1 },
        //                { 3, 8, 1, 1 },
        //                { 2, 5, 0, 5 }};
        double[] x;
        double[] xDefined;
        double xDelta;
        double matrixDelta;
        double[,] A;
        double[,] I;
        double[,] UL;
        double[,] U;
        double[,] L_;
        int[] q;
        double[,] AInverse;
        int count = 0;
        public double[,] AGetter
        {
            get { return A; }
            set => A = value;
        }
        public double[,] ULGetter
        {
            get { return UL; }
        }
        public double[,] UGetter
        {
            get { return U; }
        }
        public double[,] L_Getter
        {
            get { return L_; }
        }

        public int[] Q { get => q; set => q = value; }
        public double[,] IGetter { get => I; set => I = value; }
        public double[,] AInverseGetter { get => AInverse; set => AInverse = value; }
        public double[] XGetter { get => x; set => x = value; }
        public double[] XDefined { get => xDefined; set => xDefined = value; }
        public double XDelta { get => xDelta; set => xDelta = value; }
        public double MatrixDelta { get => matrixDelta; set => matrixDelta = value; }
        public int Count { get => count; set => count = value; }

        public string Randomize(int k)
        {
            Random temp = new Random();
            n = k;
            A = new double[k, k];
            x = new double[k];
            for (int i = 0; i < k; i++) {
                for (int j = 0; j < k; j++) {
                    A[i, j] = temp.Next(-100,100);
                }
                x[i] = i + 1.0;
            } 
          
            return Result(A);
        }
        public string FromKeys(double[,] mas) {

            A = new double[mas.GetLength(0), mas.GetLength(0)];
            A = mas;
            n = mas.GetLength(0);
            x = new double[mas.GetLength(0)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                
                x[i] = i + 1.0;
            }
            return Result(A);


        }

        public void Clone()
        {
            UL = new double[n, n];
            UL = (double[,])A.Clone();
        }

        public string Factorization()
        {
            Clone();
            q = new int[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
            }

            for (int k = n - 1; k >= 0; k--)
            {
                ChangeRows(k);
                for (int j = k - 1; j >= 0; j--) {
                    UL[q[k], j] = UL[q[k], j] / UL[q[k], k];
                    count++;
                }
                for (int i = k - 1; i >= 0; i--)
                {
                    for (int j = k - 1; j >= 0; j--)
                    {
                        UL[q[i], j] = UL[q[i], j] - UL[q[i], k] * UL[q[k], j];
                        count++;
                    }
                }
            }
            Divide(UL);
            return Result(UL);
        }

        public void ChangeRows(int k)
        {
            int imax = 0;
            int buf = 0;
            imax = k;

            for (int i = k; i >= 0; i--)

                if (Math.Abs(UL[q[i], k]) > Math.Abs(UL[q[imax], k]))
                {
                    imax = i;
                }
            if (imax != k)
            {
                buf = q[k];
                q[k] = q[imax];
                q[imax] = buf;
            }

        }

        public string Result(double[,] mas)
        {
            string s = "";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s += Math.Round(mas[i, j], 3) + "\t";
                }
                s += Environment.NewLine;
            }
            return s;
        }


        public double Determ(double[,] UL)
        {
            double det = UL[q[0], 0];
            for (int i = 1; i < UL.GetLength(0); i++)
            {
                det *= UL[q[i], i];
            }

            return Math.Abs(det);
        }
        public double[] MatrixProduct(double[,] matrixA, double[] matrixB)
        {
            int aRows = matrixA.GetLength(0); int aCols = matrixA.GetLength(0);
            int bRows = matrixB.Length;
            if (aCols != bRows)
                throw new Exception("Non-conformable matrices in MatrixProduct");
            double[] result = new double[matrixB.Length];
            for (int i = 0; i < aRows; ++i)
                for (int k = 0; k < aCols; ++k)
                    result[i] += matrixA[i, k] * matrixB[k];
            return result;
        }

        public  double[,] MatrixProductS(double[,] matrixA, double[,] matrixB)
        {
            int aRows = matrixA.GetLength(0);
            int aCols = matrixA.GetLength(1);
            int bRows = matrixB.GetLength(0);
            int bCols = matrixB.GetLength(1);
            if (aCols != bRows)
                throw new Exception("Non-conformable matrices in MatrixProduct");
            double[,] result = new double[aRows, aRows];
            for (int i = 0; i < aRows; i++) // каждая строка A
                for (int j = 0; j < bCols; j++) // каждый столбец B
                    for (int k = 0; k < aCols; k++)
                        result[i, j] += matrixA[q[i], k] * matrixB[q[k], j];
            return result;
        }
        public  double[] FindMatrixW(double[,] Umatrix, double[] b)
        {
            int n = Umatrix.GetLength(0);
            double[] w = new double[n];
            b.CopyTo(w, 0);
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = n - 1; j > i; j--)
                    sum += Umatrix[q[i], j] * w[j];
                w[i] = (b[q[i]] - sum) / Umatrix[q[i], i];
            }
            return w;
        }
        public  double[] FindMatrixX(double[,] Lmatrix, double[] w)
        {
            int n = Lmatrix.GetLength(0);
            double[] x = new double[n];
            w.CopyTo(x, 0);
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < i; j++)
                    sum += Lmatrix[q[i], j] * x[j];
                x[i] = (w[i] - sum) / Lmatrix[q[i], i];
            }
            return x;
        }

        public string ResultX(double[] mas)
        {
            string result = "";
            for (int i = 0; i < mas.Length; i++)
            {
                result += Convert.ToString(mas[i]) + " ";
            }
            return result;
        }

        public void Divide(double[,] UL)
        {
            int n = UL.GetLength(0);
            U = new double[n, n];
            L_ = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        U[q[i], j] = UL[q[i], j];
                    }
                    else if (i > j)
                    {
                        L_[q[i], j] = UL[q[i], j];
                    }
                    else if (i == j)
                    {
                        L_[q[i], j] = UL[q[i], j]/ UL[q[i], j];
                        U[q[i], j] = UL[q[i], j];
                    }
                }
            }

        }
        public static double[,] MatrixDuplicate(double[,] matrix)
        {
            double[,] result = (double[,])matrix.Clone();
            return result;
        }

        public static double[] MatrixDuplicate(double[,] matrix, int j)
        {
            double[] result = new double[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
                result[i] = matrix[i, j];
            return result;
        }

        public double[,] Inversion(double[,] L_matrix, double[,] Umatrix)
        {
            I = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                I[i, i] = 1;
            }
            AInverse = new double[Umatrix.GetLength(0), Umatrix.GetLength(0)];
            for (int j = 0; j < AInverse.GetLength(0); j++)
            {
                double[] E = MatrixDuplicate(I, j);
                double[] x = FindMatrixX(L_matrix, FindMatrixW(Umatrix, E));
                for (int i = 0; i < AInverse.GetLength(0); i++)
                {
                    AInverse[q[i], j] = x[i];
                }
            }
            return AInverse;
        }

        public double FindMax(double [,] mas) {
            double max = Math.Abs(mas[0, 0]);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Math.Abs(mas[i, j]) > max) {
                        max = Math.Abs(mas[i, j]);
                    }   
                }               
            }
            return max;
        }

        public double Delta(double[,] A, double[,] AInverse,  double [,] I) {

            double[,] Adelta = new double[n,n];
            double[,] Aproduct = MatrixProductS(A, AInverse);
            double delta;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {

                    Adelta[i, j] = I[q[i], j] - Aproduct[i, j];

                }
            }

            delta = FindMax(Adelta) / FindMax(A);

            return delta;
        }

        public double DeltaX(double [] X, double [] XDefined) {
            double delta = Math.Abs(X[0] - XDefined[0]);
            for (int i = 1; i < X.GetLength(0); i++)
            {
                if (Math.Abs(X[i] - XDefined[i]) > delta)
                    delta = Math.Abs(X[i] - XDefined[i]);
            }

            return delta;
        }

    }
}
