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
        Projet p;
        private Form1 f1 = new Form1();

        public FormProjet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionPlan fgp = new FormGestionPlan(false);
            this.Hide();
            fgp.ShowDialog();
            this.Show();
            //f1.createLPpdf();
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

        private void FormProjet_Load(object sender, EventArgs e)
        {
            p = sessionUser.projetModif;
            lblTitre.Text = lblTitre.Text + "  "+p.nom_Projet;
            lblDate.Text = "Date de début : " + p.dt_Deb_Projet.ToShortDateString() + "- Objectif de fin : " + p.dt_Obj_Fin.ToShortDateString();
        }

        private void btn_historique_Click(object sender, EventArgs e)
        {
            FormHistoDet fHist = new FormHistoDet();

            this.Hide();
            fHist.ShowDialog();
            this.Show();
        }
    }
}
