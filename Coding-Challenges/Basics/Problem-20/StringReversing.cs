namespace ReverseString
{
    public class StringReversing
    {
        public static void Solution()
        {
            string strInput = "apple";

            string strReversed = "";

            for(int i = strInput.Length - 1; i >= 0; i--)
            {
                strReversed +=strInput[i];
            }

            Console.WriteLine(strReversed);
        }
    }
}