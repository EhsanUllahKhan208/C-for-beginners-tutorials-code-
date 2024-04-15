namespace v40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Loop until valid input is received
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    string input = Console.ReadLine();

                    // Convert input to integer (might throw FormatException)
                    int number = int.Parse(input);

                    // Perform calculations (replace with your actual calculations)
                    int result = number * 2;
                    Console.WriteLine("Result: {0}", result);

                    break; // Exit loop if valid input is processed
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: Invalid input. Please enter a number.");
                }
            }
        }
    }
}
