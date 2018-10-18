using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayTwoDimLibrary
{
    public class MyTwoDimArray
    {
        private int[,] a;

        public MyTwoDimArray(int strSize, int colSize)
        {
            a = new int[strSize,colSize];
        }

        //конструктор, создающий массив определенного размера и заполняющий массив случайными числами из диапазона
        public MyTwoDimArray(int strSize, int colSize, int min, int max) : this(strSize, colSize)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j<a.GetLength(1); j++)
                {
                    a[i,j] = rnd.Next(min, max + 1);
                }
        }

        //конструктор, создающий массив из файла
        public MyTwoDimArray(string fileName)
        {
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                int strSize = int.Parse(sr.ReadLine());
                int colSize = int.Parse(sr.ReadLine());
                a = new int[strSize,colSize];
                int i = 0;
                int j = 0;
                while (!sr.EndOfStream)
                {
                    if (j == colSize)
                    {
                        j = 0;
                        i++;
                    }
                    a[i,j] = int.Parse(sr.ReadLine());
                    j++;
                }
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }

        //сумма всех элементов массива
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum+=a[i, j];
                }
            return sum;
        }
        //сумма всех элементов массива больше заданного
        public int SumGreater(int min)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > min)
                    {
                        sum += a[i, j];
                    }
                }
            return sum;
        }

        //свойство, возвращающее минимальный элемент массива
        public int Min
        {
            get
            {
                int min = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] < min)
                        {
                            min = a[i, j];
                        }
                    }
                return min;
            }
        }
        //свойство, возвращающее максимальный элемент массива
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > max)
                        {
                            max = a[i, j];
                        }
                    }
                return max;
            }
        }
        //метод, возвращающий номер максимального элемента массива(через параметры, используя модификатор ref или out)
        public void MaxPos(ref int str, ref int col)
        {
            int max = Max;
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == max)
                    {
                        str = i;
                        col = j;
                    }
                }
        }
        //метод, сохраняющий массив в файл
        public void WriteToFile(string filename)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine(a.GetLength(0));
                sw.WriteLine(a.GetLength(1));
                foreach (int el in a) //так как элементы массива идут последовательно, не нужно задумываться о строках и столбцах
                {
                    sw.WriteLine(el);
                }   
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (DirectoryNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s = s + String.Format("{0,5}", a[i,j]);
                }
                s += "\n";
            }
            return s;
        }
    }
}
