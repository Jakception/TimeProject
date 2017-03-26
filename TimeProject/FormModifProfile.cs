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
    public partial class FormModifProfile : Form
    {
        public FormModifProfile()
        {
            InitializeComponent();
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            string mdp, nouveauMdp;
            int nbLigne = 0;

            mdp = textBoxMdp.Text;
            nouveauMdp = textBoxConfirmMdp.Text;

            if(mdp != "" && nouveauMdp != "")
            {
                if(mdp == nouveauMdp)
                {
                    // Traitement
                    nbLigne = BDDPerson.ChangerMdpUser(sessionUser.getID(), nouveauMdp);
                    if(nbLigne != 0)
                    {
                        MessageBox.Show("Le mot de passe à bien été modifié !");
                    }
                }
                else
                {
                    MessageBox.Show("Les deux champs doivent être identique");
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tout les champs !");
            }
        }
    }
}
