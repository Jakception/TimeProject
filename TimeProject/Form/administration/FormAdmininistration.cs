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
    public partial class FormAdmininistration : Form
    {
        public FormAdmininistration()
        {
            InitializeComponent();
        }

        private void FormAdmininistration_Load(object sender, EventArgs e)
        {

        }

        private void btPersonne_Click(object sender, EventArgs e)
        {
            FormGestionUser formGestUser = new FormGestionUser();
            formGestUser.ShowDialog();
        }
    }
}
