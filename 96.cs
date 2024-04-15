namespace v96
{
    internal class Program
    {


class Program1
    {
        private static object lockObject1 = new object();
        private static object lockObject2 = new object();

        static void Main()
        {
            Thread threadA = new Thread(() =>
            {
                lock (lockObject1)
                {
                    Console.WriteLine("Thread A locked Resource 1");
                    Thread.Sleep(1000); // Simulate work
                    Console.WriteLine("Thread A waiting to lock Resource 2");
                    lock (lockObject2)
                    {
                        Console.WriteLine("Thread A locked Resource 2");
                        // Access Resource 1 and Resource 2
                    }
                }
            });

            Thread threadB = new Thread(() =>
            {
                // Acquire locks in the same order to prevent deadlock
                lock (lockObject1)
                {
                    Console.WriteLine("Thread B locked Resource 1");
                    Thread.Sleep(1000); // Simulate work
                    Console.WriteLine("Thread B waiting to lock Resource 2");
                    lock (lockObject2)
                    {
                        Console.WriteLine("Thread B locked Resource 2");
                        // Access Resource 1 and Resource 2
                    }
                }
            });

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            Console.WriteLine("Program completed.");
        }
    }

}
}
