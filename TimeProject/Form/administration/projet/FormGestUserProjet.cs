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
    public partial class FormGestUserProjet : Form
    {

        Projet p;
        

        public FormGestUserProjet()
        {
            InitializeComponent();
        }
        
        private void FormGestUserProjet_Load(object sender, EventArgs e)
        {
            p = classAdministration.projetModif;
            lblNomProjet.Text = p.nom_Projet;

            loadList();
        }

        private void btAjouterPersonne_Click(object sender, EventArgs e)
        {
            User u;
            foreach (var item in checkListUser.CheckedItems)
            {
                u = (User)item;
                BDDProjet.setUserProjet(u.id_User,p.code_Projet);
            }

            videList();
            loadList();
        }

        private void btDelUser_Click(object sender, EventArgs e)
        {
            User u;
            foreach (var item in checkListUserOnProjet.CheckedItems)
            {
                u = (User)item;
                BDDProjet.DelUserProjet(u.id_User, p.code_Projet);
            }

            videList();
            classAdministration.lstUserProjet = BDDProjet.getUserProjet(p.code_Projet);
            loadList();
        }


        private void loadList()
        {
            classAdministration.lstUserProjet = BDDProjet.getUserProjet(p.code_Projet);

            

            foreach (var item in classAdministration.lstUserProjet)
            {
                checkListUserOnProjet.Items.Add(item);
            }

            foreach (var user in classAdministration.lstUser)
            {
                checkListUser.Items.Add(user);
            }
        }

        private void videList()
        {
            foreach (var item in classAdministration.lstUser)
            {
                checkListUser.Items.Remove(item);
            }
            foreach (var item in classAdministration.lstUserProjet)
            {
                checkListUserOnProjet.Items.Remove(item);
            }


        }

     
    }
}
