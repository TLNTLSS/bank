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

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        //Кнопка для расчета
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение входных данных
                double principal = double.Parse(PrincipalAmountTextBox.Text);

                // Конвертация процента в долю
                double interestRate = double.Parse(InterestRateTextBox.Text) / 100;
                int years = int.Parse(YearsTextBox.Text);

                // Расчет итоговой суммы
                double totalAmount = principal * Math.Pow((1 + interestRate), years);

                // Отображение результата и форматирование до 2 знаков после запятой
                ResultTextBlock.Text = $"{totalAmount:F2} ₽";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Пожалуйста, введите корректные значения." + "\n" + ex.Message);
            }
        }
    }
}
