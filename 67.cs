namespace v67
{
    internal class Program
    {
        

public class Calculator
    {
        // Method overloading to handle different parameter combinations
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Using optional parameters (C# 4.0 and later)
        public int Multiply(int a, int b, int c = 1)
        {
            return a * b * c;
        }

        // Using Nullable<T> for optional value type parameters
        public void PrintNumber(int? number)
        {
            if (number.HasValue)
            {
                Console.WriteLine($"Received number: {number.Value}");
            }
            else
            {
                Console.WriteLine("No number provided");
            }
        }

        // Using method chaining and fluent APIs for configuration
        public class Configuration
        {
            private bool isEnabled = false;
            private int threshold = 0;

            public Configuration Enable(bool enabled = true)
            {
                isEnabled = enabled;
                return this;
            }

            public Configuration SetThreshold(int value)
            {
                threshold = value;
                return this;
            }

            public void Apply()
            {
                Console.WriteLine($"Configuration applied: Enabled={isEnabled}, Threshold={threshold}");
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Method overloading example
            Console.WriteLine("Method overloading:");
            Console.WriteLine($"Sum of 2 and 3: {calc.Add(2, 3)}");              // Calls Add(int a, int b)
            Console.WriteLine($"Sum of 2, 3, and 5: {calc.Add(2, 3, 5)}");     // Calls Add(int a, int b, int c)

            // Optional parameters example
            Console.WriteLine("\nOptional parameters:");
            Console.WriteLine($"Product of 2, 3, and default (1): {calc.Multiply(2, 3)}");         // Calls Multiply(int a, int b, int c = 1)
            Console.WriteLine($"Product of 2, 3, and 4: {calc.Multiply(2, 3, 4)}");              // Calls Multiply(int a, int b, int c)

            // Nullable<T> for optional value type parameters example
            Console.WriteLine("\nNullable<T> for optional value type parameters:");
            calc.PrintNumber(10);       // Output: Received number: 10
            calc.PrintNumber(null);     // Output: No number provided

            // Method chaining and fluent APIs example
            Console.WriteLine("\nMethod chaining and fluent APIs:");
            Calculator.Configuration config = new Calculator.Configuration();
            config.Enable().SetThreshold(100).Apply();   // Apply configuration with default values

            // Another configuration example
            Console.WriteLine("\nAnother configuration example:");
            config.Enable(false).SetThreshold(50).Apply();   // Apply configuration with custom values
        }
    }

}
}
