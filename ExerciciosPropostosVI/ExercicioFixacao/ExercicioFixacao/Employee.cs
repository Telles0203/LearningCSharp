using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary = (Salary * percentage)+Salary;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nSalary: {Salary.ToString("F2", CultureInfo.InvariantCulture)}\n-------------------\n";

        }
    }
}
