namespace v102
{
    internal class Program
    {
    

class Program1
    {
        static async Task Main()
        {
            Console.WriteLine("Main thread is starting...");

            // Start a new background thread
            Task backgroundTask = Task.Run(() =>
            {
                Console.WriteLine("Background thread is running...");
                Thread.Sleep(3000); // Simulate some work
                Console.WriteLine("Background thread is done.");
            });

            // Perform other tasks on the main thread while waiting for the background thread
            Console.WriteLine("Main thread is doing other work...");

            // Asynchronously wait for the backgroundTask to complete
            await backgroundTask;

            // Continue with main thread execution after the background thread completes
            Console.WriteLine("Main thread resumes after background thread.");

            // Do more work on the main thread
            Console.WriteLine("Main thread is finishing...");
        }
    }

}
}
