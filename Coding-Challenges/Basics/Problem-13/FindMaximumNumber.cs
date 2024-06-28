namespace MaximumNumber
{
    public class FindMaximumNumber
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the array size:");
            int nSize = int.Parse(Console.ReadLine());

            int[] nArray = new int[nSize];

            Console.WriteLine("Enter the array Elements:");

            for(int i = 0; i < nSize; i++)
            {
                nArray[i] = int.Parse(Console.ReadLine());
            }

            int nMax = 0;
            
            for(int i = 0;i < nSize; i++)
            {
                if(nArray[i] > nMax)
                {
                    nMax = nArray[i];
                }
            }

            Console.WriteLine(nMax);
        }
    }
}