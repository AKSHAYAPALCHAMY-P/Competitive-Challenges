namespace LargestElement
{
    public class ArrayLargestElement
    {
        public static void Solution()
        {
            int[] nArray = { 1, 2, 3, 4, 5 };

            int nMax = 0;

            for(int i = 0; i < nArray.Length; i++)
            {
                if(nArray[i] > nMax)
                {
                    nMax= nArray[i];
                }
            }

            Console.WriteLine(nMax);

        }
    }
}