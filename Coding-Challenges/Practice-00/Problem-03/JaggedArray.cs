namespace JaggedArray
{
    public static class PracticeJaggedArray
    {
        public static void Solution()
        {
            int[][] nArray1 = new int[5][];

            nArray1[0] = new int[3];
            nArray1[1] = new int[5];
            nArray1[2] = new int[2];
            nArray1[3] = new int[8];
            nArray1[4] = new int[10];

            nArray1[0] = new int[] {3,5,7};
            nArray1[1] = new int[5] {1,0,2,4,6};
            nArray1[2] = new int[2] {1,6};
            nArray1[3] = new int[8] {1,0,2,4,6,45,67,78};
            nArray1[4] = new int[10] {1,0,2,4,6,34,54,67,87,78};

             
            for(int i = 0; i < nArray1.Length; i++)
            { 
                for(int j = 0; j < nArray1[i].Length; j++)
                {
                    Console.Write(nArray1[i][j]+" ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
       
    }
}