using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Aluno
    {
        public string Nome;
        public string Resultado;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double QuantoFalta;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public string Status()
        {
            if (NotaFinal() >= 60.0)
            {
                Resultado = "APROVADO";
            }
            else
            {
                Resultado = "REPROVADO";
            }
            return Resultado;
        }
    }
}
