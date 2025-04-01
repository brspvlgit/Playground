namespace Lesson_9;
public static class GuessTheWord
{
    private static Dictionary<string, string> words = new Dictionary<string, string>
    {
        { "Класс", "Это основной строительный блок программы" },
        { "Метод", "Это функция которая принадлежит классу" },
        { "Массив", "Cпорядоченная коллекция, которая хранит фиксированное количество элементов одного типа" },
        { "Оператор", "Cимвол, который сообщает компилятору выполнить определенные математические или логические манипуляции" },
        { "Сплит", "Метод для разделния строк" },
        { "Мэтч", "Метод для поиска первого совпаденийя в тексте" },
        { "Рандом", "Задаёт случайное число в определённом промежутке" },
        { "Вайл", "Цикл с предусловием" },
        { "Стэк", "Область памяти для хранения переменных значимого типа" },
        { "Декремент", "Оператор для уменьшения значения переменной" },
        { "Значение", "В коллекции словарь является не уникальным" },
        { "Ключ", "В коллекции словарь является уникальным" },
        { "Список", "Коллекция, которая может динамически изменять размер."},
        { "Идентификатор", "Пользовательское имя для переменной,константы, метода или типа."},
        { "Литерал", "последовательность символов, которая может интерпретироваться как значение одного из примитивных типов."},
        { "Куча", "Область памяти, которая используется для динамического выделения памяти."},
        { "Операнд", "Значение или выражение в математической операции,которое находится с обеих сторон от оператора."},
        { "Инициализация", "Установление начального значения переменной-счетчика."},
        { "Конструктор", "Специальный метод, вызываемый при создании объекта класса."},
        { "Финализатор", "Метод, вызываемый при удалении объекта класса, содержащий завершающий код для объекта."},
    };

    public static void Play()
    {
        Random random = new Random();
        string word = words.Keys.ToList()[random.Next(words.Count)];
        string hint = words[word];
        word = word.ToLower();

        int attempts = 0;
        char[] shifr = new string('*', word.Length).ToCharArray();
        bool isOtgadan = false;

        Console.WriteLine("Добро пожаловать в игру угадай слово по подсказке!");

        while (attempts == 0)
        {
            Console.WriteLine("Выберите уровень сложности:");
            Console.WriteLine("1 - Лёгкий (10 попыток)");
            Console.WriteLine("2 - Средний (5 попыток)");
            Console.WriteLine("3 - Тяжёлый (3 попытки)");
            Console.Write("Ваш выбор (1/2/3): ");
            string complexity = Console.ReadLine();

            switch (complexity)
            {
                case "1":
                    attempts = 10;
                    break;
                case "2":
                    attempts = 6;
                    break;
                case "3":
                    attempts = 3;
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }
        }

        while (attempts > 0 && !isOtgadan)
        {
            Console.WriteLine($"Cекретное слово: {string.Join(' ', shifr)}");
            Console.WriteLine($"Осталось попыток: {attempts} ");

            if (attempts == 2)
            {
                Console.WriteLine($" Подсказка: {hint}");
            }
            
            Console.Write("Введите букву:");
            string input = Console.ReadLine().ToLower();

            if (input.Length != 1 || !char.IsLetter(input[0]) || string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Введите одну букву!!!!!!!!");
                continue;
            }

            char letter = input[0];

            bool isFound = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (letter == word[i])
                {
                    shifr[i] = letter;
                    
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("Есть такая буква!");
            }
            else 
            {
                Console.WriteLine("Нет такой буквы!");
                attempts --;
            }
            
            if (new string(shifr) == word)
            {
                Console.WriteLine($"Поздравляем, ты победил! Это было слово {word}.");
                isOtgadan = true;
            }
        }

        if (!isOtgadan)
        {
            Console.WriteLine($"Ты проиграл! Правильное слово {word}. Попробуй еще!");
        }
        Console.Write("Хотите сыграть еще раз? (y/n):");
        string answer = Console.ReadLine().ToLower();

        if (answer == "y")
        {
            Play();
        }
        else
        {
            Console.WriteLine("До скорых встречь!");
        }
    }
}