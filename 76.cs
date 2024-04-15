namespace v76
{
    internal class Program
    {

class Program1
    {
        static void Main()
        {
            // Creating a new List of integers
            List<int> numbers = new List<int> { 10, 20, 30 };

            // Displaying the initial list
            Console.WriteLine("Initial List:");
            DisplayList(numbers);

            // Adding a range of elements to the end of the list
            List<int> newNumbers = new List<int> { 40, 50, 60 };
            numbers.AddRange(newNumbers);

            Console.WriteLine("\nList after adding range:");
            DisplayList(numbers);

            // Getting a subset (range) of elements from the list
            List<int> subset = numbers.GetRange(1, 3); // Starting from index 1, count 3
            Console.WriteLine("\nSubset of List (Index 1 to 3 exclusive):");
            DisplayList(subset);

            // Inserting a range of elements into the list at a specific index
            List<int> insertNumbers = new List<int> { 70, 80, 90 };
            numbers.InsertRange(2, insertNumbers); // Inserting at index 2

            Console.WriteLine("\nList after inserting range:");
            DisplayList(numbers);

            // Removing a range of elements from the list
            numbers.RemoveRange(4, 3); // Starting from index 4, remove 3 elements

            Console.WriteLine("\nList after removing range:");
            DisplayList(numbers);
        }

        // Helper method to display elements of a list
        static void DisplayList(List<int> list)
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
