using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Form_Cinema : Form
    {
        public Form_Cinema()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void btn_altCinema_Click(object sender, EventArgs e)
        {
            Form_DefinicoesCinema Form_DefinicoesCinema = new Form_DefinicoesCinema();
            FormController.trocaForm(this, Form_DefinicoesCinema);
        }

        private void Form_Cinema_Load(object sender, EventArgs e)
        {
            loadCinema();
            LoadSalas();
            listb_salas.SelectedItem = null;
            FormController.ClearInputFields(tb_nome, tb_fila, tb_coluna);
        }

        private void loadCinema()
        {
            using (var context = new CinemaContext())
            {

                var cinema = context.Cinema.FirstOrDefault();

                if (cinema == null)
                {
                    lbl_nome.Text = "-----";
                    lbl_morada.Text = "-----";
                    lbl_email.Text = "-----";
                    lbl_salasMax.Text = "-----";
                }
                else
                {
                    
                    lbl_nome.Text = cinema.nome;
                    lbl_morada.Text = cinema.morada;
                    lbl_email.Text = cinema.email;
                    lbl_salasMax.Text = cinema.maxSalas.ToString();
                }
            }
            
        }

        private void btn_criarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_fila.Text) || string.IsNullOrEmpty(tb_coluna.Text))
            {
                MessageBox.Show("Preencha todos os campos de sala!");
                return;
            }

            try
            {

                Sala newSala = new Sala();
                newSala.nome = tb_nome.Text;
                newSala.filas = int.Parse(tb_fila.Text);
                newSala.colunas = int.Parse(tb_coluna.Text);

                using (var context = new CinemaContext())
                {
                    context.Salas.Add(newSala);
                    context.SaveChanges();
                }
                listb_salas.SelectedItem = null;
                FormController.ClearInputFields(tb_nome, tb_fila, tb_coluna);
                LoadSalas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar sala: " + ex.Message);
            }
        }

        private void btn_editarSala_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_fila.Text) || string.IsNullOrEmpty(tb_coluna.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            if (listb_salas.SelectedItem == null)
            {
                return;
            }
            try
            {
                Sala selectedSala = (Sala)listb_salas.SelectedItem;
                using (var context = new CinemaContext())
                {
                    // Vai buscar á db o item selecionado
                    Sala salaToUpdate = context.Salas.Find(selectedSala.Id);
                    // Update 
                    salaToUpdate.nome = tb_nome.Text;
                    salaToUpdate.filas = Convert.ToInt32(tb_fila.Text);
                    salaToUpdate.colunas = Convert.ToInt32(tb_coluna.Text);

                    context.SaveChanges();
                }
                FormController.ClearInputFields(tb_nome, tb_fila, tb_coluna);
                LoadSalas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar a sala: " + ex.Message);
            }
        }

        private void btn_eliminarSala_Click(object sender, EventArgs e)
        {
            if (listb_salas.SelectedItem == null)
            {
                return;
            }
            Sala SalaToRemove = (Sala)listb_salas.SelectedItem;

            using (var context = new CinemaContext())
            {
                // remove com o mesmo id selecionado da BD
                Sala sala = context.Salas.SingleOrDefault(f => f.Id == SalaToRemove.Id);

                if (sala != null)
                {
                    context.Salas.Remove(sala);
                    context.SaveChanges();
                }
            }

            LoadSalas();
        }

        private void listb_salas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listb_salas.SelectedItem == null)
            {
                return;
            }
            else
            {
                Sala selectedSala = (Sala)listb_salas.SelectedItem;
                //coloca os valores textboxes
                tb_nome.Text = selectedSala.nome;
                tb_fila.Text = selectedSala.filas.ToString();
                tb_coluna.Text = selectedSala.colunas.ToString();

            }
        }

        private void LoadSalas()
        {
            listb_salas.DataSource = null;
            using (var context = new CinemaContext())
            {
                listb_salas.DataSource = context.Salas.ToList();

            }
        }

        private void Form_Cinema_Click(object sender, EventArgs e)
        {
            listb_salas.ClearSelected();
            FormController.ClearInputFields(tb_nome, tb_fila, tb_coluna);
        }
    }
}
