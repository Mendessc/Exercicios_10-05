using System;

namespace Exercicio3_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o nome do seu produto?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a quantidade adquirida?");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço unitário do produto?");
            double preco = double.Parse(Console.ReadLine());

            double total = quantidade * preco;
            if (quantidade <= 5)
            {
                double totalPagar = total * 0.98;
                Console.WriteLine($"O valor a ser pago é de: R$ {(totalPagar) .ToString("N2")}");
            } 
            else if (quantidade > 5 && total <= 10)
            {
                double totalPagar = total * 0.97;
                Console.WriteLine($"O valor a ser pago é de: R$ {(totalPagar) .ToString("N2")}");
            } 
            else  
            {
                double totalPagar = total * 0.95;
                Console.WriteLine($"O valor a ser pago é de: R$ {(totalPagar) .ToString("N2")}");
            } 
        }
    }
}
