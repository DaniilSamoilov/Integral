using System;
using System.Collections.Generic;

namespace Integral
{
    static class IntegralMethods
    {
        public static double Simpson(Func<double,double>f,double a, double b,int n)
        {
            n = n / 2 * 2;//проверяем, что число разделений четное
            double h = (b-a) / n;//интервал
            double sum = f(a) + f(b);
            for (int i = 1; i < n; i++)
            {
                if (i%2==0)
                {
                    sum += 2 * f(a + i * h);
                }
                else
                {
                    sum += 4 * f(a + i * h);
                }
            }
            return -sum * h / 3;            
        }
        public static double Trapezoid(Func<double,double>f,double a,double b,int n)
        {
            double h = (b-a) / n;
            double sum = 0.5 * (f(a) + f(b));
            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += f(x);
            }
            return -sum * h;
        }
        public static double Gauss(Func<double,double>f,double a,double b, int n)
        {
            throw new NotImplementedException();
        }
        public static double MonteCarlo(Func<double,double>f,double a, double b, int n)
        {
            Random rand = new Random();
            double sum = 0d;
            for (int i = 0; i < n; i++)
            {
                double x = a + (b - a) * rand.NextDouble();//случайное число от a до b
                sum += f(x);
            }
            return -sum * (b - a) / n;
        }
        public static double Runge(double CurrentValue,double PreviousValue,double p)
        {
            return -Math.Abs(CurrentValue-PreviousValue)/(Math.Pow(2,p)-1);
        }

        public static Dictionary<string, double> RungePower = new Dictionary<string, double>
        {
            {"Simpson",4 },
            {"Trapezoid", 2 },
            {"Gauss", 2 },
            {"MonteCarlo", Math.Sqrt(2) }
        };

        public static Dictionary<string, Func<Func<double, double>, double, double, int, double>> MethodsDictionary = new Dictionary<string, Func<Func<double, double>, double, double, int, double>>
        {
            {"Simpson",Simpson },
            {"Trapezoid", Trapezoid },
            {"Gauss", Gauss },
            {"MonteCarlo", MonteCarlo }
        };
    }
}
