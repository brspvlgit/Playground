
using System.Text.RegularExpressions;

namespace Lesson8;

public static class Practice
{
    public static void Password()
    {
        Console.Write("Введите пароль\t");
        string password = Console.ReadLine();
        if (password.Length < 8 || password.Length > 20)
        {
            Console.Write("\nНекоректная длинна пароля");
        }

        if (password.Contains(' '))
        {
            Console.Write("\nПароль не должен содержать пробелов");
        }

        if (password.ToLower() == password)
        {
            Console.Write("\nПароль должен содержать заглавные буквы");
        }
        
        if (password.ToUpper() == password)
        {
            Console.Write("\nПароль должен содержать строчные буквы");
        }

        if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            Console.Write("\nПароль должен содержать заглавные буквы");
        }
        
        if (!Regex.IsMatch(password, @"[a-z]"))
        {
            Console.Write("\nПароль должен содержать строчные буквы");
        }
        
        if (!Regex.IsMatch(password, @"\d"))
        {
            Console.Write("\nПароль должен хотя бы одну цифру");
        }
        
        if (!Regex.IsMatch(password, @"\W"))
        {
            Console.Write("\nПароль должен хотя бы один символ");
        }
    }

    public static void CountWords()
    {
        List<string> words = new List<string>() { "Anna", "Irina", "Ivan", "Anna", "Anna", "Ivan" };
        var result = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (result.ContainsKey(word))
            {
                result[word] = result[word] + 1;
            }
            else
            {
                result[word] = 1;
            }
        }

        foreach (var kvp in result)
        {
            Console.WriteLine($"Word {kvp.Key} count {kvp.Value}");
        }
    }

    public static void FirstUnique()
    {
        List<int> numbers  = new List<int>() { 1, 2, 2, 3, 5, 5, 1, 7};
        var result = new Dictionary<int, int>();

        foreach (var number in numbers)
        {
            if (result.ContainsKey(number))
            {
                result[number]++;
            }
            else
            {
                result[number] = 1;
            }
        }
        
        foreach (var kvp in result)
        {
            if (kvp.Value == 1)
            {
                Console.WriteLine($"Unique number: {kvp.Key}");
            }
        }
    }

    public static void GroupString()
    {
        List<string> words = new List<string>() { "apple", "banana", "cat", "dog" };
        Dictionary<int, List<string>> result = new Dictionary<int, List<string>>();
        
        foreach (var word in words)
        {
            if (!result.ContainsKey(word.Length))
            {
                result[word.Length] = new List<string>();
            }
            
            result[word.Length].Add(word);
        }
        
        foreach (var kvp in result)
        {
            Console.WriteLine($"Строки длинной {kvp.Key}: {string.Join(" ", kvp.Value)}");
        }
    }
}