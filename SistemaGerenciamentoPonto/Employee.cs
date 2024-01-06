using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoPonto
{
    public class Employee
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }

        public Employee(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
    }
}
