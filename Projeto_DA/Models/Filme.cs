using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public int duracao { get; set; }
        public Categoria Categoria { get; set; }
        public bool activo { get; set; }
        public string activoS { get; set; }

        public Filme()
        {
            
            
        }

        public override string ToString()
        {
            return nome + "|Categoria-" + Categoria + "|" + "Duração-" + duracao + "||" + "|Estado-" + activoS + "||";
        }

    }

}
