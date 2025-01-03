namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 6;
            int height = 5;
            int[,] ar = new int[height, width];
            int number = 1;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    ar[y, x] = number++;
                    Console.Write("{0, -8}", ar[y, x]); // -5 это для выравнивание по левому краю в ряд
                }
                Console.WriteLine();
            }
        }
    }
}