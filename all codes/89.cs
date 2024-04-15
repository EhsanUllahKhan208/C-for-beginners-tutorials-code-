namespace v89
{
    internal class Program
    {
    

class Program1
    {
        static void Main()
        {
            // Create a ParameterizedThreadStart delegate pointing to the ThreadMethod
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ThreadMethod);

            // Create a new thread and specify the ParameterizedThreadStart delegate
            Thread thread = new Thread(threadStart);

            // Start the thread with a parameter
            string message = "Hello, from the new thread!";
            thread.Start(message);

            Console.WriteLine("Main thread is running...");
        }

        static void ThreadMethod(object obj)
        {
            string message = (string)obj; // Cast the object back to string
            Console.WriteLine("New thread started. Received message: " + message);
            Thread.Sleep(2000); // Simulate work using Thread.Sleep
            Console.WriteLine("New thread completed its work.");
        }
    }

}
}
