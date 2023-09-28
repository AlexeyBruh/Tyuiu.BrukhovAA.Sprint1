using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint1.Task6.V1.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task6.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класс String                                  *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #1                                                             *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем       *");
            Console.WriteLine("* символа                                                                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string x;

            Console.WriteLine("Введите символ и нажмите <ENTER>");
            Console.WriteLine("Для завершения нажмите точку");
            x = Console.ReadLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Символ: " + x + " Код: " + ds.SymbolCode(x));
            {
                ConsoleKeyInfo cons = Console.ReadKey();
                while (cons.Key != ConsoleKey.Escape)
                {
                    cons = Console.ReadKey();
                }
            }
        }
    }
}
