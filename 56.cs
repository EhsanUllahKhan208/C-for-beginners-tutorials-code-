namespace v56
{
    internal class Program
    {
        
public class Stack<T>
    {
        private T[] items;
        private int top; // index of the top element (or -1 if stack is empty)
        private const int DefaultCapacity = 10;

        public Stack()
        {
            items = new T[DefaultCapacity];
            top = -1;
        }

        public Stack(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be a positive number.");
            }

            items = new T[capacity];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                Array.Resize(ref items, items.Length * 2); // double the capacity
            }

            top++;
            items[top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T item = items[top];
            top--;
            return item;
        }

        public T Peek()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return items[top];
        }

        public int Count
        {
            get { return top + 1; }
        }

        public void Print()
        {
            Console.WriteLine("Stack Contents:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i]);
            }
        }
    }

    public static class Utility
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Demonstrate using Stack<T>
            Stack<int> intStack = new Stack<int>();

            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);

            Console.WriteLine("Stack Count: " + intStack.Count);
            int poppedValue = intStack.Pop();
            Console.WriteLine("Popped Value: " + poppedValue);

            Console.WriteLine("Top Value: " + intStack.Peek());
            intStack.Print();

            Console.WriteLine();

            // Demonstrate using Swap<T>
            int x = 5, y = 10;
            Console.WriteLine($"Before Swap: x = {x}, y = {y}");
            Utility.Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");

            string s1 = "Hello", s2 = "World";
            Console.WriteLine($"Before Swap: s1 = {s1}, s2 = {s2}");
            Utility.Swap(ref s1, ref s2);
            Console.WriteLine($"After Swap: s1 = {s1}, s2 = {s2}");
        }
    }

}
}
