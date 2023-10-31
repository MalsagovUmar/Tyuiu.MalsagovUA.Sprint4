using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalsagovUA.Sprint4.Task2.V30.Lib
{
    public class DataService : ISprint4Task2V30
    {
        public int Calculate(int[] array)
        {
            int res = 1;
            foreach (int number in array)
            {
                if (number % 2 == 1)
                {
                    res *= number;
                }
            }
            return res;
        }
    }
}
