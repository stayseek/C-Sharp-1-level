using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    partial class Program
    {
        static void Pause()
        {
            Console.Write("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Митрофанов Станислав");
            Console.WriteLine("Домашнее задание №3");
            Console.WriteLine("1 - Работа со структурой и классом");
            Console.WriteLine("2 - Проверка введённых данных и исключения");
            Console.WriteLine("3 - Класс дробей");
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
            MainMenu();
        }
    }
}
