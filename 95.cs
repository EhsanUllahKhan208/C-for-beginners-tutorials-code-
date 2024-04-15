namespace v95
{
    internal class Program
    {
      

class Program1
    {
        static object lockObjectX = new object();
        static object lockObjectY = new object();

        static void Main()
        {
            Thread threadA = new Thread(() =>
            {
                lock (lockObjectX)
                {
                    Console.WriteLine("Thread A locked Resource X");
                    Thread.Sleep(1000); // Simulate work
                    Console.WriteLine("Thread A waiting to lock Resource Y");
                    lock (lockObjectY)
                    {
                        Console.WriteLine("Thread A locked Resource Y");
                        // Access Resource Y
                    }
                }
            });

            Thread threadB = new Thread(() =>
            {
                lock (lockObjectY)
                {
                    Console.WriteLine("Thread B locked Resource Y");
                    Thread.Sleep(1000); // Simulate work
                    Console.WriteLine("Thread B waiting to lock Resource X");
                    lock (lockObjectX)
                    {
                        Console.WriteLine("Thread B locked Resource X");
                        // Access Resource X
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
