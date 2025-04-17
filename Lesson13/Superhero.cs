namespace Lesson13
{
    class Superhero
    {
        private static int counter = 0;
        private int superpowerLevel;

        public string Name { get; set; } //prop
        public string Superpower { get; set; }
        public int Strength { get; set; } = 50;

        public int SuperpowerLevel
        {
            get => superpowerLevel;
            set => superpowerLevel = Math.Clamp(value, 1, 10);
        }

        public Superhero () : this("Аноним", "Неизвестно", 50, 5) { } //ctor

        public Superhero (string name, string superpower, int strength, int level)
        {
            Name = name;
            Superpower = superpower;
            Strength = Math.Clamp(strength, 1, 100);
            SuperpowerLevel = level;

            counter++;
        }

        public void Display ()
        {
            Console.WriteLine($"{Name}, сила: {Strength}, способность: {Superpower} (уровень: {SuperpowerLevel})");
        }

        public void Fight (int damage)
        {
            Strength -= damage;

            if (Strength <= 0)
            {
                Strength = 0;
            }

            Console.WriteLine($"{Name} получил урон {damage}. Осталось силы: {Strength}");
        }

        public void Train (ref int extraStrength)
        {
            Strength += extraStrength;

            Strength = Math.Clamp(Strength, 1, 100);

            extraStrength++;

            Console.WriteLine($"{Name} потренировался! Теперь сила: {Strength}");
        }

        public string GetHeroStats ()
        {
            return $"{Name}, сила: {Strength}, способность: {Superpower} (уровень: {SuperpowerLevel})";
        }

        public static int GetHeroCount ()
        {
            return counter;
        }

        public void AddStrength (params int[] extraStrength)
        {
            int total = 0;

            foreach (var strength in extraStrength)
            {
                total += strength;
            }

            Strength += total;
            Strength = Math.Clamp(Strength, 1, 100);

            Console.WriteLine($"{Name} добавил {total} силы. Теперь сила: {Strength}");
        }
    }
}
