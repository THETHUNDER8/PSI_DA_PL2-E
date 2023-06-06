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

                listb_clientes.Items.Add(newCliente);
                FormController.ClearInputFields(tb_nome, tb_morada, tb_numFiscal);
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

            listb_clientes.Items.RemoveAt(listb_clientes.SelectedIndex);

        }

        private void btn_editar_cliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_numFiscal.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {
                Cliente selectedCliente = (Cliente)listb_clientes.SelectedItem;
                using (var context = new CinemaContext())
                {
                    // Retrieve the selected item from the database for updating
                    Cliente clienteToUpdate = context.Clientes.Find(selectedCliente.Id);//erro nao vai buscar ID retorna null:
                    // Update the properties with the new values
                    clienteToUpdate.nome = tb_nome.Text;
                    clienteToUpdate.morada = tb_morada.Text;
                    clienteToUpdate.numFiscal = tb_numFiscal.Text;

                    context.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o cliente: " + ex.Message);
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

    }
}
