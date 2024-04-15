namespace v92
{
    internal class Program
    {



class Program1
    {
        static void Main()
        {
            Thread thread = new Thread(ThreadMethod);
            thread.Start();

            Console.WriteLine("Main thread is running...");

            // Wait for the thread to complete using Join()
            thread.Join();
            Console.WriteLine("Thread joined.");

            // Check if the thread is still alive using IsAlive
            if (thread.IsAlive)
            {
                Console.WriteLine("Thread is still running.");
            }
            else
            {
                Console.WriteLine("Thread has completed its execution.");
            }
        }

        static void ThreadMethod()
        {
            Console.WriteLine("Thread started...");
            Thread.Sleep(2000); // Simulate work
            Console.WriteLine("Thread completed.");
        }
    }

}
}
