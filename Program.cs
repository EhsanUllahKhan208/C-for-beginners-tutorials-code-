public class Circle
{
    // Static field for the mathematical constant PI (shared by all circles)
    public static double PI = 3.14159;

    // Instance field to store the circle's radius (specific to each circle)
    private double radius;

    // Constructor to set the radius (instance specific)
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Instance method to calculate the circle's area (uses PI and radius)
    public double CalculateArea()
    {
        return PI * radius * radius;
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Create two circles with different radii
        Circle circle1 = new Circle(5);
        Circle circle2 = new Circle(3);

        // Static field access (PI)
        Console.WriteLine("Area of circle1 (radius 5): " + circle1.CalculateArea());
        Console.WriteLine("Area of circle2 (radius 3): " + circle2.CalculateArea());
    }
}
