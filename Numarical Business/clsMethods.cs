using Numarical_Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numarical_Business
{
    public static class clsMethods
    {

        public static List<BracketResult> Bisection(Func<double, double> f, double xl, double xu, double eps)
        {
            var results = new List<BracketResult>();

            double xr = 0, xrOld = 0, error = 0;
            int iter = 0;

            if (f(xl) * f(xu) > 0)
                throw new Exception("No root in this interval");

            do
            {
                xrOld = xr;
                xr = (xl + xu) / 2;

                if (iter == 0)
                    error = 0;
                else
                    error = Math.Abs((xr - xrOld) / xr) * 100;

                results.Add(new BracketResult
                {
                    Iteration = iter,
                    Xl = xl,
                    FXl = f(xl),
                    Xu = xu,
                    FXu = f(xu),
                    Xr = xr,
                    FXr = f(xr),
                    Error = error
                });

                if (f(xl) * f(xr) > 0)
                    xl = xr;
                else
                    xu = xr;

                iter++;

            } while (iter == 1 || error > eps);

            return results;
        }
        public static List<BracketResult> FalsePosition(Func<double, double> f, double xl, double xu, double eps)
        {
            var results = new List<BracketResult>();

            double xr = 0, xrOld = 0, error = 0;
            int iter = 0;

            if (f(xl) * f(xu) > 0)
                throw new Exception("No root in this interval");

            do
            {
                xrOld = xr;

                double denom = f(xl) - f(xu);

                if (Math.Abs(denom) < 1e-12)
                    throw new Exception("Division by zero in False Position");

                xr = xu - (f(xu) * (xl - xu)) / denom;

                if (iter == 0 || xr == 0)
                    error = 0;
                else
                    error = Math.Abs((xr - xrOld) / xr) * 100;

                results.Add(new BracketResult
                {
                    Iteration = iter,
                    Xl = xl,
                    FXl = f(xl),
                    Xu = xu,
                    FXu = f(xu),
                    Xr = xr,
                    FXr = f(xr),
                    Error = error
                });

                if (f(xl) * f(xr) > 0)
                    xl = xr;
                else
                    xu = xr;

                iter++;

            } while (iter == 1 || error > eps);

            return results;
        }
        public static List<FixedPointResult> FixedPointAuto(Func<double, double> f, double x0, double eps)
        {
            var g = clsHelper.BuildGSqrtFromQuadratic(f);
            return FixedPoint(g, x0, eps);
        }

        private static List<FixedPointResult> FixedPoint(Func<double, double> g, double x0, double eps)
        {
            var results = new List<FixedPointResult>();

            double xi = x0, xiPlus1, error;
            int iter = 0;

            do
            {
                xiPlus1 = g(xi);

                error = (iter == 0) ? 0 : Math.Abs((xiPlus1 - xi) / xiPlus1) * 100;

                results.Add(new FixedPointResult
                {
                    Iteration = iter,
                    Xi = xi,
                    FXi = g(xi),
                    Error = error
                });

                xi = xiPlus1;
                iter++;

            } while (iter==1||error > eps);

            return results;
        }
        public static List<NewtonResult> Newton(Func<double, double> f, double x0, double eps)
        {
            return Newton(f, x => clsHelper.Derivative(f, x), x0, eps);
        }

        private static List<NewtonResult> Newton(Func<double, double> f,
            Func<double, double> fDash, double x0, double eps)
        {
            var results = new List<NewtonResult>();

            double xi = x0, xiPlus1, error;
            int iter = 0;

            do
            {
                double d = fDash(xi);

                if (d == 0)
                    throw new Exception("Derivative = 0");

                xiPlus1 = xi - (f(xi) / d);

                error = (iter == 0) ? 0 : Math.Abs((xiPlus1 - xi) / xiPlus1) * 100;

                results.Add(new NewtonResult
                {
                    Iteration = iter,
                    Xi = xi,
                    FXi = f(xi),
                    FDashXi = d,
                    Error = error
                });

                xi = xiPlus1;
                iter++;

            } while (iter == 1 || error > eps);

            return results;
        }
        public static List<SecantResult> Secant(
    Func<double, double> f,
    double xiMinus1,
    double xi,
    double eps)
        {
            var results = new List<SecantResult>();

            double error = 0;
            int iter = 0;

            do
            {
                if (iter != 0)
                    error = Math.Abs((xi - xiMinus1) / xi) * 100;
                else
                    error = 0;

                results.Add(new SecantResult
                {
                    Iteration = iter,
                    XiMinus1 = xiMinus1,
                    FXiMinus1 = f(xiMinus1),
                    Xi = xi,
                    FXi = f(xi),
                    Error = error
                });

                double denominator = f(xiMinus1) - f(xi);

                if (denominator == 0)
                    throw new Exception("Division by zero");

                double xiPlus1 = xi - (f(xi) * (xiMinus1 - xi)) / denominator;

                xiMinus1 = xi;
                xi = xiPlus1;

                iter++;

            } while (iter == 1 || error > eps);

            return results;
        }
    }
}
