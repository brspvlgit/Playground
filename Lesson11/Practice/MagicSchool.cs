using Lesson11.Models;

namespace Lesson11.Practice;

public class MagicSchool
{
    private List<Wizard> wizards = new List<Wizard>
    {
        new Wizard("Эльдарион Тенепламя", "Некромант", 92),
        new Wizard("Мирелла Лунный Лист", "Друид", 78),
        new Wizard("Азариус Бесконечный", "Арканист", 95),
        new Wizard("Вел'Торн Чернокост", "Некромант", 85),
        new Wizard("Фаэрис Зеленое Пламя", "Друид", 80),
        new Wizard("Люциан Сияющий", "Арканист", 88),
        new Wizard("Сильвана Ночная Тень", "Некромант", 90),
        new Wizard("Террамос Камнекров", "Друид", 83),
        new Wizard("Орфирион Искрящийся", "Арканист", 91),
        new Wizard("Зараэль Морозный Шепот", "Некромант", 87),
    };

    public void AwgPowerSchool()
    {
        var result = wizards.GroupBy(w => w.SchoolName)
            .Select(g => new { SchoolName = g.Key, AvgPower = g.Average(w => w.PowerLevel) });

        foreach (var school in result)
        {
            Console.WriteLine($"Школа {school.SchoolName}, среднее значение силы: {school.AvgPower}");
        }
    }

    public void MostPowerfullWizard()
    {
        var result = wizards.OrderBy(w => w.PowerLevel).Last();

        Console.WriteLine($"{result.Name}, {result.SchoolName}, {result.PowerLevel}");
    }

    public void PercentInSchool()
    {
        var result = wizards
            .GroupBy(w => w.SchoolName)
            .Select(g => new { Name = g.Key, Percentage = (double)g.Count() / wizards.Count * 100 });

        foreach (var school in result)
        {
            Console.WriteLine($"{school.Name}, {school.Percentage:F1}");
        }
    }

    public void SumPowerBySchool()
    {
        var result = wizards
            .GroupBy(w => w.SchoolName)
            .Select(g => new { SchoolName = g.Key, TotalPower = g.Sum(w => w.PowerLevel) });

        foreach (var school in result)
        {
            Console.WriteLine($"{school.SchoolName}, {school.TotalPower}");
        }
    }
    
    public void MaxPowerSchool()
    {
        var result = wizards
            .GroupBy(w => w.SchoolName)
            .Select(g => new { SchoolName = g.Key, AvgPower = g.Average(w => w.PowerLevel) })
            .OrderBy(a => a.AvgPower)
            .Last();
     
        Console.WriteLine($"Школа {result.SchoolName}, мощность - {result.AvgPower} ");
    }
}