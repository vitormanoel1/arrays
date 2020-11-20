using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alimentos = { "feijão ", "arroz ", "bife ", "frango ", "carne moida ", "macarrão ", "frango " };

            for (int i = 0; i < alimentos.Length; i++)
            {
                Console.WriteLine(alimentos[i]);
            }

        }
    }
}
