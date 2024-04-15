namespace v52
{
    internal class Program
    {
       

// Define a custom attribute with parameters
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; }

        // Constructor with parameters
        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    // Apply the custom attribute to a class and method
    [MyCustomAttribute("This is a sample class.")]
    public class MyClass
    {
        [MyCustomAttribute("This is a sample method.")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod...");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Retrieve and inspect attributes at runtime using reflection
            Type myClassType = typeof(MyClass);
            var classAttributes = myClassType.GetCustomAttributes(typeof(MyCustomAttribute), false);

            if (classAttributes.Length > 0)
            {
                MyCustomAttribute classAttribute = (MyCustomAttribute)classAttributes[0];
                Console.WriteLine($"Class Description: {classAttribute.Description}");
            }

            var methodInfo = myClassType.GetMethod("MyMethod");
            var methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);

            if (methodAttributes.Length > 0)
            {
                MyCustomAttribute methodAttribute = (MyCustomAttribute)methodAttributes[0];
                Console.WriteLine($"Method Description: {methodAttribute.Description}");
            }

            // Invoke the method
            MyClass myObject = new MyClass();
            myObject.MyMethod();
        }
    }

}
}
