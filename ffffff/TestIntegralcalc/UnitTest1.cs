using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ffffff; // ������������ ������������ ����

namespace TestIntegralcalc
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleXX_Sucess()
        {
            // Arrange
            double lower = 0;
            double upper = 100;
            int count = 100000;
            double expected = 5000; // ������������ ��������� ��������
            Func<double, double> func = x => x;

            // Act
            var calculator = new Calculator();
            double actual = calculator.RectangleIntegration(lower, upper, count, func);

            // Assert
            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestMethod]
        public void RectangleXX_SmallRange_Sucess()
        {
            // Arrange
            double lower = 0;
            double upper = 5;
            int count = 1000;
            double expected = 41.666667; // ��������� �������� ��� ������� x * x � �������� �� 0 �� 5
            Func<double, double> func = x => x * x;

            // Act
            var calculator = new Calculator();
            double actual = calculator.RectangleIntegration(lower, upper, count, func);

            // Assert
            Assert.AreEqual(expected, actual, 0.1);
        }

        [TestMethod]
        public void TrapezoidalIntegration_X_Success()
        {
            // Arrange
            double lower = 1;
            double upper = 10;
            int count = 100;
            double expected = 49.5; // ��������� �������� ��� ������� x � �������� �� 1 �� 10
            Func<double, double> func = x => x;

            // Act
            var calculator = new Calculator();
            double actual = calculator.TrapezoidalIntegration(lower, upper, count, func);

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void TrapezoidalIntegration_X_SmallRange_Success()
        {
            // Arrange
            double lower = 1;
            double upper = 5;
            int count = 500;
            double expected = 12; // ��������� �������� ��� ������� x � �������� �� 1 �� 5
            Func<double, double> func = x => x;

            // Act
            var calculator = new Calculator();
            double actual = calculator.TrapezoidalIntegration(lower, upper, count, func);

            // Assert
            Assert.AreEqual(expected, actual, 0.01);
        }

        [TestMethod]
        public void Factorial_Success()
        {
            // Arrange
            int n = 5;
            int expected = 120; // ��������� �������� ��� ���������� 5

            // Act
            var calculator = new Calculator();
            int actual = calculator.Factorial(n);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}