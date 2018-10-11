//Автор: Станислав Митрофанов
//Код для меню был взят из проекта Menu, приложенного к уроку, доработан до нужного количества задач.
//Методы, общие для всех проектов, указаны именно в этом файле.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static void Pause()
        {
            Console.Write("Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Митрофанов Станислав");
            Console.WriteLine("Домашнее задание №2");
            Console.WriteLine("1 - Поиск наименьшего из 3 чисел");
            Console.WriteLine("2 - Подсчёт количества цифр числа");
            Console.WriteLine("3 - Подсчёт суммы введённых нечётных положительных чисел");
            Console.WriteLine("4 - Проверка логина и пароля");
            Console.WriteLine("5 - Расчёт Индекса Массы Тела");
            Console.WriteLine("6 - Подсчёт количества \"хороших\" чисел в диапазоне");
            Console.WriteLine("7 - Рекурсивный вывод чисел последовательности и подсчёт их суммы");
            Console.WriteLine("0 - Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Program.Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Program.Task2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                         Program.Task3();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                         Program.Task4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                         Program.Task5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                         Program.Task6();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                         Program.Task7();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("\nBye-bye");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Wrong select!");
                    break;
            }

        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
