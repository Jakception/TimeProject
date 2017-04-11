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
    public partial class FormSuiviValidation : Form
    {
        public FormSuiviValidation()
        {
            InitializeComponent();
        }

        private void btValidArchi_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            f.ShowDialog();
        }

        private void btValidBC_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation();
            f.ShowDialog();
        }
    }
}
