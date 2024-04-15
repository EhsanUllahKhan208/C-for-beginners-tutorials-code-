namespace v100
{
    internal class Program
    {


class Program1
    {
        static void Main()
        {
            // Define a Func delegate that takes two integers and returns their sum
            Func<int, int, int> addFunc = (a, b) => a + b;

            // Define a Func delegate that checks if a number is even
            Func<int, bool> isEvenFunc = (num) => num % 2 == 0;

            // Define a Func delegate that calculates the length of a string
            Func<string, int> stringLengthFunc = (s) => s.Length;

            // Use the addFunc delegate to compute the sum of two numbers
            int result = addFunc(10, 20);
            Console.WriteLine($"Sum of 10 and 20: {result}");

            // Use the isEvenFunc delegate to check if a number is even
            int number = 15;
            bool isEven = isEvenFunc(number);
            Console.WriteLine($"{number} is even? {isEven}");

            // Use the stringLengthFunc delegate to get the length of a string
            string message = "Hello, World!";
            int length = stringLengthFunc(message);
            Console.WriteLine($"Length of '{message}': {length}");
        }
    }

}
}
