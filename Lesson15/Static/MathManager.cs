namespace Lesson15.Static
{
    public static class MathManager
    {
        private static int _usageCount = 0;
        private static readonly DateTime _createdAt = DateTime.Now;

        public static int UsageCount
        {
            get { return _usageCount; }
        }

        public static DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        static MathManager ()
        {
            Console.WriteLine("MathHelper инициализирован.");
        }

        public static int Square (int x)
        {
            _usageCount++;
            return x * x;
        }

        public static bool IsEven (int x)
        {
            return x % 2 == 0;
        }
    }

    class MathHelper
    {
        public void Run ()
        {
            MathManager.Square(1);
            Console.WriteLine(MathManager.UsageCount);
        }

    }
}
