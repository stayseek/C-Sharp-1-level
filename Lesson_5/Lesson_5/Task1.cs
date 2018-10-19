//Автор: Станислав Митрофанов
//1. Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, 
//содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой: 
// а) без использования регулярных выражений; 
// б) ** с использованием регулярных выражений.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson_5
{
    partial class Program
    {
        static bool IsLatinOrNum(string str)
        {
            bool pass = true;
            for (int i=0; i < str.Length; i++)
            {
                if (!((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= '0' && str[i] <= '9')))
                {
                    pass = false;
                }
            }
            return pass;
        }
        static void Task1()
        {
            Console.Clear();
            Console.WriteLine("Введите логин:");
            string loginString = Console.ReadLine();

            Console.WriteLine("Проверка по значениям символов.");
            if ( (loginString.Length > 1)&&(loginString.Length < 11)&&char.IsLetter(loginString[0])&&IsLatinOrNum(loginString))
            {
                Console.WriteLine("Введён верный логин.");
            }
            else
            {
                Console.WriteLine("Введён неверный логин.");
            }

            Console.WriteLine("Проверка с помощью регулярного выражения.");
            Regex loginRegEx = new Regex(@"^[A-Za-z][A-Za-z0-9]{1,9}$");
            if (loginRegEx.IsMatch(loginString))
            {
                Console.WriteLine("Введён верный логин.");
            }
            else
            {
                Console.WriteLine("Введён неверный логин.");
            }

            Pause();
            Menu();
        }
    }
}
