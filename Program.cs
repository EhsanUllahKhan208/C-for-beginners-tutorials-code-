namespace v36
{
    internal class Program
    {
        public delegate int MathOperation(int a); // Delegate for math operations

        static int Square(int x) { return x * x; } // Method to square a number
        static int Double(int x) { return x * 2; }   // Method to double a number

        static void Main(string[] args)
        {
            // Create delegate instances and assign methods
            MathOperation operation1 = Square;
            MathOperation operation2 = Double;

            // Invoke the delegate instances
            int result1 = operation1(5); // result1 will be 25 (5 squared)
            int result2 = operation2(10); // result2 will be 20 (10 doubled)

            Console.WriteLine("5 squared: {0}", result1);
            Console.WriteLine("10 doubled: {0}", result2);
        }

    }
}
