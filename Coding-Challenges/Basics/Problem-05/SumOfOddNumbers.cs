namespace SumOfNumbers
{
    public static class SumOfOddNumbers
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Value:");
            int nTotal = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= 10; i++) 
            //{
            //    nTotal += i; 
            //}

            int nResult = nTotal*(nTotal + 1) / 2;

            Console.WriteLine(nResult);
        }
    }
}