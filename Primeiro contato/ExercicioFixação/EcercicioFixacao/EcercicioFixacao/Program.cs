using System;
using System.Globalization;



namespace ExercicioFixacao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Excritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:");
            Console.WriteLine($"{produto1}, cujo valor é R$ {preco1}");
            Console.WriteLine($"{produto2}, cujo preço é R$ {preco2}");
            Console.WriteLine($"Registro: {idade} anos, código {codigo} e gênero {genero}");
            Console.WriteLine($"Medida em oito casas decimais: {medida:F8}");
            Console.WriteLine($"Medida em três casas decimais: {medida:F3}");
            Console.WriteLine("Medida com ponto casas decimais: "+ medida.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}