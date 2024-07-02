namespace ElementsChecking
{
    public class CheckAnElementIntwoArrays
    {
        public static void Solution()
        {
            int[] nArray1 = { 1, 2, 3, 4, 5 };
            int[] nArray2 = { 2, 3, 7, 8, 1 };

            Console.WriteLine("Enter the number for checking;");
            bool nNumber = int.TryParse(Console.ReadLine(), out int nValue);

            for(int i = 0; i < nArray1.Length; i++) 
            {
                if(nValue == nArray1[i])
                {
                    Console.WriteLine($"{nValue} present in an Array1");
                }

                else if(nValue == nArray2[i])
                {
                    Console.WriteLine($"{nValue} present in an Array2");
                }
            }
        }
    } }