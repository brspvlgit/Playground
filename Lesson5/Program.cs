namespace Lesson_5;

public class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Задачи занятия:");
            Console.WriteLine("1. Вывод массива в обратном порядке.");
            Console.WriteLine("2. Определение дня недели.");
            Console.WriteLine("3. Подсчет гласных.");
            Console.WriteLine("4. Отображение лайков.");
            Console.WriteLine("5. Числа, на которые делится дата ДР.");
            Console.WriteLine("6. Таблица умножения от 1 до 10:");
            Console.WriteLine("7 ДЗ. Подсчет + - 0 чисел:");
            Console.WriteLine("8 ДЗ. Первые буквы слов:");
            Console.WriteLine("9 ДЗ. Вывод введенных значений по убыванию:");
            Console.WriteLine("10. Выход.");
            Console.Write("\nВведите № задачи для запуска:\t");

            String input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Practice.GetNumbersReverse();
                    break;
                case "2":
                    Practice.CheckDayType();
                    break;
                case "3":
                    Practice.CountVowels();
                    break;
                case "4":
                    Practice.GetLikes();
                    break;
                case "5":
                    Practice.BirthdayMath();
                    break;
                case "6":
                    Practice.MultiplicationTable();
                    break;
                case "7":
                    Homework.NumbersStats();
                    break;
                case "8":
                    Homework.GetFirstLetters();
                    break;
                case "9":
                    Homework.ArrayFirstStap();
                    break;
                case "10":
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
