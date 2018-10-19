//Автор: Станислав Митрофанов
//3.* Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
//Например:
//badc являются перестановкой abcd.

//Навскидку, можно:
//1) провести частотный посимвольный анализ строк, записав результаты в Dictionary <string,int> и сравнить получившиеся словари 
//  на соответствие количества ключей и их значений.
//2) удалять символы одной строки из другой, пока, или следующий символ не будет найден, или строка не станет пустой (корявенько, но легко реализуемо)
//Сделаем по 2 варианту.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    partial class Program
    {
        static bool CheckStrings (string str1, string str2)
        {
            bool compat = false;
            int i = 0;
            if (str1 != string.Empty)//Вдруг строка не введена
            {
                while ((str2.IndexOf(str1[i]) != -1) || str2 != "")
                {
                    str2 = str2.Remove(str2.IndexOf(str1[i]), 1);
                    i++;
                    if (i == str1.Length) break;
                }
            }
            if ((str2 == string.Empty) && (i == str1.Length))//работает, даже если строки пустые, так как тогда и i=0 и строка пустая
            {
                compat = true;
            }
            return compat;
        }
        static void Task3()
        {
            Console.Clear();
            Console.WriteLine("Введите первую строку:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            string str2 = Console.ReadLine();
            if (CheckStrings(str1,str2))
            {
                Console.WriteLine("Строки \"{0}\" и \"{1}\" содержат одинаковые символы", str1, str2);
            }
            else
            {
                Console.WriteLine("Строки \"{0}\" и \"{1}\" содержат различные символы", str1, str2);
            }
            Pause();
            Menu();
        }
    }
}
