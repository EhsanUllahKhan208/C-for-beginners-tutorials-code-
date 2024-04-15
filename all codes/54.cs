using System.Reflection;

namespace v54
{
    internal class Program
    {
       
public interface IPlugin
    {
        string Name { get; }
        void Run();
    }

    public class CalculatorPlugin : IPlugin
    {
        public string Name => "Calculator Plugin";

        public void Run()
        {
            Console.WriteLine("Running Calculator Plugin...");
            Console.WriteLine("2 + 2 = " + (2 + 2));
        }
    }

    public class GreetingPlugin : IPlugin
    {
        public string Name => "Greeting Plugin";

        public void Run()
        {
            Console.WriteLine("Running Greeting Plugin...");
            Console.WriteLine("Hello, Reflection!");
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            // Configuration: Specify plugins to load
            List<string> pluginNames = new List<string> { "CalculatorPlugin", "GreetingPlugin" };

            // Load and run plugins dynamically
            foreach (var pluginName in pluginNames)
            {
                // Load the assembly containing the plugin classes (assuming they are in the same assembly)
                Assembly assembly = Assembly.GetExecutingAssembly();

                // Get the type of the plugin class
                Type pluginType = assembly.GetType(pluginName);

                if (pluginType != null && typeof(IPlugin).IsAssignableFrom(pluginType))
                {
                    // Create an instance of the plugin class
                    IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginType);

                    // Run the plugin
                    Console.WriteLine($"--- Running {plugin.Name} ---");
                    plugin.Run();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Error: Plugin {pluginName} not found or does not implement IPlugin.");
                }
            }
        }
    }

}
}
