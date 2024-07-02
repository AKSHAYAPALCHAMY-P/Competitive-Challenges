namespace InverseMatrix
{
    public static class InverseSolution
    {
        public static void Solution()
        {
            int[,] nInput = { { 4, 7 }, { 2, 6 } };

            int[,] nInverseOutput = Inverse(nInput);

            
            int[,] dMultiplyLeft = Multiply(nInput,nInverseOutput);
            int[,] dMultiplyRight = Multiply(nInverseOutput,nInput);


            Console.WriteLine("left-hand side:");
            PrintArray(dMultiplyLeft);

            Console.WriteLine("Right-Hand side");
            PrintArray(dMultiplyRight);
        }

        static int[,] Inverse(int[,] nMatrix)
        {
            int[,] nResult = new int[2, 2];

            int nA = nMatrix[0, 0];
            int nB = nMatrix[0, 1];
            int nC = nMatrix[1, 0];
            int nD = nMatrix[1, 1];

            int dDeterminant = nA * nD - nB * nC;


            int dInversion = 1 / dDeterminant;

            nResult[0, 0] = nD * dInversion;
            nResult[0, 1] = -nB * dInversion;
            nResult[1, 0] = -nC * dInversion;
            nResult[1, 1] = nA * dInversion;

            return nResult;
        }

        static int[,] Multiply(int[,] nMatrix1, int[,] nMatrix2)
        {
            int[,] nOutput = new int[2, 2];

            for(int i = 0; i < nMatrix1.GetLength(0); i++)
            {
                for(int j = 0; j < nMatrix2.GetLength(1); j++)
                {
                    nOutput[i, j] = 0;

                    for(int k = 0; k < nMatrix1.GetLength(0); k++)
                    {
                        nOutput[i, j] += nMatrix1[i, k] * nMatrix2[k, j];
                    }
                }
            }

            return nOutput;
        }

        static void PrintArray(int[,] nMatrix)
        {
            for(int i = 0; i < nMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < nMatrix.GetLength(1); j++)
                {
                    Console.Write(nMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
