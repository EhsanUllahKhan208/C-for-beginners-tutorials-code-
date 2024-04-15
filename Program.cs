namespace v16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Calling CalculateArea with parameters and using the return value
            int rectangleLength = 5;
            int rectangleWidth = 3;
            int area = CalculateArea(rectangleLength, rectangleWidth);
            Console.WriteLine("Area of the rectangle: " + area);

            // Example 2: Calling CalculateDistance with parameters and using the return value
            double point1X = 2.0;
            double point1Y = 4.0;
            double point2X = 6.0;
            double point2Y = 1.0;
            double distance = CalculateDistance(point1X, point1Y, point2X, point2Y);
            Console.WriteLine("Distance between points: " + distance);
        }
        public static int CalculateArea(int length, int width)
        {
            // This method calculates the area of a rectangle
            int area = length * width;
            return area;
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            // This method calculates the distance between two points
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distance;
        }
    }
}
