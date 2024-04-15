namespace v88
{
    internal class Program
    {
    

class Program1
    {
        static void Main()
        {
            // Create a new ThreadStart delegate pointing to the ThreadMethod
            ThreadStart threadStart = new ThreadStart(ThreadMethod);

            // Create a new thread and specify the ThreadStart delegate
            Thread thread = new Thread(threadStart);

            // Start the thread
            thread.Start();

            Console.WriteLine("Main thread is running...");
        }

        static void ThreadMethod()
        {
            Console.WriteLine("New thread started. Performing some work...");
            Thread.Sleep(2000); // Simulate work using Thread.Sleep
            Console.WriteLine("New thread completed its work.");
        }
    }

}
}
