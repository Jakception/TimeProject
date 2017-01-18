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
            FileStream fs = new FileStream("..\\PDF\\fichier.pdf", FileMode.Create);
            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter writer = PdfWriter.GetInstance(doc,fs);
            doc.Open();
            /* document.AddAuthor("Micke Blomquist");
           document.AddCreator("Sample application using iTextSharp");
           document.AddKeywords("PDF tutorial education");
           document.AddSubject("Document subject - Describing the steps creating a PDF document");
           document.AddTitle("Liste des plans");*/

            PdfContentByte cb = writer.DirectContent;
            BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            cb.SetFontAndSize(f_cb, 14);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("D:\\Ludivine\\Mes Documents\\Ingésup\\YDAYS\\TimeProject\\TimeProject\\logo.png");
            img.ScalePercent(80);
            img.SetAbsolutePosition(10, 470);
            cb.AddImage(img);
            cb.BeginText();
            int matrixY = 440;
            
            cb.SetTextMatrix(30, matrixY);
            cb.ShowText(label_date.Text);
            matrixY -= 30;
            cb.SetTextMatrix(30, matrixY);
            cb.ShowText(label_Affairesuivie.Text);
            matrixY -= 30;
            cb.SetTextMatrix(30, matrixY);
            cb.ShowText(label_refDossier.Text);
            matrixY -= 50;

            cb.SetTextMatrix(400, matrixY);
            cb.ShowText(label_listePlans.Text);



            cb.EndText();

                doc.Close();
                writer.Close();
                fs.Close();
            
        }
        
    }
}
