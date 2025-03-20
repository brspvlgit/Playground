namespace Lesson3;

public static class Practice
{
    public static void Greet()
    {
        const string name = "john doe";

        Console.Write("Enter your name: ");

        string input = Console.ReadLine().ToLower();

        if (name == input)
        {
            Console.WriteLine($"Nice to meet you again, {input}");
        }
        else
        {
            Console.WriteLine("Hello, unknown user");
        }
    }
    
    public static void GetMaxWeight()
    {
        int box1 = 1;
        int box2 = 8;
        int box3 = 5;
        int box4 = 3;
        int box5 = 9;

        int max = box1;

        if (box2 > max)
        {
            max = box2;
        }

        if (box3 > max) max = box3;
        if (box4 > max) max = box4;
        if (box5 > max) max = box5;

        Console.WriteLine("Max weight is " + max);
    }
    
    public static void GetAvgValue()
    {
        Console.WriteLine("Enter a variable:");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter another variable:");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter another variable:");
        int number3 = int.Parse(Console.ReadLine());

        double average = (number1 + number2 + number3) / 3.0;

        Console.WriteLine($"Среднее значение: {average}");
    }
    
    public static void GetCurrentAge()
    {
        const int year = 2025;

        Console.WriteLine("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = year - birthYear;

        Console.WriteLine($"Your age: {age}");
    }
}


