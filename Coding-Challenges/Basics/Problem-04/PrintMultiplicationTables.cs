namespace PrintTablesContext
{
    public static class PrintMultiplicationTables
    {
        public static void Solution()
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{j} x {i} = {j * i}");
                }

                
            }
        }
    }
}