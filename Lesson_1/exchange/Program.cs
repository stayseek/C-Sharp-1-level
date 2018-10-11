using System;

class Program
{
    //Обмен значений переменных. Будем считать, что имеются в виду числовые переменные.
    static void Main()
    {
        //Ввод данных с конвертицией строки в число
        Console.Write("Введите зачение первой переменной: ");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение второй переменной: ");
        double Second = Convert.ToDouble(Console.ReadLine());

        //Обмен значений с использованием третьей переменной
        double Third = First;
        First = Second;
        Second = Third;
        Console.WriteLine("Значение первой переменной теперь - {0}, второй - {1}", First, Second);
        Console.WriteLine("Нажмите любую клавишу для обратного перемещения.");
        Console.ReadKey();

        //Обмен без использования третьей переменной
        First = First + Second;
        Second = First - Second;
        First = First - Second;
        Console.WriteLine("Значение первой переменной теперь - {0}, второй - {1}", First, Second);
        Console.ReadKey();

    }
}