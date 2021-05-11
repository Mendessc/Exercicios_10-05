using System;

namespace Exercicio6_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes;

            Console.WriteLine("Digite 10 nomes");
            nomes = new string[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º nome");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("Digite o nome que deseja procurar");
            string nomeProcurado = Console.ReadLine();
            bool encontrado = false;

            foreach (var item in nomes)
            {
                if (nomeProcurado == item)
                {
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                    Console.WriteLine("ACHEI!");
            }
            else
            {
                    Console.WriteLine("NÃO ACHEI!");  
            }
        }
    }
}
