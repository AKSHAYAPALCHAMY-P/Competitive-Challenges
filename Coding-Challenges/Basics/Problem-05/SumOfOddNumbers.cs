namespace SumOfNumbers
{
    public static class SumOfOddNumbers
    {
        public static void Solution()
        {
            int nTotal = 0;

            for(int i = 1; i <= 10; i++) 
            {
                nTotal += i; 
            }

            Console.WriteLine(nTotal);
        }
    }
}