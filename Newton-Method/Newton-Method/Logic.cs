using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Object.Math;

namespace Newton_Method
{
    public static class Logic
    {
        public static double Algorithm(int n, double x, double eps)
        {
            if (eps<=0 || eps>1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (x < 0 && n%2==0)
            {
                throw new ArgumentException();
            }

            double x1 = x / 2;
            double x0;
            do
            {
                x0 = x1;
                x1 = ((n - 1) * x0 + x / Math.Pow(x0, n - 1)) / n;

            } while (Math.Abs(x0 - x1) > eps);
            return x1;

        }
    }
}
