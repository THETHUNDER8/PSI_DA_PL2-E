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
    public partial class Form_escolheCliente : Form
    {
        public Form_escolheCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sessao sessao = new Sessao();
            using (var context = new CinemaContext())
            {
                //Filme filme = context.Filmes.FirstOrDefault(f => f.Id == sessao.Filme.Id);
                //Bilhete bilhete = context.Bilhetes.FirstOrDefault(b => b.Id == sessao.Filme.Id);
                //// vai buscar funcionario
                //Form_Principal Form_Principal = new Form_Principal();
                //Form_Principal.ShowDialog();
                //Funcionario selectedObject = Form_Principal.SelectedItem;
                //Funcionario funcionario = selectedObject;
                //Cliente cliente = (Cliente)listBox1.SelectedItem;

                //cliente.nome, filme.nome, sessao.DataHora, bilhete.filaBilhete, bilhete.colunaBilhete, funcionario.nome
                Bilhete.exportar("-----", "----", DateTime.Now, 0, 0, "-----");

            }
        }

        private void Form_escolheCliente_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            using (var context = new CinemaContext())
            {
                listBox1.DataSource = context.Clientes.ToList();
            }
        }
    }
}
