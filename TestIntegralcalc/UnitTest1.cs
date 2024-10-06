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
            double expected = 333333.333333; // ������������ ��������� ��������
            Func<double, double> func = x => x * x;

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
    }
}