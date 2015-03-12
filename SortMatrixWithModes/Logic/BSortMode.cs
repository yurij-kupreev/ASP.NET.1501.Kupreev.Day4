using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BSortMode : ISortModes
    {
        public int[] TakeArray(int[][] matrix)
        {
            int[] array = new int[matrix.Length];
            int min;
            for (int i = 0; i < matrix.Length; ++i)
            {
                min = matrix[i][0];
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    if (matrix[i][j] < min) min = matrix[i][j];
                }
                array[i] = min;
            }
            return array;
        }
    }
}
