using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Form_Sessoes : Form
    {
        public Form_Sessoes()
        {
            InitializeComponent();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void btn_criarSessao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_preco.Text) || listb_salas.SelectedItem == null || listb_filmes.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos ou verifique se tem um filme e uma sala selecionados!");
                return;
            }

            try
            {
                
                Sessao newSessao = new Sessao();
                using (var context = new CinemaContext())
                {
                    DateTime dataHora = Picker_dataHora.Value;

                    
                    Sala selectedSala = (Sala)listb_salas.SelectedItem;
                    bool sessionExists = context.Sessoes.Any(s => s.ID == selectedSala.Id && s.DataHora == dataHora);
                    if (dataHora < DateTime.Now)
                    {
                        MessageBox.Show("A data e hora selecionadas devem ser posteriores à data e hora atual!");
                        return;
                    }
                    if (sessionExists)
                    {
                        MessageBox.Show("Já existe uma sessão marcada para a mesma sala e hora selecionadas!");
                        return;
                    }

                    //ToDo fazer a conta entreduração do filme e a hora para que so possa haver sessoes depis do filme acabar

                    newSessao.DataHora = dataHora;
                    newSessao.preco = float.Parse(tb_preco.Text);
                    //busca filme
                    newSessao.Filme = (Filme)listb_filmes.SelectedItem;
                    //busca sala
                    newSessao.Sala = (Sala)listb_salas.SelectedItem;

                    context.Sessoes.Add(newSessao);
                    context.SaveChanges();
                }

                FormController.ClearInputFields(tb_preco);
                LoadSessoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar a Sessao: " + ex.Message);
            }
        }

        private void btn_eliminarSessao_Click(object sender, EventArgs e)
        {
            if (listb_sessoes.SelectedItem == null)
            {
                return;
            }
            Sessao sessaoToRemove = (Sessao)listb_sessoes.SelectedItem;

            using (var context = new CinemaContext())
            {
                // remove com o mesmo id selecionado da BD
                Sessao sessao = context.Sessoes.SingleOrDefault(f => f.ID == sessaoToRemove.ID);

                if (sessao != null)
                {
                    context.Sessoes.Remove(sessao);
                    context.SaveChanges();
                }
            }

            LoadSessoes();
        }

        private void Form_Sessoes_Load(object sender, EventArgs e)
        {
            LoadFilmes();
            LoadSalas();
            LoadSessoes();
            listb_filmes.SelectedItem = null;
            listb_salas.SelectedItem = null;
            listb_sessoes.SelectedItem = null;
        }

        public void LoadFilmes()
        {
            listb_filmes.DataSource = null;
            using (var context = new CinemaContext())
            {
                var filmes = context.Filmes.Where(f => f.activo).Include("categoria").ToList();//verifica se o estado do filme é true que significa
                                                                          //que o filme esta disponivel para eximição
                listb_filmes.DataSource = filmes;


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

        private void LoadSessoes()
        {
            listb_sessoes.DataSource = null;
            using (var context = new CinemaContext())
            {
                var sessoes = context.Sessoes.Include("Filme").Include("Sala").ToList();
                listb_sessoes.DataSource = sessoes;

            }
        }

        private void btn_bilhetes_Click(object sender, EventArgs e)
        {
            if (listb_sessoes.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma sessao para comprar bilhetes");
                return;
            }

            Sessao selectedSessao = (Sessao)listb_sessoes.SelectedItem;
            Form_Atendimento formAtendimento = new Form_Atendimento(selectedSessao);
            FormController.trocaForm(this, formAtendimento);
        }
    }
}
