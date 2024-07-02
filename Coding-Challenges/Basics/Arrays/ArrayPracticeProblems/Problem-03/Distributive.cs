namespace MatrixAlgebra
{
    public class Distributive
    {
        public static void Solution()
        {
            int[,] nArray1 = { { 1, 2 }, { 3, 4 } };
            int[,] nArray2 = { { 5, 6 }, { 7, 8 } };
            int[,] nArray3 = { { 9, 10 }, {11,12 } };

            //Distributive Law
            Console.WriteLine("Distributive Law:");
            int[,] nAddition = Add(nArray2,nArray3 );
            int[,] nMultiplication = MultiplyValues(nArray1, nAddition);
            int[,] nPrint = Add(MultiplyValues(nArray1, nArray2), MultiplyValues(nArray1, nArray3));


            Console.WriteLine("Left Side(A(B+C))");
            PrintArray(nMultiplication);

            Console.WriteLine("Right side(AB+AC)");
            PrintArray(nPrint);


        }


        static int[,] Add(int[,] nA, int[,] nB)
        {
            int[,] nResult = new int[2,2];

            for(int i = 0; i < nA.GetLength(0); i++)
            {
                for(int j = 0; j < nB.GetLength(1); j++)
                {
                    nResult[i,j] = nA[i, j] + nB[i, j];
                }
            }
            return nResult;

        }


        static int[,] MultiplyValues(int[,] nResult, int[,] nC)
        {
            int[,] nFinal = new int[2,2];

            for(int i = 0;i < nFinal.GetLength(0); i++)
            {
                for (int j = 0;j < nFinal.GetLength(1); j++)
                {
                    nFinal[i, j] = 0;

                    for(int k = 0;k < nFinal.GetLength(0); k++)
                    {
                        nFinal[i, j] += nResult[i,k] * nC[k,j];
                    }
                }
            }

            return nFinal;
        }

        static int[,] PrintArray(int[,] nMatrix) 
        {
            for(int i = 0; i < nMatrix.GetLength(0); i++)
            {
                for(int j=0;j < nMatrix.GetLength(1); j++)
                {
                    Console.WriteLine(nMatrix[i,j]);
                }
            }

            return nMatrix;
        }

    }
}