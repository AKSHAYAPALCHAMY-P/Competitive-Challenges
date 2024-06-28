namespace SumArray
{
    public static class SumOfAnArray
    {
        public static void Solution()
        {


            int[] nNums = { 1, 2, 3, 4, 5 };

            int nSum = 0;

            for(int i = 0; i < nNums.Length; i++)
            {
                nSum += nNums[i];
            }

            Console.WriteLine(nSum);
        }
    }
}