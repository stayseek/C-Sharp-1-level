//Автор: Станислав Митрофанов
//Задание:4. Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
//Создайте структуру Account, содержащую Login и Password.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_4
{
    partial class Program
    {
        struct Account
        {
            public string login;
            public string password;
        }
        static Account[] LoadCredentials(string fileName)
        {
            Account[] a = null;
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(fileName);
                int count = int.Parse(sr.ReadLine());
                a = new Account[count];
                int i = 0;
                while (!sr.EndOfStream)
                {
                    a[i].login = sr.ReadLine();
                    a[i].password = sr.ReadLine();
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

        static bool CheckCredentials(string login, string password, Account[] credentials)
        {
            bool pass = false;
            for (int i = 0; i<credentials.Length; i++)
            {
                if ((login == credentials[i].login) && (password == credentials[i].password))
                {
                    pass = true;
                }
            }
            return pass;
        }
        static void Task4()
        {
            const string fileName = "C:\\test\\credentials.txt";
            Console.Clear();
            Console.WriteLine("Программа проверки логина и пароля.");
            int loginCount = 3;
            bool enter = false;
            Account[] a = null;
            a = LoadCredentials(fileName);
            do
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                if (CheckCredentials(login, password,a))
                {
                    enter = true;
                }
                else
                {
                    loginCount--;
                    Console.WriteLine("Логин или пароль не верны, осталось {0} попытки входа.", loginCount);
                }
            }
            while ((loginCount > 0) && !(enter));

            if (enter)
            {
                Console.WriteLine("Вы вошли в систему!");
            }
            else
            {
                Console.WriteLine("Количество попыток ввода закончилось, пока.");
            }
            Pause();
            Menu();
        }
    }
}
