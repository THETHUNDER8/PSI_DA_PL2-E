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
        public Sala Sala { get; set; }//faz FK das salas
        public Filme Filme { get; set; }// faz FK dos filmes

        public ICollection<Bilhete> Bilhetes { get; set; }

        public Sessao()
        {
            Bilhetes = new List<Bilhete>();
        }

        public override string ToString()
        {

            return "Data/hora-" + DataHora + "|Preço-" + preco  + "|Filme-" + Filme.nome + "|Sala-" + Sala.nome;
        }
    }
}
