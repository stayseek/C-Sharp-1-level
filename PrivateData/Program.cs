using System;

class Program
{
    //Программа для вывода данных на экран
    static void Main()
    {
        //Ввод данных, экран чистим после ввода каждого значения
        Console.Write("Введите ваше имя: ");
        string FirstName = Console.ReadLine();
        Console.Clear();
        Console.Write("Введите вашу фамилию: ");
        string SecondName = Console.ReadLine();
        Console.Clear();
        Console.Write("Введите город вашего проживания: ");
        string City = Console.ReadLine();
        Console.Clear();

        //Вывод результирующей строки в центр окна ("длина строки" была найдена в предлагаемых автоподстановщиком вариантах)
        string Text = $"{FirstName} {SecondName}, {City}";
        WriteAt(Text, (Console.WindowWidth / 2)-(Text.Length/2), Console.WindowHeight / 2);
        Console.ReadKey();

    }

    static void WriteAt(string s, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(s);
    }
}