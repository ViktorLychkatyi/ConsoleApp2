using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class AnalyzeText
    {
        public void Run() 
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            char[] symbol = text.ToCharArray();
            string[] words = text.Split(' ');

            string glasnyie = "аеёиоуыэюяaeiouy";
            string soglasnyie = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxyz";
            string znaki = ".,:;!?-() ";
            string numbers = "1234567890";

            int glasnyie_сount = 0;
            int soglasnyie_сount = 0;
            int znaki_сount = 0;
            int numbers_сount = 0;

            foreach (char s in symbol)
            {
                if (glasnyie.Contains(char.ToLower(s)))
                {
                    glasnyie_сount++;
                }
                else if (soglasnyie.Contains(char.ToLower(s)))
                {
                    soglasnyie_сount++;
                }
                else if (znaki.Contains(s))
                {
                    znaki_сount++;
                }
                else if (numbers.Contains(s))
                {
                    numbers_сount++;
                }
            }

            Console.WriteLine("Всего символов: " + symbol.Length);
            Console.WriteLine("Всего слов: " + words.Length);
            Console.WriteLine("Гласных: " + glasnyie_сount);
            Console.WriteLine("Согласных: " + soglasnyie_сount);
            Console.WriteLine("Цифр: " + numbers_сount);
            Console.WriteLine("Знаков пунктуации: " + znaki_сount);
        }

        public void Print()
        {
            Run();
        }
    }
}