namespace v73
{
    internal class Program
    {

class Program1
    {
        static void Main()
        {
            // Creating a new Dictionary to store student scores (string keys and int values)
            Dictionary<string, int> studentScores = new Dictionary<string, int>();

            // Adding key-value pairs to the dictionary using Add method
            studentScores.Add("Alice", 95);
            studentScores.Add("Bob", 87);
            studentScores.Add("Charlie", 91);

            // Displaying all keys and values in the dictionary
            Console.WriteLine("Initial Dictionary:");
            foreach (var pair in studentScores)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine();

            // Checking if a key exists in the dictionary using ContainsKey
            string searchKey = "Bob";
            if (studentScores.ContainsKey(searchKey))
            {
                Console.WriteLine($"{searchKey} exists in the dictionary.");
            }
            else
            {
                Console.WriteLine($"{searchKey} does not exist in the dictionary.");
            }
            Console.WriteLine();

            // Retrieving value associated with a key using TryGetValue
            string retrieveKey = "Alice";
            if (studentScores.TryGetValue(retrieveKey, out int aliceScore))
            {
                Console.WriteLine($"Score of {retrieveKey}: {aliceScore}");
            }
            else
            {
                Console.WriteLine($"{retrieveKey} not found in the dictionary.");
            }
            Console.WriteLine();

            // Removing a key-value pair from the dictionary using Remove
            string removeKey = "Charlie";
            studentScores.Remove(removeKey);
            Console.WriteLine($"Removed {removeKey} from the dictionary.");
            Console.WriteLine();

            // Displaying remaining keys and values in the dictionary after removal
            Console.WriteLine("Dictionary after removal:");
            foreach (var pair in studentScores)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }
            Console.WriteLine();

            // Using Keys property to display all keys in the dictionary
            Console.WriteLine("Keys in the dictionary:");
            foreach (var key in studentScores.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            // Using Values property to display all values in the dictionary
            Console.WriteLine("Values in the dictionary:");
            foreach (var value in studentScores.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // Clearing the dictionary using Clear method
            studentScores.Clear();
            Console.WriteLine("Dictionary cleared. Count: " + studentScores.Count);
        }
    }

}
}
