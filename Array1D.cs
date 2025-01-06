using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Array1D
    {
        public void StepsNumbers(string number, int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                Console.WriteLine($"Шаг {i + 1}: {number}");
                StringBuilder result = new StringBuilder();
                int count = 1;

                for (int j = 1; j < number.Length; j++)
                {
                    if (number[j] == number[j - 1])
                    {
                        count++;
                    }
                    else if (number[j] != number[j - 1])
                    {
                        result.Append(count);
                        result.Append(number[j - 1]);
                        count = 1;
                    }
                }
                result.Append(count);
                result.Append(number[number.Length - 1]);
                number = result.ToString();
            }
        }

        public void Print()
        {
            Console.Write("Введите начальное число: ");
            string number = Console.ReadLine();

            Console.Write("Введите количество шагов: ");
            int steps = int.Parse(Console.ReadLine());

            Console.WriteLine("\nРезультаты выполнения:");
            StepsNumbers(number, steps);
        }
    }
}