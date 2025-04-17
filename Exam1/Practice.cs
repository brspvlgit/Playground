namespace Exam1;

public class Practice
{
    public static void Array ()
    {
        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        DiagonalChange(array);
    }

    static void DiagonalChange(int[,] array)
    {
        int n = array.GetLength(0);
        int sum = 0;
        
        for (int i = 0; i < n; i++)
        {
            sum += array[i, i];  
            array[i, i] = 0;
        }
        
        Console.WriteLine("Сумма значений диагонали: " + sum);
        Console.WriteLine("Измененная диагональ:");
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}