//1. Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
//Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    // Описываем делегат. В делегате описывается сигнатура методов, на
    // которые он сможет ссылаться в дальнейшем (хранить в себе) 
    // !!! Fun будет также использован во 2 задании !!! 
    public delegate double Fun(double x);

    public delegate double DoubleFun(double x, double a);

    partial class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        //Перегружаем метод для возможности передачи функций с 2 параметрами double
        public static void Table(DoubleFun F, double a, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x)
        {
            return x * x * x;
        }

        public static double MyDoubleFunc(double x, double a)
        {
            return a * x * x;
        }

        public static double MySinFunc(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Task1()
        {
            Console.Clear();

            // Создаем новый делегат и передаем ссылку на него в метод Table
            Console.WriteLine("Таблица функции MyFunc:");
            // Параметры метода и тип возвращаемого значения, должны совпадать с делегатом
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Еще раз та же таблица, но вызов организован по-новому");
            // Упрощение(c C# 2.0).Делегат создается автоматически.
            Table(MyFunc, -2, 2);
            Pause();
            Console.WriteLine("Таблица функции Sin:");
            Table(Math.Sin, -2, 2); // Можно передавать уже созданные методы
            Console.WriteLine("Таблица функции x^2:");
            // Упрощение(с C# 2.0). Использование анонимного метода
            Table(delegate (double x) { return x * x; }, 0, 3);
            Pause();
            Console.WriteLine("\nРабота с делагатом, принимающим 2 параметра.\n");
            Console.WriteLine("Введите константу a для передачи в функцию (по-умолчанию = 2)");
            double a;//зададим константу для передачи в метод
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                a = 2;
            } 
            Console.WriteLine("Таблица функции a* x^2, при a={0}:",a);
            Table(MyDoubleFunc, a, 0, 3);
            Console.WriteLine("Таблица функции a* sin(x), при a={0}:", a);
            Table(MySinFunc, a, -2, 2);
            Pause();
            Menu();
        }
    }
}
