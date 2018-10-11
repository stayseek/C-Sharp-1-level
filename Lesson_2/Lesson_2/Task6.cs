//Автор: Станислав Митрофанов
//Условие: *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000
//000. «Хорошим» называется число, которое делится на ​ сумму своих цифр​.Реализовать
//подсчёт времени выполнения программы, используя структуру DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static int DigitSum (int num)
        {
            int sum = 0;

            while (num >= 1)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        static int CheckRange(int fromNum, int toNum)
        {
            int count = 0;
            for (int i = fromNum; i <= toNum; i++)
            {
                if (i % DigitSum(i) == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Task6()
        {
            const int minNum = 1;
            const int maxNum = 1000000000;

            Console.Clear();
            Console.WriteLine("Программа подсчёта \"хороших\" чисел в диапазоне от {0} до {1}\nПодсчёт начат...", minNum, maxNum);
            DateTime dateStart = DateTime.Now;
            Console.WriteLine("Количество \"хороших\" чисел в диапазоне - {0}", CheckRange(minNum, maxNum));
            DateTime dateFinish = DateTime.Now;
            TimeSpan ts = dateFinish - dateStart;
            Console.WriteLine("Время выполнения операций - {0}", ts);
            Pause();
            Menu();
        }
    }
}
