using CourseExercicio2.Entities.Enum;
using System.Globalization;

namespace CourseExercicio2.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contracts)
        {
           Contracts.Add(contracts);
        }
        public void RemoveContract(HourContract contracts)
        {
            Contracts.Remove(contracts);
        }
        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                sum = (contract.Date.Year == year && contract.Date.Month == month)? sum += contract.TotalValue():sum;
            }
            return sum;
        }
    }

}
