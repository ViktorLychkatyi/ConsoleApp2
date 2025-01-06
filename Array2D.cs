using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Array2D
    {
        int number = 1;
        int width = 6;
        int height = 5;
        int[,] ar;

        public void Print()
        {
            ar = new int[height, width];
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    ar[y, x] = number++;
                    Console.Write("{0,-4}", ar[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}