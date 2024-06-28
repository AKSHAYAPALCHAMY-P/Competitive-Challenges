namespace PrintoddNumbers
{
    public static class AddOddNumbers
    {
        public static void Solution()
        {

            for(int i = 0; i <= 100; i++) 
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
       
            }
   
        }
    }
}