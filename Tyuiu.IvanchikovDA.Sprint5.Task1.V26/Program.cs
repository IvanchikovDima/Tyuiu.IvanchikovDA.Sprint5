using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.IvanchikovDA.Sprint5.Task1.V26.Lib;

namespace Tyuiu.IvanchikovDA.Sprint5.Task1.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;
            DataService ds = new DataService();
            Console.Title = "Спринт#5 | Выполнил: Иванчиков Д.А. | ПКТБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись набора данных в текстовый файл                       *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Иванчиков Дмитрий Александрович | ПКТБ-23-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, f(x) на заданном диапазоне [-5; 5] с шагом 1.             *");
            Console.WriteLine("* Произвести проверку деления на ноль.                                    *");
            Console.WriteLine("* При делении на ноль вернуть значение 0 .                                *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Фаил : " + res);
            Console.WriteLine("Создан !");
            Console.ReadKey();
        }
    }
}
