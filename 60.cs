using System.Text;

namespace v60
{
    internal class Program
    {
        

class Program1
    {
        static void Main(string[] args)
        {
            // Using System.String (immutable)
            string fullName = "John";
            fullName += " Doe"; // Creates a new string object
            Console.WriteLine("Using System.String: " + fullName); // Output: John Doe

            // Using System.Text.StringBuilder (mutable)
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello");
            stringBuilder.Append(" ");
            stringBuilder.Append("World");
            Console.WriteLine("Using System.Text.StringBuilder: " + stringBuilder.ToString()); // Output: Hello World
        }
    }

}
}
