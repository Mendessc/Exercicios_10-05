using System;

namespace Exercicio2_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual combustivel deseja usar, Alcool ou Gasolina?");
            string combustivel = Console.ReadLine() .ToLower();
            string letra = combustivel.Substring(0, 1);

            if (letra == "g")
            {
                Console.WriteLine("Ok, você escolheu gasolina");
                Console.WriteLine("Quantos litros deseja colocar?");
                double litros = double.Parse(Console.ReadLine());
                if (litros <= 20)
                {
                    double valor = litros * 5.30; 
                    Console.WriteLine($"O valor a ser pago será de: R$ {(valor * 0.96) .ToString("N2")}");
                }
                else
                {
                    double valor = litros * 5.30;
                    Console.WriteLine($"O valor a ser pago será de: R$ {(valor * 0.94) .ToString("N2")}");
                }
            }
             if (letra == "a")
            {
                Console.WriteLine("Ok, você escolheu álcool");
                Console.WriteLine("Quantos litros deseja colocar?");
                double litros = double.Parse(Console.ReadLine());
                if (litros <= 20)
                {
                    double valor = litros * 4.90; 
                    Console.WriteLine($"O valor a ser pago será de: R$ {(valor * 0.97) .ToString("N2")}");
                }
                else
                {
                    double valor = litros * 4.90;
                    Console.WriteLine($"O valor a ser pago será de: R$ {(valor * 0.95) .ToString("N2")}");
                }
            }


        }
    }
}
