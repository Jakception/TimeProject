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
            int numeroBordereau = 0, nbLigne = 0, nbdtgv = 0;
            List<Plan> listPlan = new List<Plan>();

            if(textBoxNumeroBordereau.Text != "" && textBoxDesignationBordereau.Text != "" && textBoxExemplaireBordereau.Text != "" && textBoxVersionBordereau.Text != "")
            {
                try
                {
                    numeroBordereau = Convert.ToInt32(textBoxNumeroBordereau.Text);
                }
                catch(Exception err)
                {
                    messErreur = (err.Message);
                }

                foreach (DataGridViewRow row in dataGridViewPlan.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        //nbLigne = BDDBordPlan.CreateBordPlan(codeBordereau, row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value));
                        Plan plan = new Plan(row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString(), Convert.ToInt32(row.Cells[4].Value), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), Convert.ToDateTime(row.Cells[7].Value));
                        listPlan.Add(plan);
                    }
                }
                foreach (DataGridViewRow row in dataGridViewPlan.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        Plan plan = new Plan(row.Cells[1].Value.ToString(), Convert.ToInt32(row.Cells[2].Value), row.Cells[3].Value.ToString(), Convert.ToInt32(row.Cells[4].Value), row.Cells[5].Value.ToString(), row.Cells[6].Value.ToString(), Convert.ToDateTime(row.Cells[7].Value));
                        if(BDDPlan.containsInListPlanByCode(listPlan, plan))
                        {
                            messErreur += "Veuillez à ne pas cocher le même plan : '" + plan.Code_Plan + "' !\n";
                        }
                    }
                }

                if (messErreur == "")
                {
                    designation = textBoxDesignationBordereau.Text;
                    exemplaire = textBoxExemplaireBordereau.Text;
                    version = textBoxVersionBordereau.Text;

                    if(this.mode == 1)
                    {
                        // On créé le bordereau_envoi

                        codeBordereau = BDDBordereauEnvoi.GenerateCodeBE(sessionUser.projetModif.code_Projet);
                        
                        nbLigne = BDDBordereauEnvoi.CreateBordereauEnvoi(sessionUser.projetModif.code_Projet, codeBordereau, numeroBordereau, designation, exemplaire, version, 1);

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
                        nbLigne = BDDBordereauEnvoi.UpdateBordereauEnvoi(sessionUser.projetModif.code_Projet, codeBordereau, numeroBordereau, designation, exemplaire, version);
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
