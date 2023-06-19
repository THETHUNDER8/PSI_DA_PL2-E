using Projeto_DA.Controllers;
using Projeto_DA.Models;
using Projeto_DA.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA
{
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        public Funcionario SelectedItem//permite vir buscar o funcionario selecionado
        {
            get { return (Funcionario)cb_funcionario.SelectedItem; }
        }

        private  void bnt_cinema_Click(object sender, EventArgs e)
        {

            Form_Cinema Form_Cinema = new Form_Cinema();
            FormController.trocaForm(this, Form_Cinema);

        }

        private void btn_filmes_Click(object sender, EventArgs e)
        {
            Form_Filmes Form_Filmes = new Form_Filmes();
            FormController.trocaForm(this, Form_Filmes);
        }

        private void btn_sessoes_Click(object sender, EventArgs e)
        {
            Form_Sessoes Form_Sessoes = new Form_Sessoes();
            FormController.trocaForm(this, Form_Sessoes);
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Form_Clientes Form_Clientes = new Form_Clientes();
            FormController.trocaForm(this, Form_Clientes);
        }

        private void btn_Funcionaios_Click(object sender, EventArgs e)
        {
            Form_Funcionarios Form_Funcionarios = new Form_Funcionarios();
            FormController.trocaForm(this, Form_Funcionarios);
        }

        private void cb_funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {
            using (var context = new CinemaContext())
            {
                int cinemaCount = context.Cinema.Count();
                if (cinemaCount == 0)
                {
                    Form_DefinicoesCinema formDefinicoesCinema = new Form_DefinicoesCinema();
                    FormController.trocaForm(this, formDefinicoesCinema);
                }
            }

            LoadFuncionarios();
            LoadSessoesHoje();
        }

        private void LoadFuncionarios()
        {
            cb_funcionario.DataSource = null;
            using (var context = new CinemaContext())
            {
                cb_funcionario.DataSource = context.Funcionarios.ToList();
                cb_funcionario.DisplayMember = "nome";
            }
        }

        private void LoadSessoesHoje()
        {
            listBox1.Items.Clear();

            using (var context = new CinemaContext())
            {
                // data de hoje
                DateTime today = DateTime.Today;

                // busca sessoes
                var sessions = context.Sessoes.ToList();

                // filtra por dia de hoje
                var filteredSessions = sessions.Where(s => s.DataHora.Date == today);

                // adiciona as sessoess filtradas a listbox
                foreach (var session in filteredSessions)
                {
                    listBox1.Items.Add(session);
                }
            }
        }


    }
}
