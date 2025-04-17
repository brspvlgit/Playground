using Lesson14.OOP_Demo;
using Lesson14.OOP_Demo.Abstraction;
using Lesson14.OOP_Demo.Inheritance;

namespace Lesson14;

internal class Program
{
    static void Main (string[] args)
    {
        //OOP_Demo.Abstraction.Animal dog = new OOP_Demo.Abstraction.Dog("Max");
        //OOP_Demo.Abstraction.Cat cat = new Cat("Whiskers");

        //dog.MakeSound();

        //cat.MakeSound();
        //cat.Run();

        //PersonManager.Populate();

        Employee employee = new("John Doe");
        Manager manager = new Manager("Jane Doe", 10);
        Director director = new Director("Nasa", "John Doe Sr", 1000);

        employee.Work();
        manager.Work();
        director.Work();

        employee.TakeBreak();
        manager.TakeBreak();
        director.TakeBreak();
    }
}
