using Lesson3;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("text");
        Console.WriteLine("text");
        var response = Console.ReadLine().ToLower();
        var number = int.Parse(response);
        
        Console.WriteLine("" + number);
        
        Practice.Greet();
        Practice.GetMaxWeight();
        Practice.GetAvgValue();
        Practice.GetCurrentAge();
        
        Homework.yesNo();
        Homework.ScissorsPaperRock();
    }
    
}