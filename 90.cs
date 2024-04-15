namespace v90
{
    internal class Program
    {
       

class Program1
    {
        static void Main()
        {
            // Define data to be passed to the thread
            string message = "Hello from the thread!";
            int count = 5;

            // Start a new thread using a lambda expression
            Thread thread = new Thread(() =>
            {
                ThreadMethod(message, count); // Call the thread method with parameters
            });

            // Start the thread
            thread.Start();

            Console.WriteLine("Main thread is running...");
        }

        static void ThreadMethod(string message, int count)
        {
            Console.WriteLine($"New thread started. Received message: {message}");

            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine($"Thread is running. Iteration {i}");
                Thread.Sleep(1000); // Simulate work using Thread.Sleep
            }

            Console.WriteLine("Thread completed its work.");
        }
    }

}
}
