namespace v86
{
    internal class Program
    {
       

class Program1
    {
        static void Main()
        {
            // Start multiple tasks concurrently
            Task task1 = Task.Run(() => DoWork("Task 1"));
            Task task2 = Task.Run(() => DoWork("Task 2"));
            Task task3 = Task.Run(() => DoWork("Task 3"));

            // Wait for all tasks to complete
            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("All tasks have completed.");
        }

        static void DoWork(string taskName)
        {
            Console.WriteLine($"{taskName} starting...");
            // Simulate some work
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{taskName} is working... Step {i}");
                Task.Delay(1000).Wait(); // Simulate work using Task.Delay
            }
            Console.WriteLine($"{taskName} completed.");
        }
    }

}
}
