//Автор: Станислав Митрофанов
//Условие: С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечётных положительных чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Программа подсчёта суммы введённых нечётных положительных чисел");
            Console.WriteLine("Вводите целые числа. Введите 0 для окончания ввода и вывода результата.");
            int number = 0;
            int sum = 0;
            do
            {
                number = int.Parse(Console.ReadLine());
                if ((number>0)&&(!(number%2==0)))
                {
                    sum += number;
                }
            }
            while (number != 0);
            Console.WriteLine("Сумма нечётных положительных чисел равна - {0}", sum);
            Pause();
            Menu();
        }
    }
}
