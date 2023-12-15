using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Science_Solver.Properties
{
    public static class MathExtensions
    {
        public static double Cbrt(this double number)
        {
            return Math.Pow(number, 1.0 / 3.0);
        }
        public static double Asinh(double x)
        {
            if (x == 0)
            {
                return 0; // asinh(0) = 0
            }

            double result = Math.Log(x + Math.Sqrt(x * x + 1));

            return result;
        }
        public static double Acosh(double x)
        {
            if (x < 1)
            {
                throw new ArgumentException("x phải lớn hơn hoặc bằng 1 để tính acosh(x).");
            }

            double result = Math.Log(x + Math.Sqrt(x * x - 1));

            return result;
        }
        public static double Atanh(double x)
        {
            if (Math.Abs(x) >= 1)
            {
                throw new ArgumentException("x phải thuộc khoảng (-1, 1) để tính atanh(x).");
            }

            double result = 0.5 * Math.Log((1 + x) / (1 - x));

            return result;
        }
        public static double Acotanh(double x)
        {
            if (Math.Abs(x) <= 1)
            {
                throw new ArgumentException("x phải nằm ngoài khoảng (-1, 1) để tính acoth(x).");
            }

            double result = 0.5 * Math.Log((x + 1) / (x - 1));

            return result;
        }
    }
}
