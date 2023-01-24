using Exercicio3;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////Exercício do retângulo//
            //Retangulo retangulo = new Retangulo();

            //Console.Write("Entre com a largura do triângulo: ");
            //retangulo.Largura = double.Parse(Console.ReadLine());
            //Console.Write("Entre com a altura do triângulo: ");
            //retangulo.Altura = double.Parse(Console.ReadLine());



            //Console.WriteLine($"Área = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}\nPerímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}\nDiagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

            //Exercício do funcionário:
            Funcionario funcionario = new Funcionario();
            Console.Write($"Por favor, insira o nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write($"Agora insira o salário: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write($"Agora insira o imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {funcionario}");

            Console.Write($"Qual a porcentagem que deseja aumentar? ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

            Console.WriteLine($"Funcionário: {funcionario}");

            ////Exercício do aluno Aprovado e reprovado:
            //Aluno aluno = new Aluno();
            //Console.Write($"Por favor, insira o nome: ");
            //aluno.Nome = Console.ReadLine();
            //Console.Write($"Por favor, insira a nota 1: ");
            //aluno.Nota1 = double.Parse(Console.ReadLine());
            //Console.Write($"Por favor, insira a nota 2: ");
            //aluno.Nota2 = double.Parse(Console.ReadLine());
            //Console.Write($"Por favor, insira a nota 3: ");
            //aluno.Nota3 = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Nota final = {aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");

            //if (aluno.Status() == "APROVADO")
            //{
            //    Console.WriteLine(aluno.Status());
            //}
            //else
            //{
            //    Console.WriteLine(aluno.Status());
            //    Console.WriteLine($"FALTARAM {Math.Abs(aluno.NotaFinal() - 60).ToString("F2",CultureInfo.InvariantCulture)} PONTOS");}


        }
    }
}