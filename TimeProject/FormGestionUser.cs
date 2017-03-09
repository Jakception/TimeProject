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
        }

        private void btClosePnlCrea_Click(object sender, EventArgs e)
        {
            pnlCreaUser.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t
        }

        private void txtBoxPrenom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
