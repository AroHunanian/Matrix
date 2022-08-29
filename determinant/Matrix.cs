using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{



    struct Matrix
    {
        public static int FindFirstOrderDeterminant(int[,] matrix)
        {
            return matrix[0, 0];
        }
        public static int FindSecondOrderDeterminant(int[,] matrix)
        {
            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]); ;
        }
        public static int FindThirdOrderDeterminant(int[,] matrix)
        {
            int determinant = 0;
            int row = 0;
            while (row <= 2)
            {
                int[,] newMatrix = new int[2, 2];
                switch (row)
                {
                    case 0:
                        {
                            newMatrix[0, 0] = matrix[1, 1];
                            newMatrix[0, 1] = matrix[1, 2];
                            newMatrix[1, 0] = matrix[2, 1];
                            newMatrix[1, 1] = matrix[2, 2];
                            determinant += matrix[0, 0] * FindSecondOrderDeterminant(newMatrix);
                            row++;
                            break;
}
                    case 1:
                        {
                            newMatrix[0, 0] = matrix[1, 0];
                            newMatrix[0, 1] = matrix[1, 2];
                            newMatrix[1, 0] = matrix[2, 0];
                            newMatrix[1, 1] = matrix[2, 2];
                            determinant += -(1 * matrix[0, 1]) * FindSecondOrderDeterminant(newMatrix);
                            row++;
                            break;
}
                    case 2:
                        {
                            newMatrix[0, 0] = matrix[1, 0];
                            newMatrix[0, 1] = matrix[1, 1];
                            newMatrix[1, 0] = matrix[2, 0];
                            newMatrix[1, 1] = matrix[2, 1];
                            determinant += matrix[0, 2] * FindSecondOrderDeterminant(newMatrix);
                            row++;
                            break;
                        }
                }
            }
            return determinant;
        }
        public static int FindFourthOrderDeterminant(int[,] matrix)
        {
            int determinant = 0;
            int row = 0;
            while (row <= 3)
            {


                int[,] newMatrix = new int[3, 3];
                switch (row)
                {
                    case 0:
                        {
                            newMatrix[0, 0] = matrix[1, 1];
                            newMatrix[0, 1] = matrix[1, 2];
                            newMatrix[0, 2] = matrix[1, 3];

                            newMatrix[1, 0] = matrix[2, 1];
                            newMatrix[1, 1] = matrix[2, 2];
                            newMatrix[1, 2] = matrix[2, 3];

                            newMatrix[2, 0] = matrix[3, 1];
                            newMatrix[2, 1] = matrix[3, 2];
                            newMatrix[2, 2] = matrix[3, 3];

                            determinant += matrix[0, 0] * FindThirdOrderDeterminant(newMatrix);
                            row++;
                            break;

                        }
                    case 1:
                        {
                            newMatrix[0, 0] = matrix[1, 0];
                            newMatrix[0, 1] = matrix[1, 2];
                            newMatrix[0, 2] = matrix[1, 3];

                            newMatrix[1, 0] = matrix[2, 0];
                            newMatrix[1, 1] = matrix[2, 2];
                            newMatrix[1, 2] = matrix[2, 3];

                            newMatrix[2, 0] = matrix[3, 0];
                            newMatrix[2, 1] = matrix[3, 2];
                            newMatrix[2, 2] = matrix[3, 3];
                            determinant += -(1 * matrix[0, 1]) * FindThirdOrderDeterminant(newMatrix);
                            row++;
                            break;

                        }
                    case 2:
                        {

                            newMatrix[0, 0] = matrix[1, 0];
                            newMatrix[0, 1] = matrix[1, 1];
                            newMatrix[0, 2] = matrix[1, 3];

                            newMatrix[1, 0] = matrix[2, 0];
                            newMatrix[1, 1] = matrix[2, 1];
                            newMatrix[1, 2] = matrix[2, 3];

                            newMatrix[2, 0] = matrix[3, 0];
                            newMatrix[2, 1] = matrix[3, 1];
                            newMatrix[2, 2] = matrix[3, 3];
                            determinant += matrix[0, 2] * FindThirdOrderDeterminant(newMatrix);
                            row++;
                            break;

                        }
                    case 3:
                        {
                            newMatrix[0, 0] = matrix[1, 0];
                            newMatrix[0, 1] = matrix[1, 1];
                            newMatrix[0, 2] = matrix[1, 2];

                            newMatrix[1, 0] = matrix[2, 0];
                            newMatrix[1, 1] = matrix[2, 1];
                            newMatrix[1, 2] = matrix[2, 2];

                            newMatrix[2, 0] = matrix[3, 0];
                            newMatrix[2, 1] = matrix[3, 1];
                            newMatrix[2, 2] = matrix[3, 2];
                            determinant += (-1 * matrix[0, 3]) * FindThirdOrderDeterminant(newMatrix);
                            row++;
                            break;


                        }

                }

            }
            return determinant;
        }
        public static void FindDeterminant(int[,] matrix, byte length)
        {
            switch (length)
            {
                case 1:
                    Console.WriteLine(FindFirstOrderDeterminant(matrix));
                    break;
                case 2:
                    Console.WriteLine(FindSecondOrderDeterminant(matrix));

                    break;
                case 3:
                    Console.WriteLine(FindThirdOrderDeterminant(matrix));

                    break;
                case 4:
                    Console.WriteLine(FindFourthOrderDeterminant(matrix));
                    FindFourthOrderDeterminant(matrix);
                    break;
            }
        }
        public static int[,] EnterMatrix(int[,] matrix, byte length)
        {
            for (int i = 0; i < length; i++)
            {

                for (int j = 0; j < length; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

            }
            return matrix;
        }
        public static void PrintMatrix(int[,] matrix, byte length)
        {
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
