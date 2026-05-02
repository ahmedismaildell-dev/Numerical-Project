using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numarical_Business
{
    public static class clsHelper
    {
        public static double Derivative(Func<double, double> f, double x)
        {
            double h = 1e-5;
            return (f(x + h) - f(x - h)) / (2 * h);
        }
        public static Func<double, double> BuildGSqrtFromQuadratic(Func<double, double> f)
        {
            double h = 1e-5;

            double c = f(0);
            double b = (f(h) - f(-h)) / (2 * h);
            double f2 = (f(h) - 2 * f(0) + f(-h)) / (h * h);
            double a = f2 / 2;

            if (Math.Abs(a) < 1e-10)
                throw new Exception("Not quadratic");

            double B = b / (-a);
            double C = c / (-a);

            Console.WriteLine($"g(x) = sqrt({B} * x + {C})");

            return x => Math.Sqrt(B * x + C);
        }
    }
}
