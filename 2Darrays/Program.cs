// https://www.youtube.com/watch?v=uORalPNuO_U&ab_channel=Programmingw%2FProfessorSluiter

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How tall will the 2d array be? (rows)");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("How wide will the 2d array be (columns)");
        int columns = int.Parse(Console.ReadLine());

        int[,] grid = new int[rows, columns];

        Console.WriteLine("Time to fill the grid with numbers");

        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                Console.WriteLine("grid[{0}, {1}] = " , row, column);
                grid[row, column] = int.Parse(Console.ReadLine()) ;
            }
        }

        // print the grid
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                Console.Write(grid[r,c] + " ");
            }
            Console.WriteLine();
        }

    }
}
