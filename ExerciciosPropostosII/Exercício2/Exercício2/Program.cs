using Exercício2;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a= new Pessoa();
            b= new Pessoa();
            Console.Write("Digite o nome do primeiro funcionário: ");
            a.nome = Console.ReadLine();
            Console.Write("Digite o valor do salário: ");
            a.salario = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite o nome do segundo funcionário: ");
            b.nome = Console.ReadLine();
            Console.Write("Digite o valor do salário: ");
            b.salario = float.Parse(Console.ReadLine());

            float mediaSalario = (a.salario + b.salario)/2;
            Console.WriteLine($"Salário médio: {mediaSalario.ToString("F2")}");
        }
    }
}