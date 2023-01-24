using PrimeirosExercicios;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas a, b;
            a = new Pessoas();
            b = new Pessoas();


            Console.WriteLine("Coloque o nome da primeira pessoa: ");
            a.nome = Console.ReadLine();
            Console.WriteLine("Idade da primeira pessoa: ");
            a.idade = int.Parse(Console.ReadLine());
            
            
            Console.WriteLine("Coloque o nome da segunda pessoa: ");
            b.nome = Console.ReadLine();
            Console.WriteLine("Idade da segunda pessoa: ");
            b.idade = int.Parse(Console.ReadLine());

            if (a.idade > b.idade)
            {
                Console.WriteLine($"Pessoa mais velha: {a.nome}.");
            }
            else{
            Console.WriteLine($"Pessoa mais velha: {b.nome}.");
            }

            //............................................


        }
    }
}