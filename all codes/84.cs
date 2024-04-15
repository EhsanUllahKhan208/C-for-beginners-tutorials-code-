namespace v84
{
    internal class Program
    {
      

class Program1
    {
        static Queue<Action> taskQueue = new Queue<Action>();
        static object lockObject = new object();

        static void Main()
        {
            // Enqueue tasks (actions) into the task queue
            EnqueueTask(() => Console.WriteLine("Task 1"));
            EnqueueTask(() => Console.WriteLine("Task 2"));
            EnqueueTask(() => Console.WriteLine("Task 3"));

            // Start worker threads to process tasks concurrently
            StartWorkerThreads(2);

            Console.WriteLine("Tasks enqueued. Press any key to exit...");
            Console.ReadKey();
        }

        static void EnqueueTask(Action task)
        {
            lock (lockObject)
            {
                taskQueue.Enqueue(task);
                Monitor.PulseAll(lockObject); // Notify waiting threads
            }
        }

        static void StartWorkerThreads(int numThreads)
        {
            for (int i = 0; i < numThreads; i++)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        Action task = null;
                        lock (lockObject)
                        {
                            while (taskQueue.Count == 0)
                            {
                                Monitor.Wait(lockObject); // Wait for tasks
                            }
                            task = taskQueue.Dequeue();
                        }
                        task?.Invoke(); // Execute the task
                    }
                });
            }
        }
    }

}
}
