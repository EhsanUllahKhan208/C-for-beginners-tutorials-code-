public class Product
{
    private string name;
    private double price;
    private FileStream fileStream;  // Resource to be managed (example)

    public Product(string name, double price)  // Basic constructor
    {
        this.name = name;
        this.price = price;
    }

    public Product(string name, double price, string filePath)  // Overloaded constructor with file path
    {
        this.name = name;
        this.price = price;
        this.fileStream = File.Open(filePath, FileMode.OpenOrCreate);  // Open a file stream (potential resource)
    }

    public string GetName()
    {
        return this.name;  // Use 'this' to access the object's name member
    }

    public double GetPrice()
    {
        return price;
    }

    public void DoSomethingWithFile()  // Method potentially using the file stream
    {
        if (fileStream != null)
        {
            // Perform operations on the file stream (example: writing data)
            Console.WriteLine("Using file stream for product: " + this.name);
        }
    }

    ~Product()  // Destructor (finalize)
    {
        // Optional: Close the file stream if it's still open (potential cleanup)
        if (fileStream != null)
        {
            Console.WriteLine("Closing file stream for product: " + this.name);
            fileStream.Close();
        }
    }
}

public class MainProgram
{
    public static void Main(string[] args)
    {
        // Basic product creation
        Product product1 = new Product("T-Shirt", 19.99);
        Console.WriteLine("Product Name: " + product1.GetName());
        Console.WriteLine("Product Price: " + product1.GetPrice());

        // Product creation with file path (assuming a file exists)
        Product product2 = new Product("Laptop", 799.99, @"C:\data\product_info.txt");  // Use '@' for verbatim string literals
        product2.DoSomethingWithFile();  // Example usage of file stream

        // Destructors will be called automatically when the objects go out of scope (garbage collection)
    }
}
