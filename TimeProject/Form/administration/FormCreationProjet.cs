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
    public partial class FormCreationProjet : Form
    {
        public FormCreationProjet()
        {
            InitializeComponent();

            //charge la list de tous les users
        }

        private void btCreaProjet_Click(object sender, EventArgs e)
        {
            List<User> lstUserProj = new List<User>();

            foreach (var item in checkListUserProjet.SelectedItems)
            {
                lstUserProj.Add((User)item);
            }         



        }
    }
}
