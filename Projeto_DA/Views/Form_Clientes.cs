using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void btn_criarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_numFiscal.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {

                Cliente newCliente = new Cliente();
                newCliente.nome = tb_nome.Text;
                newCliente.morada = tb_morada.Text;
                newCliente.numFiscal = tb_numFiscal.Text;
                using (var context = new CinemaContext())
                {
                    context.Clientes.Add(newCliente);
                    context.SaveChanges();
                }

                FormController.ClearInputFields(tb_nome, tb_morada, tb_numFiscal);
                LoadClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o cliente: " + ex.Message);
            }
        }
        private void btn_eleminarCliente_Click(object sender, EventArgs e)
        {
            if (listb_clientes.SelectedItem == null)
            {
                return;
            }
            Cliente ClienteToRemove = (Cliente)listb_clientes.SelectedItem;

            using (var context = new CinemaContext())
            {
                // remove com o mesmo id selecionado da BD
                Cliente Cliente = context.Clientes.SingleOrDefault(f => f.Id == ClienteToRemove.Id);

                if (Cliente != null)
                {
                    context.Clientes.Remove(Cliente);
                    context.SaveChanges();
                }
            }

            LoadClientes();

        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_numFiscal.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            if (listb_clientes.SelectedItem == null)
            {
                return;
            }
            try
            {
                Cliente selectedCliente = (Cliente)listb_clientes.SelectedItem;
                using (var context = new CinemaContext())
                {
                    // Vai buscar á db o item selecionado
                    Cliente clienteToUpdate = context.Clientes.Find(selectedCliente.Id);
                    // Update 
                    clienteToUpdate.nome = tb_nome.Text;
                    clienteToUpdate.morada = tb_morada.Text;
                    clienteToUpdate.numFiscal = tb_numFiscal.Text;

                    context.SaveChanges();
                }
                FormController.ClearInputFields(tb_nome, tb_morada, tb_numFiscal);
                LoadClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar o cliente: " + ex.Message);
            }
        }

        private void listb_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listb_clientes.SelectedItem == null)
            {
                return;
            }
            else
            {
                Cliente selectedCliente = (Cliente)listb_clientes.SelectedItem;
                //coloca os valores textboxes
                tb_nome.Text = selectedCliente.nome;
                tb_morada.Text = selectedCliente.morada;
                tb_numFiscal.Text = selectedCliente.numFiscal;

            }
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            LoadClientes();
            listb_clientes.SelectedItem = null;
            FormController.ClearInputFields(tb_nome, tb_morada, tb_numFiscal);
        }

        private void LoadClientes()
        {
            listb_clientes.DataSource = null;
            using (var context = new CinemaContext())
            {
                listb_clientes.DataSource = context.Clientes.ToList();
            }
        }

        private void Form_Clientes_Click(object sender, EventArgs e)
        {
            listb_clientes.ClearSelected();
            FormController.ClearInputFields(tb_nome, tb_morada, tb_numFiscal);
        }
    }
}
