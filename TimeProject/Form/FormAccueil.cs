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

namespace TimeProject
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
            BDDProjet.ProjetEncours();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            if (sessionUser.getTpProfil() != "adm")
            {
                pnlAdmin.Visible = false;
            }
            else
            {
                pnlAdmin.Visible = true;
            }
            string dt;

            dt = System.DateTime.Today.Date.ToShortDateString();
            lblDate.Text = "Date: " + dt;
            lblName.Text = sessionUser.getNomPrenom();


           
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();
            
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            FormAdmininistration formAdmin = new FormAdmininistration();

            formAdmin.ShowDialog();

            sessionUser.getListProj();
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();
        }



        private void pnlAdmin_Click(object sender, EventArgs e)
        {
            FormAdmininistration formAdmin = new FormAdmininistration();

            formAdmin.ShowDialog();
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();

        }

        private void pnlAdmin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pnlAdmin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void lblAdmin_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void lblAdmin_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblName_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pnlUser_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void pnlUser_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstBoxProjet_DoubleClick(object sender, EventArgs e)
        {
            sessionUser.projetModif = (Projet)lstBoxProjet.SelectedItem;
            FormProjet fProj = new FormProjet();
            this.Hide();    
            fProj.ShowDialog();
            this.Visible = true;
        }
    }
}
