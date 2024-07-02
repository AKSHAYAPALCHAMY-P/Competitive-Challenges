namespace PrimeNumber
{
    public static class CheckPrimeNumber
    {
        public static void Solution()
        {
            Console.WriteLine("Enter The Number:");
            bool nNumber = int.TryParse(Console.ReadLine(), out int n);

            if(n % 10 == 0)
            {
                Console.WriteLine("It's a prime Number");
            }
            else
            {
                Console.WriteLine("It's not a Prime");
            }
    }
    }
}