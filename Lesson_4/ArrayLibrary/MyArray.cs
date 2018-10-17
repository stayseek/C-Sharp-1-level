using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLibrary
{
    public class MyArray
    {
        private int[] a;

        public MyArray(int size)
        {
            a = new int[size];
        }

        //конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом
        public MyArray(int size, int start, int step) : this(size)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = start + step * i;
        }

        public int this[int index]
        {
            get { return a[index]; }
            set { a[index] = value; }
        }

        int Max()
        {
            int m = a[0];
            foreach (int element in a)
            {
                if (element > m) m = element;
            }
            return m;
        }

        //свойство Sum, которое возвращает сумму элементов массива
        public int Sum
        {
            get
            {
                int sum = 0;
                foreach (int element in a)
                {
                    sum += element;
                }
                return sum;
            }
        }
        //метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений)
        public MyArray Inverse()
        {
            MyArray b = null;
            b = new MyArray(a.Length);
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = -a[i];
            }
            return b;
        }
        //метод Multi, умножающий каждый элемент массива на определённое число
        public void Multy(int multy)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * multy;
            }
        }

        //свойство MaxCount, возвращающее количество максимальных элементов
        public int MaxCount
        {
            get
            {
                int maxCount = 0;
                int max = Max();
                foreach (int element in a)
                {
                    if (element == max) maxCount++;
                }
                return maxCount;
            }
        }

        //Подсчёт частоты вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
        public Dictionary<int, int> GetFrequency()
        {
            Dictionary<int, int> dict = null;
            dict = new Dictionary<int, int>();
            foreach (int element in a)
            {
               if (dict.ContainsKey(element))
                {
                    dict[element]++;
                }
                else
                {
                    dict.Add(element, 1);
                } 
            }
            return dict;
        }

        public int Length
        {
            get
            {
                return a.Length;
            }
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.Length; i++)
                s = s + String.Format("{0,5}", a[i]);
            return s;
        }

    }
}
