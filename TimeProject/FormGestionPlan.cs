﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeProject.Models.request;
using TimeProject.Models.Class;
using TimeProject.Models.Utilitaire;

namespace TimeProject
{
    public partial class FormGestionPlan : Form
    {
        public FormGestionPlan()
        {
            InitializeComponent();
        }

        public void FormGestionPlan_Load(object sender, EventArgs e)
        {
            lstBoxPlan.DataSource = null;
            lstBoxPlan.DataSource = BDDPlan.getAllPlan();
        }

        private void LoadPlan()
        {
            // Charge tous les plans dans lstBoxPlan et met a vide toutes les txtBox
            lstBoxPlan.DataSource = null;
            lstBoxPlan.DataSource = BDDPerson.getAllUser();
        }

        private void btn_Ajout_Click(object sender, EventArgs e)
        {

        }

        private void btn_ModificationPlan_Click(object sender, EventArgs e)
        {

        }

        private void btn_Suppression_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditionPDF_Click(object sender, EventArgs e)
        {

        }
    }
}
