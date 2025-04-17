namespace Lesson15.Partial
{
    public partial class Employee
    {
        private decimal _salary;

        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value < 0 ? 0 : value; }
        }

        public decimal CalculateSalary (decimal bonus)
        {
            return _salary + bonus;
        }

        public static int CompareByAge (Employee e1, Employee e2)
        {
            return e1.Age.CompareTo(e2.Age);
        }
    }

    class EmployeeHelper
    {
        public void Run ()
        {
            var employee1 = new Employee("John", "Doe", new DateTime(1985, 4, 12));
            var employee2 = new Employee("Jane", "Smith", new DateTime(1990, 7, 20));

            employee1.Salary = 50000;
            employee2.Salary = 55000;

            Console.WriteLine($"Employee 1: {employee1.GetFullName()}, Age: {employee1.Age}, Salary: {employee1.Salary}");
            Console.WriteLine($"Employee 2: {employee2.GetFullName()}, Age: {employee2.Age}, Salary: {employee2.Salary}");

            decimal bonus = 5000;
            Console.WriteLine($"Employee 1 Salary with bonus: {employee1.CalculateSalary(bonus)}");
            Console.WriteLine($"Employee 2 Salary with bonus: {employee2.CalculateSalary(bonus)}");

            Console.WriteLine($"Comparison by age: {Employee.CompareByAge(employee1, employee2)}");
        }
    }
}
