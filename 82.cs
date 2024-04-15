namespace v82
{
    internal class Program
    {
      

public enum TransactionResult
    {
        Success,
        InsufficientFunds,
        InvalidAmount
    }

    public class CustomerTransaction
    {
        public string CustomerName { get; }
        public decimal Amount { get; }

        public CustomerTransaction(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;
        }
    }

    public class ATM
    {
        private Queue<CustomerTransaction> transactionQueue = new Queue<CustomerTransaction>();
        private decimal availableFunds = 1000.00m; // ATM's available funds

        public void QueueTransaction(CustomerTransaction transaction)
        {
            transactionQueue.Enqueue(transaction);
            Console.WriteLine($"Transaction added to queue: {transaction.CustomerName} - Amount: ${transaction.Amount}");
        }

        public void ProcessTransactions()
        {
            while (transactionQueue.Count > 0)
            {
                CustomerTransaction transaction = transactionQueue.Dequeue();
                Console.WriteLine($"Processing transaction for {transaction.CustomerName} - Amount: ${transaction.Amount}");

                // Process the transaction
                TransactionResult result = ProcessTransaction(transaction);

                // Display result
                switch (result)
                {
                    case TransactionResult.Success:
                        Console.WriteLine("Transaction successful.");
                        break;
                    case TransactionResult.InsufficientFunds:
                        Console.WriteLine("Transaction failed: Insufficient funds.");
                        break;
                    case TransactionResult.InvalidAmount:
                        Console.WriteLine("Transaction failed: Invalid amount.");
                        break;
                }
            }
        }

        private TransactionResult ProcessTransaction(CustomerTransaction transaction)
        {
            if (transaction.Amount <= 0)
            {
                return TransactionResult.InvalidAmount;
            }

            if (transaction.Amount > availableFunds)
            {
                return TransactionResult.InsufficientFunds;
            }

            // Perform transaction (deduct amount from available funds)
            availableFunds -= transaction.Amount;
            return TransactionResult.Success;
        }
    }

    class Program1
    {
        static void Main()
        {
            // Create an instance of ATM
            ATM atm = new ATM();

            // Queue customer transactions
            atm.QueueTransaction(new CustomerTransaction("Alice", 200.00m));
            atm.QueueTransaction(new CustomerTransaction("Bob", 150.00m));
            atm.QueueTransaction(new CustomerTransaction("Eve", 300.00m));

            // Process transactions
            Console.WriteLine("\nProcessing transactions...\n");
            atm.ProcessTransactions();

            // Display remaining funds in the ATM
            Console.WriteLine($"\nRemaining funds in ATM: ${atm.AvailableFunds}");
        }
    }

}
}
