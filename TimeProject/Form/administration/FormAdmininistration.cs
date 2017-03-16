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
    public partial class FormAdmininistration : Form
    {
        public FormAdmininistration()
        {
            InitializeComponent();
        }

        private void FormAdmininistration_Load(object sender, EventArgs e)
        {
            classAdministration.lstUser = BDDPerson.getAllUser();
        }

        private void btPersonne_Click(object sender, EventArgs e)
        {
            FormGestUser formGestUser = new FormGestUser();
            formGestUser.ShowDialog();
        }

        private void btProjet_Click(object sender, EventArgs e)
        {
            FormGestionProjet fProj = new FormGestionProjet();

            fProj.ShowDialog();
        }
    }
}
