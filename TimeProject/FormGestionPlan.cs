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
    public partial class FormGestionPlan : Form
    {

        public FormGestionPlan()
        {   
            InitializeComponent();
        }

        public void FormGestionPlan_Load(object sender, EventArgs e)
        {
            LoadPlan();
        }
        private void LoadPlan()
        {
            // Charge tous les plans dans lstBoxPlan et met a vide toutes les txtBox
            dataGridViewPlan.DataSource = null;
            dataGridViewPlan.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
        }

        private void btn_AjoutPlan_Click(object sender, EventArgs e)
        {
            FormAjoutPlan f1 = new FormAjoutPlan();
            this.Hide();
            f1.ShowDialog();
            LoadPlan();
            this.Show();
        }

        private void btn_ModificationPlan_Click(object sender, EventArgs e)
        {
            Plan plan;
            int maxIndice = 0, nbLigne = 0;
            
            if(dataGridViewPlan.Rows.Count > 0)
            {
                plan = new Plan (dataGridViewPlan.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridViewPlan.CurrentRow.Cells[1].Value), dataGridViewPlan.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(dataGridViewPlan.CurrentRow.Cells[3].Value), dataGridViewPlan.CurrentRow.Cells[4].Value.ToString(), dataGridViewPlan.CurrentRow.Cells[5].Value.ToString(), Convert.ToDateTime(dataGridViewPlan.CurrentRow.Cells[6].Value));
                maxIndice = BDDPlan.RecupereDernierIndice(plan.Code_Plan);

                if (maxIndice > 0)
                {
                    maxIndice = maxIndice + 1;
                    nbLigne = BDDPlan.CreatePlan(plan.Code_Plan, maxIndice.ToString(), plan.Code_Projet, plan.Numero_Plan.ToString(), plan.Libelle_Plan, plan.Designation, plan.Dt_Plan.ToString());

                    if (nbLigne != 0)
                    {
                        MessageBox.Show("Le plan à bien été ajouté !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du plan.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dans la recherche de l'indice.");
                }

                LoadPlan();
            }
            
        }
        private void btn_SuppressionPlan_Click(object sender, EventArgs e)
        {
            //Plan plan;
            //int maxIndice = 0, nbLigne = 0;

            //if (lstBoxPlan.Items.Count > 0)
            //{
            //    plan = (Plan)lstBoxPlan.SelectedItem;
            //    maxIndice = BDDPlan.RecupereDernierIndice(plan.Code_Plan);

            //    if (maxIndice > 0)
            //    {
            //        nbLigne = BDDPlan.DeletePlan(plan.Code_Plan, maxIndice.ToString());

            //        if (nbLigne != 0)
            //        {
            //            MessageBox.Show("Le plan à bien été Supprimé !");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Erreur lors de la suppression du plan.");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Erreur dans la recherche de l'indice.");
            //    }

            //    LoadPlan();

            Plan plan;
            int maxIndice = 0, nbLigne = 0;

            if (dataGridViewPlan.Rows.Count > 0)
            {
                plan = new Plan(dataGridViewPlan.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridViewPlan.CurrentRow.Cells[1].Value), dataGridViewPlan.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(dataGridViewPlan.CurrentRow.Cells[3].Value), dataGridViewPlan.CurrentRow.Cells[4].Value.ToString(), dataGridViewPlan.CurrentRow.Cells[5].Value.ToString(), Convert.ToDateTime(dataGridViewPlan.CurrentRow.Cells[6].Value));
                maxIndice = BDDPlan.RecupereDernierIndice(plan.Code_Plan);

                if (maxIndice > 0)
                {
                    nbLigne = BDDPlan.DeletePlan(plan.Code_Plan, maxIndice.ToString());

                    if (nbLigne != 0)
                    {
                        MessageBox.Show("Le plan à bien été Supprimé !");
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de la suppression du plan.");
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dans la recherche de l'indice.");
                }

                LoadPlan();
            }
        }
        private void btn_EditionPDF_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListeDernierIndice_Click(object sender, EventArgs e)
        {
            dataGridViewPlan.DataSource = null;
            dataGridViewPlan.DataSource = BDDPlan.GetPlanWithMaxIndice(sessionUser.projetModif.code_Projet);
        }

    }
}
