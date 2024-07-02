namespace SumOFOddAndEven
{
    public class SumOfOddAndEvenInAnArray
    {
        public static void Solution()
        {
            int[] nInputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10};

            int nOdd = 0;
            int nEven = 0;

            for(int i = 0; i < nInputArray.Length; i++)
            {
                if(nInputArray[i] % 2 == 0)
                {
                    nEven += i;
                }

                else
                {
                    nOdd += i;
                }
            }

            Console.WriteLine(nOdd);
            Console.WriteLine(nEven);

        }
    }
}