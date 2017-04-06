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
using TimeProject.Models.request;
using TimeProject.Models.Utilitaire;

namespace TimeProject
{
    public partial class FormAjoutPlan : Form
    {
        public FormAjoutPlan()
        {
            InitializeComponent();
        }

        private void buttonValiderPlan_Click(object sender, EventArgs e)
        {
            string sNumPlan = "", libellePlan = "", designationPlan = "", codePlan = "", messErreur = "";
            int numPlan = 0, nbLigne = 0;
            DateTime datePlan;
            Plan plan;

            sNumPlan = textBoxLibellePlan.Text;
            libellePlan = textBoxLibellePlan.Text;
            designationPlan = textBoxDesignation.Text;
            datePlan = dateTimePickerDatePlan.Value;

            if(sNumPlan != "" && libellePlan != "" && designationPlan != "" && datePlan != null)
            {
                try
                {
                    numPlan = Convert.ToInt32(textBoxNumeroPlan.Text);
                }
                catch (Exception err)
                {

                    messErreur = (err.Message);
                }

                if (messErreur == "")
                {
                    // Traitement
                    codePlan = sessionUser.projetModif.code_Projet + numPlan.ToString();
                    plan = BDDPlan.DejaExistePlan(codePlan, 1, sessionUser.projetModif.code_Projet);
                    if(plan == null)
                    {
                        nbLigne = BDDPlan.CreatePlan(codePlan, "1", sessionUser.projetModif.code_Projet, numPlan.ToString(), libellePlan, designationPlan, datePlan.ToString());
                    }

                    if (nbLigne != 0)
                    {
                        MessageBox.Show("Le plan à bien été ajouté !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout du plan.");
                    }
                }
                else
                {
                    MessageBox.Show(messErreur);
                    messErreur = "";
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs !");
            }
        }

        private void buttonAnnulePlan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerDatePlan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDesignation_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDesignation_Click(object sender, EventArgs e)
        {

        }

        private void labelDatePlan_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLibellePlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumeroPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLiebellePlan_Click(object sender, EventArgs e)
        {

        }

        private void labelNumeroPlan_Click(object sender, EventArgs e)
        {

        }
    }
}
