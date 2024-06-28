namespace SumofNumbers
{
    public static class SumOfOdd
    {
        public static void Solution()
        {
            int nTotal = 0;

            for(int i = 0; i <= 30; i++) 
            {
                if(i % 2 == 0)
                {
                    nTotal += i;
                }  
            }

            Console.WriteLine(nTotal);
        } 
    }
}