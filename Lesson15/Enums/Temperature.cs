namespace Lesson15.Enums
{
    public enum Temperature
    {
        Freezing = 0,
        Cold = 10,
        Warm = 20,
        Hot = 35
    }

    static class TempHelper
    {
        public static void Run ()
        {
            Temperature currentTemp = Temperature.Warm;

            Console.WriteLine("Current temperature is: " + currentTemp);
            Console.WriteLine("Numeric value of current temperature: " + (double)currentTemp);
        }
    }
}
