using System;

class Program
{
    //Программа для расчёта Индекса Массы Тела (ИМТ)
    static void Main()
    {
        //Ввод данных с конвертицией строки в число
        Console.Write("Введите ваш рост в сантиметрах: ");
        double Height = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ваш вес в килограммах: ");
        double Weight = Convert.ToDouble(Console.ReadLine());

        //Расчёт и вывод ИМТ
        double BMI = Weight / ((Height * Height) / 10000);
        Console.WriteLine("Ваш Индекс Массы Тела равен {0:F2}", BMI);

        Console.ReadKey();

    }
}