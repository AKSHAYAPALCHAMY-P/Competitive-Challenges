namespace FibonacciNumbers
{
    public static class FibonacciSequence
    {
        public static void Solution()
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int nNumber = 10;

            for (int i = 2; i <=nNumber; ++i)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.WriteLine(n3);
            }

           
        }
    }
}