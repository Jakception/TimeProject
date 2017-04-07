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
        private int mode = 0;
        private BordereauEnvoi be;

        public FormCUBordereauEnvoi(BordereauEnvoi bordereauEnvoi)
        {
            InitializeComponent();

            List<Plan> listPlans = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);

            if (bordereauEnvoi == null)
            {
                // Création
                mode = 1;

                this.Text = "Ajout d'un bordereau d'envoi";
                lblGestionBE.Text = "Ajout d'un bordereau d'envoi";
                textBoxNumeroBordereau.Text = "";
                textBoxDesignationBordereau.Text = "";
                textBoxExemplaireBordereau.Text = "";
                textBoxVersionBordereau.Text = "";
                textBoxEtatBordereau.Text = "";

                dataGridViewPlan.DataSource = null;
                //dataGridViewPlan.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
                if(listPlans.Count() > 0)
                {
                    foreach(Plan plan in listPlans)
                    {
                        this.dataGridViewPlan.Rows.Add(0, plan.Code_Plan, plan.Indice, plan.Code_Projet, plan.Numero_Plan, plan.Libelle_Plan, plan.Designation, plan.Dt_Plan);
                    }
                }
                
            }
            else
            {
                // Modifcation
                mode = 2;
                be = bordereauEnvoi;

                this.Text = "Modification d'un bordereau d'envoi";
                textBoxNumeroBordereau.Text = be.Numero_Bordereau.ToString();
                textBoxDesignationBordereau.Text = be.Designation;
                textBoxExemplaireBordereau.Text = be.Exemplaire;
                textBoxVersionBordereau.Text = be.Version;
                textBoxEtatBordereau.Text = be.Etat.ToString();

                dataGridViewPlan.DataSource = null;
                // dataGridViewPlan.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
                if (listPlans.Count() > 0)
                {
                    foreach (Plan plan in listPlans)
                    {
                        if (BDDPlan.containsInListPlan(be.ListPlan, plan))
                        {
                            this.dataGridViewPlan.Rows.Add(1, plan.Code_Plan, plan.Indice, plan.Code_Projet, plan.Numero_Plan, plan.Libelle_Plan, plan.Designation, plan.Dt_Plan);
                        }
                        else
                        {
                            this.dataGridViewPlan.Rows.Add(0, plan.Code_Plan, plan.Indice, plan.Code_Projet, plan.Numero_Plan, plan.Libelle_Plan, plan.Designation, plan.Dt_Plan);
                        }
                    }
                }
            }
            this.dataGridViewPlan.Columns[0].ReadOnly = true;
        }

        private void buttonValiderBE_Click(object sender, EventArgs e)
        {
            string codeBordereau = "", designation = "", exemplaire = "", version = "", messErreur = "";
            int numeroBordereau = 0, etat = 0, nbLigne = 0, nbdtgv = 0;

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
                    designation = textBoxDesignationBordereau.Text;
                    exemplaire = textBoxExemplaireBordereau.Text;
                    version = textBoxVersionBordereau.Text;

                    if(this.mode == 1)
                    {
                        // On créé le bordereau_envoi

                        codeBordereau = BDDBordereauEnvoi.GenerateCodeBE(sessionUser.projetModif.code_Projet);
                        
                        nbLigne = BDDBordereauEnvoi.CreateBordereauEnvoi(sessionUser.projetModif.code_Projet, codeBordereau, numeroBordereau, designation, exemplaire, version, etat);

                        if (nbLigne != 0)
                        {
                            // On créé le bord_projet
                            nbLigne = BDDBordProjet.CreateBordereauProjet(sessionUser.projetModif.code_Projet, codeBordereau);
                            // On créé le bord_plan
                            foreach (DataGridViewRow row in dataGridViewPlan.Rows)
                            {
                                if (Convert.ToBoolean(row.Cells[0].Value))
                                {
                                    nbLigne = BDDBordPlan.CreateBordPlan(codeBordereau, row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                                }
                            }

                            MessageBox.Show("Le bordereau à bien été ajouté !");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Erreur lors de l'ajout du bordereau.");
                        }
                    }
                    else
                    {
                        // On modifie le bordereau_envoi
                        codeBordereau = this.be.Code_Bordereau;
                        // Update BE
                        nbLigne = BDDBordereauEnvoi.UpdateBordereauEnvoi(sessionUser.projetModif.code_Projet, codeBordereau, numeroBordereau, designation, exemplaire, version, etat);
                        // Update Bord_Plan
                        foreach (DataGridViewRow row in dataGridViewPlan.Rows)
                        {
                            Plan plan = new Plan(row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString(), Convert.ToInt32(row.Cells[4].Value), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), Convert.ToDateTime(row.Cells[7].Value));
                            // Si le plan est coché
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                if (!BDDPlan.containsInListPlan(be.ListPlan, plan))
                                {
                                    // On ajoute un bord plan
                                    nbLigne = BDDBordPlan.CreateBordPlan(codeBordereau, row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                                }
                            }
                            else
                            {
                                if (BDDPlan.containsInListPlan(be.ListPlan, plan))
                                {
                                    // DELETE
                                    nbLigne = BDDBordPlan.DeleteBordPlan(codeBordereau, row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                                }
                            }
                        }

                        MessageBox.Show("Le bordereau à bien été modifié !");
                        this.Close();
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

        private void buttonAnnuleBE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewPlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                if((int)dataGridViewPlan.CurrentCell.Value == 1)
                {
                    dataGridViewPlan.CurrentCell.Value = 0;
                }
                else
                {
                    dataGridViewPlan.CurrentCell.Value = 1;
                }
            }
        }
    }
}
