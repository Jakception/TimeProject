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

namespace TimeProject
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {
            string dt;

            dt = System.DateTime.Today.Date.ToShortDateString();
            lblDate.Text = "Date: " + dt;

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            FormAdmininistration formAdmin = new FormAdmininistration();

            formAdmin.ShowDialog();
        }

        private void pnlAdmin_Paint(object sender, PaintEventArgs e)
        {
            FormAdmininistration formAdmin = new FormAdmininistration();

            formAdmin.ShowDialog();
        }
    }
}
