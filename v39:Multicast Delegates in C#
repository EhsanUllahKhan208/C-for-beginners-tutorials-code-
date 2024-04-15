namespace v39
{
    internal class Program
    {
        public delegate void LogMessage(string message); // Delegate for logging messages

        static void ConsoleLog(string message) { Console.WriteLine(message); }
        static void FileLog(string message)
        {
            // Simulate writing to a file (replace with actual file I/O)
            System.IO.File.AppendAllText("log.txt", message + Environment.NewLine);
        }

        static void Main(string[] args)
        {
            LogMessage logDelegate = null; // Start with empty delegate

            // Add methods to the delegate
            logDelegate += ConsoleLog;
            logDelegate += FileLog;

            // Log messages (calls both ConsoleLog and FileLog)
            logDelegate("This is an informational message.");
            logDelegate("This is a warning message.");
        }

    }
}
