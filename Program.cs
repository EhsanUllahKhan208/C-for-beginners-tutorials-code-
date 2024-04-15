public class Product
{
    // Read-Write Property (full access)
    public string Name { get; set; }

    // Read-Only Property (getter only)
    public int ProductId { get; private set; } // Private setter restricts modification

    private double _price;  // Private field for price (encapsulation)

    // Write-Only Property (setter only)
    public double Price
    {
        set
        {
            if (value >= 0)  // Validation logic in setter
            {
                _price = value;
            }
            else
            {
                Console.WriteLine("Error: Price cannot be negative.");
            }
        }
    }

    // Auto-Implemented Property (simple property with no custom logic)
    public bool InStock { get; set; }

    public Product(int productId, string name, double price, bool inStock)
    {
        ProductId = productId;  // Set using private setter in constructor
        Name = name;
        Price = price;  // Trigger validation in setter
        InStock = inStock;
    }
}

