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
    public partial class FormGestUser : Form
    {
        public FormGestUser()
        {
            InitializeComponent();
        }

        private void FormGestUser_Load(object sender, EventArgs e)
        {
            lstBoxUser.DataSource = null;
            lstBoxUser.DataSource = classAdministration.lstUser;
        }

        private void btCreaUser_Click(object sender, EventArgs e)
        {
            User user = BDDPerson.DejaExisteUser(txtBoxNom.Text, txtBoxPrenom.Text);
            // crée le user avec les info renseignés mdp générés auto
            if (user == null)
            {
                BDDPerson.CreateUser(GeneneCodeTypeProfi(checkBoxAdm.Checked), txtBoxInit.Text, txtBoxNom.Text, txtBoxPrenom.Text, txtBoxMail.Text);
                user = BDDPerson.DejaExisteUser(txtBoxNom.Text, txtBoxPrenom.Text);
                Mail.EnvoiMail("mailSettings", txtBoxMail.Text, "TimeProject Mot de passe", "Votre mot de passe est : " + user.pwd);
            }
            else
            {
                MessageBox.Show("L'utilisateur " + txtBoxNom.Text + " " + txtBoxPrenom.Text + " existe déjà !");
            }

            LoadUser();
        }

        private void btDelUser_Click(object sender, EventArgs e)
        {
            //supprime le user selectionne (requete avec le mail en where clause ou le nom - prenom) 
            // Récupérer la liste des user en cours et rechercher par rapport à l'id.
            User user;

            user = (User)lstBoxUser.SelectedItem;

            BDDPerson.DeleteUser(user.id_User);

            LoadUser();
        }


        private void LoadUser ()
        {
            // Charge tous les user dans  lstBoxUser et met a vide toutes les txtBox
            lstBoxUser.DataSource = null;
            lstBoxUser.DataSource = BDDPerson.getAllUser();

            txtBoxNom.Text = "";
            txtBoxPrenom.Text = "";
            txtBoxInit.Text = "";
            txtBoxMail.Text = "";
            checkBoxAdm.Checked = false;

        }

        public string GeneneCodeTypeProfi(bool typeProfil)
        {
            string codeTypeProfil = "";

            if(typeProfil == true)
            {
                codeTypeProfil = "adm";
            }
            else
            {
                codeTypeProfil = "sal";
            }

            return codeTypeProfil;
        }
    }
}
