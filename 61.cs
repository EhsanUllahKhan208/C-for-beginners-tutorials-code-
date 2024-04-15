namespace v61
{
    internal class Program
    {// File: MyClass_Part1.cs
        public partial class MyClass
        {
            private int id;

            public void SetId(int newId)
            {
                id = newId;
            }
        }

        // File: MyClass_Part2.cs
        public partial class MyClass
        {
            private string name;

            public void SetName(string newName)
            {
                name = newName;
            }

            public override string ToString()
            {
                return $"Id: {id}, Name: {name}";
            }
        }

        // Main program
        class Program1
        {
            static void Main(string[] args)
            {
                MyClass obj = new MyClass();
                obj.SetId(1);
                obj.SetName("John");

                Console.WriteLine(obj); // Output: Id: 1, Name: John
            }
        }

    }
}
