namespace v17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers("Enter three numbers: ", 10, 20, 30);
            PrintNumbers("Enter two numbers: ", 5, 15);
        }
        public static void PrintNumbers(string message, params int[] numbers)
        {
            Console.WriteLine(message);
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

    }
}
