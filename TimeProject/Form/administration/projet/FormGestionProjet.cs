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
using TimeProject.Models;

namespace TimeProject
{
    public partial class FormGestionProjet : Form
    {
        public FormGestionProjet()
        {
            InitializeComponent();
            loadListProjet();
            
        }

        private void btCreaProjet_Click(object sender, EventArgs e)
        {
            FormCreationProjet fproj = new FormCreationProjet();
            this.Hide();
            fproj.ShowDialog();
            
            this.Show();
            loadListProjet();
        }



        private void btCloreProjet_Click(object sender, EventArgs e)
        {

            DateTime dtCloture;
            string date;
            Projet p;

            dtCloture = System.DateTime.Today.Date;
            date = DateTime.Now.ToString("yyyy-MM-dd");


            p = (Projet)lstBoxProjet.SelectedItem;


            
                        BDDProjet.clotureProjet(date, p.code_Projet);

                        BDDProjet.ProjetEncours();
                        loadListProjet();
        }

        private void loadListProjet()
        {
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();
        }

        private void FormGestionProjet_Load(object sender, EventArgs e)
        {

        }

        private void btGestionUser_Click(object sender, EventArgs e)
        {
            Projet p;

            p = (Projet)lstBoxProjet.SelectedItem;
            classAdministration.projetModif = p;

            FormGestUserProjet form = new FormGestUserProjet();
            
            form.ShowDialog();
           
        }
    }
     
}
