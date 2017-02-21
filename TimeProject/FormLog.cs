using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeProject.Models;


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

            identifiant = textBox_Identifiant.Text;
            mdp = textBox_pwd.Text;

            if (identifiant != "" && mdp != "")
            {
                // Traitement
                MessageBox.Show(DataBase.TestConnexion());
            }

            this.Hide();
            f1.ShowDialog();
            this.Close();
           
        }

       
    }
}
