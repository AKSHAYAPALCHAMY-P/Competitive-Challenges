namespace ArrayReverse
{
    public class RevreseAnArray
    {
        public static void Solution()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };

            int[] nArray2 = new int[nArray1.Length];

            for(int i = nArray1.Length - 1,j = 0; i >= 0; i--,j++)
            {
                nArray2[j] = nArray1[i];
                
            }

            for(int j=0; j < nArray2.Length; j++)
            {
                Console.WriteLine(nArray2[j]);
            }
        }
    }
}