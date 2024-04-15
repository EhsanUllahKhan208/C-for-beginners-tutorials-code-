namespace v85
{
    internal class Program
    {
       

class Program1
    {
        static Stack<string> browserHistory = new Stack<string>();

        static void Main()
        {
            // Simulate browsing history
            VisitPage("https://www.example.com");
            VisitPage("https://www.example.com/products");
            VisitPage("https://www.example.com/contact");
            VisitPage("https://www.example.com/about");

            // Display and navigate browser history
            Console.WriteLine("Browser History:");
            while (browserHistory.Count > 0)
            {
                string currentPage = browserHistory.Pop();
                Console.WriteLine(currentPage);

                // Simulate user navigating back (revisiting pages in reverse order)
                if (browserHistory.Count > 0)
                {
                    Console.WriteLine("Navigating back...");
                }
            }
        }

        static void VisitPage(string url)
        {
            browserHistory.Push(url);
            Console.WriteLine($"Visited: {url}");
        }
    }

}
}
