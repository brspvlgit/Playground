namespace Lesson14.OOP_Demo
{
    #region Inheritance (Наследование)
    // Базовый класс Animal
    public abstract class Animal
    {
        public abstract void MakeSound ();
    }

    // Класс Dog наследует от Animal
    public class Dog : Animal
    {
        public override void MakeSound ()
        {
            Console.WriteLine("Woof!");
        }
    }
    #endregion

    #region Delegation (Делегация)
    // Класс Human делегирует выполнение задачи объекту Dog
    public class Human
    {
        private Dog _dog;

        public Human (Dog dog)
        {
            _dog = dog;
        }

        public void Speak ()
        {
            Console.WriteLine("Person is speaking:");
            _dog.MakeSound(); // Делегирует выполнение звука собаке
        }
    }
    #endregion

    #region Ассоциация (Агрегация и Композиция)

    // Аггрегация: Класс School ассоциируется с объектами CourseListener, но студенты могут существовать независимо
    public class CourseListener
    {
        public string Name { get; set; }
        public CourseListener (string name)
        {
            Name = name;
        }
    }

    public class School
    {
        private List<CourseListener> _students;

        public School ()
        {
            _students = new List<CourseListener>();
        }

        public void AddStudent (CourseListener student)
        {
            _students.Add(student);
        }

        public void ShowStudents ()
        {
            Console.WriteLine("Students in the school:");
            foreach (var student in _students)
            {
                Console.WriteLine(student.Name);
            }
        }
    }

    // Композиция: Класс House содержит Room, и если дом уничтожается, уничтожаются все комнаты
    public class Room
    {
        public string RoomName { get; set; }

        public Room (string roomName)
        {
            RoomName = roomName;
        }

        public void ShowRoom ()
        {
            Console.WriteLine($"This is the {RoomName}.");
        }
    }

    public class House
    {
        public List<Room> Rooms { get; set; }

        public House ()
        {
            Rooms = new List<Room>();
            // Добавляем комнаты в дом при его создании (композиция)
            Rooms.Add(new Room("Living Room"));
            Rooms.Add(new Room("Bedroom"));
        }

        public void ShowRooms ()
        {
            Console.WriteLine("Rooms in the house:");
            foreach (var room in Rooms)
            {
                room.ShowRoom();
            }
        }
    }
    #endregion
}
