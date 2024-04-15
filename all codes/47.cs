namespace v47
{
    internal class Program
    {
        

public class tr
    {
        // Define an enum named Fruit
        public enum Fruit
        {
            Apple,
            Orange,
            Banana,
            Mango
        }

        public static void Main(string[] args)
        {
            // Using enums in C#

            // Assigning an enum value to a variable
            Fruit myFruit = Fruit.Orange;

            // Switch statement with enums
            Console.WriteLine("Switch statement with enums:");
            switch (myFruit)
            {
                case Fruit.Apple:
                    Console.WriteLine("Selected fruit: Apple");
                    break;
                case Fruit.Orange:
                    Console.WriteLine("Selected fruit: Orange");
                    break;
                case Fruit.Banana:
                    Console.WriteLine("Selected fruit: Banana");
                    break;
                case Fruit.Mango:
                    Console.WriteLine("Selected fruit: Mango");
                    break;
                default:
                    Console.WriteLine("Unknown fruit");
                    break;
            }

            // Enum iteration
            Console.WriteLine("\nIterating over all enum values:");
            foreach (Fruit fruit in Enum.GetValues(typeof(Fruit)))
            {
                Console.WriteLine(fruit);
            }

            // Getting enum value by name
            string fruitName = "Banana";
            Fruit parsedFruit;
            if (Enum.TryParse<Fruit>(fruitName, out parsedFruit))
            {
                Console.WriteLine($"\nParsed fruit: {parsedFruit}");
            }
            else
            {
                Console.WriteLine("\nInvalid fruit name");
            }
        }
    }

}
}
