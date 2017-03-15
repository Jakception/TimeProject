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
    public partial class FormGestUser : Form
    {
        public FormGestUser()
        {
            InitializeComponent();
        }

        private void FormGestUser_Load(object sender, EventArgs e)
        {

        }

        private void btCreaUser_Click(object sender, EventArgs e)
        {
            // crée le user avec les info renseignés mdp générés auto

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


        }
    }
}
