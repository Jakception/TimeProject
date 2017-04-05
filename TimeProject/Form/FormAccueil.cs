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

        List<Evenement> lstEvent = new List<Evenement>();
        List<Evenement> lstTaskImp = new List<Evenement>();
        List<ActionProjet> lstAct;
        List<ActionProjet> lstActImp = new List<ActionProjet>();
        List<ActionProjet> lstRendu = new List<ActionProjet>();

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

            

            lstBoxTask.DataSource = null;
            lstBoxRendu.DataSource = null;

            loadListBox();

            

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
      
  

        private void lstBoxProjet_DoubleClick(object sender, EventArgs e)
        {
            sessionUser.projetModif = (Projet)lstBoxProjet.SelectedItem;

            sessionUser.projetModif.lstInfo = BDDEvent.getInfoProjet(sessionUser.projetModif.code_Projet);
            foreach (var item in sessionUser.projetModif.lstInfo)
            {
                item.projet = sessionUser.projetModif;
            }
            FormProjet fProj = new FormProjet();


            this.Hide();    
            fProj.ShowDialog();
            this.Visible = true;


            loadListBox();
            lstBoxRendu.DataSource = lstRendu;

        }

        private void lblName_Click(object sender, EventArgs e)
        {
            FormModifProfile fModifMdp = new FormModifProfile();
            fModifMdp.ShowDialog();
        }

        private void loadListBox()
        {
            foreach (Projet item in sessionUser.getListProj())
            {

                item.lstSalarieProjet = BDDProjet.getUserProjet(item.code_Projet);
                item.chefProjet = BDDProjet.getChefProjet(item.code_Projet);
                lstAct = BDDEvent.getActionProjet(item.code_Projet);
                foreach (var action in lstAct)
                {
                    action.projet = item;
                }
                item.lstAction = lstAct;
                foreach (var act in lstAct)
                {
                    if (act.importance == 1)
                    {
                        lstActImp.Add(act);
                    }
                    if (act.etat == "4")
                    {
                       
                        if ( DateTime.Now.ToShortDateString() == act.dt_Event.ToShortDateString() )
                        {
                            lstRendu.Add(act);
                        }
                        
                    }
                }
            }

            lstBoxTask.DataSource = lstActImp;
            lstBoxRendu.DataSource = lstRendu;
        }

        #region Mouse
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

        #endregion

        private void lstBoxProjet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
