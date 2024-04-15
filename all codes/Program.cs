namespace v43
{
    internal class Program
    {
        public class InvalidMarksFormatException : Exception
        {
            public InvalidMarksFormatException() : base("Invalid format used for marks in the file.") { }

            public InvalidMarksFormatException(string message) : base(message) { }
        }

        static void Main(string[] args)
        {
            try
            {
                // Read marks from a file
                string[] marksStr = File.ReadAllLines("marks.txt");

                // Calculate average score
                double averageScore = CalculateAverageScore(marksStr);
                Console.WriteLine("Average Score: {0:F2}", averageScore);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Marks file not found!");
            }
            catch (InvalidMarksFormatException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message); // Informative message from custom exception
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        static double CalculateAverageScore(string[] marksStr)
        {
            double totalScore = 0;
            int validMarksCount = 0;

            foreach (string markStr in marksStr)
            {
                try
                {
                    int mark = int.Parse(markStr); // Might throw FormatException for invalid marks
                    totalScore += mark;
                    validMarksCount++;
                }
                catch (FormatException ex)
                {
                    throw new InvalidMarksFormatException("The value '" + markStr + "' is not a valid mark."); // Wrap FormatException
                }
            }

            if (validMarksCount == 0)
            {
                throw new InvalidDataException("No valid marks found in file!");
            }

            return totalScore / validMarksCount;
        }
    }
}
