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
            // crée le user avec les info renseignés mdp générés auto
            if(BDDPerson.DejaExisteUser(txtBoxNom.Text, txtBoxPrenom.Text) == null)
            {
                BDDPerson.CreateUser(GeneneCodeTypeProfi(checkBoxAdm.Checked), txtBoxInit.Text, txtBoxNom.Text, txtBoxPrenom.Text, txtBoxMail.Text);
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
