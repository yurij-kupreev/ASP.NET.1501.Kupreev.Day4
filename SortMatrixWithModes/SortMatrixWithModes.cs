using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class SortMatrixWithModes
    {
        public static void SortMatrixMode(this int[][] matrix, IComparer sortmodes)
        {
            if (matrix == null) throw new ArgumentException();
            BubbleSort(matrix, sortmodes);  
        }
        private static void BubbleSort(int[][] matrix, IComparer sortmodes)
        {
            int [] matrixBuffer;
            for (int i = 0; i < matrix.Length; ++i)
            {
                for (int j = i + 1; j < matrix.Length; ++j)
                {
                    if (sortmodes.Compare(matrix[i], matrix[j]) > 0)
                    {
                        matrixBuffer = matrix[i];
                        matrix[i] = matrix[j];
                        matrix[j] = matrixBuffer;
                    }
                }
            }
        }
    }      
}
