using Projeto_DA.Controllers;
using Projeto_DA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            using (var context = new CinemaContext())
            {
                List<Cliente> clientList = context.Clientes.ToList();
                Cliente newCliente = new Cliente
                {
                    nome = tb_nome.Text,
                    morada = tb_morada.Text,
                    numFiscal = Convert.ToInt32(tb_numFiscal)
                };
                // Adiciona clientes e salva na base de dados
                context.Clientes.Add(newCliente);
                context.SaveChanges();
                listb_clientes.Items.Add(newCliente);

            }
        }
    }
}
