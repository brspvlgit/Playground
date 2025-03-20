namespace Lesson10;

public class Practice
{
   private List<int> nums = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

   private Dictionary<string, int> people = new Dictionary<string, int>
   {
      { "Petya", 21 },
      { "Pasha", 12 },
      { "Ira", 18 },
      { "Masha", 19 },
      { "Maksim", 32 },
      { "Natasha", 35 },
      { "Gena", 48 },
      { "Olga", 22 },
      { "Dasha", 12 }
   };
   
   private static List<string> input = new List<string> { "klass", "iron", "right mark", "digit is one" };
   
   public void FilterEvenNumbers()
   {
      var result = nums.Where(num => num % 2 == 0 || num % 3 == 0);

      foreach (var num in result)
      {
         Console.WriteLine(num);
      }
   }

   public void MaxNumbers()
   {
      var maxNum = nums.Max();

      Console.WriteLine($"Максимальнео число {maxNum}");
   }
   
   public void FindUniqueElements()
   {
      var result = nums.Distinct().ToList();

      foreach (var number in result)
      {
         Console.WriteLine($"Уникальные элементы: {number}");
      }
   }
   
   public void FindSummNumbers()
   {
      var reult = nums.Where(n => n % 3 == 0).Sum();
      Console.WriteLine($"Сумма чисел, кратных 3: {reult}");
   }
   
   public void CountAdults()
   {
      //var result = people.Where(p => p.Value >18).Count();
      var result = people.Count(p => p.Value > 18);
      Console.WriteLine($"Старше 18  {result} человек");
   }

   public void StudentsSort()
   {
      var result = people.OrderBy(p => p.Key).Select(p => p.Key).ToList();

      foreach (var p in result)
      {
         Console.WriteLine(p);
      }
   }
   
   public void CountStrings()
   {
      var result = input.Count(s => s.Split(" ").Length >= 2);

      Console.WriteLine($"Строки у которых больше 2 слов: {result}");
   }

   public void CountNumbers()
   {
      var result = nums.Where(n => n >= 10 && n <= 50);

      foreach (var n in result)
      {
         Console.WriteLine(n);
      }
   }

   public void SortByLength()
   {
      var result = input.OrderByDescending(s => s.Length);
      foreach (var s in result)
      {
         Console.WriteLine(s);
      }
   }
   
   
}