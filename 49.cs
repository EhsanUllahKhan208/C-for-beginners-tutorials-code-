namespace v49
{
    internal class Program
    {
       

// Define a base class
public class Animal
    {
        // Private field accessible only within the class
        private string species;

        // Public property accessible from anywhere
        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        // Protected property accessible within this class and derived classes
        protected int Age { get; set; }

        // Constructor to initialize properties
        public Animal(string species, int age)
        {
            Species = species;
            Age = age;
        }

        // Public method accessible from anywhere
        public void DisplayInfo()
        {
            Console.WriteLine($"Species: {Species}, Age: {Age}");
        }
    }

    // Define a derived class inheriting from Animal
    public class Dog : Animal
    {
        // Constructor to initialize properties including base class properties
        public Dog(string species, int age) : base(species, age)
        {
            // Accessing protected property Age from the base class
            Age = age; // OK to access within derived class
        }

        // Method to display dog's info using base class method
        public void DisplayDogInfo()
        {
            DisplayInfo(); // OK to call base class public method
        }
    }

    public class Program1
    {
        public static void Main(string[] args)
        {
            // Create an instance of Animal
            Animal animal = new Animal("Lion", 10);

            // Access public property and method
            animal.Species = "Tiger"; // OK to set property
            animal.DisplayInfo();     // OK to call method

            Console.WriteLine();

            // Create an instance of Dog
            Dog dog = new Dog("Labrador", 5);

            // Access public property and method inherited from base class
            dog.Species = "Golden Retriever"; // OK to set property inherited from base class
            dog.DisplayInfo();                 // OK to call method inherited from base class
            dog.DisplayDogInfo();              // OK to call method within derived class
        }
    }

}
}
