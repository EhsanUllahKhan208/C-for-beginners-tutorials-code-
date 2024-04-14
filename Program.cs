namespace v6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25; 

            int? maybeAge; 

            maybeAge = null;  

            if (maybeAge.HasValue) 
            {
                Console.WriteLine("The age is: " + maybeAge.Value); 
            }
            else
            {
                Console.WriteLine("Age is unknown");
            }

        }
    }
}
