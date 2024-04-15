namespace v97
{
    internal class Program
    {

class Program1
    {
        static void Main()
        {
            int numThreads = 4;
            ManualResetEvent allThreadsComplete = new ManualResetEvent(false);

            for (int i = 0; i < numThreads; i++)
            {
                int threadNumber = i;
                ThreadPool.QueueUserWorkItem(state =>
                {
                    Console.WriteLine($"Thread {threadNumber} started.");
                    Thread.Sleep(1000); // Simulate work
                    Console.WriteLine($"Thread {threadNumber} completed.");

                    if (Interlocked.Decrement(ref numThreads) == 0)
                    {
                        allThreadsComplete.Set();
                    }
                });
            }

            allThreadsComplete.WaitOne();
            Console.WriteLine("All threads have completed.");
        }
    }

}
}
