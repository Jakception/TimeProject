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

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_valIdentification_Click(object sender, EventArgs e)
        {
            //string nom;

            //nom = Models.DataBase.TestConnexion();

            //MessageBox.Show(nom);

            string identifiant;
            string mdp;

            identifiant = textBox_Identifiant.Text;
            mdp = textBox_pwd.Text;

            if (identifiant != "" && mdp != "")
            {
                // Traitement
                DataBase BDConnexion = new DataBase();
                MessageBox.Show(BDConnexion.TestConnexion());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.pdfCreator();
        }
    }
}
