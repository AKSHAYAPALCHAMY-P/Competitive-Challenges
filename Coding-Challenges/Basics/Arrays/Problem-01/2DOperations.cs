using System.Reflection.Metadata.Ecma335;

namespace TwoDimensionalArrayOperations
{
    public class MattrixOperations
    {
        public static void Solution()
        {
            int[,] nArray1 = { { 1, 2 }, { 3, 4 } };
            int[,] nArray2 = { { 5, 6 }, { 7, 8 } };


            Console.WriteLine("Matrix Multiplication:");
            int[,] nArray3 = Multiplication(nArray1, nArray2);
            PrintMatrix(nArray3);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Transpose of Matrix1:");
            int[,] nTransposedMatrix1 = TransposeMatrix(nArray1);
            PrintMatrix(nTransposedMatrix1);

            Console.WriteLine("Transpose of Matrix2:");
            int[,] nTransposedMatrix2 = TransposeMatrix(nArray2);
            PrintMatrix(nTransposedMatrix2);


            Console.WriteLine("--------------------------------");

            Console.WriteLine("Sum of the Transposed Matrices:");
            int[,] nSumMatrices = AddMatrices(nArray1, nArray2);
            PrintMatrix(nSumMatrices);

        }

        //Multiplication of Matrices

        static int[,] Multiplication(int[,] matrix1, int[,] matrix2) 
            {

                int[,] result = new int[2,2];
                for(int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for(int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        result[i, j] = 0;

                        for(int k = 0; k < matrix2.GetLength(1); k++)
                        {

                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }                       

                    }
                   
                }

               return result;
            }
           

          //Transpose an Arrays

            static int[,] TransposeMatrix(int[,] matrix)
            {
                int[,] nTransposedMatrix = new int[2, 2];

                for(int i = 0; i< matrix.GetLength(0); i++)
                {
                    for(int j = 0; j< matrix.GetLength(1); j++)
                    {
                        nTransposedMatrix[i,j]= matrix[j, i];
                    }
                }

                return nTransposedMatrix;
            }

            //Summ the transposed Array

            static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
            {
                int[,] SumMatrices = new int[2, 2];

                for(int i = 0;i< matrix1.GetLength(0); i++)
                {
                    for(int j = 0;j< matrix2.GetLength(1); j++)
                    {
                        SumMatrices[i, j] += matrix1[j, i] + matrix2[j, i];
                    }
                }

                return SumMatrices;
            }


            //Print Matrix

            static void PrintMatrix(int[,] matrix) 
            {
                for(int i = 0;i< matrix.GetLength(0); i++)
                {
                    for(int j = 0;j < matrix.GetLength(1); j++)
                    {
                        Console.WriteLine(matrix[i,j] + " ");
                    }

                    Console.WriteLine();
                }
            }


        
    }
}