using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMethods
{
    static class Processing
    {
        /// <summary>
        /// LU Гауссово исключение по строкам
        /// </summary>
        /// <param name="matrix">Матрица А</param>
        /// <param name="prem">Дополнительный вектор, позволяющий обращаться к определённым элементам в матрице</param>
        /// <returns></returns>
        public static double[,] LUrzl(double[,] matrix, ref int[] prem)
        {
            double[,] LUmatrix = MatrixDuplicate(matrix);
            for (int i = 0; i < LUmatrix.GetLength(0); i++)
            {
                for (int k = 0; k < i; k++)
                {
                    for (int j = k + 1; j < LUmatrix.GetLength(0); j++)
                        LUmatrix[i, prem[j]] = LUmatrix[i, prem[j]] - LUmatrix[i, prem[k]] * LUmatrix[k, prem[j]];
                }
                ChangeColumns(i, LUmatrix, ref prem);
                for (int j = i + 1; j < LUmatrix.GetLength(0); j++)
                    LUmatrix[i, prem[j]] = LUmatrix[i, prem[j]] / LUmatrix[i, prem[i]];
            }
            return LUmatrix;
        }
        /// <summary>
        /// Производит поиск и выбор главного элемента в строке
        /// </summary>
        /// <param name="k">Номер шага</param>
        /// <param name="matrix">Матрица А</param>
        /// <param name="prem">Дополнительный вектор</param>
        private static void ChangeColumns(int k, double[,] matrix, ref int[] prem)
        {
            int jmax = 0;
            int buf = 0;
            jmax = k;
            for (int j = k; j < matrix.GetLength(0); j++)
                if (Math.Abs(matrix[k, prem[j]]) > Math.Abs(matrix[k, prem[jmax]]))
                {
                    jmax = j;
                }
            if (jmax != k)
            {
                buf = prem[k];
                prem[k] = prem[jmax];
                prem[jmax] = buf;
            }
        }
        /// <summary>
        /// Возвращает детерминант выходной матрицы LU
        /// </summary>
        /// <param name="LUmatrix">LU матрица</param>
        /// <returns></returns>
        public static double Determ(double[,] LUmatrix, int[] prem)
        {
            double det = 1;
            for (int i = 0; i < LUmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < LUmatrix.GetLength(1); j++)
                {
                    if (i == j)
                        det *= LUmatrix[i, prem[j]];
                }
            }
            return Math.Abs(det);
        }
        /// <summary>
        /// Вычисление вектора столбца W из матрицы L и вектора столбца B
        /// </summary>
        /// <param name="Lmatrix">Нижне-треугольная матрица</param>
        /// <param name="b">Вектор столбец</param>
        /// <returns></returns>
        public static double[] FindMatrixW(double[,] Lmatrix, double[] b, int[] prem)
        {
            int n = Lmatrix.GetLength(0);
            double[] w = new double[n];
            b.CopyTo(w, 0);
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < i; j++)
                    sum += Lmatrix[i, prem[j]] * w[j];
                w[i] = (b[i] - sum) / Lmatrix[i, prem[i]];
            }
            return w;
        }
        /// <summary>
        /// Вычисление вектора столбца Х из матрицы U и вектора столбца W
        /// </summary>
        /// <param name="Umatrix">Верхне-треугольная матрица</param>
        /// <param name="w">Вектор столбец</param>
        /// <returns></returns>
        public static double[] FindMatrixX(double[,] Umatrix, double[] w, int[] prem)
        {
            int n = Umatrix.GetLength(0);
            double[] x = new double[n];
            w.CopyTo(x, 0);
            for (int i = n - 1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = n - 1; j > i; j--)
                    sum += Umatrix[i, prem[j]] * x[j];
                x[i] = (w[i] - sum) / Umatrix[i, prem[i]];
            }
            return x;
        }
        /// <summary>
        /// Создание матрицы с заданным количеством столбцов и строк.
        /// </summary>
        /// <param name="rows">Количество строк</param>
        /// <param name="cols">Количество столбцов</param>
        /// <returns></returns>
        public static double[,] MatrixCreate(int rows, int cols)
        {
            // Создаем матрицу, полностью инициализированную
            // значениями 0.0. Проверка входных параметров опущена.
            double[,] result = new double[rows, cols];
            return result;
        }
        /// <summary>
        /// Произведение квадратной матрицы А на вектор стоблец B
        /// </summary>
        /// <param name="matrixA">Квадратная матрица</param>
        /// <param name="matrixB">Вектор столбец</param>
        /// <returns></returns>
        public static double[] MatrixProduct(double[,] matrixA, double[] matrixB)
        {
            int aRows = matrixA.GetLength(0); int aCols = matrixA.GetLength(0);
            int bRows = matrixB.Length;
            double[] result = new double[aRows];
            for (int i = 0; i < aRows; ++i) // каждая строка A
                for (int k = 0; k < aCols; ++k)
                    result[i] += matrixA[i, k] * matrixB[k];
            return result;
        }
        /// <summary>
        /// Произведение квадратной матрицы А на квадратную матрицу B
        /// </summary>
        /// <param name="matrixA">Квадратная матрица</param>
        /// <param name="matrixB">Вектор столбец</param>
        /// <returns></returns>
        public static double[,] MatrixProduct(double[,] matrixA, double[,] matrixB, int[] prem)
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
                        result[i, j] += matrixA[i, prem[k]] * matrixB[k, prem[j]];
            return result;
        }
        /// <summary>
        /// Делит входную матрицу на верхнюю и нижнюю треугольные
        /// </summary>
        /// <param name="LUmatrix">Входная матрица LU. Матрица U с единицами по диагонали</param>
        /// <param name="Lmatrix">Нижне-треугольная матрица</param>
        /// <param name="Umatrix">Верхне-треугольная матрица</param>
        public static void Division(double[,] LUmatrix, out double[,] Lmatrix, out double[,] Umatrix, int[] prem)
        {
            Lmatrix = new double[LUmatrix.GetLength(0), LUmatrix.GetLength(0)];
            Umatrix = new double[LUmatrix.GetLength(0), LUmatrix.GetLength(0)];
            for (int i = 0; i < LUmatrix.GetLength(0); i++)
                for (int j = 0; j < LUmatrix.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        Umatrix[i, prem[j]] = LUmatrix[i, prem[j]];
                    }
                    else if (i > j)
                    {
                        Lmatrix[i, prem[j]] = LUmatrix[i, prem[j]];
                    }
                    else
                    {
                        Umatrix[i, prem[j]] = LUmatrix[i, prem[j]] / LUmatrix[i, prem[j]];
                        Lmatrix[i, prem[j]] = LUmatrix[i, prem[j]];
                    }
                }
        }
        /// <summary>
        /// Клонирует входную матрицу. Возвращает ссылку на новую матрицу.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double[,] MatrixDuplicate(double[,] matrix)
        {
            double[,] result = (double[,])matrix.Clone();
            return result;
        }
        /// <summary>
        /// Клонирует столбец входной матрицы по номеру.
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static double[] MatrixDuplicate(double[,] matrix, int j)
        {
            double[] result = new double[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
                result[i] = matrix[i, j];
            return result;
        }
        /// <summary>
        /// Возвращает обратную матрицу
        /// </summary>
        /// <param name="Lmatrix"></param>
        /// <param name="Umatrix"></param>
        /// <param name="prem"></param>
        /// <returns></returns>
        public static double[,] Inversion(double[,] Lmatrix, double[,] Umatrix, double[,] Imatrix, int[] prem)
        {
            double[,] result = new double[Lmatrix.GetLength(0), Lmatrix.GetLength(0)];
            for (int j = 0; j < result.GetLength(0); j++)
            {
                double[] I = MatrixDuplicate(Imatrix, j);
                double[] x = FindMatrixX(Umatrix, FindMatrixW(Lmatrix, I, prem), prem);
                for (int i = 0; i < result.GetLength(0); i++)
                {
                    result[i, prem[j]] = x[i];
                }
            }
            return result;
        }
        /// <summary>
        /// Поиск нормы в матрице
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static double FindMax(double[,] matrix)
        {
            double max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (Math.Abs(matrix[i, j]) > max)
                        max = Math.Abs(Math.Abs(matrix[i, j]));
                }
            }
            return max;
        }
        /// <summary>
        /// Вычисление погрешности между начальным вектором X и получившимся вектором X
        /// </summary>
        /// <param name="X"></param>
        /// <param name="XReady"></param>
        /// <returns></returns>
        public static double DeltaMax(double[] X, double[] XReady, int[] prem)
        {
            double max = 0;
            for (int i = 0; i < X.GetLength(0); i++)
            {
                if (Math.Abs(X[i] - XReady[prem[i]]) > max)
                    max = Math.Abs(X[i] - XReady[prem[i]]);
            }
            return max;
        }

        public static double DeltaMax(double[,] Amatrix, double[,] AImatrix, double[,] Imatrix, int[] prem)
        {
            double[,] Iproduct = MatrixProduct(Amatrix, AImatrix, prem);
            double[,] IDelta = new double[Amatrix.GetLength(0), Amatrix.GetLength(0)];
            for (int i = 0; i < Amatrix.GetLength(0); i++)
            {
                for (int j = 0; j < Amatrix.GetLength(0); j++)
                {
                    IDelta[i, j] = Imatrix[i, j] - IDelta[i, j];
                }
            }
            return FindMax(IDelta) / FindMax(Amatrix);
        }

        public static string ArrayToString(double[,] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result += string.Format("{0,20:0.###}", matrix[i, j]) + "\t";
                    //    result += Math.Round(matrix[i, j], 3) + "\t";
                }
                result += "\r\n";
            }
            return result + "\r\n";
        }

        public static string ArrayToString(double[] vector)
        {
            string result = "";
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                //result += string.Format("{0,10:0.###}", vector[i]) + "\t";
                result += vector[i] + "\t";
            }
            return result + "\r\n\r\n";
        }

        public static string ArrayToString(int[] vector)
        {
            string result = "";
            for (int i = 0; i < vector.GetLength(0); i++)
            {
                result += vector[i] + "\t";
            }
            return result + "\r\n\r\n";
        }
    }
}
