namespace PrimeNumbers
{
    public static class PrintPrimeNumbers
    {
        public static void Solution()
        {
            //int nCount = 0;
            //int nNum = 2;

            for(int i = 2; i <= 100; i++)
            { 
                IsPrime(i);
            }            
        }

        public static void IsPrime(int num)
        {
            
            bool bIsPrime = true;

            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    bIsPrime = false;
                    break;
                }
            }

            if(bIsPrime)
            {
                Console.WriteLine($"Number {num} is Prime");
            }
            else
            {
                Console.WriteLine($"Number {num} is not Prime");
            }
        }
    }
}