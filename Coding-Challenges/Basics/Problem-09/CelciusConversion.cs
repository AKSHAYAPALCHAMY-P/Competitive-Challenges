namespace FarenheitToCelcius
{
    public static class CelciusConversion
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Farenheit Value:");
            double dFarenheit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{(dFarenheit-32) * 5/9}");
        }
    }
}