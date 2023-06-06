using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DA.Controllers
{
    public static class FormController
    {
        public static void trocaForm(Form FormAtual, Form novoForm)
        {
            //esconde form atual
            FormAtual.Hide();
            //Mostra form
            novoForm.ShowDialog();

        }

        public static void ClearInputFields(params TextBox[] textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Text = string.Empty;
            }
        }
    }
}
