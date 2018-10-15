//Автор: Станислав Митрофанов
//Задание №2: 
//С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечётных положительных чисел.Сами числа и сумму
//вывести на экран, используя tryParse.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    partial class Program
    {
        static void IncorrectInput()
        {
            Console.WriteLine("Вы должны вводить целые положительные числа. Повторите ввод.");
        }
        static int GetkNumbers()
        {
            int number = 0;
            bool flag;
            do
            {
                flag = int.TryParse(Console.ReadLine(), out number);
                if (!flag || (number < 0))//number = 0 при вводе букв
                {
                    IncorrectInput();
                }
                flag = flag && (number >= 0);//введённые данные должны быть положительными цифрами или 0
            }
            while (!flag);
            return number;
        }
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Программа подсчёта суммы введённых нечётных положительных чисел");
            Console.WriteLine("Вводите целые числа. Введите 0 для окончания ввода и вывода результата.");
            int number = 0;
            int sum = 0;
            do
            {
                number = GetkNumbers();

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