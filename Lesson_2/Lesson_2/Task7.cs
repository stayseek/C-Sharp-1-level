﻿//Автор: Станислав Митрофанов
//Условие: a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
//б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static void RecurNum(int firstNum, int lastNum)
        {
            if (lastNum > firstNum)
            {
                RecurNum(firstNum, lastNum - 1);
            }
            Console.WriteLine(lastNum);
            return;
        }

        static int RecurSum(int curNum, int stopNum)
        {
            int sum = 0;
            if (curNum < stopNum)
            {
                sum += RecurSum(curNum + 1, stopNum);
            }
            return sum+curNum;
        }

        static void Task7()
        {
            Console.Clear();
            Console.WriteLine("Рекурсивный вывод чисел последовательности и их суммы.");
            Console.Write("Введите первое число последовательности: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Введите последнее число последовательности: ");
            int lastNumber = int.Parse(Console.ReadLine());
            RecurNum(firstNumber, lastNumber);
            Console.WriteLine("Сумма чисел последовательности - {0}",RecurSum(firstNumber, lastNumber));
            Pause();
            Menu();
        }
    }
}
