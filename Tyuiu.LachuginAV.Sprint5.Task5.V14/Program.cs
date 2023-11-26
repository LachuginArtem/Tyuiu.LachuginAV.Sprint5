using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.LachuginAV.Sprint5.Task5.V14.Lib;
namespace Tyuiu.LachuginAV.Sprint5.Task5.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Лачугин А.В. | АСОиУБ 23-3";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла.                                     *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #14                                                                  *");
            Console.WriteLine("* Выполнил  Лачугин Артем Викторович |  АСОиУБ 23-3                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая находит факториал наибольшего числа в файле,     *");
            Console.WriteLine("* кратного 3.                                                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask5V14.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}