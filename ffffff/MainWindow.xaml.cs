using System;
using System.Windows;
using System.Windows.Controls;

namespace ffffff
{
    public partial class MainWindow : Window
    {
        private Calculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения из текстовых полей
            if (!double.TryParse(tbUpperBound.Text, out double upperBound) ||
                !double.TryParse(tbUpperBound1.Text, out double lowerBound) ||
                !int.TryParse(tbUpperBound2.Text, out int n))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            // Получаем выбранный метод интегрирования
            string selectedMethod = (cmbBoxIntegralType.SelectedItem as ComboBoxItem).Content.ToString();

            double result = 0;

            // Определяем функцию, которую хотим интегрировать
            Func<double, double> func = x => 322 * x - Math.Log(11 * x) - 2;

            // Вычисляем интеграл в зависимости от выбранного метода
            if (selectedMethod == "Метод Симпсона")
            {
                result = calculator.SimpsonIntegration(lowerBound, upperBound, n);
            }
            else if (selectedMethod == "Метод прямоугольников")
            {
                result = calculator.RectangleIntegration(lowerBound, upperBound, n, func);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите метод интегрирования.");
                return;
            }

            // Выводим результат
            MessageBox.Show($"Результат интегрирования: {result}");
        }
    }
}