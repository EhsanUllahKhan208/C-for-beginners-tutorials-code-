namespace v41
{
    internal class Program
    {
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
                // Re-throw for further handling (optional)
                // throw new ApplicationException("Error reading marks file!", ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid marks format in file!");
                // Re-throw for further handling (optional)
                // throw new InvalidDataException("Error: Invalid marks format in file!", ex);
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
                    Console.WriteLine("Warning: Skipping invalid mark: {0}", markStr);
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
