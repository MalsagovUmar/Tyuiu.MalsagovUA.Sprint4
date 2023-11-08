using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.MalsagovUA.Sprint4.Task4.V26.Lib
{
    public class DataService : ISprint4Task4V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[,] array = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        array[i, j] = 0;
                    }
                    else
                    {
                        array[i, j] = matrix[i, j];
                    }
                }
            }
            return array;
        }
    }
}
