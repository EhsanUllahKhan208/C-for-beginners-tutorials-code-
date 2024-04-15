namespace v68
{
    internal class Program
    {


public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers (third parameter is optional with default value)
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two integers with an optional third parameter (default value)
        public int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // Calling the Add method with different parameter combinations
            int sum1 = calc.Add(2, 3);              // Calls Add(int a, int b)
            int sum2 = calc.Add(2, 3, 5);           // Calls Add(int a, int b, int c)
            int sum3 = calc.Add(2, 3, c: 10);       // Calls Add(int a, int b, int c)

            // Displaying the results
            Console.WriteLine($"Sum of 2 and 3: {sum1}");

        }
    }
