namespace v72
{
    internal class Program
    {
        

public class Printer
    {
        // Method to print a message with optional emphasis
        public void PrintMessage(string message, bool? emphasize = null)
        {
            if (emphasize == true)
            {
                Console.WriteLine($"*{message}*");
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            // Calling the PrintMessage method with different parameter combinations
            printer.PrintMessage("Hello");          // Prints: Hello
            printer.PrintMessage("Welcome", true);  // Prints: *Welcome*
            printer.PrintMessage("Goodbye", false); // Prints: Goodbye
        }
    }

}
}
