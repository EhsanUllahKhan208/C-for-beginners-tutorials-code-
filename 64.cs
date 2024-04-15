namespace v64
{
    internal class Program
    {

public class MyCollection
    {
        private string[] elements = new string[10];

        // Indexer definition
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                return elements[index];
            }
            set
            {
                if (index < 0 || index >= elements.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                elements[index] = value;
            }
        }
    }

    public class Program1
    {
        public static void Main(string[] args)
        {
            MyCollection collection = new MyCollection();

            // Assigning values using indexer
            collection[0] = "First";
            collection[1] = "Second";
            collection[2] = "Third";

            // Retrieving values using indexer
            Console.WriteLine(collection[0]); // Output: First
            Console.WriteLine(collection[1]); // Output: Second
            Console.WriteLine(collection[2]); // Output: Third

            // Attempting to access out-of-range index (will throw an exception)
            try
            {
                Console.WriteLine(collection[10]); // This will throw IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

}
}
