using System;

namespace ffffff
{
    public class Calculator
    {
        public double TrapezoidalIntegration(double a, double b, int n, Func<double, double> func)
        {
            if (n <= 0)
                throw new ArgumentException("Отрицательное количество разбиений");

            double h = (b - a) / n;
            double sum = 0.0;

            for (int i = 1; i < n; i++)
            {
                sum += func(a + i * h);
            }

            return h / 2 * (func(a) + 2 * sum + func(b));
        }

        public double RectangleIntegration(double a, double b, int n, Func<double, double> func)
        {
            double h = (b - a) / n;
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += func(a + i * h);
            }

            return h * sum;
        }

        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определен только для неотрицательных чисел");

            if (n == 0 || n == 1)
                return 1;

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        private double Function(double x)
        {
            return 322 * x - Math.Log(11 * x) - 2;
        }
    }
}