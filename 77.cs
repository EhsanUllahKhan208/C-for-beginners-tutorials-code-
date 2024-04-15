namespace v77
{
    internal class Program
    {
     

class Program1
    {
        static void Main()
        {
            // Sorting a List<int>
            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };

            Console.WriteLine("Original List (integers):");
            DisplayList(numbers);

            numbers.Sort(); // Sorting the list in ascending order

            Console.WriteLine("\nSorted List (integers - ascending):");
            DisplayList(numbers);

            // Sorting a List<string>
            List<string> names = new List<string> { "John", "Alice", "Bob", "Eve", "Charlie" };

            Console.WriteLine("\nOriginal List (strings):");
            DisplayList(names);

            names.Sort(); // Sorting the list in alphabetical order

            Console.WriteLine("\nSorted List (strings - alphabetical order):");
            DisplayList(names);
        }

        // Helper method to display elements of a list
        static void DisplayList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
}
