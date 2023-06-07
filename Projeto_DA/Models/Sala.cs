using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int colunas { get; set; }
        public int filas { get; set; }

        public Sala() 
        {
        
        
        }
        public override string ToString()
        {
            return nome + "(Filas-" + filas + ")" + "(Colunas-" + colunas + ")";
        }
    }
}
