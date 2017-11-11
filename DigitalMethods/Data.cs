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
        double[,] lu;
        double[] x;
        double[] b;
        double[] w;
        double[] xReady;
        int n = 4;
        int[] q;
        double[,] l;
        double[,] u;

        public Data()
        {
            q = new int[n];
            x = new double[n];
            XReady = new double[n];
            for (int i = 0; i < n; i++)
            {
                q[i] = i;
                x[i] = Convert.ToDouble(i + 1.0);
            }
        }

        public double[,] A
        {
            get { return a; }
            set { a = value; }
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
    }
}