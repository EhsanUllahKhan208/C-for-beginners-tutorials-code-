public class Customer  // Class for customers (reference type)
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Point Location { get; set; }  // Property of type Point struct

    public Customer(string name, int id, int x, int y)
    {
        Name = name;
        Id = id;
        Location = new Point { X = x, Y = y };  // Initialize Point struct within constructor
    }
}

public struct Point  // Struct for 2D points (value type)
{
    public int X { get; set; }
    public int Y { get; set; }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Create a Customer object with a Point location
        Customer customer1 = new Customer("Alice Smith", 123, 10, 20);

        Console.WriteLine($"Customer Name: {customer1.Name}");
        Console.WriteLine($"Customer ID: {customer1.Id}");
        Console.WriteLine($"Customer Location: ({customer1.Location.X}, {customer1.Location.Y})");

        // Modifying customer1.Location creates a copy (value type)
        customer1.Location = new Point { X = 30, Y = 40 };

        Console.WriteLine($"Modified Location (copy): ({customer1.Location.X}, {customer1.Location.Y})");
    }
}
