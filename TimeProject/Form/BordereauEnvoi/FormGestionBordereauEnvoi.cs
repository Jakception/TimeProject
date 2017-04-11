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
            BordereauEnvoi be;

            if (dataGridViewBE.Rows.Count > 0)
            {
                be = new BordereauEnvoi(dataGridViewBE.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridViewBE.CurrentRow.Cells[1].Value), dataGridViewBE.CurrentRow.Cells[2].Value.ToString(), dataGridViewBE.CurrentRow.Cells[4].Value.ToString(), dataGridViewBE.CurrentRow.Cells[5].Value.ToString(), Convert.ToInt32(dataGridViewBE.CurrentRow.Cells[6].Value), BDDPlan.getAllPlanBE(dataGridViewBE.CurrentRow.Cells[0].Value.ToString(), sessionUser.projetModif.code_Projet));
                if(be.Etat == 1)
                {
                    FormCUBordereauEnvoi f1 = new FormCUBordereauEnvoi(be);
                    this.Hide();
                    f1.ShowDialog();
                    LoadBE();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Le bordereau " + be.Code_Bordereau + " a été validé et ne peut plus être modifié !");
                }
            }
        }

        private void btn_EditionPDF_Click(object sender, EventArgs e)
        {
            FormAdresseBordereau fAd = new FormAdresseBordereau(sessionUser.projetModif.code_Projet);
            fAd.ShowDialog();
        }

        private void btn_ValidationBE_Click(object sender, EventArgs e)
        {
            BordereauEnvoi be;

            if (dataGridViewBE.Rows.Count > 0)
            {
                be = new BordereauEnvoi(dataGridViewBE.CurrentRow.Cells[0].Value.ToString(), Convert.ToInt32(dataGridViewBE.CurrentRow.Cells[1].Value), dataGridViewBE.CurrentRow.Cells[2].Value.ToString(), dataGridViewBE.CurrentRow.Cells[4].Value.ToString(), dataGridViewBE.CurrentRow.Cells[5].Value.ToString(), Convert.ToInt32(dataGridViewBE.CurrentRow.Cells[6].Value), BDDPlan.getAllPlanBE(dataGridViewBE.CurrentRow.Cells[0].Value.ToString(), sessionUser.projetModif.code_Projet));
                if (be.Etat == 1)
                {
                    // Validation bordereau envoi
                    BDDBordereauEnvoi.UpdateBordereauEnvoiValidation(be.Code_Bordereau, 2);
                    foreach(Plan plan in be.ListPlan)
                    {
                        // Valid_Archi

                        // Valid_BC

                    }

                }
                else
                {
                    MessageBox.Show("Le bordereau " + be.Code_Bordereau + " a déjà été validé !");
                }
            }
        }

        private void LoadBE()
        {
            // Charge tous les bordereaux d'envois dans le dataGridViewBE
            List<BordereauEnvoi> listBE = BDDBordereauEnvoi.getAllBE(sessionUser.projetModif.code_Projet);
            string listPlans = "";
            int nbPlan = 0;

            dataGridViewBE.DataSource = null;
            dataGridViewBE.Rows.Clear();

            if(listBE.Count() != 0)
            {
                foreach (BordereauEnvoi be in listBE)
                {
                    nbPlan = be.ListPlan.Count();
                    if (nbPlan != 0)
                    {
                        foreach (Plan plan in be.ListPlan)
                        {
                            if(listPlans != "")
                            {
                                listPlans += " - " + plan.Numero_Plan;
                            }
                            else
                            {
                                listPlans += plan.Numero_Plan;
                            }
                        }
                    }

                    this.dataGridViewBE.Rows.Add(be.Code_Bordereau, be.Numero_Bordereau, be.Designation, listPlans, be.Exemplaire, be.Version, be.Etat);

                    listPlans = "";
                }
            }
            
        }

    }
}
