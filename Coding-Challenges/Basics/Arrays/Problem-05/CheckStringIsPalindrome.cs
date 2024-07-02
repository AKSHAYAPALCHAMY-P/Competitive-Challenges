namespace PalindromeCheck
{
    public class CheckStringIsPalindrome
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the String:");
            string? strInput = Console.ReadLine();

            string strReverse = string.Empty;

            for(int i = strInput.Length -1; i >= 0 ; i--)
            {
                strReverse += strInput[i];
            }

            if(strReverse == strInput)
            {
                Console.WriteLine("Given String is Palindrome");
            }

            else
            {
                Console.WriteLine("Given String is not a palindrome");
            }
        }
    }
}