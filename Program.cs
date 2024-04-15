public class Person  // Base class for common properties
{
    public string Name { get; set; }
    public int Age { get; set; }

    public virtual void Introduce()  // Virtual method for introduction (can be overridden)
    {
        Console.WriteLine("Hello, my name is {0}.", Name);
    }
}

public class Employee : Person  // Derived class inheriting from Person
{
    public string EmployeeId { get; set; }
    public string Department { get; set; }

    public override void Introduce()  // Override Introduce to include employee details
    {
        base.Introduce();  // Call the hidden base class (Person) Introduce method
        Console.WriteLine("I am an employee with ID: {0} in the {1} department.", EmployeeId, Department);
    }
}

public class Manager : Employee  // Derived class inheriting from Employee
{
    public int TeamSize { get; set; }

    public void AssignTasks()  // Method specific to Manager class
    {
        Console.WriteLine("Manager assigning tasks to team...");
    }

    public new void Introduce()  // Method hiding (same signature as Employee.Introduce)
    {
        Console.WriteLine("Greetings! I am {0}, a manager leading a team of {1}.", Name, TeamSize);
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

        emp1.Introduce();  // Calls overridden Employee.Introduce

        Manager manager1 = new Manager();  // Create a Manager object
        manager1.Name = "Jane Smith";
        manager1.Age = 40;
        manager1.EmployeeId = "MNG002";
        manager1.Department = "Marketing";
        manager1.TeamSize = 5;

        manager1.Introduce();  // Calls hidden Employee.Introduce (unless using 'new' keyword)

        // Using 'new' keyword for method hiding in Manager
        ((Employee)manager1).Introduce();  // Cast to Employee to call hidden Manager.Introduce

        manager1.AssignTasks();  // Call method specific to Manager
    }
}

