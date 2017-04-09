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

            loadDataGrid();
        }

        private void btAjoutEvent_Click(object sender, EventArgs e)
        {
            FormAjoutEvent fadd = new FormAjoutEvent();
            fadd.ShowDialog();
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            List<ActionProjet> lstAction = new List<ActionProjet>();
            List<ActionProjet> lstRendu = new List<ActionProjet>();

            dataAction.DataSource = null;
            dataInfo.DataSource = null;
            dataRendu.DataSource = null;

            foreach (var item in p.lstAction)
            {
                if (Convert.ToInt32(item.etat) > 3 )
                {
                    lstRendu.Add(item);
                }
                else
                {
                    lstAction.Add(item);
                }
            }

            dataAction.DataSource = lstAction;
            dataRendu.DataSource = lstRendu;
            dataInfo.DataSource = p.lstInfo;
        }

        private void btDelEvent_Click(object sender, EventArgs e)
        {
            ActionProjet act;
            Information info;
            int index;

            if (checkAct.Checked)
            {
                act = (ActionProjet)dataAction.SelectedItem;
                BDDEvent.delAction(act);
                index = sessionUser.projetModif.lstAction.IndexOf(act);
                sessionUser.projetModif.lstAction.RemoveAt(index);
            }
            else if (checkInfo.Checked)
            {
                info = (Information)dataInfo.SelectedItem;
                BDDEvent.delInfo(info);
                index = sessionUser.projetModif.lstInfo.IndexOf(info);
                sessionUser.projetModif.lstInfo.RemoveAt(index);
            }
            else if (checkRendu.Checked)
            {
                act = (ActionProjet)dataRendu.SelectedItem;
                BDDEvent.delAction(act);
                index = sessionUser.projetModif.lstAction.IndexOf(act);
                sessionUser.projetModif.lstAction.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Merci de cocher le type d'event à supprimer");
            }

            loadDataGrid();
        }

        private void checkAct_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAct.Checked)
            {
                checkInfo.Checked = false;
                checkRendu.Checked = false;
            }
        }

        private void checkInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInfo.Checked)
            {
                checkRendu.Checked = false;
                checkAct.Checked = false;
            }
        }

        private void checkRendu_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRendu.Checked)
            {
                checkInfo.Checked = false;
                checkAct.Checked = false;
            }
        }

        private void btClassementImp_Click(object sender, EventArgs e)
        {
            List<ActionProjet> lstActImp = new List<ActionProjet>();
            List<ActionProjet> lstRenduImp = new List<ActionProjet>();

            for (int i = 1; i < 4; i++)
            {
                
                foreach (var even in sessionUser.projetModif.lstAction)
                {
                    if (Convert.ToInt32(even.etat) < 4)
                    {
                        if (even.importance == i)
                        {
                            lstActImp.Add(even);
                        }
                    }
                    else
                    {
                        if (even.importance == i)
                        {
                            lstRenduImp.Add(even);
                        }
                    }
                }
            }

            dataAction.DataSource = null;
            dataAction.DataSource = lstActImp;

            dataRendu.DataSource = null;
            dataRendu.DataSource = lstRenduImp;
            
        }

        private void btValAction_Click(object sender, EventArgs e)
        {
            ActionProjet act = (ActionProjet) dataAction.SelectedItem;

            if (act.etat == "3")
            {
                MessageBox.Show("L'action a déjà été finalisé");
            }
            else
            {
                int etat;

                etat = Convert.ToInt32(act.etat) + 1;
                act.etat = etat.ToString();
                BDDEvent.changeEtat(act);
            }

            loadDataGrid(); 
        }

        private void btRendu_Click(object sender, EventArgs e)
        {
            ActionProjet act = (ActionProjet)dataRendu.SelectedItem;

            if (act.etat == "5")
            {
                MessageBox.Show("Le rendu a déjà été finalisé");
            }
            else
            {
                int etat;

                etat = Convert.ToInt32(act.etat) + 1;
                act.etat = etat.ToString();
                BDDEvent.changeEtat(act);
            }
            loadDataGrid();

        }
    }
}
