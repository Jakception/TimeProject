using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeProject.Models.Class;

namespace TimeProject
{
    public partial class FormProjet : Form
    {
        private Form1 f1 = new Form1();
        Projet p;
        
        public FormProjet()
        {
            InitializeComponent();
            p = sessionUser.projetModif;
            lblDate.Text = "Date de Début :  " + p.dt_Deb_Projet.ToString("dd-MM-YY") + "  - Objectif de Fin : " + p.dt_Obj_Fin.ToString("dd-MM-YY");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f1.createLPpdf();
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

        private void btn_historique_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormHistoDet fHis = new FormHistoDet();

            fHis.ShowDialog();
            this.Visible = true;
        }

        private void FormProjet_Load(object sender, EventArgs e)
        {

        }
    }
}
