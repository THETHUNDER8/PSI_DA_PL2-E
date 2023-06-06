﻿using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text.pdf;//bibliotecas para dar export em pdf,txt etc...

namespace Projeto_DA.Models
{
    internal class Bilhete
    {
        public int Id { get; set; }
        int lugar;
        bool estado;

        public void exportar()
        {

            var date = DateTime.Now;
            string date_str = "Data: " + date.ToString();
            string filmevisto = "Filme: ";
            Image imagem = Image.GetInstance("img/img.jpg");//diretório da imagem para o ticket
            imagem.SetAbsolutePosition(10, 10);

            var doc = new Document(PageSize.A6);//Tamanho da página do ticket, escolhi A6 porque é um tamanho mais pequeno
            PdfWriter.GetInstance(doc, new FileStream("D:/ticket.pdf", FileMode.Create));

            doc.Open();

            Console.WriteLine(date_str);
            Paragraph titulo = new Paragraph("Bem vindo ao cinema!", new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD));
            titulo.Alignment = Element.ALIGN_CENTER;

            doc.Add(titulo);
            doc.Add(new Paragraph(date_str));
            doc.Add(new Paragraph(filmevisto));

            doc.Add(imagem);


            doc.Close();
        }
    }
}