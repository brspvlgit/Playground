namespace Lesson14.OOP_Demo
{
    // Абстракция: базовый класс "Человек"
    abstract class Person
    {
        public string Name { get; } // Инкапсуляция : свойство доступно только для чтения
        public int BirthYear { get; } // Инкапсуляция : свойство доступно только для чтения
        public int Age { get; private set; }

        public Person (string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
            Age = DateTime.Now.Year - birthYear;
        }

        public void GrowOlder ()
        {
            Age++;
        }

        public abstract void IntroduceYourself (); // Полиморфизм: метод будет разным у потомков
    }
}
