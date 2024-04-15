public abstract class Animal  // Abstract class for animals
{
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();  // Abstract method - must be implemented by derived classes

    public virtual void Eat()  // Virtual method (can be overridden in derived classes)
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Dog : Animal  // Derived class inheriting from Animal
{
    public override void MakeSound()  // Implementation for Dog's MakeSound
    {
        Console.WriteLine("Woof!");
    }

    public override void Eat()  // Overriding Eat behavior for Dog
    {
        Console.WriteLine("The dog is eating kibble.");
    }
}

public class Cat : Animal  // Derived class inheriting from Animal
{
    public override void MakeSound()  // Implementation for Cat's MakeSound
    {
        Console.WriteLine("Meow!");
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // You cannot create an Animal object directly (abstract class)
        // Animal animal = new Animal();  // This would cause an error

        Dog dog = new Dog { Name = "Fido", Age = 5 };
        Cat cat = new Cat { Name = "Whiskers", Age = 2 };

        dog.MakeSound();  // Calls Dog's implementation
        dog.Eat();        // Calls Dog's overridden Eat behavior

        cat.MakeSound();  // Calls Cat's implementation
        cat.Eat();        // Calls Animal's default Eat behavior
    }
}

