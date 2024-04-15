namespace v87
{
    internal class Program
    {
     

class Program1
    {
        static void Main()
        {
            // Start multiple tasks concurrently
            Task task1 = Task.Run(() => SimulateTask("Task 1", 3000)); // SimulateTask will run for 3 seconds
            Task task2 = Task.Run(() => SimulateTask("Task 2", 2000)); // SimulateTask will run for 2 seconds
            Task task3 = Task.Run(() => SimulateTask("Task 3", 4000)); // SimulateTask will run for 4 seconds

            Console.WriteLine("Main thread continues executing...");

            // Wait for all tasks to complete
            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("All tasks have completed.");
        }

        static void SimulateTask(string taskName, int durationMs)
        {
            Console.WriteLine($"{taskName} starting...");
            Task.Delay(durationMs).Wait(); // Simulate work using Task.Delay
            Console.WriteLine($"{taskName} completed after {durationMs} ms.");
        }
    }

}
}
