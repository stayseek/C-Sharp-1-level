//Автор: Станислав Митрофанов
//Задание 3:
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
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                else
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
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0");
            }
            else
            {
                this.denominator = denominator;
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
        int NOD () //поиск наибольшего общего делителя, данные надо брать по модулю
        {
            int big = (Math.Abs(numerator) > Math.Abs(denominator)) ? Math.Abs(numerator) : Math.Abs(denominator);
            int small = (big == Math.Abs(numerator)) ? Math.Abs(denominator) : Math.Abs(numerator);
            while (big % small != 0)
            {
                int ost = big % small;
                big = small;
                small = ost;
            }
            return small;
        }

        public Fraction Simplify() //упрощение дроби
        {
            Fraction y = new Fraction(numerator / NOD(), denominator / NOD());
            return y;
        }

        public override string ToString()//красивый вывод дроби. Добавим выделение целой части, вне задания, просто так лучше выглядит
        {
            if (Math.Abs(numerator) > Math.Abs(denominator))
            {
                string temp = string.Empty;
                if (numerator%denominator != 0)
                {
                    temp = " "+(Math.Abs(numerator % denominator)) + "/" + denominator;
                }
                return (numerator / denominator) + temp;
            }
            else
            {
                return (numerator + "/" + denominator);
            }
        }


    }
    partial class Program
    {
        static void Task3()
        {
            int num;
            int den;
            Console.Clear();
            // для ввода цифр будем пользоваться функцией контролируемого ввода из 2-го задания.
            Console.Write("Введите числитель первой дроби: ");
            num = GetkNumbers();
            Console.Write("Введите знаменатель первой дроби: ");
            den = GetkNumbers();
            Fraction a = new Fraction(num, den);

            Console.Write("Введите числитель второй дроби: ");
            num = GetkNumbers();
            Console.Write("Введите знаменатель второй дроби: ");
            den = GetkNumbers();
            Fraction b = new Fraction(num, den);

            Console.WriteLine("Операции будут производится над числами " + a + " и " + b);
            Console.WriteLine("Упрощение первой дроби: "+ a + " = " + a.Simplify());
            Console.WriteLine("Упрощение второй дроби: " + b + " = " + b.Simplify());
            //Дальнейшие действия будем проводить для упрощенных дробей и выводить результат с упрощением.
            a = a.Simplify();
            b = b.Simplify();
            Console.WriteLine("Десятичный вид первой дроби: " + a + " = " + a.DecimalFraction);
            Console.WriteLine("Десятичный вид второй дроби: " + b + " = " + b.DecimalFraction);
            Console.WriteLine("Сумма дробей: " + a +" + " + b + " = " + a.Add(b).Simplify());
            Console.WriteLine("Разность дробей: " + a + " - " + b + " = " + a.Sub(b).Simplify());
            Console.WriteLine("Произведение дробей: " + a + " * " + b + " = " + a.Multi(b).Simplify());
            Console.WriteLine("Деление дробей: " + a + " / " + b + " = " + a.Div(b).Simplify());
            Pause();
            MainMenu();
        }
    }
}
