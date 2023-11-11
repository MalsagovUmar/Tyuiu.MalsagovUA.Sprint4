using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint4.Task6.V6.Lib;
namespace Tyuiu.MalsagovUA.Sprint4.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            Console.Title = "Спринт #4 | Выполнил: Мальсагов У.А. | АСОиУБ-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУБ-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* ['Борис', 'Анна', 'Михаил', 'Ирина', 'Сергей', 'Татьяна', 'Олег'].      *");
            Console.WriteLine("* Используя класс Array, выведите элементы массива,                       *");
            Console.WriteLine("* длина которых равна 5 символам.                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Массив: {");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
                if (i != names.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(names);
            Console.WriteLine($"Элементы массива, длина которых равна 5:");
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i]);
                if (i != res.Length - 1) { Console.Write(", "); }
            }
            Console.ReadKey();
        }
    }
}
