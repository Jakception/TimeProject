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

       
    }
}
