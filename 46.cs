namespace v46
{
    internal class Program
    {
        public enum CustomerType { Retail, Wholesale, Corporate }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public CustomerType Type { get; set; }
        }

        static void Main(string[] args)
        {
            // Create a customer object with Retail type
            Customer customer1 = new Customer { CustomerID = 1001, Name = "John Doe", Type = CustomerType.Retail };

            // Use switch statement based on customer type
            switch (customer1.Type)
            {
                case CustomerType.Retail:
                    Console.WriteLine("Retail customer discount applied for {0} (ID: {1}).", customer1.Name, customer1.CustomerID);
                    break;
                case CustomerType.Wholesale:
                    Console.WriteLine("Wholesale pricing used for order of {0} (ID: {1}).", customer1.Name, customer1.CustomerID);
                    break;
                case CustomerType.Corporate:
                    Console.WriteLine("Dedicated account manager assigned to {0} (ID: {1}).", customer1.Name, customer1.CustomerID);
                    break;
                default:
                    Console.WriteLine("Invalid customer type for {0} (ID: {1}).", customer1.Name, customer1.CustomerID);
                    break; // Add a break statement here
            }
        }

    }
}
