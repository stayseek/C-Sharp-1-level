//Автор: Станислав Митрофанов
//Задание:
//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать
//программу, позволяющую найти и вывести количество пар элементов массива, в которых только
//одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих
//элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    partial class Program
    {
        static void Task1()
        {
            const int min = -10000;
            const int max = 10000;
            const int size = 20;
            int count = 0;
            int[] a = null;
            a = new int[size];
            Console.Clear();
            Console.WriteLine("Значения в массиве a[{0}]:", size);
            Random rnd = new Random();
            for (int i = 0; i<a.Length; i++)
            {
                a[i] = rnd.Next(min, max+1);
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length - 1; i++)
            {
                if ((a[i] % 3 == 0)^(a[i+1] % 3 == 0))
                {
                    count++;
                }
            }
            Console.WriteLine("Количество пар элементов, в которых только одно из чисел делится на 3: {0}", count);
            Pause();
            Menu();
        }
    }
}
