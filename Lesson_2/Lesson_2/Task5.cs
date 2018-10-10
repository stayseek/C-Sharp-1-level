//Автор: Станислав Митрофанов
//Условие: а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
//массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static void Task5()
        {
            Console.Clear();
            Console.WriteLine("Расчёт Индекса Массы Тела");
            Console.Write("Введите ваш рост в сантиметрах: ");
            double Height = double.Parse(Console.ReadLine())/100;
            Console.Write("Введите ваш вес в килограммах: ");
            double Weight = double.Parse(Console.ReadLine());

            //Расчёт и вывод ИМТ

            //Граница "нормальной" зоны ИМТ
            const double minBMI = 18.5;
            const double maxBMI = 24.99;

            double BMI = Weight / ((Height * Height));
            Console.WriteLine("Ваш Индекс Массы Тела равен {0:F2}", BMI);

            if ((BMI >= minBMI)&&(BMI <= maxBMI))
            {
                Console.WriteLine("Поздравляю! У вас нормальный вес.");
            }
            else
            {
                //Расчётные формулы выведены на бумаге.
                if (BMI < minBMI)
                {
                    Console.WriteLine("У вас нехватка веса.\nДля нормализации веса вам необходимо набрать хотя бы {0:F2} кг.", (minBMI * (Height * Height)-Weight));
                }
                if (BMI > maxBMI)
                {
                    Console.WriteLine("У вас избыток веса.\nДля нормализации веса вам необходимо сбросить хотя бы {0:F2} кг.", (Weight - maxBMI * (Height * Height)));
                }
            }

            Pause();
            Menu();
        }
    }
}
