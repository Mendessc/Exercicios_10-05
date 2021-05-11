using System;

namespace Exercicio7_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [5];

            Console.WriteLine($"Digite {numeros.Length} números");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numeros);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
        }
    }
}
