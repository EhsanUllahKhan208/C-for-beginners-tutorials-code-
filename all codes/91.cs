namespace v91
{
    internal class Program
    {
       

class Program1
    {
        static void Main()
        {
            // Start a new thread and provide a callback method to retrieve data
            ThreadStart threadStart = new ThreadStart(() =>
            {
                string result = GetDataFromThread();
                OnThreadCompleted(result); // Invoke callback method with the result
            });

            Thread thread = new Thread(threadStart);
            thread.Start();

            Console.WriteLine("Main thread is running...");
            Console.ReadLine(); // Keep the console application running
        }

        static string GetDataFromThread()
        {
            // Simulate a time-consuming operation
            Thread.Sleep(3000);

            // Return the data (for example, a string)
            return "Data retrieved from the thread.";
        }

        static void OnThreadCompleted(string result)
        {
            Console.WriteLine("Thread operation completed.");
            Console.WriteLine("Result: " + result);

            // Handle the retrieved data (e.g., update UI, process the result, etc.)
        }
    }

}
}
