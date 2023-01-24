using ExercicioFixacao;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            Employee employee = new Employee();
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());
            
            //Cadastrar funcionário> Id, Name e Salary;
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine($"Employee # {i}\n");
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployees.Add(new Employee { Id = id, Name = name, Salary = salary });
            }
           
            
            //Localizar id e atualizar salário:
            Console.Write("Enter the employee id that will have salary increase: ");
            id = int.Parse(Console.ReadLine());
                    
            Employee idFinder = listEmployees.Find(x => x.Id == id);
           
            if (idFinder != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                percentage = percentage / 100;
                idFinder.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            //Imprimir:
            foreach (var item in listEmployees)
            {
                Console.WriteLine(item);
            }

        }
    }
}