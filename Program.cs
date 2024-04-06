namespace video_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            int result = num1 + num2;
            Console.WriteLine("Addition result = {0}", result);

            
            int result1 = num1 - num2;
            Console.WriteLine("Subtraction result = {0}", result1);

          
            int result2 = num1 * num2;
            Console.WriteLine("Multiplication result = {0}", result2);

            int result3 = num1 / num2;
            Console.WriteLine("Division result = {0}", result3);

            int result4 = num1 % num2;
            Console.WriteLine("Reminder result = {0}", result4);
            if (num1 == 10 || num2==20) {
                Console.WriteLine("true");
            }
        }
    }
}
