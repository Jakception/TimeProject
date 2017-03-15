using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeProject
{
    public partial class FormGestionUser : Form
    {
        private string nom;
        private string prenom;
        private string initiale; 

        public FormGestionUser()
        {
            InitializeComponent();
        }

        private void btCreaUser_Click(object sender, EventArgs e)
        {
            pnlCreaUser.Visible = true;
        }

        private void FormGestionUser_Load(object sender, EventArgs e)
        {
            pnlCreaUser.BackColor = Color.Transparent;
             pnlCreaUser.Visible = false;
            lblInitiale.Text = "";
        }

        private void btClosePnlCrea_Click(object sender, EventArgs e)
        {
            pnlCreaUser.Visible = false;
        }

        private void txtBoxNom_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxNom.Text != "")
            {
                nom = txtBoxNom.Text.Substring(0,1);
                MessageBox.Show(nom);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlCreaUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
