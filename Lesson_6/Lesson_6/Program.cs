using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    partial class Program
    {
        static void Pause()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...\n");
            Console.ReadKey();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Станислав Митрофанов");
            Console.WriteLine("Домашнее задание №6");
            Console.WriteLine("1 - Вывод таблицы функции");
            Console.WriteLine("2 - Программа поиска минимума функции");
            Console.WriteLine("3 - Использование коллекций");
            Console.WriteLine("4 - Чтение из файла различными способами");
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
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("\nBye-bye");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("\nWrong select!");
                    Pause();
                    Menu();
                    break;
            }

        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
