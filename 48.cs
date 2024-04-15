namespace v48
{
    internal class Program
    {
      
// Define a class representing a Person
public class Person
    {
        // Fields (type members)
        private string name;
        private int age;

        // Properties (type members)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120) // Validate age
                    age = value;
                else
                    throw new ArgumentException("Age must be between 0 and 120.");
            }
        }

        // Constructor (type member)
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method (type member)
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Define an enum for Days of the Week
    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class Program1
    {
        public static void Main(string[] args)
        {
            // Using the Person class
            Person person1 = new Person("John", 30);
            person1.DisplayInfo();

            // Using the enum DayOfWeek
            DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine($"Today is {today}");

            // Accessing type members of Person class
            person1.Name = "Alice";
            person1.Age = 25;
            person1.DisplayInfo();
        }
    }

}
}
