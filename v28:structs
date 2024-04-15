public struct Point  // Struct for 2D points
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class Employee  // Class for employees
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Point Location { get; set; }  // Property of type Point struct

    public Employee(string name, int id, int x, int y)
    {
        Name = name;
        Id = id;
        Location = new Point { X = x, Y = y };  // Initialize Point struct within constructor
    }
}

public class MainProgram  // Class to hold the Main method
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("Alice Smith", 123, 10, 20);

        Console.WriteLine($"Employee Name: {emp1.Name}");
        Console.WriteLine($"Employee ID: {emp1.Id}");
        Console.WriteLine($"Employee Location: ({emp1.Location.X}, {emp1.Location.Y})");

        // Modifying emp1.Location creates a copy (value type)
        emp1.Location = new Point { X = 30, Y = 40 };

        Console.WriteLine($"Modified Location (copy): ({emp1.Location.X}, {emp1.Location.Y})");
    }
}
