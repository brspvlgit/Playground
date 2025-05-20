using System.Text;

namespace Exam2;

public static class StringTask
{
    public static string NumericToWords(this string str)
    {
        var symbolToWord = new Dictionary<int, string>()
        {
            { 0, "ноль" },
            { 1, "один" },
            { 2, "два" },
            { 3, "три" },
            { 4, "четыре" },
            { 5, "пять" },
            { 6, "шесть" },
            { 7, "сем" },
            { 8, "восем" },
            { 9, "девять" },
        };

        var index = 0;
        var builder = new StringBuilder();
        foreach (var symbol in str)
        {
            var digit = symbol - '0';
            if (symbolToWord.TryGetValue(digit, out var result))
            {
                var replace = result;
                if (index > 0)
                {
                    replace = replace.Insert(0, " ");
                }
                if (index < str.Length - 1)
                {
                    replace = replace.Insert(replace.Length, " ");
                }
                
                builder.Append(replace);
            }
            else
            {
                builder.Append(symbol);
            }
            
            index++;
        }
        
        return builder.ToString();
    }
    
    public static void Do()
    {
        Console.WriteLine("Введите строку: ");
        var input = Console.ReadLine();
        
        Console.WriteLine(input.NumericToWords());
    }
}