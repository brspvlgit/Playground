namespace Lesson13
{
    class TestCase
    {
        private string status;

        private const string Passed = "Пройден";
        private const string Failed = "Не пройден";

        public string Name { get; }
        public string Description { get; }
        public DateTime LastRun { get; private set; }

        public required string Status
        {
            get => status;
            set
            {
                if (value != Passed && value != Failed)
                    throw new ArgumentException("Статус должен быть 'Пройден' или 'Не пройден'");
                status = value;
            }
        }

        //public string TimeSinceLastRun => LastRun == DateTime.MinValue
        //    ? "Тест ещё не был выполнен"
        //    : $"{(DateTime.Now - LastRun).TotalHours:F2} часов назад";

        public string TimeSinceLastRun
        {
            get
            {
                if (LastRun == DateTime.MinValue)
                    return "Тест ещё не был выполнен";

                var timeDiff = DateTime.Now - LastRun;
                return $"{timeDiff.TotalMinutes:F2} минут назад";
            }
        }

        public TestCase (string name, string description)
        {
            Name = name;
            Description = description;
            Status = Failed;
            LastRun = DateTime.MinValue;
        }

        public void RunTest ()
        {
            LastRun = DateTime.Now;
            Status = Passed;
            Console.WriteLine($"Тест {Name} выполнен успешно.");
        }

        public void FailTest ()
        {
            Status = Failed;
            LastRun = DateTime.Now;
            Console.WriteLine($"Тест {Name} не пройден.");
        }

        public void DisplayTestDetails ()
        {
            Console.WriteLine($"\nТест: {Name}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Статус: {Status}");
            Console.WriteLine($"Последний запуск: {LastRun}");
            Console.WriteLine($"Время с последнего запуска: {TimeSinceLastRun}");
        }
    }
}
