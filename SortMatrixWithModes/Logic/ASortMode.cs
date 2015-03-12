using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ASortMode : ISortModes
    {
        public int[] TakeArray(int[][] matrix)
        {
            int[] array = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = 0; j < matrix[i].Length; ++j)
                {
                    array[i] += matrix[i][j];
                }
            }
            return array;
        }
    }
}
