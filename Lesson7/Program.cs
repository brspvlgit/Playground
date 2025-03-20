using Lesson7;

public class Program
{
    static void Main(string[] args)
    {
        Practice practice = new Practice ();
        
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Задачи занятия:");
            Console.WriteLine("1. Реверс слов.");
            Console.WriteLine("2. Удаление символов из строки.");
            Console.WriteLine("3. Подсчет слов.");
            Console.WriteLine("4. Поиск самого длинного слова.");
            Console.WriteLine("5. Подсчет гласных, согласных, пробелов и цифр.");
            Console.WriteLine("6. Выход.");
            Console.Write("\nВведите № задачи для запуска:\t");

            String input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                    Console.Write("Введите строку: ");
                    string userInput = Console.ReadLine();

                    switch (input)
                    {
                        case "1": practice.ReverseWords(userInput); break;
                        case "2": practice.RemoveNonAlphanumeric(userInput); break;
                        case "3": practice.CountWords(userInput); break;
                        case "4": practice.FindLongestWord(userInput); break;
                        case "5": practice.CountCharacters(userInput); break;
                    }
                    break;
                case "6":
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
    }
}