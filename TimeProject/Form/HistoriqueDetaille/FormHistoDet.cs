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
    public partial class FormHistoDet : Form
    {
        Projet p;
        public FormHistoDet()
        {
            InitializeComponent();
        }

        private void FormHistoDet_Load(object sender, EventArgs e)
        {
            p = sessionUser.projetModif;
            lblTitre.Text = lblTitre.Text + "  " + p.nom_Projet;
            lblDate.Text = "Date de début : " + p.dt_Deb_Projet.ToShortDateString() + "- Objectif de fin : " + p.dt_Obj_Fin.ToShortDateString();
        }

        private void btAjoutEvent_Click(object sender, EventArgs e)
        {
            FormAjoutEvent fadd = new FormAjoutEvent();
            fadd.ShowDialog();
        }
    }
}
