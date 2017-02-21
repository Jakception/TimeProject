using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeProject
{
    public partial class FormProjet : Form
    {
        private Form1 f1 = new Form1();

        public FormProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.pdfCreator();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.createCRpdf();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f1.createBordereau();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }
    }
}
