using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeProject.Models.request;
using TimeProject.Models.Class;
using TimeProject.Models.Utilitaire;

namespace TimeProject
{
    public partial class FormGestionBE : Form
    {

        public FormGestionBE()
        {   
            InitializeComponent();
        }

        private void FormGestionBE_Load(object sender, EventArgs e)
        {
            LoadBE();
        }


        private void btn_ListeDernierIndice_Click(object sender, EventArgs e)
        {
            dataGridViewBE.DataSource = null;
            //dataGridViewBE.DataSource = BDDPlan.GetPlanWithMaxIndice(sessionUser.projetModif.code_Projet);
        }

        private void btn_CreationBE_Click(object sender, EventArgs e)
        {
            BordereauEnvoi be = null;
            FormCUBordereauEnvoi f1 = new FormCUBordereauEnvoi(be);
            this.Hide();
            f1.ShowDialog();
            LoadBE();
            this.Show();
        }

        private void btn_ModificationBE_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditionPDF_Click(object sender, EventArgs e)
        {

        }

        private void btn_ValidationBE_Click(object sender, EventArgs e)
        {

        }

        private void LoadBE()
        {
            // Charge tous les bordereaux d'envois dans le dataGridViewBE
            List<BordereauEnvoi> listBE = BDDBordereauEnvoi.getAllBE(sessionUser.projetModif.code_Projet);
            string listPlans = "";
            int nbPlan = 0;
            int compteur = 0;

            dataGridViewBE.DataSource = null;

            if(listBE.Count() != 0)
            {
                foreach (BordereauEnvoi be in listBE)
                {
                    nbPlan = be.ListPlan.Count();
                    if (nbPlan != 0)
                    {
                        foreach (Plan plan in be.ListPlan)
                        {
                            if (compteur == nbPlan)
                            {
                                listPlans += plan.Numero_Plan;
                            }
                            else
                            {
                                listPlans += plan.Numero_Plan + " - ";
                            }

                            compteur++;
                        }
                    }

                    this.dataGridViewBE.Rows.Add(be.Code_Bordereau, be.Numero_Bordereau, be.Designation, listPlans, be.Exemplaire, be.Version, be.Etat);
                }
            }
            
        }

    }
}
