namespace v51
{
    internal class Program
    {
        

// Public class accessible from any code
public class PublicClass
    {
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
    }

    // Internal class accessible only within the same assembly
    internal class InternalClass
    {
        public void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
    }

    // Protected class (not allowed at the namespace level, only as a nested class)
    public class BaseClass
    {
        protected class ProtectedNestedClass
        {
            public void ProtectedMethod()
            {
                Console.WriteLine("This is a protected method.");
            }
        }
    }

    // Derived class accessing protected members from BaseClass
    public class DerivedClass : BaseClass
    {
        public void UseProtectedMethod()
        {
            ProtectedNestedClass nestedInstance = new ProtectedNestedClass();
            nestedInstance.ProtectedMethod(); // Accessing protected method from derived class
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Accessing public class and method
            PublicClass publicObj = new PublicClass();
            publicObj.PublicMethod(); // OK, accessible from anywhere

            Console.WriteLine();

            // Accessing internal class and method within the same assembly
            InternalClass internalObj = new InternalClass();
            internalObj.InternalMethod(); // OK, accessible within the same assembly

            Console.WriteLine();

            // Accessing protected members through derived class
            DerivedClass derivedObj = new DerivedClass();
            derivedObj.UseProtectedMethod(); // OK, accessing protected method from derived class
        }
    }

}
}
