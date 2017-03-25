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
using TimeProject.Models.Utilitaire;

namespace TimeProject
{
    public partial class FormLog : Form
    {
        

        public FormLog()
        {
            InitializeComponent();         
        }

        private void btn_valIdentification_Click(object sender, EventArgs e)
        {
            //string nom;
            FormAccueil f1 = new FormAccueil();
            //nom = Models.DataBase.TestConnexion();

            //MessageBox.Show(nom);

            string identifiant;
            string mdp;
            User user;

            identifiant = textBox_Identifiant.Text;
            mdp = textBox_pwd.Text;

            if (identifiant != "" && mdp != "")
            {
                user = Authentification.AuthentificationApp(identifiant, mdp);

                if (user != null)
                {
                    // Session
                    sessionUser.loadUser(user);
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erreur d'identifiant / Mot de passe");
                }
            }
            else
            {
                MessageBox.Show("Merci de renseigner tous les champs");
            }

            
           
        }

        private void linkLabel_PwdOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            User user;
            string pwd = "";
            //Vérification de l'email
            user = BDDPerson.VerifieEmail(textBox_Identifiant.Text);
            if (user != null)
            {
                // Màj du mdp
                BDDPerson.MajMdpUser(user.id_User, user.mail);
                // Envoi du mail
                pwd = BDDPerson.RecupereMdp(user.id_User, user.pwd);
                Mail.EnvoiMail("mailSettings", user.mail, "Changement mot de passe", "Votre mot de passe à été modifié et est maintnant : '" + pwd + "'. ");
                //Mail.EnvoiMail("mailSettings", "", "", "");
            }
            else
            {
                MessageBox.Show("Le mail n'existe pas!");
            } 
        }
    }
}
