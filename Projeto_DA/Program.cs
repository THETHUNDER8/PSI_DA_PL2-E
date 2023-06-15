using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Projeto_DA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var context = new CinemaContext())
            {
                // llista de categoriass a adiconar
                var categoryNames = new List<string>
                    {
                    "Comédia",
                    "Sci - fi",
                    "Terror",
                    "Romance",
                    "Acção",
                    "Thriller",
                    "Drama" ,
                    "Mistério" ,
                    "Crime" ,
                    "Aventura",
                    "Fantasia" ,
                    "Animação"
                };

                foreach (var categoryName in categoryNames)
                {
                    // Check if the category already exists
                    var existingCategory = context.Categorias.FirstOrDefault(c => c.nome == categoryName);

                    //se as categorias nao existrirem cria
                    if (existingCategory == null)
                    {
                        var newCategory = new Categoria { nome = categoryName };
                        context.Categorias.Add(newCategory);
                    }
                }

                context.SaveChanges();
            }
            Application.Run(new Form_Principal());
        }
    }
}

