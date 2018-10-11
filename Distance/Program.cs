using System;

class Program
{
    //Программа для расчёта расстояния между точкам
    static void Main()
    {
        //Ввод данных с конвертицией строки в число
        Console.Write("Введите координату X первой точки: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y первой точки: ");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите координату X второй точки: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y второй точки: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        //Вывод результата в форматированном виде с использованием метода
        Console.WriteLine("Расстояние между точками равно {0:F2}",getDistance(x1,y1,x2,y2));

        Console.ReadKey();

    }

    static double getDistance(double x1, double y1, double x2, double y2)
    {
        //Сразу выдаём рассчётное значение
        return Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
    }
}