using System.Reflection;

namespace v53
{
    internal class Program
    {
        
// Define a sample class
public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Get the type information for the Person class
            Type personType = typeof(Person);

            // Create an instance of the Person class using reflection
            object personInstance = Activator.CreateInstance(personType);

            // Set property values using reflection
            PropertyInfo nameProperty = personType.GetProperty("Name");
            if (nameProperty != null)
                nameProperty.SetValue(personInstance, "John");

            PropertyInfo ageProperty = personType.GetProperty("Age");
            if (ageProperty != null)
                ageProperty.SetValue(personInstance, 30);

            // Call a method dynamically using reflection
            MethodInfo introduceMethod = personType.GetMethod("Introduce");
            if (introduceMethod != null)
                introduceMethod.Invoke(personInstance, null);

            // Display property values using reflection
            if (nameProperty != null && ageProperty != null)
            {
                Console.WriteLine($"Name: {nameProperty.GetValue(personInstance)}");
                Console.WriteLine($"Age: {ageProperty.GetValue(personInstance)}");
            }
        }
    }

}
}
