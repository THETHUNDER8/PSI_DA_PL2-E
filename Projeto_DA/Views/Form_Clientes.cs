using Projeto_DA.Controllers;
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
    }
}
