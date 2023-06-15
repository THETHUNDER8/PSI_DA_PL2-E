using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;//bibliotecas para dar export em pdf,txt etc...
using System.IO;


namespace Projeto_DA.Models
{
    public class Bilhete
    {
        public int Id { get; set; }
        public int lugar { get; set; }
        public bool estado { get; set; }


        public Bilhete(int id, int Lugar, bool Estado)
        {
            Id = id;
            lugar = Lugar;
            estado = Estado;
        }

        public static void exportar()
        {

            var date = DateTime.Now;
            string date_str = "Data: " + date.ToString();
            string filmevisto = "Filme: ";
            //Image imagem = Image.GetInstance("img/img.jpg");//diretório da imagem para o ticket
            //imagem.SetAbsolutePosition(10, 10);

            var doc = new Document(PageSize.A6);//Tamanho da página do ticket, escolhi A6 porque é um tamanho mais pequeno
            PdfWriter.GetInstance(doc, new FileStream("C:\\Users\\Hugo Gonçalves\\Desktop\\New folderticket.pdf", FileMode.Create));

            doc.Open();

            Console.WriteLine(date_str);
            Paragraph titulo = new Paragraph("Bem vindo ao cinema!", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;

            doc.Add(titulo);
            doc.Add(new Paragraph(date_str));
            doc.Add(new Paragraph(filmevisto));

            //doc.Add(imagem);


            doc.Close();
        }

    }
}