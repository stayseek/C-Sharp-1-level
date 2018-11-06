using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace WFStudents
{
    [Serializable]
    public class Student
    {
        string lastName = string.Empty;
        string firstName = string.Empty;
        string university = string.Empty;
        string faculty = string.Empty;
        int course = 1;
        string department = string.Empty;
        int group = 0;
        string city = string.Empty;
        int age = 0;
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
        
        public Student()
        {

        }

        public string LastName
        {
            set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        public string FirstName
        {
            set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        public string University
        {
            set
            {
                university = value;
            }
            get
            {
                return university;
            }
        }
        public string Faculty
        {
            set
            {
                faculty = value;
            }
            get
            {
                return faculty;
            }
        }
        public int Course
        {
            set
            {
                course = value;
            }
            get
            {
                return course;
            }
        }
        public string Department
        {
            set
            {
                department = value;
            }
            get
            {
                return department;
            }
        }
        public int Group
        {
            set
            {
                group = value;
            }
            get
            {
                return group;
            }
        }
        public string City
        {
            set
            {
                city = value;
            }
            get
            {
                return city;
            }
        }
        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }
    }
    class StudentsBase
    {
        string fileName;
        List<Student> list;

        public List<Student> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }

        public string FileName
        {
            set
            {
                fileName = value;
            }
            get
            {
                return fileName;
            }
        }

        public StudentsBase(string fileName)
        {
            this.fileName = fileName;
            list = new List<Student>();
        }

        public void Save(string fileName)
        {
            Stream fStream = null;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            try
            {
                fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                xmlFormat.Serialize(fStream, list);
                this.fileName = fileName;
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
                if (fStream != null) fStream.Close();
            }
        }

        public void Load()
        {
            Stream fStream = null;
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Student>));
            try
            {
                fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                list = (List<Student>)xmlFormat.Deserialize(fStream);
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
                if (fStream != null) fStream.Close();
            }
        }
        public void ImportFromCSV(string fileNameCSV)
        {
            StreamReader sr = new StreamReader(fileNameCSV);
            list.Clear();
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
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
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }
    }
}
