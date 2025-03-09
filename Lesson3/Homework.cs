namespace Lesson3;

public static class Homework
{
    public static void ScissorsPaperRock()
    {
        int scissorsFirst = 0;
        int paperFirst = 0;
        int rockFirst = 0;
        int scissorsSecond = 0;
        int paperSecond = 0;
        int rockSecond = 0;

        Console.WriteLine("Первый, выбери своего бойца (камень, ножницы, бумага): ");
        string first = Console.ReadLine().ToLower();

        if (first == "ножницы") scissorsFirst = 1;
        if (first == "бумага") paperFirst = 1;
        if (first == "камень") rockFirst = 1;

        

        do
        {
            if (scissorsFirst == 0 && paperFirst == 0 && rockFirst == 0)
            {
                Console.WriteLine("Нормально выбирай. Еще раз (камень, ножницы, бумага): ");
                first = Console.ReadLine().ToLower();
                if (first == "ножницы") scissorsFirst = 1;
                if (first == "бумага") paperFirst = 1;
                if (first == "камень") rockFirst = 1;
            }
        } while (scissorsFirst == 0 && paperFirst == 0 && rockFirst == 0);

        Console.WriteLine("Второй, выбери своего бойца (камень, ножницы, бумага): ");
        string second = Console.ReadLine().ToLower();

        if (second == "ножницы") scissorsSecond = 1;
        if (second == "бумага") paperSecond = 1;
        if (second == "камень") rockSecond = 1;

        do
        {
            if (scissorsSecond == 0 && paperSecond == 0 && rockSecond == 0)
            {
                Console.WriteLine("Нормально выбирай. Еще раз (камень, ножницы, бумага): ");
                second = Console.ReadLine().ToLower();
                if (second == "ножницы") scissorsSecond = 1;
                if (second == "бумага") paperSecond = 1;
                if (second == "камень") rockSecond = 1;
            }
        } while (scissorsSecond == 0 && paperSecond == 0 && rockSecond == 0);
        
        //Сравнение результатов
        if (first == second)
        {
            Console.WriteLine("Ничья");
        }

        if (scissorsFirst == 1 && paperSecond == 1)
        {
            Console.WriteLine("Первый победил");
        }
        
        if (scissorsFirst == 1 && rockSecond == 1)
        {
            Console.WriteLine("Второй победил");
        }
        
        if ( rockFirst == 1 && scissorsSecond == 1)
        {
            Console.WriteLine("Первый победил");
        }
        
        if ( rockFirst == 1 && paperSecond == 1)
        {
            Console.WriteLine("Второй победил");
        }
        
        if ( paperFirst == 1 && scissorsSecond == 1)
        {
            Console.WriteLine("Второй победил");
        }
        
        if ( paperFirst == 1 && rockSecond == 1)
        {
            Console.WriteLine("первый победил");
        }

}
    

    public static void yesNo()
    {
        Console.WriteLine("Введите число: ");
        double num = double.Parse(Console.ReadLine());

        if (num >= 0 && num % 2 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}