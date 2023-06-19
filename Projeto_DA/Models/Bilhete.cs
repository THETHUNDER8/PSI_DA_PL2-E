using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;//bibliotecas para dar export em pdf,txt etc...
using System.IO;
using static System.Net.WebRequestMethods;


namespace Projeto_DA.Models
{
    public class Bilhete
    {
        public int Id { get; set; }
        public int filaBilhete  { get; set; }

        public int colunaBilhete { get; set; }
        public bool estado { get; set; }

        public Sessao Sessao { get; set; }


        public Bilhete()
        {

        }

        public static void exportar(string clienteNome, string filmeNome, DateTime date, int fila, int coluna, string funcionarioNome)
        {
            string date_str = "Data: " + date.ToString();
            string filmevisto = "Filme: " + filmeNome;

            var doc = new Document(PageSize.A6);
            //Envia para o desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Bilhete.pdf");

            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            doc.Open();

            Paragraph titulo = new Paragraph("Bem vindo ao cinema!", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;

            doc.Add(titulo);
            doc.Add(new Paragraph(date_str));
            doc.Add(new Paragraph(filmevisto));
            doc.Add(new Paragraph("Cliente: " + (string.IsNullOrEmpty(clienteNome) ? "anonimo" : clienteNome)));
            doc.Add(new Paragraph("Fila: " + fila));
            doc.Add(new Paragraph("Coluna: " + coluna));
            doc.Add(new Paragraph("Funcionário: " + funcionarioNome));

            doc.Close();
        }

        public override string ToString()
        {
            return  "| Colunas-" + colunaBilhete + "| Fila-" + filaBilhete;
        }
    }
}