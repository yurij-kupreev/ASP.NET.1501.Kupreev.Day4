using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Task2Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortMatrixWithModesTestASortMode()
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 1, 1, 10 };
            matrix[1] = new int[] { 3, 3, 3, 3 };
            matrix[2] = new int[] { 2, 2, 2 }; 
            matrix[3] = new int[] { 4, 4, 5 };

            matrix.SortMatrixMode(new ElementsSumIncreasing());

            

            int[][] expectedMatrix = new int[4][];
            expectedMatrix[0] = new int[] { 2, 2, 2 };
            expectedMatrix[1] = new int[] { 3, 3, 3, 3 };
            expectedMatrix[2] = new int[] { 1, 1, 1, 10 };
            expectedMatrix[3] = new int[] { 4, 4, 5 };

           // CollectionAssert.AreEqual(expectedMatrix, matrix);
            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }
        [TestMethod]
        public void SortMatrixWithModesTestCSortMode()
        {
            int[][] matrix = new int[4][];
            matrix[0] = new int[] { 1, 1, 1, 10 };
            matrix[1] = new int[] { 3, 3, 3, 3 };
            matrix[2] = new int[] { 2, 2, 2 };
            matrix[3] = new int[] { 4, 4, 5 };

            matrix.SortMatrixMode(new ElementsMaxIncreasing());

            int[][] expectedMatrix = new int[4][];
            expectedMatrix[0] = new int[] { 2, 2, 2 };
            expectedMatrix[1] = new int[] { 3, 3, 3, 3 };
            expectedMatrix[2] = new int[] { 4, 4, 5 };
            expectedMatrix[3] = new int[] { 1, 1, 1, 10 };

            Assert.IsTrue(MatrixComparer(matrix, expectedMatrix));
        }
        private bool MatrixComparer(int[][] LeftMatrix, int[][] RightMatrix)
        {
            bool goodTest = true;
            for (int i = 0; i < LeftMatrix.Length; ++i)
            {
                for (int j = 0; j < LeftMatrix[i].Length; ++j)
                {
                    if (LeftMatrix[i][j] != RightMatrix[i][j])
                    {
                        goodTest = false;
                        break;
                    }
                }
            }
            return goodTest;
        }
    }
}
