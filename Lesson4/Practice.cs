namespace Lesson4;

public class Practice
{
    public static void GuessTheNumber ()
    {
        Console.Write("Угадайте число от 1 до 100 ");
        Random rand = new Random();
        int secretNumber = rand.Next(1, 101);
        int myNumber;

        do
        {
            Console.Write("Введите вашу догадку: ");
            myNumber = int.Parse(Console.ReadLine());

            if (myNumber > secretNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }
            else if (myNumber < secretNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else
            {
                Console.WriteLine("Поздравляю, вы угадали!");
            }
        } while (myNumber != secretNumber);
    }

    public static void PrintArray ()
    {
        int[] numbers = [1, 2, 3, 4, 5];

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    public static void GetNumber ()
    {
        int i = -20;

        do
        {
            Console.WriteLine(i);
            i -= 20;

        } while (i >= -1000);
    }

    public static void MulitplesOfFive ()
    {
        for (int i = 10; i < 100; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    public static void MoveTheFigure ()
    {
        Console.Write("Нажмите клавишу: ");
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.W:
                Console.WriteLine("Передвинуть вверх");
                break;
            case ConsoleKey.S:
                Console.WriteLine("Передвинуть вниз");
                break;
            case ConsoleKey.A:
                Console.WriteLine("Передвинуть влево");
                break;
            case ConsoleKey.D:
                Console.WriteLine("Передвинуть вправо");
                break;
            default:
                Console.WriteLine("Нажмите другую");
                break;
        }
    }
}