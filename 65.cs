namespace v65
{
    internal class Program
    {
       

public class ShoppingCart
    {
        private string[] items = new string[10];

        // Indexer declaration for accessing items array
        public string this[int index]
        {
            get
            {
                // Check if the index is within bounds
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                // Return the item at the specified index
                return items[index];
            }
            set
            {
                // Check if the index is within bounds
                if (index < 0 || index >= items.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                // Set the item at the specified index
                items[index] = value;
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();

            // Setting values using the indexer
            cart[0] = "Product A";
            cart[1] = "Product B";
            cart[2] = "Product C";

            // Getting values using the indexer and printing them
            Console.WriteLine("Items in the shopping cart:");
            for (int i = 0; i < 3; i++) // Looping through a few indices
            {
                Console.WriteLine($"Item {i + 1}: {cart[i]}");
            }

            // Trying to access an out-of-range index (will throw an exception)
            try
            {
                Console.WriteLine(cart[10]); // This will throw IndexOutOfRangeException
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }

}
}
