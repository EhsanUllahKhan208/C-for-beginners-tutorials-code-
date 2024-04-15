public class Person  // Base class for common properties of people
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Employee : Person  // Derived class inheriting from Person
{
    public string EmployeeId { get; set; }
    public string Department { get; set; }

    public void PrintEmployeeDetails()  // Method specific to Employee class
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Age: {0}", Age);
        Console.WriteLine("Employee ID: {0}", EmployeeId);
        Console.WriteLine("Department: {0}", Department);
    }
}

public class Manager : Employee  // Derived class inheriting from Employee (multi-level inheritance)
{
    public int TeamSize { get; set; }

    public void AssignTasks()  // Method specific to Manager class
    {
        Console.WriteLine("Manager assigning tasks to team...");
    }

    public override void PrintEmployeeDetails()  // Overridden method including team size
    {
        base.PrintEmployeeDetails();  // Call the base class method (Employee.PrintEmployeeDetails)
        Console.WriteLine("Team Size: {0}", TeamSize);
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee();  // Create an Employee object
        emp1.Name = "John Doe";
        emp1.Age = 30;
        emp1.EmployeeId = "EMP001";
        emp1.Department = "Sales";

        emp1.PrintEmployeeDetails();  // Call the method specific to Employee

        Manager manager1 = new Manager();  // Create a Manager object (inherits from Employee)
        manager1.Name = "Jane Smith";
        manager1.Age = 40;
        manager1.EmployeeId = "MNG002";
        manager1.Department = "Marketing";
        manager1.TeamSize = 5;

        manager1.PrintEmployeeDetails();  // Calls overridden method including TeamSize
        manager1.AssignTasks();  // Call method specific to Manager
    }
}
