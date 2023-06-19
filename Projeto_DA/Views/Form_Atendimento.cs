using Org.BouncyCastle.Bcpg.OpenPgp;
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
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace Projeto_DA.Views
{
    public partial class Form_Atendimento : Form
    {
        private bool selected = false;//lugar selecionado para trocar cores                             
        //List<string> selectedLugar = new List<string>();// define uma lista para guardar os lugar selecinados
        public Form_Atendimento(Sessao sessao)
        {
            InitializeComponent();

            int rows;
            int columns;

            using (var context = new CinemaContext())
            {
                rows = sessao.Sala.filas;
                columns = sessao.Sala.colunas;
            }

            // cria a sala de cinema escolhida para essa sessao
            bool[,] cinemaRoom = new bool[rows, columns];

            // mostra os lugares disponiveis e indisponiveis
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // true representa um logar disponivel
                    cinemaRoom[i, j] = true;
                }
            }

            //ToDo representar os lugares ocupados

            // Cria um TableLayoutPanel
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.RowCount = rows;
            tableLayoutPanel.ColumnCount = columns;

            // controla o  tamanho de cada celula
            tableLayoutPanel.ColumnStyles.Clear();
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columns));
            }

            tableLayoutPanel.RowStyles.Clear();
            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
            }

            // adiciona butoes que representam lugares
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Button lugarButton = new Button();
                    lugarButton.Dock = DockStyle.Fill;
                    lugarButton.Text = $"Lugar {i + 1}-{j + 1}";

                    if (cinemaRoom[i, j])
                    {
                        lugarButton.BackColor = Color.Green;
                        lugarButton.Enabled = true;
                    }
                    else
                    {
                        lugarButton.BackColor = Color.Gray;
                        lugarButton.Enabled = false;
                    }

                    // Event handler para os butoes dos lugares
                    lugarButton.Click += lugarButton_Click;

                    tableLayoutPanel.Controls.Add(lugarButton, j, i);
                }
            }

            // Climpa possiveis controlos que existam no panel
            panel1.Controls.Clear();

            // Add the TableLayoutPanel to the panel
            tableLayoutPanel.Dock = DockStyle.Fill;
            panel1.Controls.Add(tableLayoutPanel);
        }


        private void lugarButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Extract the seat information from the button text
            string seatText = clickedButton.Text;
            string[] seatParts = seatText.Split(' ');
            string[] seatCoordinates = seatParts[1].Split('-');
            int fila = int.Parse(seatCoordinates[0]);
            int coluna = int.Parse(seatCoordinates[1]);

            if (selected)
            {
                clickedButton.BackColor = Color.Green;
                selected = false;
                remove_listaBilhestes();
            }
            else
            {
                clickedButton.BackColor = Color.Yellow;
                selected = true;
                add_listaBilhetes(fila, coluna);
            }
        }

        private void add_listaBilhetes(int fila, int coluna)
        {
            Bilhete bilhete = new Bilhete();
            using (var context = new CinemaContext())
            {

                bilhete.filaBilhete = fila;
                bilhete.colunaBilhete = coluna;


                context.Bilhetes.Add(bilhete);
                context.SaveChanges();
            }

            LoadBilhetes();
        }

        private void remove_listaBilhestes()
        {

            if (lb_bilhetes.SelectedItem == null)
            {
                return;
            }

            Bilhete BilheteToRemove = (Bilhete)lb_bilhetes.SelectedItem;

            using (var context = new CinemaContext())
            {
                // remove o filme com o mesmo id selecionado da BD
                Bilhete bilhete = context.Bilhetes.SingleOrDefault(f => f.Id == BilheteToRemove.Id);

                if (bilhete != null)
                {
                    context.Bilhetes.Remove(bilhete);
                    context.SaveChanges();
                }
            }
            LoadBilhetes();
        }
   
        private void LoadBilhetes()
        {
            lb_bilhetes.DataSource = null;
            using (var context = new CinemaContext())
            {
                lb_bilhetes.DataSource = context.Bilhetes.ToList();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Principal Form_Principal = new Form_Principal();
            FormController.trocaForm(this, Form_Principal);
        }

        private void btn_emitirBilhete_Click_1( object sender, EventArgs e)
        {
            //Sessao sessao = new Sessao();
            using (var context = new CinemaContext())
            {
                
                //Filme filme = context.Filmes.FirstOrDefault(f => f.Id == sessao.Filme.Id);
                //Bilhete bilhete = context.Bilhetes.FirstOrDefault(b => b.Id == sessao.Filme.Id);
                //Form_Principal Form_Principal = new Form_Principal();
                //Form_Principal.ShowDialog();

                //Funcionario selectedObject = Form_Principal.SelectedItem;

                //Funcionario funcionario = selectedObject;


                DialogResult result = MessageBox.Show("Pretende comprar com cliente anonimo?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //filme.nome, sessao.DataHora, bilhete.filaBilhete, bilhete.colunaBilhete, funcionario.nome
                    Bilhete.exportar("anonimo", "----",DateTime.Now,0,0,"-----");
                }
                else if (result == DialogResult.No)
                {
                    Form_escolheCliente Form_escolheCliente = new Form_escolheCliente();
                    FormController.trocaForm(this, Form_escolheCliente);
                }
            }
        }
    }
}
