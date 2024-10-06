using System;

namespace ffffff
{
    public class Calculator
    {
        public double SimpsonIntegration(double a, double b, int n)
        {
            double h = (b - a) / n;
            double sum1 = 0.0;
            double sum2 = 0.0;

            if (n <= 0)
                throw new ArgumentException("Отрицательное количество разбиений");

            for (int i = 1; i < n; i += 2)
            {
                sum1 += Function(a + i * h);
            }

            for (int i = 2; i < n - 1; i += 2)
            {
                sum2 += Function(a + i * h);
            }

            return h / 3 * (Function(a) + 4 * sum1 + 2 * sum2 + Function(b));
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

        private double Function(double x)
        {
            return 322 * x - Math.Log(11 * x) - 2;
        }
    }
}
