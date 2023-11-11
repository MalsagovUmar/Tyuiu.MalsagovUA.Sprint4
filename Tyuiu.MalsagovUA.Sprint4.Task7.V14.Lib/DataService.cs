using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalsagovUA.Sprint4.Task7.V14.Lib
{
    public class DataService : ISprint4Task7V14
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            foreach (char element in value)
            {
                if ((int)Char.GetNumericValue(element) % 2 == 1)
                {
                    res += (int)Char.GetNumericValue(element);
                }
            }
            return res;
        }
    }
}
