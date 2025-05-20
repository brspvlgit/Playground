namespace Exam2;

public class MathTask
{
    public static void Do()
    {
        SuperMath.PrintPow();
        SuperMath.PrintFactorial();
    }
    
    public static class SuperMath
    {
        public static void PrintPow()
        {
            try
            {
                var x = ReadInt("основание");
                var y = ReadInt("степень");
            
                Console.WriteLine($"Результат: {DoPow(x, y)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при выполнении функции степени: {e}");
            }
        }

        public static void PrintFactorial()
        {
            try
            {
                var x = ReadInt("аргумент факториала");

                Console.WriteLine($"Результат: {Factorial(x)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при выполнении функции факториала: {e}");
            }
        }
        
        private static int ReadInt(string title)
        {
            while (true)
            {
                Console.Write($"Введите {title}: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var result))
                    return result;
                
                Console.WriteLine($"Введено не число.");
            }
        }
        
        public static int DoPow(int x, int y)
        {
            if(y < 0)
                throw new ArgumentException("Невозможно возвести в отрицательную степерь.");
                
            if (y == 0)
                return 1;

            var result = 1;
            for (var i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        public static int Factorial(int x)
        {
            if (x < 0)
                throw new ArgumentException("Факториал определён только для неотрицательных целых чисел.");

            var result = 1;
            for (var i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}