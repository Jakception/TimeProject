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
            lstBoxPlan.DataSource = null;
            lstBoxPlan.DataSource = BDDPlan.getAllPlan();
        }

        private void btCreaPlan_Click(object sender, EventArgs e)
        {
            //Plan plan = BDDPlan.DejaExistePlan();
            // créée le plan
            //if (plan == null)
            //{
                //BDDPerson.CreatePlan();
            //}
            //else
            //{
            //    MessageBox.Show("Le plan existe déjà !");
            //}

            //LoadPlan();
        }

        private void btSupprimerPlan_Click(object sender, EventArgs e)
        {

        }

        private void LoadPlan()
        {
            // Charge tous les plans dans lstBoxPlan et met a vide toutes les txtBox
            lstBoxPlan.DataSource = null;
            lstBoxPlan.DataSource = BDDPerson.getAllUser();

            txtBoxCodePlan.Text = "";
            txtBoxIndice.Text = "";
            txtBoxCodeProjet.Text = "";
            txtBoxNumPlan.Text = "";
            txtBoxLibellePlan.Text = "";
            txtBoxDesignationPlan.Text = "";
            dtPickPlan = null;
        }
    }
}
