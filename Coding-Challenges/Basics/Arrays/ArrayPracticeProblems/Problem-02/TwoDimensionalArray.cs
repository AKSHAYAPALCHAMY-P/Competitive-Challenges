namespace MultiTwoDimensionalArray
{
    public static class TwoDimensionalArray
    {
        public static void Solution()
        {
            int[,] nArray1 = { { 1, 2}, {3,4}, { 5,6} };

            for(int i = 0; i < nArray1.GetLength(0); i++) 
            {
                for(int j = 0; j < nArray1.GetLength(1); j++)
                {
                    Console.Write(nArray1[i,j]+" ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------------------");

            //Array Transpose

            for(int i = 0; i < nArray1.GetLength(1); i++)
            {
                for(int j = 0; j < nArray1.GetLength(0); j++)
                {
                    Console.Write(nArray1[j,i] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}