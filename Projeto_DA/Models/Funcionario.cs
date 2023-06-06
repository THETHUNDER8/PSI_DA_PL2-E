using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Funcionario : Pessoa
    {
        public int Id { get; set; }
        public string funcao { get; set; }
        public float salario { get; set; }

        public Funcionario()
        {
            
        }

        public override string ToString()
        {
            return nome + "(Morada-" + morada + ")" + "(Funcao-" + funcao + ")" + "(Salario-" + salario + "€)";
        }
    }
}
