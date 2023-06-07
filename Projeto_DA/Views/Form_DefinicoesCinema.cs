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
    public partial class Form_DefinicoesCinema : Form
    {
        public Form_DefinicoesCinema()
        {
            InitializeComponent();
        }

        private void btn_criarCinema_Click(object sender, EventArgs e)
        {
            using (var context = new CinemaContext())
            {
                int cinemaCount = context.Cinema.Count();
                if (cinemaCount == 0)
                {
                    CriaCinema();
                    Form_Principal Form_Principal = new Form_Principal();
                    FormController.trocaForm(this, Form_Principal);
                }
                else
                {
                    UpdateCinema();
                    Form_Cinema Form_Cinema = new Form_Cinema();
                    FormController.trocaForm(this, Form_Cinema);
                }
            }

        }

        private void CriaCinema()
        {
            if (string.IsNullOrEmpty(tb_nomeCinema.Text) || string.IsNullOrEmpty(tb_moradaCinema.Text) || string.IsNullOrEmpty(tb_emailCinema.Text) || string.IsNullOrEmpty(tb_maxSalas.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {

                Cinema novoCinema = new Cinema();
                novoCinema.nome = tb_nomeCinema.Text;
                novoCinema.morada = tb_moradaCinema.Text;
                novoCinema.email = tb_emailCinema.Text;
                novoCinema.maxSalas = Convert.ToInt32(tb_maxSalas.Text);
                using (var context = new CinemaContext())
                {
                    context.Cinema.Add(novoCinema);
                    context.SaveChanges();
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o cliente: " + ex.Message);
            }
        }

        private void UpdateCinema()
        {
            if (string.IsNullOrEmpty(tb_nomeCinema.Text) || string.IsNullOrEmpty(tb_moradaCinema.Text) || string.IsNullOrEmpty(tb_emailCinema.Text) || string.IsNullOrEmpty(tb_maxSalas.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            try
            {
                
                using (var context = new CinemaContext())
                {
                    // Vai buscar á db o cinema
                    Cinema cinemaUpdate = context.Cinema.Find(1);
                    // Update 
                    cinemaUpdate.nome = tb_nomeCinema.Text;
                    cinemaUpdate.morada = tb_moradaCinema.Text;
                    cinemaUpdate.email = tb_emailCinema.Text;
                    cinemaUpdate.maxSalas = Convert.ToInt32(tb_maxSalas.Text);

                    context.SaveChanges();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o cliente: " + ex.Message);
            }
        }
    }
}
