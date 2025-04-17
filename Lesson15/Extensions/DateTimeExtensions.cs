namespace Lesson15.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge (this DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }

    class DateTimeHelper
    {
        public void Run ()
        {
            DateTime birthDate = new DateTime(1990, 7, 20);
            int age = birthDate.CalculateAge();

            Console.WriteLine($"Age: {age} years old.");
        }
    }
}
