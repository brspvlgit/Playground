namespace Lesson6;

public class Practice
{
    private int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    public static void SortAndReverse ()
    {
        int[] numbers = new int[6];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Array.Sort(numbers);
        Array.Reverse(numbers);

        Print(numbers);

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                { 
                    int temp = numbers[j]; 
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }

        Print(numbers);

        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }

        Print(numbers);
    }

    public static void MultiplyArrayElements ()
    {
        int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int result = 1;

        foreach (var number in numbers)
        {
            result *= number;
        }

        Console.WriteLine(result);
    }

    public static void CalculatePositiveSum ()
    {
        int[] numbers = new int[6];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (var num in numbers)
        {
            if (num > 0)
            {
                sum += num;
            }
        }

        Console.WriteLine(sum);
    }

    public static void CountOccurrences ()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Введите число для поиска:");
        int search = int.Parse(Console.ReadLine());
        int count = 0;

        foreach (var num in numbers)
        {
            if (num == search)
                count++;
        }
    }

    public static void SwapAdjacentElements ()
    {
    }

    public static void MoveZerosToEnd ()
    {
        int[] array = new int[10] { 1, 0, 3, 4, 0, 6, 7, 8, 0, 10 };

        int nonZeroIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {

                int temp = array[i];
                array[i] = array[nonZeroIndex];
                array[nonZeroIndex] = temp;

                nonZeroIndex++;
            }
        }

        Console.WriteLine("Массив после перемещения нулей в конец:");

        foreach (var num in array)
        {
            Console.Write(num + " ");
        }
    }

    public static void SplitAndReverse ()
    {
    }

    public static void RemoveDuplicates ()
    {
        int[] array = [2, 2, 3, 5, 5, 6, 8, 8, 9, 10];

        //int[] result = array.Distinct().ToArray();

        int[] tempArray = new int[array.Length];

        int uniqueCount = 0;

        foreach (var num in array)
        {
            if (Array.IndexOf(tempArray, num, 0, uniqueCount) == -1)
            {
                tempArray[uniqueCount] = num;
                uniqueCount++;
            }
        }

        for (int i = 0; i < uniqueCount; i++)
        {
            Console.Write(tempArray[i] + " ");
        }
    }

    public static void FindSecondLargest ()
    {
    }

    public static void FindSumBetweenMinAndMax ()
    {
    }

    public static void FindLongestSequence ()
    {
        bool[] boolean = { true, false, true, true, true, true, false, false, false, false, false };

        if (boolean.Length == 0)
        {
            Console.WriteLine("0");
        }

        int maxSequence = 1;
        int nowSequence = 1;

        for (int i = 1; i < boolean.Length; i++)
        {
            if (boolean[i] == boolean[i - 1])
            {
                nowSequence++;
            }
            else
            {
                if (nowSequence > maxSequence)
                {
                    maxSequence = nowSequence;
                }

                nowSequence = 1;
            }
        }

        if (nowSequence > maxSequence)
        {
            maxSequence = nowSequence;
        }

        Console.WriteLine(maxSequence);
    }

    public static void ConvertBoolArrayToString ()
    {
        bool[] boolean = { true, false, true, true, true, false, false };
        string output = "";

        foreach (var item in boolean)
        {
            output += item ? "1" : "0";
        }

        Console.WriteLine(output);
    }

    public static void IsPalindrome ()
    {
    }

    public static void AreAnagrams ()
    {
    }

    public static void ReverseWords ()
    {
    }

    public static void PrintMaxElementsOfRows ()
    {
    }

    public static void SumDiagonals ()
    {
    }

    private static void Print (int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}