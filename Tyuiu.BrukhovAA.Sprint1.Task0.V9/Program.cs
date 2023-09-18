﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BrukhovAA.Sprint1.Task0.V9.Lib;

namespace Tyuiu.BrukhovAA.Sprint1.Task0.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Брюхов А. А. | АСОиУБ-23-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Брюхов Алексей Андреевич | АСОиУБ-23-1                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (9/3)*4/3/2+1          *");
            Console.WriteLine("* И печатает результат на экране                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* (9/3)*4/3/2+1                                                          *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЗУЛЬТАТ:                                                              *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
