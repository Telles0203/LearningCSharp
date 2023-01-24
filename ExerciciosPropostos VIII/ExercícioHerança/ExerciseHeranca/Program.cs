using System;
using System.Globalization;
using System.Collections.Generic;
using ExerciseHeranca.Entities;


namespace ExerciseHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char var1 = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (var1 == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listEmployees.Add(new OutSourceEmployee (name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    listEmployees.Add(new Employee (name, hours, valuePerHour));
                }

            }
            
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee employee in listEmployees)
            {
                Console.Write($"{employee.Name} - $ {employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");

            }
        }
    }
}