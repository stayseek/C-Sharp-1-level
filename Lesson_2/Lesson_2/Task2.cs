//Автор: Станислав Митрофанов
//Условие: Написать метод подсчета количества цифр числа.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static int SymbolsNumber(long number) //Пусть будет long - что бы число можно было побольше ввести.
        {
            int symbols = 0;

            while (number != 0)
            {
                number /= 10;
                symbols++;
            } 

            return symbols;

            //Корявый вариант, просто вернуть
            //return number.ToString().Length;
        }
        static void Task2()
        {
            Console.Clear();
            Console.WriteLine("Программа подсчёта количества цифр числа");
            Console.Write("Введите целое положительное число: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("Количество цифр в числе - {0}", SymbolsNumber(number));
            Pause();
            Menu();
        }
    }
}
