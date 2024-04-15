namespace v78
{
    internal class Program
    {
    

public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Implementing IComparable<T> for sorting by Name
        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            return string.Compare(Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name} (Age: {Age})";
        }
    }

    class Program1
    {
        static void Main()
        {
            // Creating a List of Person objects
            List<Person> people = new List<Person>
        {
            new Person("Alice", 25),
            new Person("Charlie", 30),
            new Person("Bob", 20),
            new Person("Eve", 22)
        };

            // Displaying the original list
            Console.WriteLine("Original List:");
            DisplayList(people);

            // Sorting the list by Name using the Sort method
            people.Sort();

            // Displaying the sorted list
            Console.WriteLine("\nSorted List (by Name):");
            DisplayList(people);
        }

        // Helper method to display elements of a list
        static void DisplayList(List<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }
    }

}
}
