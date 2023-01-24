using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMembroEstatico
{
    internal class ConversorDeMoedas
    {
        public static double IOF = 0.06;
        public static double ValorDolar;
        public static double ValorComprar;

        public static double ValorPagar()
        {
            return ValorDolar * ValorComprar + (ValorDolar * ValorComprar * IOF);
        }
    }
}