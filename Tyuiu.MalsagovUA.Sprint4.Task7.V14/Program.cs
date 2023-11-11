using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MalsagovUA.Sprint4.Task7.V14.Lib;
namespace Tyuiu.MalsagovUA.Sprint4.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Мальсагов У.А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Обработка структурных типов                                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр \"458712659137\". Преобразуйте ее в     *");
            Console.WriteLine("* матрицу 3 на 4 и подсчитайте сумму нечетных чисел.                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3, columns = 4;
            int[,] mtrx = new int[rows, columns];

            string value = "458712659137";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }

            Console.Write("Массив:{ ");
            for (int i = 0; i < mtrx.GetUpperBound(0) + 1; i++)
            {
                if (i != 0) { Console.Write("\t "); }
                Console.Write("{");
                for (int j = 0; j < mtrx.Length / (mtrx.GetUpperBound(0) + 1); j++)
                {
                    Console.Write(mtrx[i, j]);
                    if (j != mtrx.GetLength(1) - 1) { Console.Write(", "); }
                }
                Console.Write("}");
                if (i != mtrx.GetLength(0) - 1) { Console.WriteLine(","); }
            }
            Console.WriteLine("}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = dataService.Calculate(rows, columns, value);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
