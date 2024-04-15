namespace v75
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

            // Inserting an element at a specific index
            numbers.Insert(1, 15);

            // Removing an element from the list
            numbers.Remove(20);

            // Accessing elements by index
            int firstElement = numbers[0];

            // Checking if an element exists in the list
            bool containsElement = numbers.Contains(10);

            // Sorting the list
            numbers.Sort();

            // Iterating over elements using foreach loop
            Console.WriteLine("Elements in the list:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Getting the number of elements and capacity
            int count = numbers.Count;
            int capacity = numbers.Capacity;

            Console.WriteLine($"Number of elements: {count}");
            Console.WriteLine($"Capacity of the list: {capacity}");

            // Clearing the list
            numbers.Clear();

            Console.WriteLine("List cleared. Number of elements: " + numbers.Count);
        }
    }

}
}
