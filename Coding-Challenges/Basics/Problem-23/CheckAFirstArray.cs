namespace ElementCheckingInFirstArray
{
    public class CheckAFirstArray
    {
        public static void Solution()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            int[] nArray2 = { 6, 7, 8, 9, 10 };

            Console.WriteLine("Enter the number for checking:");
            bool nNumber = int.TryParse(Console.ReadLine(), out int nValue);

            for(int i = 0; i < nArray1.Length; i++)
            {
                if(nValue == nArray1[i])
                {
                    Console.WriteLine($"{nValue} Present in First Array");
                    break;
                }

                else
                {
                    Console.WriteLine("Not Present");
                    break;
                }
               
            }

            
        }

        }
}