namespace v66
{
    internal class Program
    {
      

public class Matrix
    {
        private int[,] data;

        // Constructor to initialize the matrix
        public Matrix(int rows, int cols)
        {
            data = new int[rows, cols];
        }

        // Indexer for accessing elements by row and column indices
        public int this[int row, int col]
        {
            get
            {
                return data[row, col];
            }
            set
            {
                data[row, col] = value;
            }
        }

        // Overloaded indexer for accessing elements by a single index (linear index)
        public int this[int index]
        {
            get
            {
                int totalLength = data.GetLength(0) * data.GetLength(1);
                if (index < 0 || index >= totalLength)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                int row = index / data.GetLength(1);
                int col = index % data.GetLength(1);

                return data[row, col];
            }
            set
            {
                int totalLength = data.GetLength(0) * data.GetLength(1);
                if (index < 0 || index >= totalLength)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                int row = index / data.GetLength(1);
                int col = index % data.GetLength(1);

                data[row, col] = value;
            }
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix(2, 3);

            // Set elements using two-dimensional indexer
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[1, 0] = 4;
            matrix[1, 1] = 5;
            matrix[1, 2] = 6;

            // Get and print elements using two-dimensional indexer
            Console.WriteLine("Matrix elements (2D indexer):");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            // Set elements using one-dimensional indexer (linear index)
            matrix[0] = 10;
            matrix[1] = 20;
            matrix[2] = 30;
            matrix[3] = 40;
            matrix[4] = 50;
            matrix[5] = 60;

            // Get and print elements using one-dimensional indexer (linear index)
            Console.WriteLine("\nMatrix elements (1D indexer):");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(matrix[i] + " ");
            }
            Console.WriteLine();
        }
    }

}
}
