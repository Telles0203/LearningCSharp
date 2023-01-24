using ResolucaoExercicioPeloProfessor;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write($"Entre com o nome do Titular da Conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine($"Haverá depósito inicial? (S/N)");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 'S' || resposta == 's')
            {
                Console.WriteLine($"Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\n");
            Console.WriteLine($"Dados da conta:\n" +
                $"{conta}");

            
            Console.WriteLine($"");
        }
    }
}