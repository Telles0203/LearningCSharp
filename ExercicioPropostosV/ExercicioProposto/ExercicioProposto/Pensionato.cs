using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto
{
    internal class Pensionato
    {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Pensionato(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nome} , {Email}";
        }

    }
}
