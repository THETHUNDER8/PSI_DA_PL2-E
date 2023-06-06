using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Cliente : Pessoa
    {
        public int Id { get; set; }
        public string numFiscal { get; set; }

        public Cliente()
        {

        }

        public override string ToString()
        {
            return nome + "(Morada-"+morada+ ")" + "(NIF-" + numFiscal + ")";
        }
    }
}
