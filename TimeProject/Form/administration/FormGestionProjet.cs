﻿using System;
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
    public partial class FormGestionProjet : Form
    {
        public FormGestionProjet()
        {
            InitializeComponent();
            lstBoxProjet.DataSource = null;
           lstBoxProjet.DataSource =  requestProjet.getProjetEncours();
        }

        private void btCreaProjet_Click(object sender, EventArgs e)
        {

        }
    }
     
}
