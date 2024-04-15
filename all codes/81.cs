using System.Collections.ObjectModel;

namespace v81
{
    internal class Program
    {


class Program1
    {
        static void Main()
        {
            // Example 1: TrueForAll method
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };

            // Check if all numbers in the list are even
            bool allEven = numbers.TrueForAll(x => x % 2 == 0);

            Console.WriteLine($"All numbers are even: {allEven}"); // Output: True

            Console.WriteLine();

            // Example 2: AsReadOnly method
            List<string> colors = new List<string> { "Red", "Green", "Blue" };

            // Get a read-only wrapper around the list
            ReadOnlyCollection<string> readOnlyColors = colors.AsReadOnly();

            // Attempting to modify the read-only collection (will throw exception)
            // readOnlyColors.Add("Yellow"); // This will throw NotSupportedException

            // Accessing elements in the read-only collection
            Console.WriteLine("Read-only Colors:");
            foreach (var color in readOnlyColors)
            {
                Console.WriteLine(color);
            }

            Console.WriteLine();

            // Example 3: TrimExcess method
            List<int> largeList = new List<int>(100);

            // Add elements to the list
            for (int i = 0; i < 50; i++)
            {
                largeList.Add(i);
            }

            Console.WriteLine($"Capacity before adding elements: {largeList.Capacity}"); // Output: 100

            // Remove elements from the list
            largeList.RemoveRange(10, 30); // Removing elements from index 10 to 39

            Console.WriteLine($"Capacity after removal: {largeList.Capacity}"); // Output: 100

            // Trim excess capacity
            largeList.TrimExcess();

            Console.WriteLine($"Capacity after trim: {largeList.Capacity}"); // Output: 50
        }
    }

}
}
