using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_DA.Models
{
    public class Sessao
    {
        public int ID { get; set; }
        public DateTime DataHora { get; set; }
        public float preco { get; set; }
        public Sala Sala { get; set; }
        public Filme Filme { get; set; }

        public Sessao()
        {
        
        }

        public override string ToString()
        {

            return "Data/hora-" + DataHora + "|Preço-" + preco  + "|Filme-" + Filme + "|Sala-" + Sala;
        }
    }
}
