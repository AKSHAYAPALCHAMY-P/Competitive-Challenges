namespace MergeArray
{
    public class MergetwoArrays
    {
        public static void Solution()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            int[] nArray2 = { 6, 7, 8, 9, 10 };

            int[] nArray3 = new int[nArray1.Length + nArray2.Length];

            for(int i = 0; i < nArray1.Length; i++)
            {
                nArray3[i] = nArray1[i];
            }

            for(int i=0; i < nArray2.Length; i++)
            {
                nArray3[nArray1.Length + i] =nArray2[i];
            }

            Console.WriteLine(string.Join(",", nArray3));
        }
    }
}