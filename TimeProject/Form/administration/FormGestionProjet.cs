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
using TimeProject.Models;

namespace TimeProject
{
    public partial class FormGestionProjet : Form
    {
        public FormGestionProjet()
        {
            InitializeComponent();
            loadListProjet();
            
        }

        private void btCreaProjet_Click(object sender, EventArgs e)
        {

        }



        private void btCloreProjet_Click(object sender, EventArgs e)
        {

            DateTime dtCloture;
          
            dtCloture = System.DateTime.Today.Date;

            requestProjet.ProjetEncours();
            loadListProjet();
        }

        private void loadListProjet()
        {
            lstBoxProjet.DataSource = null;
            lstBoxProjet.DataSource = sessionUser.getListProj();
        }

        private void FormGestionProjet_Load(object sender, EventArgs e)
        {

        }
    }
     
}
