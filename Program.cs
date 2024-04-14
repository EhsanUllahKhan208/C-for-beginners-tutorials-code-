namespace v10ifstatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int age = 20;
            bool hasDriversLicense = true;

            
            if (age >= 16)  
            {
                Console.WriteLine("You can drive (if you have a license).");
            }

           
            if (hasDriversLicense) 
            {
                Console.WriteLine("You have a driver's license.");
            }
            else  
            {
                Console.WriteLine("You don't have a driver's license yet.");
            }

           
            if (age >= 18 && hasDriversLicense)  // Check if both age >= 18 AND hasDriversLicense is true
            {
                Console.WriteLine("You can drive ");
            }
            else
            {
                Console.WriteLine("You cannot drive yet");
            }

           
            if (age >= 16 || hasDriversLicense)  
            {
                Console.WriteLine("You might be eligible to learn how to drive ");
            }
            else
            {
                Console.WriteLine("You are not eligible to learn how to drive yet");
            }

        }
    }
}
