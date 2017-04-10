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
            FormGestionPlan fgp = new FormGestionPlan();
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
            //f1.createBordereau();
        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void FormProjet_Load(object sender, EventArgs e)
        {
            btn_cptRendu.Visible = false;
            btn_ficheLancement.Visible = false;
            btn_suiviTH.Visible = false; 

            p = sessionUser.projetModif;
            
            lblTitre.Text = lblTitre.Text + "  "+p.nom_Projet;
            lblDate.Text = "Date de début : " + p.dt_Deb_Projet.ToShortDateString() + "- Objectif de fin : " + p.dt_Obj_Fin.ToShortDateString();
            loadListBox();
           
        }

        private void btn_historique_Click(object sender, EventArgs e)
        {
            FormHistoDet fHist = new FormHistoDet();

            
            fHist.ShowDialog();
            loadListBox();
            
        }

        private void loadListBox()
        {
            lstBoxHistorique.DataSource = null;
            lstBoxInfo.DataSource = null;
            lstTaskImp.DataSource = null;

            lstBoxHistorique.DataSource = p.lstAction;
            lstBoxInfo.DataSource = p.lstInfo;

            List<ActionProjet> lstActPro = new List<ActionProjet>();

            if (p.lstAction.Count != 0)
            {
                foreach (var item in p.lstAction)
                {
                    if (item.importance == 1)
                    {
                        if (Convert.ToInt32(item.etat) < 3)
                        {
                            lstActPro.Add(item);
                        }
                    }
                }

                lstTaskImp.DataSource = lstActPro;
            }
            
        }

        private void btn_bordereau_Click(object sender, EventArgs e)
        {
            FormGestionBE fGBE = new FormGestionBE();

            this.Hide();
            fGBE.ShowDialog();
            loadListBox();
            this.Show();
        }

        private void btn_cptRendu_Click(object sender, EventArgs e)
        {

        }

        private void btn_suiviValidations_Click(object sender, EventArgs e)
        {

        }
    }
}
