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
    public partial class FormSuiviValidation : Form
    {
        public FormSuiviValidation()
        {
            InitializeComponent();
        }

        private void btValidArchi_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation(dataGridViewValidation.CurrentRow.Cells[0].Value.ToString(), dataGridViewValidation.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(dataGridViewValidation.CurrentRow.Cells[3].Value), Convert.ToDateTime(dataGridViewValidation.CurrentRow.Cells[4].Value), Convert.ToInt32(dataGridViewValidation.CurrentRow.Cells[5].Value), dataGridViewValidation.CurrentRow.Cells[6].Value.ToString(), 1);
            // string codePlan, int indice, DateTime dtRep, int numCour, string rep
            f.ShowDialog();
            loadTabValidation();
        }

        private void btValidBC_Click(object sender, EventArgs e)
        {
            FormValidation f = new FormValidation(dataGridViewValidation.CurrentRow.Cells[0].Value.ToString(), dataGridViewValidation.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt32(dataGridViewValidation.CurrentRow.Cells[3].Value), Convert.ToDateTime(dataGridViewValidation.CurrentRow.Cells[7].Value), Convert.ToInt32(dataGridViewValidation.CurrentRow.Cells[8].Value), dataGridViewValidation.CurrentRow.Cells[9].Value.ToString(), 2);
            f.ShowDialog();
            loadTabValidation();
        }

        private void FormSuiviValidation_Onload(object sender, EventArgs e)
        {
            loadTabValidation();
        }
        public void loadTabValidation()
        {
            // Charge tous les bordereaux d'envois dans le dataGridViewBE
            List<BordereauEnvoi> listBE = BDDBordereauEnvoi.getAllBEWithDate(sessionUser.projetModif.code_Projet);
            ValidArchi vA;
            ValidBc vBC;
            int nbPlan = 0;

            dataGridViewValidation.Rows.Clear();

            if (listBE.Count() != 0)
            {
                foreach (BordereauEnvoi be in listBE)
                {
                    nbPlan = be.ListPlan.Count();
                    if (nbPlan != 0)
                    {
                        foreach (Plan plan in be.ListPlan)
                        {
                            vA = BDDValidArchi.GetVA(be.Code_Bordereau, plan.Code_Plan, plan.Indice, 1);
                            vBC = BDDValidBC.GetVBC(be.Code_Bordereau, plan.Code_Plan, plan.Indice, 1);
                            this.dataGridViewValidation.Rows.Add(be.Code_Bordereau, be.DateCrea, plan.Code_Plan, plan.Indice,vA.DT_REP_ARCHI, vA.Num_Cour_Arch, vA.Rep_Archi, vBC.Dt_Rep_Bc, vBC.Num_Courrir_Bc, vBC.Rep_Bc);
                        }
                        vA = null;
                        vBC = null;
                    }
                }
            }
        }
    }
}
