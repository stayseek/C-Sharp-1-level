using System;

class Program
{   
    //Программа-анкета
    static void Main()
    {
        //Запрос данных
        Console.Write("Введите ваше имя: ");
        string FirstName = Console.ReadLine();
        Console.Write("Введите вашу фамилию: ");
        string SecondName = Console.ReadLine();
        Console.Write("Введите ваш возраст: ");
        string Age = Console.ReadLine();
        Console.Write("Введите ваш рост: ");
        string Height = Console.ReadLine();
        Console.Write("Введите ваш вес: ");
        string Weight = Console.ReadLine();

        Console.WriteLine();

        //Вывод склеиванием
        Console.WriteLine("Вы - " + FirstName + " " + SecondName + ". Ваш возраст - " + Age + ", рост - " + Height + ", вес - " + Weight);
        
        //Вывод форматированием
        Console.WriteLine("Вы - {0} {1}. Ваш возраст - {2}, рост - {3}, вес - {4}", FirstName, SecondName, Age, Height, Weight);
        
        //Вывод с $
        Console.WriteLine($"Вы - {FirstName} {SecondName}. Ваш возраст - {Age}, рост - {Height}, вес - {Weight}"); 

        Console.ReadKey();

    }
}