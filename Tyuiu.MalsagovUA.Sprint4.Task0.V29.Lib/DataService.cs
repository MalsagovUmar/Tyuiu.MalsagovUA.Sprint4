using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalsagovUA.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            int res = 0;
            foreach (int numbers in array)
            {
                if (numbers % 2 == 1)
                {
                    res += numbers;
                }
            }
            return res;
        }
    }
}
