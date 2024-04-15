namespace v63
{
    internal class Program
    {// Rule: Same class name and same namespace
        public partial class Logger
        {
            // Rule: Partial method declaration
            partial void LogMessage(string message); // Declaration of partial method
        }
        public partial class Logger
        {
            // Rule: Partial method implementation
            partial void LogMessage(string message)
            {
                Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
            }

            // Rule: Public method calling the partial method
            public void Log(string message)
            {
                LogMessage(message); // Calls the partial method (implementation may be optional)
            }
        }
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            // Rule: Creating an instance of Logger
            logger.Log("Hello, world!"); // Calls the Log method which internally calls LogMessage
        }
    }
}
