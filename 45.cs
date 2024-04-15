namespace v45
{
    internal class Program
    {
        public enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday };

        static void Main(string[] args)
        {
            // Assign an enum value
            DayOfWeek today = DayOfWeek.Tuesday;

            // Use the enum value in a switch statement (corrected)
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("It's Monday!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("It's Tuesday!");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("It's Wednesday!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("It's Thursday!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday!");
                    break;
                default:
                    Console.WriteLine("It's the weekend!"); // Handle weekend days
                    break; // Add a break statement here
            }
        }
    }
}
