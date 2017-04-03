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
                this.Text = "Ajout d'un bordereau d'envoi";
                lblGestionBE.Text = "Ajout d'un bordereau d'envoi";
                textBoxNumeroBordereau.Text = "";
                textBoxDesignationBordereau.Text = "";
                textBoxExemplaireBordereau.Text = "";
                textBoxVersionBordereau.Text = "";
                textBoxEtatBordereau.Text = "";

                dataGridViewPlan.DataSource = null;
                dataGridViewPlan.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
            }
            else
            {
                // Modifcation
                this.Text = "Modification d'un bordereau d'envoi";
            }
        }
    }
}
