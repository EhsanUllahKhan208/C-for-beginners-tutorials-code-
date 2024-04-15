namespace v13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 1;

            while (count <= 5)
            {
                Console.WriteLine("Count: " + count);
                count++;  // Increment count by 1 after each iteration
            }
            int number = 0;

            do
            {
                Console.WriteLine("Number: " + number);
                number++;  // Increment number by 1 after each iteration
            } while (number < 3);
            for (int i = 0; i < 10; i++)  // i starts at 0, iterates until i < 10, increments i by 1 after each iteration
            {
                Console.WriteLine("Iteration: " + i);
            }
            string[] names = { "Alice", "Bob", "Charlie" };

            foreach (string name in names)
            {
                Console.WriteLine("Name: " + name);
            }

        }
    }
}
