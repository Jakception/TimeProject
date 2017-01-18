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
            cb.BeginText();
            cb.EndText();
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("D:\\Ludivine\\Mes Images\\Fonds d'écran\\licorneDuNet.jpg");
            img.ScalePercent(10);
            img.SetAbsolutePosition(10, 480);
            cb.AddImage(img);
           
           
            doc.Close();
            writer.Close();
            fs.Close();

        }
        
    }
}
