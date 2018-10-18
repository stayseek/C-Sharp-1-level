//Автор: Станислав Митрофанов
//Задание:
//3. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, создающий
//массив определенного размера и заполняющий массив числами от начального значения с
//заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод
//Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый
//массив, остается без изменений), метод Multi, умножающий каждый элемент массива на
//определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
//б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу
//библиотеки
//е) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;//что бы не писать каждый раз пространство имён библиотеки

namespace Lesson_4
{
    partial class Program
    {
        static void Task3()
        {
            const int count = 10;
            const int start = 4;
            const int step = 5;
            const int countR = 30;
            const int min = -10;
            const int max = 10;
            Console.Clear();
            Console.WriteLine("Проверка работы библиотеки одномерного массива.");
            Console.WriteLine("Создание массива из {0} элементов начиная с числа {1} с шагом {2} конструктором:", count, start, step);
            MyArray a;
            a = new MyArray(count, start, step);
            Console.WriteLine(a);
            Console.WriteLine("Для следующих тестов создадим массив из {0} элементов со случайными числами в диапазоне от {1} до {2}", countR, min, max);
            //что бы нормально можно было проверить работу частоты вхождения значений.
            MyArray b;
            b = new MyArray(countR);
            
            Random rnd = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(min, max + 1);
            }
            Console.WriteLine("Получившийся массив: \n{0}",b);
            Console.WriteLine("Сумма элементов массива: \n{0}", b.Sum);
            Pause();
            MyArray c;
            c = b.Inverse();
            Console.WriteLine("Массив с инвертированными знаками элементов: \n{0}", c);
            Console.WriteLine("При этом исходный массив остался без изменений: \n{0}", b);
            Pause();
            b.Multy(2);
            Console.WriteLine("Умножим все элементы массива на 2: \n{0}", b);
            Pause();
            Console.WriteLine("Максимальных элементов в массиве: {0}",b.MaxCount);
            Pause();
            Console.WriteLine("Частота появления элементов в массиве:");
            Dictionary<int, int> d = b.GetFrequency();
            foreach (KeyValuePair<int,int> kvp in d)
            {
                Console.WriteLine("Значение - {0}, количество элементов - {1}",kvp.Key,kvp.Value);
            }
            Pause();
            Menu();
        }
    }
}
