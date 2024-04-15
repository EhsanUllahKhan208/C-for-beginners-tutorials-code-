using System.Reflection;

namespace v55
{
    internal class Program
    {
       
public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Cannot divide by zero.");

            return a / b;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an operation
            Console.Write("Enter operation (Add, Subtract, Multiply, Divide): ");
            string operation = Console.ReadLine();

            // Prompt the user to enter operands
            Console.Write("Enter first operand: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second operand: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            // Use reflection to dynamically invoke the selected operation
            Type calculatorType = typeof(Calculator);
            MethodInfo method = calculatorType.GetMethod(operation);

            if (method != null && method.IsPublic && !method.IsStatic)
            {
                try
                {
                    // Create an instance of the Calculator class
                    Calculator calculator = new Calculator();

                    // Invoke the method dynamically on the calculator instance
                    int result = (int)method.Invoke(calculator, new object[] { operand1, operand2 });
                    Console.WriteLine($"Result: {result}");
                }
                catch (TargetInvocationException ex)
                {
                    Console.WriteLine($"Error: {ex.InnerException.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid operation or method not found.");
            }
        }
    }

}
}
