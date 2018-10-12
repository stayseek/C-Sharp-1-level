//Автор: Станислав Митрофанов
//Условие: С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел. 
//Для проверки ввода числе использовать TryParse 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    partial class Program
    {
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Программа подсчёта суммы введённых нечётных положительных чисел");
            Console.WriteLine("Вводите целые числа. Введите 0 для окончания ввода и вывода результата.");
            int number = 0;
            int sum = 0;
            bool flag;
            do
            {
                do
                {
                    flag = int.TryParse(Console.ReadLine(), out number);
                    if ( !flag || (number < 0))
                    {
                        Console.WriteLine("Вы должны вводить целые положительные числа. Повторите ввод.");
                    }
                    flag = flag && (number >= 0);
                }
                while (!flag);

                if (!(number % 2 == 0))
                {
                    sum += number;
                }
            }
            while (number != 0);
            Console.WriteLine("Сумма нечётных положительных чисел равна - {0}", sum);
            Pause();
            MainMenu();
        }
    }
}