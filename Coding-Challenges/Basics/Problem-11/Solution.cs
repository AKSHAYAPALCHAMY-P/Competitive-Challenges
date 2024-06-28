namespace AverageArray
{
    public static class AverageOfAnArray
    {
        public static void Solution()
        {
            int[] nNums = new[] { 1, 2, 3, 4, 5 };

            int nSum = 0;
            int nCount = 0;

            for(int i = 0; i < nNums.Length; i++) 
            {
                nSum += nNums[i];
                nCount++;
            }

            Console.WriteLine($"{nSum / nCount}");
        }
    }
}