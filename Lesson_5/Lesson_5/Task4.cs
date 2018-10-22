//Автор: Станислав Митрофанов
//4.* Задача ЕГЭ. 
//На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы.
//В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N 
//строк имеет следующий формат: <Фамилия> <Имя> <оценки>, где<Фамилия> — строка, состоящая не более чем из 20 символов,
//<Имя> — строка, состоящая не более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам
//по пятибалльной системе. <Фамилия> и<Имя>, а также <Имя> и<оценки> разделены одним пробелом.
//Пример входной строки: Иванов Петр 4 5 3 
//Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших
//по среднему баллу учеников. Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших,
//следует вывести и их фамилии и имена.

//Судя по описанию задачи - загрузка из файла.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5
{
    partial class Program
    {
        struct Pupil
        {
            public string name;
            public int score1;
            public int score2;
            public int score3;
            public double medianScore;

            public Pupil(string initString)
            {
                char[] div = { ' ' };
                string[] data = initString.Split(div);
                name = data[0] + " " + data[1];
                score1 = int.Parse(data[2]);
                score2 = int.Parse(data[3]);
                score3 = int.Parse(data[4]);
                medianScore = (double)(score1 + score2 + score3) / 3;
            }

            public override string ToString()
            {
                return (name+" "+score1+" "+score2+" "+score3);
            }
        }

        static Pupil[] LoadSchool(string fileName)
        {
            Pupil[] a = null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                int count = int.Parse(sr.ReadLine());
                a = new Pupil[count];
                int i = 0;
                while (!sr.EndOfStream)
                {
                    a[i] = new Pupil(sr.ReadLine());
                    i++;
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
            return a;
        }

        static double GetPossibleMinScore(Pupil[] group, double betterThen)
        {
            double worst = 5;
            for (int i = 0; i < group.Length; i++)
            {
                if ((group[i].medianScore < worst) && (group[i].medianScore > betterThen))
                {
                    worst = group[i].medianScore;
                }
            }
            return worst;
        }

        static double[] GetWorstScore(Pupil[] group)//К сожалению, красивее ничего не придумал
        {
            double[] worstScore = { 5, 5, 5 };
            worstScore[0] = GetPossibleMinScore(group, 0);
            worstScore[1] = GetPossibleMinScore(group, worstScore[0]);
            worstScore[2] = GetPossibleMinScore(group, worstScore[1]);
            return worstScore;
        }

        static void Task4()
        {
            const string fileName = "C:\\test\\School.txt";
            Console.Clear();
            Pupil[] school = LoadSchool(fileName);
            Console.WriteLine("Ученики школы:");
            for (int i =0; i < school.Length; i++)
            {
                Console.WriteLine(school[i]);
            }
            Pause();

            Console.WriteLine("\nУченики с худшими средними баллами:\n");

            double[] worst = GetWorstScore(school);
            for (int i=0; i<worst.Length; i++)
            {
                Console.WriteLine("Средний балл - {0:f2}",worst[i]);
                for (int j = 0; j < school.Length; j++)
                {
                    if (school[j].medianScore == worst[i])
                    {
                        Console.WriteLine(school[j].name);
                    }
                }
                Console.WriteLine();
            }

            Pause();
            Menu();
        }
    }
}
