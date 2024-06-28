namespace CelciusToFarenheit
{
    public static class FarenheitConversion
    {
        public static void Solution()
        {
            Console.WriteLine("Enter the Celcius value:");
            double dCelcius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{(9/5) * dCelcius + 32}");
        }
    }
}