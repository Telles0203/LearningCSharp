using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Insira um valor: ");
            double n1 = double.Parse(Console.ReadLine());
            //Console.Write($"Insira um segundo valor: ");
            //int n2 = int.Parse(Console.ReadLine());
            double PI = 3.14159;
            Console.WriteLine($"Saída PI x {n1}² = {PI*Math.Pow(n1,2):F4}");
            Console.WriteLine($"\n\n");

        }
    }
}