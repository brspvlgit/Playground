namespace Exam2;

public class ArrayTask
{
    public static void Do()
    {
        var lenght = 9;
        var array = CreateRandomArray(lenght);
        
        PrintArray(array);
        ModifyArray(array);
        Console.Write("\n");
        PrintArray(array);
    }
    

    private static int[,] CreateRandomArray(int lenght)
    {
        var random = new Random();
        var result = new int[lenght, lenght];

        for (var i = 0; i < lenght; i++)
        {
            for (var j = 0; j < lenght; j++)
            {
                result[i, j] = random.Next(1, 10);
            }   
        }

        return result;
    }
  
    private static void PrintArray(int[,] array)
    {
        for (var i = 0; i < array.GetLength(0); i++)
        {
            for (var j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j]);
            }  
            Console.Write("\n");
        }
    }
    
    private static void ModifyArray(int[,] array)
    {
        var width = array.GetLength(0);
        var height = array.GetLength(1);
        
        for (var i = 0; i < width; i++)
        {
            for (var j = 0; j < height; j++)
            {
                if (j == 0 || j == height - 1 || i == 0 || i == width - 1)
                {
                    array[i, j] = 0;
                }
            }
        }
    }
}
