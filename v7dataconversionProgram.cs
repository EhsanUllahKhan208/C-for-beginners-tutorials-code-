namespace v7Datatypes_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit
            int age1 = 25;

            double pi = 3.14159; 

            
            double ageInYears = age1; 

            Console.WriteLine(ageInYears); 

            char initial = 'A';
            int asciiValue = initial;

            Console.WriteLine(asciiValue);

            //explicit

            double average = 89.75; 

            
            int roundedAverage = (int)average;

            Console.WriteLine(roundedAverage); 

          
            string userInput = "1c";
            int number;

            bool success = int.TryParse(userInput, out number); // Attempt conversion

            if (success)
            {
                Console.WriteLine("Converted number: " + number);
            }
            else
            {
                Console.WriteLine("Conversion failed: Input is not a valid number");
            }

            // str and num conversions
            string ageStr = "30";
            int age;
            age = int.Parse(ageStr);

            Console.WriteLine(age); 

            string piStr = "3.14";
            double piValue;

            bool parseSuccess = double.TryParse(piStr, out piValue);

            if (parseSuccess)
            {
                Console.WriteLine(piValue); 
            }
            else
            {
                Console.WriteLine("Conversion failed: Input is not a valid number");
            }

        }
    }
}
