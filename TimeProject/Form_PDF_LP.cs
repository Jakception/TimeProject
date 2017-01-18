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
            Document doc = new Document(PageSize.A4.Rotate());

            try
            {
                PdfWriter.GetInstance(doc, new FileStream("fichier.pdf", FileMode.Create, FileAccess.ReadWrite));
                doc.Open();
                doc.Add(new Phrase("hello world"));
            }
            catch (DocumentException de)
            {
                Console.WriteLine("error " + de.Message);
            }
            catch (System.IO.IOException ioe)
            {
                Console.WriteLine("error " + ioe.Message);
            }
            doc.Close();
        }
        
    }
}
