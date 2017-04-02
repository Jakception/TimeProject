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
            LoadPlan();
        }

        private void btn_AjoutPlan_Click(object sender, EventArgs e)
        {
            FormAjoutPlan f1 = new FormAjoutPlan();
            this.Hide();
            f1.ShowDialog();
            LoadPlan();
            this.Show();
        }
        private void btn_EditionPDF_Click(object sender, EventArgs e)
        {

        }

        private void btn_ListeDernierIndice_Click(object sender, EventArgs e)
        {
            dataGridViewBE.DataSource = null;
            dataGridViewBE.DataSource = BDDPlan.GetPlanWithMaxIndice(sessionUser.projetModif.code_Projet);
        }

        private void btn_CreationBE_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModificationBE_Click(object sender, EventArgs e)
        {

        }

        private void btn_ValidationBE_Click(object sender, EventArgs e)
        {

        }

        private void LoadPlan()
        {
            // Charge tous les bordereaux d'envois dans le dataGridViewBE
            dataGridViewBE.DataSource = null;
            dataGridViewBE.DataSource = BDDPlan.getAllPlan(sessionUser.projetModif.code_Projet);
        }

    }
}
