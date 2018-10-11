//Автор: Станислав Митрофанов
//Условие: Написать метод, возвращающий минимальное из трёх чисел.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static double MinNumber(double first, double second, double third)
        {
            if ((first<second)&&(first<third))
            {
                return first;
            }
            else
            {
                //если первое условие не сработало, то меньшее число - меньшее из оставшихся.
                if (second < third)
                {
                    return second;
                }
                else
                {
                    return third;
                }
            }   
        }

        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Программа выбора наименьшего из 3 чисел.");

            Console.Write("Введите первое число: ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Наименьшее число - {0}",MinNumber(firstNumber,secondNumber,thirdNumber));
            Pause();
            Menu();
        }
    }
}
