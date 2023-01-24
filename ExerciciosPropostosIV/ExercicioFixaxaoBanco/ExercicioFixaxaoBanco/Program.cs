using ExercicioFixaxaoBanco;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            ContaBancaria contaBancaria = new ContaBancaria();

            Console.WriteLine($"Olá. O que gostaria de fazer hoje?");
            while (opcao != 5)
            {
                Console.WriteLine($"1 - Abrir uma conta;\n" +
                $"2 - Depositar um valor;\n" +
                $"3 - Sacar um valor;\n" +
                $"4 - Alterar nome do titular\n" +
                $"5 - Encerrar operação;");
                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    Console.WriteLine($"Você selecionou abrir uma conta;");
                    Console.WriteLine($"Qual o número da conta?");
                    contaBancaria.SetCadastroConta(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"Digite o nome do Titular");
                    contaBancaria.SetNomeTitular(Console.ReadLine());
                    Console.WriteLine($"Gostaria de depositar um valor inicial (S/N)?");
                    string depositar = Console.ReadLine();
                    if (depositar.ToLower() == "s")
                    {
                        Console.WriteLine($"Qual valor gostaria de depositar?");
                        contaBancaria.SetDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                        contaBancaria.ValorEmConta(opcao);
                    }
                    else if (depositar.ToLower() == "n")
                    {
                        Console.WriteLine($"Nenhum valor depositado\n");
                        contaBancaria.ValorEmConta(opcao);
                    }
                    else
                    {
                        Console.WriteLine($"Opção inválida, por favor selecione S/N\n");
                    }
                }
                else if (opcao == 2)
                {
                    Console.WriteLine($"Você selecionou depositar um valor;");
                    Console.WriteLine($"Qual valor gostaria de depositar?");
                    contaBancaria.SetDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    contaBancaria.ValorEmConta(opcao);
                }
                else if (opcao == 3)
                {
                    Console.WriteLine($"Você selecionou sacar um valor;");
                    Console.WriteLine($"Qual valor gostaria de sacar?");
                    contaBancaria.SetSacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                    contaBancaria.ValorEmConta(opcao);
                }
                else if (opcao == 4)
                {
                    Console.WriteLine($"Você selecionou Alterar nome;");
                    Console.WriteLine($"Qual o novo nome?");
                    contaBancaria.SetNomeTitular(Console.ReadLine());
                    contaBancaria.ValorEmConta(opcao);
                }
                else if (opcao == 5)
                {
                    Console.WriteLine($"O programa será encerrado. Obrigado por utilizar nossos serviços;");
                }
                else
                {
                    Console.WriteLine($"Opção inválida\n");
                }
            }
        }
    }
}