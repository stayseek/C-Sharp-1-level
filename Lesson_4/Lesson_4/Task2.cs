//Автор: Станислав Митрофанов
//Задание:
//2. Реализуйте задачу 1 в виде статического класса StaticClass;
//а) Класс должен содержать статический метод, который принимает на вход массив и решает
//задачу 1;
//б) * Добавьте статический метод для считывания массива из текстового файла.Метод должен
// возвращать массив целых чисел;
//в)** Добавьте обработку ситуации отсутствия файла на диске.

//Примечание: Для хранения массива будем использовать формат, предложенный на занятии сначала идёт размер массива, а затем значения элементов.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    partial class Program
    {
        public static class StaticClass
        {
            public static int Div3Pairs(int[] a)
            {
                int count = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if ((a[i] % 3 == 0) ^ (a[i + 1] % 3 == 0))
                    {
                        count++;
                    }
                }
                return count;
            }
            public static int[] LoadArray(string fileName)
            {
                StreamReader sr = null;
                int[] a = null;
                try
                {
                    sr = new StreamReader(fileName);
                    int size = int.Parse(sr.ReadLine());
                    a = new int[size];
                    int i = 0;
                    while (!sr.EndOfStream)
                    {
                        a[i] = int.Parse(sr.ReadLine());
                        i++;
                    }
                }
                catch (FileNotFoundException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (DirectoryNotFoundException exc)
                {
                    Console.WriteLine(exc.Message);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
                finally
                {
                    if (sr != null) sr.Close();
                }
                return a;
            }
        }

        static void Task2()
        {
            const string fileName = "C:\\test\\data.txt";
            int[] a = null;
            Console.Clear();
            a = StaticClass.LoadArray(fileName);
            if (a != null)
            {
                Console.WriteLine("Значения в массиве a[{0}]:", a.Length);
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.WriteLine("Количество пар элементов, в которых только одно из чисел делится на 3: {0}", StaticClass.Div3Pairs(a));
            }
            else
            {
                Console.WriteLine("Произошла ошибка при открытии файла");
            }
            Pause();
            Menu();
        }
    }
}
