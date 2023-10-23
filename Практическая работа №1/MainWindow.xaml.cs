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

namespace Практическая_работа__1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }

        private void MenuItem_Click_Выход(object sender, RoutedEventArgs e)// событие закрытия рабочего окна программы 
        {
            this.Close();
        }
      
        private void MenuItem_Click_О_программе(object sender, RoutedEventArgs e)// событие кнопки "о программе" 
        {
            MessageBox.Show("Автор:Соколов Даниил.\nПрактическая работа №1 \nЦель:Вычислить разницу целых случайных чисел, распределенных в  диапазоне от 2 до  10, пока эта разница не станет меньше некоторого числа  K(K < 0) .Вывести на экрансгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        

        private void Button_Click_Сгенерировать(object sender, RoutedEventArgs e)// событие кнопки "сгенерировать"
        {
            int raz = 0; // Переменная разности сгенерированных чисел
            int kol = 0; // Переменная-счётчик количества сгенерированных чисел
            int sum = 0; // Переменная суммы сгенерированных чисел
            bool f1 = int.TryParse(TextBox_K.Text, out int K); // вынимаем значение из поля ввода
            if (f1 == true) // проверка является ли значение числом
            {
                if (K < 0) // подходит ли число узловию задачи
                {
                    while (raz > K) // цикл, длящийся до тех пор пока разность больше числа К  
                    {
                        ClassLibrary1_Пр.р_1.Class1.GetRaz(K, ref sum, ref kol, out int value, ref raz); // Призыв метода
                        TB_Числа.Text = TB_Числа.Text + " " + Convert.ToString(value); // Заполняем поле сгенерированных чисел
                        TB_Сумма.Text = sum.ToString(); // заполняем поле суммы чисел
                        TB_Количество.Text = kol.ToString(); // заполняем поле количества чисел
                    }
                }
                else
                MessageBox.Show("Введите число меньшее чем 0");
            }
            else
            MessageBox.Show("Введите число");
        }

        private void B_Очистить(object sender, RoutedEventArgs e) // Кнопка очиски полей чисел, суммы, количества. 
        {
            TB_Количество.Clear();
            TB_Сумма.Clear();
            TB_Числа.Clear();
        }

        private void MenuItem_Click_Анекдот(object sender, RoutedEventArgs e) // 
        {
            MessageBox.Show("№1 \n Почему застрелился Гитлер - ему пришёл счет за газ; \n №2 \n Купил в интернете книгу Как обманывают в интернете \n до сих пор жду пока её доставят.");
        }
    } 
}
