namespace v69
{
    internal class Program
    {
       

public class Calculator
    {
        // Method to add two integers (with optional third parameter)
        public int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }

        // Method to multiply two integers (with optional third parameter)
        public int Multiply(int a, int b, int factor = 1)
        {
            return a * b * factor;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Calling the Add method with different parameter combinations
            int sum1 = calc.Add(2, 3);            // a=2, b=3, c=0 (default)
            int sum2 = calc.Add(2, 3, 5);         // a=2, b=3, c=5
            int sum3 = calc.Add(2, 3, c: 10);     // a=2, b=3, c=10

            // Displaying the results
            Console.WriteLine($"Sum of 2 and 3: {sum1}");      // Output: Sum of 2 and 3: 5
            Console.WriteLine($"Sum of 2, 3, and 5: {sum2}");  // Output: Sum of 2, 3, and 5: 10
            Console.WriteLine($"Sum of 2, 3, and 10: {sum3}"); // Output: Sum of 2, 3, and 10: 15

            // Calling the Multiply method with different parameter combinations
            int product1 = calc.Multiply(4, 5);            // a=4, b=5, factor=1 (default)
            int product2 = calc.Multiply(4, 5, 2);         // a=4, b=5, factor=2
            int product3 = calc.Multiply(4, 5, factor: 3); // a=4, b=5, factor=3

            // Displaying the results
            Console.WriteLine($"Product of 4 and 5: {product1}");       // Output: Product of 4 and 5: 20
            Console.WriteLine($"Product of 4, 5, and 2: {product2}");   // Output: Product of 4, 5, and 2: 40
            Console.WriteLine($"Product of 4, 5, and 3: {product3}");   // Output: Product of 4, 5, and 3: 60
        }
    }

}
}
