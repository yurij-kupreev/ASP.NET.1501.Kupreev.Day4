using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SortMatrixWithModes
    {
        public static void SortMatrixMode(int[][] matrix, ISortModes sortmodes, bool increase)
        {
            BubbleSort(matrix, sortmodes.TakeArray(matrix), increase);
        }
        private static void BubbleSort(int[][] matrix, int[] array, bool increase)
        {
            int buffer;
            int[] matrixBuffer;
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if ((array[i] > array[j] && increase) || (array[i] < array[j] && !increase))
                    {
                        buffer = array[i];
                        array[i] = array[j];
                        array[j] = buffer;
                        matrixBuffer = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = matrixBuffer;
                    }
                }
            }
        }
    }      
}
