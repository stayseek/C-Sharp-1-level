//Автор: Станислав Митрофанов
//Задание:5. * а) Реализовать библиотеку с классом для работы с двумерным массивом.Реализовать
// конструктор, заполняющий массив случайными числами.Создать методы, которые возвращают
//сумму всех элементов массива, сумму всех элементов массива больше заданного, свойство,
//возвращающее минимальный элемент массива, свойство, возвращающее максимальный
//элемент массива, метод, возвращающий номер максимального элемента массива(через
//параметры, используя модификатор ref или out).
//** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
// в файл.
// ** в) Обработать возможные исключительные ситуации при работе с файлами.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayTwoDimLibrary;

namespace Lesson_4
{
    partial class Program
    {
        static void Task5()
        {
            const int greater = 0;
            const int aStr = 7;
            const int aCol = 8;
            const int min = -10;
            const int max = 10;
            const string fileName = "C:\\test\\TwoDim.txt";
            Console.Clear();
            MyTwoDimArray a = null;
            MyTwoDimArray b = null;
            int str = 0;
            int col = 0;
            Console.WriteLine("Создадим массив {0}*{1} и заполним его случайными числами в диапазоне от {2} до {3}", aStr, aCol, min, max);
            a = new MyTwoDimArray(aStr, aCol, min, max);
            Console.WriteLine(a);
            Console.WriteLine("Сумма элементов массива равна: {0}", a.Sum());
            Console.WriteLine("Сумма элементов больших {0} равна: {1}", greater,a.SumGreater(greater));
            Pause();
            Console.WriteLine("Минимальный элемент равен: {0}", a.Min);
            Console.WriteLine("Максимальный элемент равен: {0}",a.Max);
            a.MaxPos(ref str, ref col);
            Console.WriteLine("Максимальный элемент находится в позиции: {0} {1}", str, col);
            Pause();
            Console.WriteLine("Сохраним массив в файл {0}", fileName);
            a.WriteToFile(fileName);
            Console.WriteLine("Создадим ещё один массив конструктором из файла и выведем его на экран");
            b = new MyTwoDimArray(fileName);
            Console.WriteLine(b);
            Pause();
            Menu();
        }
    }
}
