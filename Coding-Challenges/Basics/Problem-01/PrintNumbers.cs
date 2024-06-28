namespace PrintingNumbers
{
    public static class  PrintNumbers
    {
        public static void Solution()
        {
            for(int i = 1; i <= 10; i++)   //using for Loop.
            {
                Console.WriteLine(i);
            }

            int nI = 1;

            while(true) 
            {
                Console.WriteLine(nI);  //using while loop
                nI++;

                if(nI > 10)
                {
                    break;
                }
            }
        }

     }
}