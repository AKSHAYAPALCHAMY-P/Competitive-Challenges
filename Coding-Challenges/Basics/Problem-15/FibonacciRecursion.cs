namespace FibonacciSeriesWithRecursion
{
    public class FibonacciRecursion
    {
        public static void Solution()
        { 
            int nNumber = 100;

            for(int i = 0; i < nNumber; i++)
            {
                Console.WriteLine(FibonacciNumbers(i) + "");
            }
        }

        public static int FibonacciNumbers(int n)
        {
            if(n <= 1)
            {
                return n;
            }

            else
            {
                return FibonacciNumbers(n - 1) + FibonacciNumbers(n - 2);
            }
        }
    }
}
    