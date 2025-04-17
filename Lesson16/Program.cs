namespace Lesson16;

internal class Program
{
    static void Main (string[] args)
    {
        RunPaymentMethods();
    }

    public static void TransformTwoDimensionalArray ()
    {
        int[,] mas =
        {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, 8, -9 }
        };

        int countPositive = 0;
        int minValue = int.MaxValue;
        int minI = -1, minJ = -1;

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] > 0)
                {
                    countPositive++;
                }

                if (mas[i, j] < minValue)
                {
                    minValue = mas[i, j];
                    minI = i;
                    minJ = j;
                }

                if (mas[i, j] < 0)
                {
                    mas[i, j] = 0;
                }
            }
        }

        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                Console.Write(mas[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void RunPaymentMethods ()
    {
        PaymentMethod cardPayment = new CardPayment();
        cardPayment.Describe();
        cardPayment.IsAvailable(5000);
        cardPayment.ProcessPayment(5000);

        var payments = new List<(PaymentMethod method, decimal amount)>
        {
            (new CardPayment(), 5000),
            (new InvoicePayment(), 800),
            (new InvoicePayment(), 3000),
            (new MobilePayment(), 2000),
            (new MobilePayment(), 500),
        };

        foreach (var (method, amount) in payments)
        {
            method.Describe();

            if (method.IsAvailable(amount))
            {
                method.ProcessPayment(amount);
            }
            else
            {
                Console.WriteLine($"Метод {method.Name} недоступен для суммы {amount}");
            }
        }
    }
}
