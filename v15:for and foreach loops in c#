namespace v15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define questions and answers (modify these for your quiz)
            string[] questions = { "What is the capital of France?", "What is the largest planet in our solar system?" };
            string[] answers = { "Paris", "Jupiter" };

            int score = 0;

            // Loop through questions using for loop
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine("Question {0}: {1}", i + 1, questions[i]); // Display question number and text

                string userAnswer = Console.ReadLine().ToLower(); // Read user input and convert to lowercase

                if (userAnswer == answers[i].ToLower()) // Compare answers (case-insensitive)
                {
                    Console.WriteLine("Correct!");
                    score++;  // Increment score if answer is correct
                }
                else
                {
                    Console.WriteLine("Incorrect. The answer is: " + answers[i]);
                }
            }

            Console.WriteLine("Your final score: " + score + " out of " + questions.Length);
        }
    }
}
