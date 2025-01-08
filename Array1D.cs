using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Array1D
    {
        public void Run()
        {
            Console.Write("Введите количество шагов: ");
            int step = int.Parse(Console.ReadLine());

            Console.Write("Введите число для последовательности: ");
            string number = Console.ReadLine();
            int[] ar = new int[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                ar[i] = int.Parse(number[i].ToString());
            }

            for (int i = 0; i < step; i++)
            {
                foreach (int n in ar)
                {
                    Console.Write(n);
                }
                Console.WriteLine();

                StringBuilder value = new StringBuilder();
                int count = 1;

                for (int j = 1; j < ar.Length; j++)
                {
                    if (ar[j] == ar[j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        value.Append(count);
                        value.Append(ar[j - 1]);
                        count = 1;
                    }
                }
                value.Append(count);
                value.Append(ar[ar.Length - 1]);

                number = value.ToString();
                ar = new int[number.Length];
                for (int k = 0; k < number.Length; k++)
                {
                    ar[k] = int.Parse(number[k].ToString());
                }
            }
        }

        public void Print()
        {
            Run();
        }
    }
}