namespace PositiveNumberssOfAnArray
{
    public static class FindAPositivesOfAnArray
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the array size:");
            int nSize = int.Parse(Console.ReadLine());

            int[] nArray = new int[nSize];

            Console.WriteLine("Enter the array Elements:");

            for (int i = 0; i < nSize; i++) 
            {
                 nArray[i] = int.Parse(Console.ReadLine()); 
            }

            for(int i = 0; i <nSize; i++) 
            {
                if(nArray[i]> 0)
                {
                    Console.WriteLine(nArray[i]);
                }
            }
        }
    }
}