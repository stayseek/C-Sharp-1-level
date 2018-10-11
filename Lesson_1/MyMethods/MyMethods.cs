using System;

namespace Lesson_1
{
    class MyMethods
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
    }
}
