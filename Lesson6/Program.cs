namespace Lesson6;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Задачи занятия:");
            Console.WriteLine("1. Разворот строки задом наперёд.");
            Console.WriteLine("2. Перемножение знчений.");
            Console.WriteLine("3. Сумма положительных значений.");
            Console.WriteLine("4. Подсчет одинаковых чисел в массиве.");
            Console.WriteLine("5. Перенос нуля в конец.");
            Console.WriteLine("6. Удаление повторений.");
            Console.WriteLine("7. Поиск самого длинного слова.");
            Console.WriteLine("8. Конвертация булевого массива в стринговый.");
            Console.WriteLine("9. Выход.");
            Console.Write("\nВведите № задачи для запуска:\t");

            String input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Practice.SortAndReverse();
                    break;
                case "2":
                    Practice.MultiplyArrayElements();
                    break;
                case "3":
                    Practice.CalculatePositiveSum();
                    break;
                case "4":
                    Practice.CountOccurrences();
                    break;
                case "5":
                    Practice.MoveZerosToEnd();
                    break;
                case "6":
                    Practice.RemoveDuplicates();
                    break;
                case "7":
                    Practice.FindLongestSequence();
                    break;
                case "8":
                    Practice.ConvertBoolArrayToString();
                    break;
                case "9":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nНажмите любую клавишу для продолжения.");
                Console.ReadKey();
            }
        }

        Practice.AreAnagrams();
        Practice.SumDiagonals();
        Practice.IsPalindrome();
        Practice.ReverseWords();
        Practice.FindSecondLargest();
        Practice.SplitAndReverse();
        Practice.SwapAdjacentElements();
        Practice.PrintMaxElementsOfRows();
        Practice.FindSumBetweenMinAndMax();
    }
}