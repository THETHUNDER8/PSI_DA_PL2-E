using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Form_Filmes : Form
    {
        public Form_Filmes()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void Form_Filmes_Load(object sender, EventArgs e)
        {
            LoadFilmes();
            LoadCategorias();
            listb_Filmes.SelectedItem = null;
            FormController.ClearInputFields(tb_nomeFilme);
        }

        public void LoadCategorias() 
        {
            using (var context = new CinemaContext())
            {
                cb_categorias.DataSource = context.Categorias.ToList();
                cb_categorias.DisplayMember = "nome";
                cb_categorias.ValueMember = "Id";

            }

        }

        public void LoadFilmes()
        {
            listb_Filmes.DataSource = null;
            using (var context = new CinemaContext())
            {
                listb_Filmes.DataSource = context.Filmes.ToList();
            }

        }

        private void Form_Filmes_Click(object sender, EventArgs e)
        {
            listb_Filmes.ClearSelected();
            FormController.ClearInputFields(tb_nomeFilme);
        }

        private void btn_criarFilme_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nomeFilme.Text) || string.IsNullOrEmpty(tb_duracao.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                Filme newFilme = new Filme();
                newFilme.nome = tb_nomeFilme.Text;
                newFilme.duracao = Convert.ToInt32(tb_duracao.Text);
                newFilme.categoria = (Categoria)cb_categorias.SelectedItem;// erro categoria vem null
                newFilme.activoS = "Desativado";

                using (var context = new CinemaContext())
                {
                    context.Filmes.Add(newFilme);
                    context.SaveChanges();
                }

                FormController.ClearInputFields(tb_nomeFilme, tb_duracao);
                LoadFilmes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o filme: " + ex.Message);
            }
        }

        private void btn_Eleminar_Click(object sender, EventArgs e)
        {
            if (listb_Filmes.SelectedItem == null)
            {
                return;
            }

            Filme filmeToRemove = (Filme)listb_Filmes.SelectedItem; 

            using (var context = new CinemaContext())
            {
                // remove o filme com o mesmo id selecionado da BD
                Filme filme = context.Filmes.SingleOrDefault(f => f.Id == filmeToRemove.Id);

                if (filme != null)
                {
                    context.Filmes.Remove(filme); 
                    context.SaveChanges(); 
                }
            }

            LoadFilmes(); 
        }


        private void btn_activate_deactivate_Click(object sender, EventArgs e)
        {
            if (listb_Filmes.SelectedItem == null)
            {
                return;
            }

            Filme selectedFilme = (Filme)listb_Filmes.SelectedItem; // seleciona filme

            using (var context = new CinemaContext())
            {
                Filme filme = context.Filmes.Find(selectedFilme.Id);

                if (filme.activo)// muda de true para false e viceversa
                {
                    filme.activo = false;
                }
                else
                {
                    filme.activo = true;
                } 

                if (filme.activo)
                {
                    filme.activoS = "Activado";
                }
                else
                {
                    filme.activoS = "Desativado";
                }
                context.SaveChanges();

            }

            LoadFilmes(); // Reload da lista

        }

    }
}
