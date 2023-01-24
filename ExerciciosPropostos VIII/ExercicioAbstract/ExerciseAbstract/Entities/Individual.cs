using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseAbstract.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }



        public override double Tax()
        {
            return (base.AnualIncome <= 20000.00) ? (base.AnualIncome * 0.15) - (HealthExpenditures * 0.5) : (base.AnualIncome * 0.25) - (HealthExpenditures * 0.5);
        }
    }
}
