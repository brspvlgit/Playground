namespace Exam2;

public class UserModel : Model
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Gender: {Gender}, Age: {Age}";
    }
}