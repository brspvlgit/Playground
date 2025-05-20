namespace Exam2;

public class ActionTask
{
    public static void Do()
    {
        TestClass.OnCalled10Times += Print10Times;

        var test1 = new TestClass();
        var test2 = new TestClass();
        
        for (var i = 0; i < 5; i++)
        {
            test1.TestMethod();
            test2.TestMethod();
        }
    }

    private static void Print10Times()
    {
        Console.WriteLine($"Метод {nameof(TestClass.TestMethod)} был вызван 10 раз!");
    }
    
    private class TestClass
    {
        public static event Action OnCalled10Times;

        private static int counter;
        
        public void TestMethod()
        {
            Console.WriteLine($"Вызов метода номер №{counter + 1}");
            
            if (++counter >= 10)
            {
                counter = 0;
                OnCalled10Times?.Invoke();
            }
        }
    }
}