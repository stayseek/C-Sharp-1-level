//2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.
//Использовать массив(или список) делегатов, в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала коллекцию List<double> считанных значений. 
//Пусть она возвращает минимум через параметр (с использованием модификатора out).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_6
{
    //public delegate double Fun(double x); 
    //Делегат уже существует в пространстве имён (1 задание), будем использовать его и тут.

    partial class Program
    {
        public static void SaveFunc(string fileName, Fun F, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(F(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static List<double> Load(string fileName, out double min)
        {
            List<double> l = new List<double>();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                l.Add(d);
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return l;
        }

        public static double MyFunc1(double x)
        {
            return x*x*x;
        }

        public static double MyFunc2(double x)
        {
            return x * x - 50 * x + 10;
        }

        static void MakeWork(Fun F)
        {
            const string fileName = "C:\\test\\data.txt";
            double min;
            double start;
            double stop;
            double step;
            Console.WriteLine();
            Console.WriteLine("Введите начальное значение:");
            if (!double.TryParse(Console.ReadLine(), out start))
            {
                start = 0;
            }
            Console.WriteLine("Введите конечное значение:");
            if (!double.TryParse(Console.ReadLine(), out stop))
            {
                stop = 10;
            }
            Console.WriteLine("Введите шаг функции:");
            if (!double.TryParse(Console.ReadLine(), out step))
            {
                step = 1;
            }
            Console.Clear();
            SaveFunc(fileName, F, start, stop, step);
            List<double> l = Load(fileName, out min);
            Console.WriteLine("Полученные значения функции:\n");
            foreach (double num in l)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Минимум функции = {0}", min);
        }

        static void FuncMenu()
        {
            Console.Clear();
            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1 - x*x*x");
            Console.WriteLine("2 - x * x - 50 * x + 10");
            Console.WriteLine("3 - sin(x)");
            Console.WriteLine("0 - Exit");

            Fun[] funcList = {MyFunc1, MyFunc2, Math.Sin};

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    MakeWork(funcList[0]);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    MakeWork(funcList[1]);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    MakeWork(funcList[2]);
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Menu();
                    break;
                default:
                    Console.WriteLine("\nWrong select!");
                    Pause();
                    Menu();
                    break;
            }

        }
        static void Task2()
        {
            FuncMenu();
            Pause();
            Menu();
        }
    }
}
