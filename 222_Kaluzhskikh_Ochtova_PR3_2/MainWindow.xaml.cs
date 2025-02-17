using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _222_Kaluzhskikh_Ochtova_PR3_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            // Проверка на пустые текстовые поля
            if (string.IsNullOrWhiteSpace(sumTextBox.Text) ||
                string.IsNullOrWhiteSpace(termTextBox.Text) ||
                string.IsNullOrWhiteSpace(rateTextBox.Text))
            {
                MessageBox.Show("Все текстовые поля должны быть заполнены!");
                return;
            }

            // Проверка на выбор переключателя
            if (!simpleInterestRadioButton.IsChecked.Value && !compoundInterestRadioButton.IsChecked.Value)
            {
                MessageBox.Show("Выберите тип процентов!");
                return;
            }

            // Парсинг введенных значений
            if (!double.TryParse(sumTextBox.Text, out double sum) ||
                !int.TryParse(termTextBox.Text, out int term) ||
                !double.TryParse(rateTextBox.Text, out double rate))
            {
                MessageBox.Show("Введите корректные числовые значения!");
                return;
            }

            double result = 0;

            // Расчет простых процентов
            if (simpleInterestRadioButton.IsChecked.Value)
            {
                result = sum * rate * term / 100;
            }
            // Расчет сложных процентов
            else if (compoundInterestRadioButton.IsChecked.Value)
            {
                result = sum * Math.Pow(1 + rate / 12 / 100, term) - sum;
            }

            // Отображение результата
            resultTextBox.Text = $"{result:F2}";
        }
        
    }
}
