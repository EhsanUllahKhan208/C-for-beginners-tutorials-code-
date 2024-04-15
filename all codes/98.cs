namespace v98
{
    internal class Program
    {
    

class Program1
    {
        // Define a delegate type for displaying a message
        delegate void DisplayMessage(string message);

        static void Main()
        {
            // Using an anonymous method with delegate instantiation
            DisplayMessage messageDelegate = delegate (string message)
            {
                Console.WriteLine($"Anonymous method: {message}");
            };

            // Invoke the delegate with an anonymous method
            messageDelegate("Hello, world!");

            // Using a lambda expression with delegate instantiation
            DisplayMessage anotherDelegate = (string message) =>
            {
                Console.WriteLine($"Lambda expression: {message}");
            };

            // Invoke the delegate with a lambda expression
            anotherDelegate("Goodbye!");

            // Using a lambda expression directly without explicitly defining a delegate type
            Action<string> actionDelegate = (string message) =>
            {
                Console.WriteLine($"Action delegate: {message}");
            };

            // Invoke the Action delegate with a lambda expression
            actionDelegate("This is an action delegate");

            // Using a Func delegate with a lambda expression that returns a value
            Func<int, int, int> addDelegate = (a, b) =>
            {
                return a + b;
            };

            // Invoke the Func delegate with a lambda expression
            int result = addDelegate(5, 3);
            Console.WriteLine($"Result of addition: {result}");
        }
    }

}
}
