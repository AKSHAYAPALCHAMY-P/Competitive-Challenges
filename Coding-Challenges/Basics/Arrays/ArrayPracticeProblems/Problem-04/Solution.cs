namespace TransposeOfMatrix
{
    public class Associative
    {
        public static void Solution()
        {
            int[,] nArray1 = { { 1, 2 }, { 3, 4 } };
            int[,] nArray2 = { { 5, 6 }, { 7, 8 } };
            int[,] nArray3 = { { 9, 10 }, { 11, 12 } };

            int[,] nAB = Multiply(nArray1, nArray2);
            int[,] nABC = Multiply(nAB, nArray3);

            int[,] nATranspose = Transpose(nArray1);
            int[,] nBTranspose = Transpose(nArray2);
            int[,] nCTranspose = Transpose(nArray3);

            int[,] nCBMultiply = Multiply(nCTranspose, nBTranspose);
            int[,] nCBAMultiply = Multiply(nCBMultiply, nATranspose);

            Console.WriteLine("Left-hand Side:");
            PrintArray(nABC);

            Console.WriteLine("Right-hand side:");
            PrintArray(nCBAMultiply);


        }

        static int[,] Multiply(int[,] nMatrix1, int[,] nMatrix2)
        {
            int[,] nResult= new int[2, 2];

            for(int i=0;i<nMatrix1.GetLength(0);i++) 
            {
                for(int j = 0; j < nMatrix2.GetLength(1); j++)
                {
                    nResult[i, j] = 0;

                    for(int k = 0; k < nMatrix1.GetLength(0); k++)
                    {
                        nResult[i, j] += nMatrix1[i, k] * nMatrix2[k, j];
                    }
                }
            }

            return nResult;
        }

        static int[,] Transpose(int[,] nMatrix)
        {
            int[,] nTransposedMatrix = new int[2,2];

            for(int i = 0; i < nMatrix.GetLength(0); i++) 
            {
                for(int j = 0;j < nMatrix.GetLength(1); j++)
                {
                    nTransposedMatrix[i, j] = nMatrix[j,i];
                }
            }

            return nTransposedMatrix;
        }

        static void PrintArray(int[,] nMatrix)
        {
               for (int i = 0;i < nMatrix.GetLength(0); i++)
               {
                for(int j=0;j < nMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(nMatrix[i,j]);
                }
               }
        }
    }
}