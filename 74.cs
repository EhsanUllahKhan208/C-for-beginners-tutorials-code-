namespace v74
{
    internal class Program
    {
     

class Program1
    {
        static void Main()
        {
            // Creating a new List of integers
            List<int> numbers = new List<int>();

            // Adding elements to the list
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);

            // Displaying elements in the list
            Console.WriteLine("List elements:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Accessing elements by index
            Console.WriteLine($"Element at index 1: {numbers[1]}");
            Console.WriteLine();

            // Removing an element from the list
            numbers.Remove(20);

            // Inserting an element at a specific index
            numbers.Insert(1, 25);

            // Displaying modified list
            Console.WriteLine("Modified List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Sorting the list
            numbers.Sort();

            // Displaying sorted list
            Console.WriteLine("Sorted List:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Checking if an element exists in the list
            int searchNumber = 25;
            if (numbers.Contains(searchNumber))
            {
                Console.WriteLine($"List contains {searchNumber}.");
            }
            else
            {
                Console.WriteLine($"List does not contain {searchNumber}.");
            }
        }
    }

}
}
