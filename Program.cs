public class Employee  // Base class
{
    public string Name { get; set; }
    public virtual double CalculatePay()  // Virtual method for calculating pay (to be overridden)
    {
        return 0.0;  // Base implementation (can be empty or basic calculation)
    }
}

public class SalariedEmployee : Employee  // Derived class for salaried employees
{
    public double Salary { get; set; }

    public override double CalculatePay()
    {
        return Salary / 12.0;  // Monthly salary calculation
    }
}

public class HourlyEmployee : Employee  // Derived class for hourly employees
{
    public double HourlyWage { get; set; }
    public int HoursWorked { get; set; }

    public override double CalculatePay()
    {
        return HourlyWage * HoursWorked;
    }
}

public class CommissionEmployee : Employee  // Derived class for commission-based employees
{
    public double BaseSalary { get; set; }
    public double CommissionRate { get; set; }
    public double TotalSales { get; set; }

    public override double CalculatePay()
    {
        return BaseSalary + (TotalSales * CommissionRate);
    }
}

public class MainProgram
{
    public static void ProcessPayroll(List<Employee> employees)
    {
        foreach (Employee employee in employees)
        {
            Console.WriteLine("Employee: {0}", employee.Name);
            Console.WriteLine("Pay: ${0:0.00}", employee.CalculatePay());  // Polymorphism in action
        }
    }

    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new SalariedEmployee { Name = "John Doe", Salary = 50000 });
        employees.Add(new HourlyEmployee { Name = "Jane Smith", HourlyWage = 20, HoursWorked = 40 });
        employees.Add(new CommissionEmployee { Name = "Mike Lee", BaseSalary = 30000, CommissionRate = 0.1, TotalSales = 100000 });

        ProcessPayroll(employees);
    }
}
