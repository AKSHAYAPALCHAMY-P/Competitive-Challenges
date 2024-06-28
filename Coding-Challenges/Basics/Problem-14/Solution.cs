namespace FibonacciNumbers
{
    public static class FibonacciSequence
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Array Size:");
            bool nSize = int.TryParse(Console.ReadLine(), out int n);

            int[] nArray = new int[n];
            for(int i = 0; i < nArray.Length; i++)
            {
                nArray[i] = int.Parse(Console.ReadLine());
            }

            int[] nArray2 = new int[n];

            for(int i = 0; i < nArray.Length; i++)
            {
                int nFirst = 0;


            }


        }
    }
}