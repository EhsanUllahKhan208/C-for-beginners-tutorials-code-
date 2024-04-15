namespace v79
{
    internal class Program
    {
    

public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
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

            // Sorting the list by Age using a custom comparison delegate
            people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age));

            // Displaying the sorted list
            Console.WriteLine("\nSorted List (by Age):");
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

