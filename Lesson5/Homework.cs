namespace Lesson_5;

public static class Homework
{
    public static void ArrayFirstStap()
    {
        int[] array = new int [6];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введи значение массива с индексом {i + 1}: \t ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВывод Массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        int[] decreasing = array.OrderByDescending(i => i).ToArray();
        Console.WriteLine("\nВывод значений массива по убыванию:");

        for (int i = 0; i < decreasing.Length; i++)
        {
            Console.WriteLine(decreasing[i]);
        }



        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введи значение массива с индексом {i + 1}: \t ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nВывод Массива:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.WriteLine("\nВывод значений массива по убыванию:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void NumbersStats()
    {
        int plus = 0;
        int minus = 0;
        int zero = 0;

        Console.Write("Введите динну массива: \t");
        int length = int.Parse(Console.ReadLine());
        int[] usersArray = new int[length];

        for (int i = 0; i < usersArray.Length; i++)
        {
            Console.Write($"Введи значение массива с индексом {i + 1}: \t ");
            usersArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВывод Массива:");
        for (int i = 0; i < usersArray.Length; i++)
        {
            Console.WriteLine(usersArray[i]);
        }

        foreach (var number in usersArray)
        {
            if (number > 0) plus++;
            if (number < 0) minus++;
            if (number == 0) zero++;
        }

        Console.WriteLine($"\nКоличесвто положительных чисел: {plus}");
        Console.WriteLine($"\nКоличесвто отрицательных чисел: {minus}");
        Console.WriteLine($"\nКоличесвто чисел равных нулю: {zero}");
    }

    public static void GetFirstLetters()
    {
        Console.Write("Введите текст:\t");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        Console.WriteLine("\nВывод Массива:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

        Console.WriteLine($"\nПервые буквы слов:");
        foreach (var word in words)
        {
            char firstLetter = word[0];
            Console.WriteLine(firstLetter);
        }
    }
}