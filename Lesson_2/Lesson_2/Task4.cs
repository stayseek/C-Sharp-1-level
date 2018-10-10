//Автор: Станислав Митрофанов
//Условие: Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На
//выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password:
//GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь
//вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью
//цикла do while ограничить ввод пароля тремя попытками.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    partial class Program
    {
        static bool CheckCredentials(string login, string password)
        {
            if ((login == "root") && (password == "GeekBrains"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Task4()
        {
            Console.Clear();
            Console.WriteLine("Программа проверки логина и пароля.");
            int loginCount = 3;
            bool enter = false;
            do
            {
                Console.Write("Login: ");
                string login = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();
                if (CheckCredentials(login, password))
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
