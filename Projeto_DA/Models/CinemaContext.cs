using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Projeto_DA.Models
{
    public class CinemaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }

        public DbSet<Sala> Salas { get; set; }

        public DbSet<Bilhete> Bilhetes { get; set; }

        public DbSet<Sessao> Sessoes { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Cinema> Cinema { get; set; }

        public CinemaContext() : base("DBConnString") { }
    }
}
