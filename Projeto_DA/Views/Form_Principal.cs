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

        private void bnt_cinema_Click(object sender, EventArgs e)
        {

            // Create an instance of Form_Cinema
            Form_Cinema Form_Cinema = new Form_Cinema();

            // Hide the current form 
            this.Hide();

            // Show the new form 
            Form_Cinema.ShowDialog();

           
        }
    }
}
