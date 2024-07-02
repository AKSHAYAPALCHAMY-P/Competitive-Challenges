namespace SumOfMultiplies
{
    public class SumOfMultipliedValues
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Value:");
            bool nValue = int.TryParse(Console.ReadLine(), out int n);

            int nSum = 0;


            for(int i = 1; i <= n; i++) 
            {
                if(i % 3 == 0 || i / 5 == 0)
                {
                    nSum += i;
                }
              
            }

            Console.WriteLine(nSum);
           
        }
    }
}