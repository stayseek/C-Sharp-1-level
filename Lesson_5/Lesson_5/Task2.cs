//Автор: Станислав Митрофанов
//2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
// а) Вывести только те слова сообщения, которые содержат не более n букв.
// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
// в) Найти самое длинное слово сообщения.
// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
// д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается
//      массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
//      Здесь требуется использовать класс Dictionary.

//Если разрабатывается статический класс - в нём НЕЛЬЗЯ использовать StringBuilder

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5
{
    partial class Program
    {
        static class Message
        {
            static string[] GetWords(string message)
            {
                char[] div = {' ',',','.'};
                return message.Split(div, StringSplitOptions.RemoveEmptyEntries);
            }

            static string ClearString(string str)
            {
                str = str.Trim();
                str = str.Replace("  ", " ");
                return str;
            }

            //Вывод только тех слов сообщения, которые содержат не более n букв.
            public static string WordsLess(string message, int length)
            {
                string str = string.Empty;
                string[] words = GetWords(message);
                for (int i=0; i < words.Length; i++)
                {
                    if (words[i].Length < length)
                    {
                        str += words[i];
                        str += " ";
                    }
                }
                str = str.Remove(str.Length - 1);
                return str;
            }

            //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            public static string DeleteWordsWithEnd(string message, char symbol)
            {
                string[] words = GetWords(message);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i][words[i].Length-1] == symbol)
                    {
                        message = message.Replace(words[i],string.Empty);
                    }
                }
                message = ClearString(message);
                return message;
            }

            //Поиск самого длинного слова сообщения.
            public static string LongestWord(string message)
            {
                int max = 0;
                string longestWord = string.Empty;
                string[] words = GetWords(message);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > max)
                    {
                        longestWord = words[i];
                        max = words[i].Length;
                    }
                }
                return longestWord;
            }

            static int LongestWordLength(string message)
            {
                int max = 0;
                string[] words = GetWords(message);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > max)
                    {
                        max = words[i].Length;
                    }
                }
                return max;
            }
            //Формирование строки с помощью StringBuilder из самых длинных слов сообщения.
            public static string LongestWords(string message)
            {
                StringBuilder a = new StringBuilder();
                int longestWordLength = LongestWordLength(message);
                string[] words = GetWords(message);
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length == longestWordLength)
                    {
                        a.Append(words[i] + " ");
                    }
                }
                if (a.Length > 0)
                {
                    a.Remove(a.Length - 1, 1);
                }
                return a.ToString();

            }
            //метод, который производит частотный анализ текста
            public static Dictionary<string, int> GetWordsCount(string[] words, string text)
            {
                Dictionary<string, int> counter = new Dictionary<string, int>();
                for (int i = 0; i < words.Length; i++)
                {
                    counter.Add(words[i], 0);
                }
                string[] textWords = GetWords(text);
                for (int i = 0; i < textWords.Length; i++)
                {
                    if (counter.ContainsKey(textWords[i]))
                    {
                        counter[textWords[i]]++;
                    }
                }
                return counter;
            }
        }
        static void Task2()
        {
            Console.Clear();
            //Потестируем класс на классическом тексте
            const int lessLettersNumber = 5;
            const char forgottenSymbol = 'm';
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc facilisis pretium suscipit. Aliquam lacus justo, ornare quis tincidunt in, accumsan quis libero. Nulla at aliquam metus, bibendum sagittis lacus. Nunc eget est a lacus molestie pellentesque ut vitae libero. Duis scelerisque mauris ut turpis varius, sed fringilla urna dictum. Curabitur ut rhoncus ipsum. Pellentesque vitae pharetra diam. Mauris felis ex, pulvinar vestibulum nunc ac, sodales ullamcorper magna. Aenean posuere eget orci congue pellentesque. Ut a nisi ut ex condimentum imperdiet sit amet egestas erat. Mauris ornare libero ac risus blandit, sit amet sagittis arcu dignissim. Nulla elementum sem nunc, non condimentum nisl ultrices commodo.";
            string[] a = { "dolor", "est", "vitae", "amet", "ut" };

            Console.WriteLine("Произведём действия над текстом:");
            Console.WriteLine(message);
            Pause();
            Console.WriteLine();
            Console.WriteLine("Слова короче {0} букв: \n{1}", lessLettersNumber, Message.WordsLess(message,lessLettersNumber));
            Pause();
            Console.WriteLine();
            Console.WriteLine("Уберём из сообщения все слова, заканчивающиеся на {0}:\n{1}", forgottenSymbol, Message.DeleteWordsWithEnd(message, forgottenSymbol));
            Pause();
            Console.WriteLine();
            //Поиск самого длинного слова сообщения.
            Console.WriteLine("Самое длинное слово в тексте: {0}", Message.LongestWord(message));
            //Формирование строки с помощью StringBuilder из самых длинных слов сообщения.
            Console.WriteLine("Все самые длинные слова в тексте: {0}", Message.LongestWords(message));
            Pause();
            Console.WriteLine();
            //Частотный анализ текста
            Console.WriteLine("В данном тексте присутствую следующие слова в количестве:");
            Dictionary<string, int> d = Message.GetWordsCount(a, message);
            foreach(KeyValuePair<string,int> kvp in d)
            {
                Console.WriteLine("Слово \"{0}\" встречается {1} раз.",kvp.Key,kvp.Value);
            }
            Pause();
            Menu();
        }
    }
}
