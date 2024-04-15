namespace v58
{
    internal class Program
    {
       

public class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            // Check if the obj parameter is null or not of the same type
            if (obj == null || !(obj is Person))
                return false;

            // Cast obj to Person type for property comparison
            Person otherPerson = (Person)obj;

            // Compare individual properties for equality
            return FirstName == otherPerson.FirstName &&
                   LastName == otherPerson.LastName &&
                   Age == otherPerson.Age;
        }

        public override int GetHashCode()
        {
            // Combine hash codes of individual properties using XOR (^) operator
            return HashCode.Combine(FirstName, LastName, Age);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Create instances of Person
            Person person1 = new Person("John", "Doe", 30);
            Person person2 = new Person("John", "Doe", 30);
            Person person3 = new Person("Jane", "Smith", 25);

            // Test equality using overridden Equals method
            Console.WriteLine("Equality Test:");
            Console.WriteLine($"person1.Equals(person2): {person1.Equals(person2)}"); // true
            Console.WriteLine($"person1.Equals(person3): {person1.Equals(person3)}"); // false

            // Test hash code generation
            Console.WriteLine("\nHash Codes:");
            Console.WriteLine($"person1.GetHashCode(): {person1.GetHashCode()}");
            Console.WriteLine($"person2.GetHashCode(): {person2.GetHashCode()}");
            Console.WriteLine($"person3.GetHashCode(): {person3.GetHashCode()}");
        }
    }

}
}
