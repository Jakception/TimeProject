using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace TimeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   

        }

        public void pdfCreator()
        {
            try
            {
                FileStream fs = new FileStream("..\\PDF\\fichier.pdf", FileMode.Create);

                Document doc = new Document(PageSize.A4.Rotate());
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();
                /* document.AddAuthor("Micke Blomquist");
               document.AddCreator("Sample application using iTextSharp");
               document.AddKeywords("PDF tutorial education");
               document.AddSubject("Document subject - Describing the steps creating a PDF document");
               document.AddTitle("Liste des plans");*/

                PdfContentByte cb = writer.DirectContent;
                BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                cb.SetFontAndSize(f_cb, 14);
             
                // LOGO
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(global::TimeProject.Properties.Resources.logo, BaseColor.WHITE);
                img.ScalePercent(80);
                img.SetAbsolutePosition(10, 470);
                cb.AddImage(img);

                // TEXTE
                cb.BeginText();
                float matrixY = 440;

                // PERSONNE EN CHARGE DU DOSSIER
                cb.SetTextMatrix(30, matrixY);
                cb.ShowText(label_Affairesuivie.Text);
                matrixY -= 20;

                //REFERENCE DU DOSSIER
                cb.SetTextMatrix(30, matrixY);
                cb.ShowText(label_refDossier.Text);
                matrixY -= 40;

                // TITRE DE LA TABLE
                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_listePlans.Width / 2), matrixY);
                cb.ShowText(label_listePlans.Text);

                // INFOS DE CONTACT
                cb.SetFontAndSize(f_cb, 10);
                float contactY = doc.PageSize.Height - (doc.PageSize.Height - (label_contact1.Height + label_contact2.Height
                    + label_contact3.Height + label_contact4.Height + label_contact5.Height));

                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact1.Width / 2), contactY );
                cb.ShowText(label_contact1.Text);
                contactY -= 10;
                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact2.Width / 2), contactY);
                cb.ShowText(label_contact2.Text);
                contactY -= 10;
                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact3.Width / 2), contactY);
                cb.ShowText(label_contact3.Text);
                contactY -= 10;
                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact4.Width / 2), contactY);
                cb.ShowText(label_contact4.Text);
                contactY -= 10;
                cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact5.Width / 2), contactY);
                cb.ShowText(label_contact5.Text);
                contactY -= 10;

                doc.Add(new Paragraph(" "));

                PdfPTable tableau = new PdfPTable(4);
                PdfPCell celluleTitre1 = new PdfPCell(new Paragraph("N°"));
                celluleTitre1.Colspan = 1;
                tableau.AddCell(celluleTitre1);

                PdfPCell celluleTitre2 = new PdfPCell(new Paragraph("DESIGNATION"));
                celluleTitre2.Colspan = 1;
                tableau.AddCell(celluleTitre2);

                PdfPCell celluleTitre3 = new PdfPCell(new Paragraph("DATE"));
                celluleTitre3.Colspan = 1;
                tableau.AddCell(celluleTitre3);

                PdfPCell celluleTitre4 = new PdfPCell(new Paragraph("INDICE"));
                celluleTitre4.Colspan = 1;
                tableau.AddCell(celluleTitre4);

                tableau.AddCell("1.1");
                tableau.AddCell("1.2");
                tableau.AddCell("1.3");
                tableau.AddCell("1.4");

                tableau.SpacingBefore = doc.PageSize.Height-matrixY-30;
                tableau.SpacingAfter = 30;
                doc.Add(tableau);
                
   
                cb.EndText();
                doc.Close();
                writer.Close();
                fs.Close();

            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }
        }
        
    }
}
