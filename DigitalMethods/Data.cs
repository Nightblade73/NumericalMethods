﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMethods
{
    public class Data
    {
        double[,] a = { { 2.0, 4.0, -4.0, 6.0 },
                     { 1.0, 4.0, 2.0, 1.0 },
                     { 3.0, 8.0, 1.0, 1.0 },
                     { 2.0, 5.0, 0.0, 5.0 }};
        double[,] aInver;
        double[,] lu;
        double[] x;
        double[] b;
        double[] w;
        double[] xReady;
        int[] q;
        int counter;
        double[,] l;
        double[,] u;
        double[,] i;
        double errorX;
        double errorI;

        public void Init(int n)
        {
            Counter = 0;
            Random r = new Random();
            a = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = (r.NextDouble() * 2 - 1) * 100;
                }
            }
            q = new int[n];
            x = new double[n];
            XReady = new double[n];
            i = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
                x[i] = i + 1.0;
                this.i[i, i] = 1;
            }
        }

        public double[,] A
        {
            get { return a; }
            set { a = value; }
        }

        public double[,] AInver
        {
            get { return aInver; }
            set { aInver = value; }
        }

        public int[] Q
        {
            get { return q; }
            set { q = value; }
        }
        public double[] X
        {
            get { return x; }
            set { x = value; }
        }

        public double[,] L
        {
            get { return l; }
            set { l = value; }
        }

        public double[,] U
        {
            get { return u; }
            set { u = value; }
        }

        public double[,] LU
        {
            get { return lu; }

            set { lu = value; }
        }

        public double[] W
        {
            get { return w; }
            set { w = value; }
        }

        public double[] B
        {
            get { return b; }
            set { b = value; }
        }

        public double[] XReady
        {
            get { return xReady; }
            set { xReady = value; }
        }

        public double[,] I
        {
            get { return i; }
            set { i = value; }
        }

        public double ErrorX
        {
            get { return errorX; }
            set { errorX = value; }
        }

        public double ErrorI
        {
            get { return errorI; }
            set { errorI = value; }
        }

        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
    }
}
