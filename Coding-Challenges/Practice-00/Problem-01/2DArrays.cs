namespace TwoDimensionalArrays
{
    public class PracticeTwoDimensionalArray
    {
        public static void Solution()
        {
            int[,] nArray1 = new int[3, 3];

            /*
             * 0 10 0
               0 0 20
               30 0 0
             * 
             */

            nArray1[0, 1] = 10;    
            nArray1[1, 2] = 20;
            nArray1[2, 0] = 30;

            for(int i = 0; i < 3; i++) 
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(nArray1[i,j] + " ");
                }

                Console.WriteLine();
            }

          

        }

         
    } 
}