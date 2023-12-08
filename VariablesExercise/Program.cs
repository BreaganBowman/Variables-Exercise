namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Breagan";
            int age = 27;
            char middleinitial = 'B';
            bool IsOver18 = true;
            double currentTemp = 55.5;
            decimal currentPrice = 29.99m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleinitial}");
            Console.WriteLine($"Is Over 18: {IsOver18}");
            Console.WriteLine($"Current Temp: {currentTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");
        }
}
