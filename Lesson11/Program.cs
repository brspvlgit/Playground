using Lesson11.Practice;

namespace Lesson11;

public class Program
{
    static void Main(string[] args)
    {
        Library.BooksByAuthor();
        Library.BookCount();
        Library.BooksByYear();
        
        MagicSchool magicSchool = new MagicSchool();
        magicSchool.AwgPowerSchool();
        magicSchool.MostPowerfullWizard();
        magicSchool.PercentInSchool();
        magicSchool.SumPowerBySchool();
    }
}