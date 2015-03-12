using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class CSortMode : ISortModes
    {
        public int[] TakeArray(int[][] matrix)
        {
            int[] array = new int[matrix.Length];
            int max;
            for (int i = 0; i < matrix.Length; ++i)
            {
                max = matrix[i][0];
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    if (matrix[i][j] > max) max = matrix[i][j];
                }
                array[i] = max;
            }
            return array;
        }
    }
}
