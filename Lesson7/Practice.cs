using System.Text;

namespace Lesson7;

public class Practice
{
    public void ReverseWords (string input)
    {
        string[] words = input.Split (' ');
        Array.Reverse (words);
        string result = string.Join (' ', words);
        Console.WriteLine(result);
    }

    public void RemoveNonAlphanumeric (string input)
    {
        StringBuilder result = new StringBuilder ();
        foreach (char c in input)
        {
            if (char.IsLetterOrDigit(c))
            {
                result.Append (c);
            }
        }
        
        Console.WriteLine(result);
    }

    public void CountWords (string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine ("Слов в строке: 0");
            return;
        }
        string[] words = input.Split (new[] {' ', ',', '.'}, StringSplitOptions.TrimEntries);
        Console.WriteLine($"Слов в строке: {words.Length}");
    }

    public void FindLongestWord (string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.Write("Введены некорректные символы.");
            return;
        }

        string[] words = input.Split(new[] { ' ', ',' });

        int max = 1;
        string longest = "";
        
        foreach (string word in words)
        {
            if (word.Length > max)
            {
                max = word.Length;
                longest = word;
            }
        }
        Console.WriteLine(longest);
        
    }

    public void CountCharacters (string input)
    {
        int glasn = 0, sogl = 0, cifri = 0, probel = 0;
        string glBukv = "аАоОуУыЫэЭеЕёЁюЮяЯиИAaoOEeUuIi";
        foreach (char bukv in input)
        {
            if (char.IsLetter(bukv))
                if (glBukv.Contains(bukv))
                {
                    glasn++;
                }
                else
                {
                    sogl++;
                }
            if (char.IsDigit(bukv))
            {
                cifri++;
            }

            if (char.IsWhiteSpace(bukv))
            {
                probel++;
            }
        }
        
        Console.WriteLine($"Гласных {glasn}, Согласных {sogl}, Цифр {cifri}, Пробелов {probel}");

        
    }

    public void FormatProblems ()
    {
        
    }

    public void HideEmail (string input)
    {
    }

    public void FormatPhoneNumber (string phoneNumber)
    {
    }

    public static bool ValidatePassword (string password)
    {
        return false;
    }
}