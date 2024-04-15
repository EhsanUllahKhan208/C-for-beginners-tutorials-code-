namespace v94
{
    internal class Program
    {
       

class Program1
    {
        private static object lockObject = new object();
        private static int sharedCounter = 0;

        static void Main(string[] args)
        {
            // Create multiple threads that increment the shared counter
            Thread[] lockThreads = new Thread[3];
            Thread[] monitorThreads = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                lockThreads[i] = new Thread(IncrementCounterWithLock);
                lockThreads[i].Start();

                monitorThreads[i] = new Thread(IncrementCounterWithMonitor);
                monitorThreads[i].Start();
            }

            // Wait for all lock threads to complete
            foreach (Thread thread in lockThreads)
            {
                thread.Join();
            }

            Console.WriteLine($"Final value of shared counter (using lock): {sharedCounter}");

            // Reset shared counter
            sharedCounter = 0;

            // Wait for all monitor threads to complete
            foreach (Thread thread in monitorThreads)
            {
                thread.Join();
            }

            Console.WriteLine($"Final value of shared counter (using Monitor): {sharedCounter}");
        }

        static void IncrementCounterWithLock()
        {
            for (int i = 0; i < 10000; i++)
            {
                // Use lock statement to ensure mutual exclusion on the shared resource
                lock (lockObject)
                {
                    sharedCounter++;
                }
            }
        }

        static void IncrementCounterWithMonitor()
        {
            for (int i = 0; i < 10000; i++)
            {
                // Explicitly acquire and release the lock using Monitor class
                Monitor.Enter(lockObject);
                try
                {
                    sharedCounter++;
                }
                finally
                {
                    Monitor.Exit(lockObject);
                }
            }
        }
    }

}
}
