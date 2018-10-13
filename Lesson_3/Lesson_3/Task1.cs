//Автор: Станислав Митрофанов
//Задание 1:
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить
//работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3
{
    struct ComplexStruct //Заготовка структуры взята из методички
    {
        public double im;
        public double re;
        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public override string ToString() //по предложению компилятора добавлено переопределение метода (override)
        {
            return (im > 0) ? (re + "+" + im + "i") : (re +string.Empty+ im + "i");//предусматривает возможность отрицательной мнимой части
        }
    }

    class ComplexClass //Заготовка класса взята из методички
    {
        double im;
        double re;

        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        public ComplexClass(double _re, double _im)
        {
            im = _im;
            re = _re;
        }

        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public ComplexClass Multi(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }
        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }
        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public override string ToString()
        {
            return (im > 0) ? (re + "+" + im + "i") : (re + string.Empty + im + "i");//предусматривает возможность отрицательной мнимой части
        }
    }

    partial class Program
    {
        static void ComplexStructMenu()
        {
            Console.Clear();
            Console.WriteLine("Работа с комплексными числами (Struct)");
            Console.WriteLine("1 - Сложение чисел");
            Console.WriteLine("2 - Умножение чисел");
            Console.WriteLine("3 - Вычитание чисел");
            Console.WriteLine("0 - Возврат в меню раздела");

            ComplexStruct complexA, complexB;//можно сделать и ручной ввод, но для демонстрации хватит и задания в программе
            complexA.re = 3;
            complexA.im = 2;
            complexB.re = 4;
            complexB.im = 5;

            Console.WriteLine("Действия будут произодится для чисел "+ complexA.ToString() +" и "+complexB.ToString());
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("\n" + complexA.ToString()+" + "+complexB.ToString()+" = "+complexA.Plus(complexB).ToString());
                    Pause();
                    ComplexStructMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("\n" + complexA.ToString() + " * " + complexB.ToString() + " = " + complexA.Multi(complexB).ToString());
                    Pause();
                    ComplexStructMenu();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("\n" + complexA.ToString() + " - " + complexB.ToString() + " = " + complexA.Minus(complexB).ToString());
                    Pause();
                    ComplexStructMenu();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    ComplexMenu();
                    break;
                default:
                    Console.WriteLine("Wrong select!");
                    Pause();
                    ComplexStructMenu();
                    break;
            }

        }

        static void ComplexClassMenu()
        {
            Console.Clear();
            Console.WriteLine("Работа с комплексными числами (Class)");
            Console.WriteLine("1 - Сложение чисел");
            Console.WriteLine("2 - Умножение чисел");
            Console.WriteLine("3 - Вычитание чисел");
            Console.WriteLine("0 - Возврат в меню раздела");

            ComplexClass complexA, complexB;
            complexA = new ComplexClass(3, 2);//попробуем разные варианты задания значений
            complexB = new ComplexClass();
            complexB.Re = 4;
            complexB.Im = 5;

            Console.WriteLine("Действия будут произодится для чисел " + complexA.ToString() + " и " + complexB.ToString());

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("\n" + complexA.ToString() + " + " + complexB.ToString() + " = " + complexA.Plus(complexB).ToString());
                    Pause();
                    ComplexClassMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("\n" + complexA.ToString() + " * " + complexB.ToString() + " = " + complexA.Multi(complexB).ToString());
                    Pause();
                    ComplexClassMenu();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("\n" + complexA.ToString() + " - " + complexB.ToString() + " = " + complexA.Minus(complexB).ToString());
                    Pause();
                    ComplexClassMenu();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    ComplexMenu();
                    break;
                default:
                    Console.WriteLine("\nWrong select!");
                    Pause();
                    ComplexClassMenu();
                    break;
            }

        }

        static void ComplexMenu()
        {
            Console.Clear();
            Console.WriteLine("Работа с комплексными числами");
            Console.WriteLine("1 - Работа со структурой");
            Console.WriteLine("2 - Работа с классом");
            Console.WriteLine("0 - Возврат в основное меню");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ComplexStructMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    ComplexClassMenu();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("\nWrong select!");
                    Pause();
                    ComplexMenu();
                    break;
            }

        }

        static void Task1()
        {
            ComplexMenu();
        }
    }
}
