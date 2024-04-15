namespace v59
{
    internal class Program
    {
       

public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Override ToString() to provide custom string representation
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Create a Person object
            Person person = new Person("John", "Doe");

            // Using ToString() method
            string personString = person.ToString();
            Console.WriteLine("Using ToString(): " + personString); // Output: John Doe

            // Using Convert.ToString() with a null object
            Person nullPerson = null;
            string nullString = Convert.ToString(nullPerson);
            Console.WriteLine("Using Convert.ToString(): " + nullString); // Output: ""
        }
    }

}
}
