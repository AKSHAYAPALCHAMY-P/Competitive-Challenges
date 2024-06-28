namespace Factorial
{
    public static class CalculateFactorial
    {
        public static void Solution()
        {
            int nFactorialValue = 1;

            for(int i = 10; i >= 1; i--)
            {
                nFactorialValue *= i;   
            }

            Console.WriteLine(nFactorialValue);
        }
    }
}