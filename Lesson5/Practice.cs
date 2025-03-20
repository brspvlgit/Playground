namespace Lesson_5;
public class Practice
{
   public static void GetNumbersReverse ()
    {
        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }

    public static void CheckDayType ()
    {
        Console.Write("Введите номер дня недели (1-7)");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Это рабочий день");
                break;
            case 6:
            case 7:
                Console.WriteLine("Это выходной день");
                break;
            default:
                Console.WriteLine("Некорректный номер дня");
                break;
        }
    }

    public static void CountVowels ()
    {
        Console.WriteLine("Введите Слово");
        string word = Console.ReadLine();

        int counter = 0;

        foreach (char w in word)
        {
            if (w == 'a' || w == 'e' || w == 'i' || w == 'o' || w == 'u')
            {
                counter++;
            }
        }

        Console.WriteLine("Количество гласных = " + counter);
    }

    public static void GetLikes ()
    {
        string[] names = ["Peter", "Maria", "Matvey", "Sasha", "Vladimir"];

        switch (names.Length)
        {
            case 0:
                Console.WriteLine("Нет лайков");
                break;
            case 1:
                Console.WriteLine("Один лайк: " + names[0]);
                break;
            case 2:
                Console.WriteLine("Два лайка: " + names[0] + " " + names[1]);
                break;
            case 3:
                Console.WriteLine("Три лайка: " + names[0] + " " + names[1] + " " + names[2]);
                break;
            default:
                Console.WriteLine("Лайкнуло: " + names[0] + " " + names[1] + " и ещё " + (names.Length - 2));
                break;
        }
    }

    public static void BirthdayMath ()
    {
        int birthday = 12;

        for (int i = 100; i < 800; i++)
        {
            if (i % birthday == 0)
            {
                Console.Write(i);
            }
        }
    }

    public static void MultiplicationTable ()
    {
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i} * {j}= {i * j}\t");
            }

            Console.WriteLine();
        }
    }
}