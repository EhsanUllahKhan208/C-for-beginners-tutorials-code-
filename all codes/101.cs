namespace v101
{
    internal class Program
    {

class Program1
    {
        static async Task Main()
        {
            Console.WriteLine("Downloading web page...");

            // Call an asynchronous method using await
            string webpageContent = await DownloadWebPageAsync("https://example.com");

            // This line will execute after the DownloadWebPageAsync method completes
            Console.WriteLine($"Web page content length: {webpageContent.Length}");
        }

        static async Task<string> DownloadWebPageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Asynchronously send an HTTP GET request
                HttpResponseMessage response = await client.GetAsync(url);

                // Asynchronously read the response content as a string
                string content = await response.Content.ReadAsStringAsync();

                return content;
            }
        }
    }

}
}
