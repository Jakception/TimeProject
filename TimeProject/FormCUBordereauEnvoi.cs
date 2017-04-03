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
    public partial class FormCUBordereauEnvoi : Form
    {
        public FormCUBordereauEnvoi(BordereauEnvoi bordereauEnvoi)
        {
            InitializeComponent();

            if(bordereauEnvoi == null)
            {
                // Création
                List<Plan> listPlans = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);

                this.Text = "Ajout d'un bordereau d'envoi";
                lblGestionBE.Text = "Ajout d'un bordereau d'envoi";
                textBoxNumeroBordereau.Text = "";
                textBoxDesignationBordereau.Text = "";
                textBoxExemplaireBordereau.Text = "";
                textBoxVersionBordereau.Text = "";
                textBoxEtatBordereau.Text = "";

                dataGridViewPlan.DataSource = null;
                dataGridViewPlan.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
                if(listPlans.Count() > 0)
                {
                    foreach(Plan plan in listPlans)
                    {
                        this.dataGridViewPlan.Rows.Add(plan.Code_Plan, plan.Indice, plan.Code_Projet, plan.Numero_Plan, plan.Libelle_Plan, plan.Designation, plan.Dt_Plan);
                    }
                }
                
            }
            else
            {
                // Modifcation
                this.Text = "Modification d'un bordereau d'envoi";
            }
        }

        private void buttonValiderBE_Click(object sender, EventArgs e)
        {
            string designation = "", exemplaire = "", version = "", messErreur = "";
            int numeroBordereau = 0, etat = 0;

            if(textBoxNumeroBordereau.Text != "" && textBoxDesignationBordereau.Text != "" && textBoxExemplaireBordereau.Text != "" && textBoxVersionBordereau.Text != "" && textBoxEtatBordereau.Text != "")
            {
                try
                {
                    numeroBordereau = Convert.ToInt32(textBoxNumeroBordereau.Text);
                    etat = Convert.ToInt32(textBoxEtatBordereau.Text);
                }
                catch(Exception err)
                {
                    messErreur = (err.Message);
                }

                if(messErreur == "")
                {
                    
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

        private void buttonAnnuleBE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
