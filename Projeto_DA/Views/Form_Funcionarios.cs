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
    public partial class Form_Funcionarios : Form
    {
        public Form_Funcionarios()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void btn_criarFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_funcao.Text) || string.IsNullOrEmpty(tb_funcao.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            try
            {

                Funcionario newFuncionario = new Funcionario();
                newFuncionario.nome = tb_nome.Text;
                newFuncionario.morada = tb_morada.Text;
                newFuncionario.funcao = tb_funcao.Text;
                newFuncionario.salario = float.Parse(tb_salario.Text);

                using (var context = new CinemaContext())
                {
                    context.Funcionarios.Add(newFuncionario);
                    context.SaveChanges();
                }

                FormController.ClearInputFields(tb_nome, tb_morada, tb_funcao, tb_salario);
                LoadFuncionarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao criar o Funcionario: " + ex.Message);
            }
        }

        private void btn_editarFuncionario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_nome.Text) || string.IsNullOrEmpty(tb_morada.Text) || string.IsNullOrEmpty(tb_funcao.Text) || string.IsNullOrEmpty(tb_funcao.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }
            if (listb_Funcionario.SelectedItem == null)
            {
                return;
            }
            try
            {
                Funcionario selectedFuncionario = (Funcionario)listb_Funcionario.SelectedItem;
                using (var context = new CinemaContext())
                {
                    // Vai buscar á db o item selecionado
                    Funcionario FuncionarioToUpdate = context.Funcionarios.Find(selectedFuncionario.Id);
                    // Update 
                    FuncionarioToUpdate.nome = tb_nome.Text;
                    FuncionarioToUpdate.morada = tb_morada.Text;
                    FuncionarioToUpdate.funcao = tb_funcao.Text;
                    FuncionarioToUpdate.salario = float.Parse(tb_salario.Text);

                    context.SaveChanges();
                }
                LoadFuncionarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao editar o Funcionario: " + ex.Message);
            }
        }

        private void btn_eleminarFuncionario_Click(object sender, EventArgs e)
        {
            if (listb_Funcionario.SelectedItem == null)
            {
                return;
            }
            Funcionario funcionarioToRemove = (Funcionario)listb_Funcionario.SelectedItem;

            using (var context = new CinemaContext())
            {
                // remove com o mesmo id selecionado da BD
                Funcionario funcionario = context.Funcionarios.SingleOrDefault(f => f.Id == funcionarioToRemove.Id);

                if (funcionario != null)
                {
                    context.Funcionarios.Remove(funcionario);
                    context.SaveChanges();
                }
            }

            LoadFuncionarios();
        }

        private void listb_Funcionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listb_Funcionario.SelectedItem == null)
            {
                return;
            }
            else
            {
                Funcionario selectedFuncionario = (Funcionario)listb_Funcionario.SelectedItem;
                //coloca os valores textboxes
                tb_nome.Text = selectedFuncionario.nome;
                tb_morada.Text = selectedFuncionario.morada;
                tb_funcao.Text = selectedFuncionario.funcao;
                tb_salario.Text = selectedFuncionario.salario.ToString();

            }
        }

        private void Form_Funcionarios_Load(object sender, EventArgs e)
        {
            LoadFuncionarios();
            listb_Funcionario.SelectedItem = null;
            FormController.ClearInputFields(tb_nome, tb_morada, tb_funcao, tb_salario);
        }

        private void LoadFuncionarios()
        {
            listb_Funcionario.DataSource = null;
            using (var context = new CinemaContext())
            {
                listb_Funcionario.DataSource = context.Funcionarios.ToList();
            }
        }

        private void Form_Funcionarios_Click(object sender, EventArgs e)
        {
            listb_Funcionario.ClearSelected();
            FormController.ClearInputFields(tb_nome, tb_morada, tb_funcao, tb_salario);
        }
    }
}
