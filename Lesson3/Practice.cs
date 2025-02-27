namespace Lesson3;

public static class Practice
{
    //Задание 1:
    //Написать программу, которая принимает строку, и если строка
    //совпадает с вашим именем, выводить персональное приветствие.
    //Если не совпадает - стандартное.
    //Задача со звездочкой - принимать и распознавать имя в любом регистре (Аня = аНя = анЯ). 
    //Использовать метод .ToLower() или его аналог.
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
    
    //Задание 2:
    //Дано 5 гирь с разным весом в случайном порядке.Найти вес самой
    //тяжелой гири.Вес гирь прописан в коде (захардкодан).
    //Задача со звездочкой - принимать вес гирь с консоли.
    //Для конвертации строки в число использовать int.Parse(строка)
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
    
    //Задание 3:
    //Создать 3 переменных и инициализировать их значениями из
    //консоли. Найти среднее значение переменных и вывести в консоль.
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
    
    //Задание 4:
    //Пользователь вводит свой год рождения.Программа должна вывести
    //его возраст на текущий год.Подсказка: используйте переменные типа
    //int для хранения года рождения и текущего года.
    public static void GetCurrentAge()
    {
        const int year = 2025;

        Console.WriteLine("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int age = year - birthYear;

        Console.WriteLine($"Your age: {age}");
    }
}


