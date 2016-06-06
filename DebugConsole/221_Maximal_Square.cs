using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Given a 2D binary matrix filled with 0's and 1's, find the largest square containing all 1's and return its area.

//For example, given the following matrix:

//1 0 1 0 0
//1 0 1 1 1
//1 1 1 1 1
//1 0 0 1 0
//Return 4.

namespace DebugConsole
{
    public class _221_Maximal_Square
    {
        public int MaximalSquare(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int maxSquareLength = Math.Min(rows, columns);

            char[] flatMatrix = new char[matrix.Length];

            for (int i = 0; i < flatMatrix.Length; i++)
            {
                flatMatrix[i] = matrix[i / columns, i % columns];
            }

            int countOfOne = flatMatrix.Count(item => item == '1');

            if (countOfOne == 0)
            {
                return 0;
            }

            if (countOfOne > 0 && countOfOne < 4)
            {
                return 1;
            }

            if (countOfOne == flatMatrix.Length)
            {
                return maxSquareLength * maxSquareLength;
            }

            if (maxSquareLength == 1)
            {
                return countOfOne > 0 ? 1 : 0;
            }

            int maxArea = 0;

            for (int i = 1; i <= maxSquareLength; i++)
            {
                int area = GetSquareArea(matrix, i);

                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }

        private int GetSquareArea(char[,] matrix, int length)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i <= rows - length; i++)
            {
                for (int j = 0; j <= columns - length; j++)
                {
                    if (CalcArea(matrix, length, i, j) == length * length)
                    {
                        return length * length;
                    }
                }
            }

            return 0;
        }

        private int CalcArea(char[,] matrix, int length, int startRow, int startColumn)
        {
            for (int i = startRow; i < length + startRow; i++)
            {
                for (int j = startColumn; j < length + startColumn; j++)
                {
                    if (matrix[i, j] == '0')
                    {
                        return 0;
                    }
                }
            }

            return length * length;
        }
    }
}
