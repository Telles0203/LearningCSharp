using ExercicioProposto;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Seja bem vindo");
            Console.Write($"Digite a quantidade de quartos: ");
            int n1 = int.Parse(Console.ReadLine());
            Pensionato[] pensionato = new Pensionato[n1];



            Console.Write($"Quantos irão alugar?: ");
            int n2 = int.Parse(Console.ReadLine());


            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Número quarto:");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write($"Nome: ");
                string nome = Console.ReadLine();
                Console.Write($"Email: ");
                string email = Console.ReadLine();
                pensionato[quarto] = new Pensionato(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < n1; i++)
            {
                if (pensionato[i] != null)
                {
                    Console.WriteLine($"{i}: {pensionato[i]}");
                }
            }

        }
    }
}