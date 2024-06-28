namespace MultiplicationTable
{
    public static class Printingtable
    {
        public static void Solution()
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i} x 7 = {i * 7}");
            }
        }
    }
}