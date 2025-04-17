namespace Lesson15.Extensions
{
    public static class StringExtensions
    {
        public static bool IsPalindrome (this string str)
        {
            if (string.IsNullOrEmpty(str)) return false;

            var reversed = new string(str.Reverse().ToArray());

            return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
        }
    }

    class StringExtHelper
    {
        public void Run ()
        {
            string word = "Madam";
            bool isPalindrome = word.IsPalindrome();

            Console.WriteLine($"Is '{word}' a palindrome? {isPalindrome}");
        }
    }
}
