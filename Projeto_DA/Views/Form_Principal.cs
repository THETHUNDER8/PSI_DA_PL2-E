﻿using Projeto_DA.Controllers;
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
    }
}
