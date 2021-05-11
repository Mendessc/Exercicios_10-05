using System;

namespace Exercicio4_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = null;
            numeros = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Informe o valor do {i + 1}º número");
                numeros[i] = int.Parse(Console.ReadLine());
            }

             Array.Sort(numeros);
             
            Console.WriteLine($"O maior número é: {numeros[9]}");
            Console.WriteLine($"O menor número é: {numeros[0]}");
        }
    }
}
