using System;

namespace Exercicio1_10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());
            int idadePessoa = DateTime.Now.Year - anoNascimento;
            Console.WriteLine("Sua idade é: " + idadePessoa + "\n");
            if (idadePessoa < 16)
            {
                Console.WriteLine("Você não tem idade suficiente para votar");
            }
            else if(idadePessoa > 16 && idadePessoa < 18)
            {
                Console.WriteLine("Você ja possui idade suficiente para votar, mas não é obrigatório");
            }
            else
            {
                  Console.WriteLine("Você ja possui idade suficiente para votar, obrigatoriamente!");
            }
        }
    }
}
