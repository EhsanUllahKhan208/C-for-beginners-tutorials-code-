namespace v62
{
    internal class Program
    {
        // Part 1: Declaration of partial class (Part1.cs)
        public partial class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        // Part 2: Declaration of partial class (Part2.cs)
        public partial class Person
        {
            public int Age { get; set; }

            // Constructor
            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            // Method to display person's details
            public void DisplayDetails()
            {
                Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}");
            }
        }

        // Main program to use the partial class
        class Program1
        {
            static void Main(string[] args)
            {
                // Creating an instance of Person using the constructor from Part2.cs
                Person person = new Person("John", "Doe", 30);

                // Displaying person's details using DisplayDetails() method from Part2.cs
                person.DisplayDetails();
            }
        }
    }
}
