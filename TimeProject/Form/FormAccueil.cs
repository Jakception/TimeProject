﻿using System;
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

        // tache = table Action et information
        // importance 1 = importance haute

        public FormAccueil()
        {
            InitializeComponent();
            if (sessionUser.getTpProfil() == "adm")
            {
                BDDProjet.ProjetEncours();
            }
            else
            {
                BDDProjet.ProjetEnCoursUSer();
            }
            
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            ConfigItem.initListImportance();
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();
            
            // TO DO Fonction permettant de charger les tâches des projets. 

            List<Evenement> lstEvent = new List<Evenement>();
            List<Evenement> lstTaskImp = new List<Evenement>();
            List<ActionProjet> lstAct;
            List<ActionProjet> lstActImp = new List<ActionProjet>();
            List<ActionProjet> lstRendu = new List<ActionProjet>();

            lstBoxTask.DataSource = null;
            lstBoxRendu.DataSource = null;
            foreach (Projet item in sessionUser.getListProj())
            {

                lstAct = BDDEvent.getActionProjet(item.code_Projet);
                item.lstAction = lstAct;
                foreach (var act in lstAct)
                {
                    if (act.importance == 1)
                    {
                        lstActImp.Add(act);
                    }
                    if (act.etat == "4")
                    {
                        lstRendu.Add(act);
                    }
                }
            }

            lstBoxTask.DataSource = lstActImp;
            lstBoxRendu.DataSource = lstRendu;

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

        private void lstBoxProjet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Projet p;
            FormProjet fProj = new FormProjet();

            p = (Projet) lstBoxProjet.SelectedItem;
            p.lstSalarieProjet = BDDProjet.getUserProjet(p.code_Projet);
            sessionUser.projetModif = p;

            
            this.Visible = false;
            fProj.ShowDialog();
            this.Visible = true;
        }

        private void lstBoxProjet_DoubleClick(object sender, EventArgs e)
        {
            sessionUser.projetModif = (Projet)lstBoxProjet.SelectedItem;
            FormProjet fProj = new FormProjet();


            this.Hide();    
            fProj.ShowDialog();
            this.Visible = true;
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            FormModifProfile fModifMdp = new FormModifProfile();
            fModifMdp.ShowDialog();
        }
    }
}
