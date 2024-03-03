using System;
using System.Collections.Generic;

namespace Integral
{
    public class FunctionsForIntegration
    {
        static double sinusoida(double x) => Math.Sin(x);
        static double f1(double x) => -Math.Pow((x - 2),2) + 5;
        static double f2(double x) => Math.Abs(Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 5);

        public static Dictionary<string, Func<double, double>> FunctionDictionary = new Dictionary<string, Func<double, double>>
        {
            {"sin(x)",sinusoida },
            {"-(x-2)^2 + 5",f1 },
            {"|x^3 - 3x^2 + 5|",f2 }
        };
    }
}
