namespace v44
{
    internal class Program
    {
        public class InvalidDataException : Exception
        {
            public InvalidDataException() : base("Invalid data encountered while processing the file.") { }

            public InvalidDataException(string message) : base(message) { }
        }

        static void Main(string[] args)
        {
            string filePath = "data.txt"; // Replace with your actual file path

            // Validate file existence before processing
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error: File '{0}' does not exist!", filePath);
                return; // Exit program if file is missing
            }

            try
            {
                // Read data from the file
                string[] dataLines = File.ReadAllLines(filePath);

                // Process data with explicit validation (replace with your actual logic)
                ProcessData(dataLines);
            }
            catch (IOException ex) // Catch general I/O errors
            {
                Console.WriteLine("Error: An I/O error occurred while processing the file!");
                Console.WriteLine("Details: {0}", ex.Message); // Log or handle appropriately
            }
            catch (InvalidDataException ex) // Catch specific data format errors
            {
                Console.WriteLine("Error: Invalid data format encountered in the file!");
                Console.WriteLine("Details: {0}", ex.Message); // Log or handle specifically
            }
        }

        static void ProcessData(string[] dataLines)
        {
            foreach (string line in dataLines)
            {
                // Validate data before using it (replace with specific validation logic)
                if (string.IsNullOrEmpty(line))
                {
                    throw new InvalidDataException("Empty line found in data!");
                }

                // Process valid data (replace with your actual processing logic)
                // ...
            }
        }
    }
}
