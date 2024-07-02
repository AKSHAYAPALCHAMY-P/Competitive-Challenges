namespace PositiveInteger
{
    public static class SumOfPositiveIntegers
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the value:");
            bool bValue = int.TryParse(Console.ReadLine(), out int n);

            int nSum = 0;

            while(n > 0)
            {
                nSum += n % 10;
                n = n / 10;
            }

            Console.WriteLine($"{nSum + n}");
        }
    }
}