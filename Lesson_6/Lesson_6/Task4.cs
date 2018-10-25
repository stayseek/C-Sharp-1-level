//4. ** Считайте файл различными способами.Смотрите “Пример записи файла различными способами”. 
//Создайте методы, которые возвращают массив byte (FileStream, BufferedStream), строку для StreamReader и массив int для BinaryReader.
//!!! Изменён метод записи для StreamWriter, иначе файл пустой!!!
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Lesson_6
{
    partial class Program
    {
        static long FileStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < size; i++)
            {
                fs.WriteByte(0);
            }
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        //Чтение из FileStream
        static byte[] ReadFileStream(string fileName, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            for (int i = 0; i < fs.Length; i++)
            {
                data[i] = (byte)fs.ReadByte();
            }
            fs.Close();
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return data;
        }

        static long BinaryStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < size; i++)
                bw.Write((byte)0);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }
        //Чтение с использованием BinaryReader
        static int[] ReadBinaryStream(string fileName, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int[] data = new int[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            for (int i = 0; i < fs.Length; i++)
            {
                data[i] = br.Read();
            }
            fs.Close();
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return data;
        }

        static long StreamWriterSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 0; i < size; i++)
            {
                sw.Write(0);
            }
            sw.WriteLine();//Добавлено, в противном случае файл пустой!!!
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static string StreamReaderSample(string fileName, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string data = string.Empty;
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                data += sr.ReadLine();
            }
            fs.Close();
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return data;
        }

        static long BufferedStreamSample(string filename, long size)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            int countPart = 4;//количество частей
            int bufsize = (int)(size / countPart);
            byte[] buffer = new byte[size];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            //bs.Write(buffer, 0, (int)size);//Error!
            for (int i = 0; i < countPart; i++)
                bs.Write(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            return stopwatch.ElapsedMilliseconds;
        }

        static byte[] BufferedReadSample(string fileName, out long time)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            int countPart = 4;//количество частей
            int bufsize = (int)(fs.Length / countPart);
            byte[] buffer = new byte[fs.Length];
            BufferedStream bs = new BufferedStream(fs, bufsize);
            for (int i = 0; i < countPart; i++)
                bs.Read(buffer, 0, (int)bufsize);
            fs.Close();
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
            return buffer;
        }

        static void Task4()
        {
            Console.Clear();

            long kbyte = 1024;
            long mbyte = 1024 * kbyte;//1048576
            long gbyte = 1024 * mbyte;//1073741824
            long size = mbyte;
            long time;
            Console.WriteLine("Размер файла {0} Байт",size);
            Console.WriteLine("Запись в файлы:");
            Console.WriteLine("FileStream. Milliseconds:{0}", FileStreamSample("C:\\test\\bigdata0.bin", size));
            Console.WriteLine("BinaryStream. Milliseconds:{0}", BinaryStreamSample("C:\\test\\bigdata1.bin", size));
            Console.WriteLine("StreamWriter. Milliseconds:{0}", StreamWriterSample("C:\\test\\bigdata2.bin", size));
            Console.WriteLine("BufferedStream. Milliseconds:{0}", BufferedStreamSample("C:\\test\\bigdata3.bin", size));
            Pause();
            Console.WriteLine("Чтение из файла:");
            byte[] file = ReadFileStream("C:\\test\\bigdata0.bin", out time);
            Console.WriteLine("FileStream. Milliseconds:{0}", time);
            int[] binary = ReadBinaryStream("C:\\test\\bigdata1.bin", out time);
            Console.WriteLine("BinaryStream. Milliseconds:{0}", time);
            string stream = StreamReaderSample("C:\\test\\bigdata2.bin", out time);
            Console.WriteLine("StreamReader. Milliseconds:{0}", time);
            byte[] buffer = BufferedReadSample("C:\\test\\bigdata3.bin", out time);
            Console.WriteLine("BufferedStream. Milliseconds:{0}", time);
            Pause();
            Menu();
        }
    }
}
