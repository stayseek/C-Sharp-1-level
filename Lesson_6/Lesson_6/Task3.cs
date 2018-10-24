//3. Переделать программу Пример использования коллекций для решения следующих задач:

//а) Подсчитать количество студентов учащихся на 5 и 6 курсах; 
//(Подсчёт учащихся на 5 и 6 курсах уже произведён в изначальном тексте программы, так как их количество совпадает с количеством магистров.
//Будем считать, что имелось в виду "на 5 курсе и на 6 курсе")

//б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);

//в) отсортировать список по возрасту студента;
//г) * отсортировать список по курсу и возрасту студента;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_6
{
    class Student
    {
        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        public int age;
        // Создаем конструктор
        public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }
    }
    partial class Program
    {
        static int MyDelegat(Student st1, Student st2) // Создаем метод для сравнения для экземпляров (по имени)
        {
            return String.Compare(st1.firstName, st2.firstName); //Сравниваем две строки
        }
        static int AgeSort(Student st1, Student st2) // Создаем метод для сравнения для экземпляров (по возрасту)
        {
            return st1.age.CompareTo(st2.age);
        }
        static int AgeCourseSort(Student st1, Student st2) // Создаем метод для сравнения для экземпляров (сначала по курсу, внутри курса - по возрасту)
        {
            if (st1.course == st2.course)
            {
                return st1.age - st2.age;
                
            }
            else
            {
                return st1.course - st2.course;
            }
        }
        static void Task3()
        {
            Console.Clear();
            const string fileName = "C:\\test\\students_1.csv";
            int bakalavr = 0;
            int magistr = 0;
            int fifth = 0;
            int sixth = 0;
            int consoleCapacity = Console.WindowHeight-5;

            List<Student> list = new List<Student>();

            //Создание словаря для частотного анализа по возрасту
            Dictionary<int, int> ageCourse = new Dictionary<int, int>();
            for (int i = 1; i<7; i++)
            {
                ageCourse.Add(i, 0);
            }

            // Создаем список студентов
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader(fileName);
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                    // Одновременно подсчитываем количество бакалавров и магистров
                    if (int.Parse(s[6]) < 5)
                    {
                        bakalavr++;
                        
                    }
                    else
                    {
                        magistr++;
                        if (int.Parse(s[6]) == 5)
                        {
                            fifth++;
                        }
                        else
                        {
                            sixth++;
                        }
                    }
                    //Заполнение словаря для частотного анализа по возрасту
                    if ((int.Parse(s[5]) <= 20)&&((int.Parse(s[5]) >= 18)))
                    {
                        ageCourse[int.Parse(s[6])]++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    // Выход из Main
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Выберите вариант сортировки списка:");
            Console.WriteLine("1 - По имени (по-умолчанию)");
            Console.WriteLine("2 - По возрасту");
            Console.WriteLine("3 - По курсу и возрасту");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    list.Sort(new Comparison<Student>(MyDelegat));
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    list.Sort(new Comparison<Student>(AgeSort));
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    list.Sort(new Comparison<Student>(AgeCourseSort));
                    break;
                default:
                    Console.WriteLine("\nWrong select!");
                    list.Sort(new Comparison<Student>(MyDelegat));
                    break;
            }

            Console.WriteLine("\nВсего студентов:" + list.Count);
            Console.WriteLine("Бакалавров (1-4 курс):{0}", bakalavr);
            //!!!Подсчёт учащихся на 5 и 6 курсах уже произведён, так как их количество совпадает с количеством магистров !!!
            Console.WriteLine("Магистров (5-6 курс):{0}", magistr);
            Console.WriteLine("На 5 курсе обучаются:{0}", fifth);
            Console.WriteLine("На 6 курсе обучаются::{0}", sixth);
            Pause();

            Console.WriteLine("Распределение по курсам студентов возрастом от 18 до 20 лет:\n");
            foreach (KeyValuePair<int,int> course in ageCourse)
            {
                Console.WriteLine("{0} курс - {1} студентов", course.Key, course.Value);
            }
            Pause();

            Console.WriteLine("Отсортированный список студентов:\n");
            Console.WriteLine("Имя_________________|Фамилия______________|Возраст|Курс");
            int count = 0;
            foreach (var v in list)
            {
                Console.WriteLine($"{v.firstName,-20} {v.lastName,-20} {v.age,8} {v.course,4}");
                count++;
                if (count == consoleCapacity)
                {
                    Console.ReadKey();
                    count = 0;
                }
            }
            Console.WriteLine(DateTime.Now - dt);
            Pause();
            Menu();
        }
    }
}
