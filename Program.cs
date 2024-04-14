namespace v8Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[1000];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 2;  
            }
  
            int specificNumber = numbers[50]; 

            Console.WriteLine(specificNumber);

            // fixed size
            string[] names = new string[5]; 

            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";

            Console.WriteLine(names.Length); 


        }
    }
}
