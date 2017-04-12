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
    public partial class FormValidation : Form
    {
        string mode;
        string messErreur = "";
        string codeBordereau;
        string codePlan;
        int indice;

        public FormValidation(string code_Bordereau, string code_Plan, int indicePlan, DateTime dtRep, int numCour, string rep, int param)
        {
            InitializeComponent();

            codeBordereau = code_Bordereau;
            codePlan = code_Plan;
            indice = indicePlan;
            if (param == 1)
            {
                mode = "ValidArchi";
                this.Text = "Validation Archi"; 
            }
            else
            {
                mode = "ValidBC";
                this.Text = "Validation BC";
            }

            dtTimeValidation.Value = dtRep;
            if (rep != "0")
            {
                if (rep == "Favorable")
                {
                    listBox1.SelectedItem = listBox1.FindString("Favorable");
                }
                else
                {
                    listBox1.SelectedItem = listBox1.FindString("Rejete");
                }
            }
            textBox1.Text = numCour.ToString();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string rep = (string)listBox1.SelectedItem;
            DateTime dtRep = dtTimeValidation.Value;
            int numCour = 0, nbLigne = 0;

            if(rep != "" && dtRep != null && textBox1.Text != "")
            {
                try
                {
                    numCour = Convert.ToInt32(textBox1.Text);
                }
                catch(Exception err)
                {
                    messErreur = (err.Message);
                }

                if(messErreur == "")
                {
                    // Trt
                    if(mode == "ValidArchi")
                    {
                        nbLigne = BDDValidArchi.UpdateValidArchi(codeBordereau, codePlan, indice, 1, dtRep, rep, numCour);
                    }
                    else
                    {
                        nbLigne = BDDValidBC.UpdateValidBC(codeBordereau, codePlan, indice, 1, dtRep, rep, numCour);
                    }
                }
            }
            else
            {
                messErreur = "Veuillez remplir tous les champs !";
            }

            if(messErreur != "")
            {
                MessageBox.Show(messErreur);
            }
            if(nbLigne != 0)
            {
                this.Close();
            }
            
        }

        private void buttonAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
