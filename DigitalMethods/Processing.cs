using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMethods
{
    static class Processing
    {
        //   int[,] A = new int[n, n];


        public static string LUrzl(ref double[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int k = 0; k < i; k++)
                {
                    for (int j = k + 1; j < matrix.GetLength(0); j++)
                        matrix[i, j] = matrix[i, j] - matrix[i, k] * matrix[k, j];
                }
                // выбор главного элеменета по k-й строке
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                    matrix[i, j] = matrix[i, j] / matrix[i, i];
                result += ArrayToString(matrix);
            }
            return result;
        }

        public static string ArrayToString(double[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result += Math.Round(matrix[i, j], 3) + "\t";
                }
                result += "\r\n";
            }
            return result + "\r\n";
        }
        public static double[,] GetMinor(double[,] matrix, int row, int column)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception(" Число строк в матрице не совпадает с числом столбцов");
            double[,] buf = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i != row) || (j != column))
                    {
                        if (i > row && j < column) buf[i - 1, j] = matrix[i, j];
                        if (i < row && j > column) buf[i, j - 1] = matrix[i, j];
                        if (i > row && j > column) buf[i - 1, j - 1] = matrix[i, j];
                        if (i < row && j < column) buf[i, j] = matrix[i, j];
                    }
                }
            return buf;
        }
        public static double Determ(double[,] matrix)
        {
            if (matrix.GetLength(0) != matrix.GetLength(1)) throw new Exception(" Число строк в матрице не совпадает с числом столбцов");
            double det = 0;
            int Rank = matrix.GetLength(0);
            if (Rank == 1) det = matrix[0, 0];
            if (Rank == 2) det = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            if (Rank > 2)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    det += Math.Pow(-1, 0 + j) * matrix[0, j] * Determ(GetMinor(matrix, 0, j));
                }
            }
            return det;
        }

        static double[] HelperSolve(double[,] matrix, double[] b)
        {
            // Решаем matrix * x = b
            int n = matrix.Length;
            double[] x = new double[n];
            b.CopyTo(x, 0);
            for (int i = 1; i < n; ++i)
            {
                double sum = x[i];
                for (int j = 0; j < i; ++j)
                    sum -= matrix[i, j] * x[j];
                x[i] = sum;
            }
            x[n - 1] /= matrix[n - 1, n - 1];
            for (int i = n - 2; i >= 0; --i)
            {
                double sum = x[i];
                for (int j = i + 1; j < n; ++j)
                    sum -= matrix[i, j] * x[j];
                x[i] = sum / matrix[i, i];
            }
            return x;
        }
        static double[,] MatrixInverse(double[,] matrix)
        {
            int n = matrix.Length;
            double[,] result = MatrixDuplicate(matrix);
            int[] perm;
            int toggle;
            double[,] lum = MatrixDecompose(matrix, out perm, out toggle);
            if (lum == null)
                throw new Exception("Unable to compute inverse");
            double[] b = new double[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (i == perm[j])
                        b[j] = 1.0;
                    else
                        b[j] = 0.0;
                }
                double[] x = HelperSolve(lum, b);
                for (int j = 0; j < n; ++j)
                    result[j,i] = x[j];
            }
            return result;
        }
        static double[,] MatrixDuplicate(double[,] matrix)
        {
            double[,] result = (double[,]) matrix.Clone() ;
            //for (int i = 0; i < matrix.GetLength(0); ++i) // Копирование значений
            //    for (int j = 0; j < matrix.GetLength(1); ++j)
            //        result[i,j] = matrix[i,j];
            return result;
        }
    }
}
