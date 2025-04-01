namespace Lesson11.Models;

public class Wizard
{
    public string Name { get; set; }
    public string SchoolName { get; set; }
    public int PowerLevel { get; set; }

    public Wizard (string name, string school, int power)
    {
        Name = name;
        SchoolName = school;
        PowerLevel = power;
    }
}