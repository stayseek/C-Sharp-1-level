//Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
//программу, демонстрирующую все разработанные элементы класса.
//* Добавить свойства типа int для доступа к числителю и знаменателю;
//* Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
//** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
//ArgumentException("Знаменатель не может быть равен 0");
//*** Добавить упрощение дробей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    class Fraction
    {
        //Поля
        int numerator;
        int denominator;
        
        //Свойства
        public int Numerator
        {
            set
            {
                if (value != 0)
                {
                    numerator = value;
                }
            }
            get
            {
                return numerator;
            }
        }
        public int Denominator
        {
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
            }
            get
            {
                return denominator;
            }
        }
        public double DecimalFraction
        {
            get
            {
                return (double)numerator / denominator;
            }
        }

        //Конструкторы
        public Fraction()
        {
            numerator = 1;
            denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator != 0)
            {
                this.denominator = denominator;
            }
            else
            {
                this.denominator = 1;
            }
            
        }

        //Методы
        public Fraction Add (Fraction x)//Сложение
        {
            Fraction y = new Fraction();
            y.numerator = (numerator * x.denominator + x.numerator * denominator);
            y.denominator = denominator * x.denominator;
            return y;
        }
        public Fraction Sub(Fraction x)//Вычитание
        {
            Fraction y = new Fraction();
            y.numerator = (numerator * x.denominator - x.numerator * denominator);
            y.denominator = denominator * x.denominator;
            return y;
        }
        public Fraction Multi(Fraction x)//Умножение
        {
            Fraction y = new Fraction();
            y.numerator = (numerator * x.numerator);
            y.denominator = denominator * x.denominator;
            return y;
        }
        public Fraction Div(Fraction x)//Деление
        {
            Fraction y = new Fraction();
            y.numerator = (numerator * x.denominator);
            y.denominator = denominator * x.numerator;
            return y;
        }
        int NOD () //поиск наибольшего общего делителя
        {
            int big = (Numerator > Denominator) ? Numerator : Denominator;
            int small = (big == Numerator) ? Denominator : Numerator;
            while (big % small != 0)
            {
                int ost = big % small;
                big = small;
                small = ost;
            }
            return small;
        }
        public string Simplify() //вывод упрощенной дроби
        {
            return (numerator / NOD() + "/" + denominator / NOD());
        }
        public override string ToString()//красивый вывод дроби
        {
            return (numerator+"/"+denominator);
        }

    }
    partial class Program
    {
        static void Task3()
        {
            Console.Clear();
            Fraction a = new Fraction(16, 48);
            Fraction b = new Fraction(23, 49);
            Console.WriteLine(a.ToString());
            Console.WriteLine(a.Simplify());
            Console.WriteLine(a.Add(b).Simplify());
            Console.WriteLine(a.Sub(b).Simplify());
            Console.WriteLine(a.Multi(b).Simplify());
            Console.WriteLine(a.Div(b).Simplify());
            Console.WriteLine("{0:F4}",a.DecimalFraction);
            Console.WriteLine();
            Pause();
        }
    }
}
