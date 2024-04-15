namespace v93
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
            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(IncrementCounter);
                threads[i].Start();
            }

            // Wait for all threads to complete
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine($"Final value of shared counter: {sharedCounter}");
        }

        static void IncrementCounter()
        {
            for (int i = 0; i < 10000; i++)
            {
                // Use lock to ensure mutual exclusion on the shared resource
                lock (lockObject)
                {
                    sharedCounter++;
                }
            }
        }
    }

}
}
