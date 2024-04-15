namespace v14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Secret number to guess
            int secretNumber = 7;
            int guess;

            // do-while loop to keep prompting for guesses until the correct number is entered
            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                guess = int.Parse(Console.ReadLine()); // Read user input and convert to integer

                if (guess == secretNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                }
                else
                {
                    Console.WriteLine("Try again. That wasn't the secret number.");
                }

            } while (guess != secretNumber); // Loop continues as long as guess is not equal to secretNumber
        }
    }
}
