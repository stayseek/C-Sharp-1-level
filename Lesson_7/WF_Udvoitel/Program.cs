//Автор: Станислав Митрофанов
//а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.

//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число
//должен получить игрок.Игрок должен получить это число за минимальное количество ходов.

//!!! Количество ходов вынесено на форму, по окончанию игры выводится сообщение, содержащее количество сделаных ходов и минимальное достижимое. 

//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.

//!!! Подсчёт ходов реализован через подсчёт количества элементов в Stack

// Вся логика игры должна быть реализована в классе с удвоителем.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
