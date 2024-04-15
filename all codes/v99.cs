namespace v99
{
    internal class Program
    {
     

class Program1
    {
        static void Main()
        {
            // Lambda expression with no parameters
            Func<int> getRandomNumber = () => new Random().Next(1, 101);
            Console.WriteLine($"Random number: {getRandomNumber()}");

            // Lambda expression with one parameter
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Square of 5: {square(5)}");

            // Lambda expression with multiple parameters
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"Sum of 3 and 7: {add(3, 7)}");

            // Using lambda expression in LINQ
            int[] numbers = { 1, 2, 3, 4, 5 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            // Lambda expression as an event handler
            Button button = new Button();
            button.Click += (sender, e) =>
            {
                Console.WriteLine("Button clicked!");
            };

            // Simulate button click to invoke the event handler
            button.SimulateClick();
        }
    }

    // Example class for event handling
    class Button
    {
        public event EventHandler Click;

        public void SimulateClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }

}
}
