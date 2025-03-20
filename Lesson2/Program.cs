
class Programm
{
    static void Main()
    {
        int x = 20;
        int y = 7;
        var sum = x + y;
        Console.WriteLine("Summa: " + sum);
        var minus = y - x;
        Console.WriteLine("Minus: " + minus);
        var multipl = y * x;
        Console.WriteLine("Multiplication: " + multipl);
        var division = x / y;
        Console.WriteLine("Division: " + division);
        
        var name = Console.ReadLine();
        
        Console.WriteLine("Hello, " + name);
        
        string str1 = "Hello";
        string str2 = str1;
        str1 = str1 + "Wrold";
        
        System.Console.WriteLine(str2);
    }
}