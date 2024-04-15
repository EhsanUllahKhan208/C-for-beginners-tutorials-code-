namespace v83
{
    internal class Program
    {
        

class Program1
    {
        static void Main()
        {
            // Creating a stack of integers
            Stack<int> stack = new Stack<int>();

            // Push elements onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            // Displaying the elements in the stack
            Console.WriteLine("Stack elements:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            // Pop elements from the stack
            int poppedItem = stack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");

            // Peek at the next item without removing it
            int topItem = stack.Peek();
            Console.WriteLine($"Top item in stack: {topItem}");

            // Display the updated stack after pop operation
            Console.WriteLine("Updated Stack elements:");
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }

            // Clear the stack
            stack.Clear();
            Console.WriteLine($"Stack is cleared. Count: {stack.Count}");
        }
    }

}
}
