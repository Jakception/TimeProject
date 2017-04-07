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
    public partial class FormAjoutEvent : Form
    {
        public FormAjoutEvent()
        {
            InitializeComponent();
            
            lstBoxEtat.DataSource = null;
            lstBoxEtat.DataSource = ConfigItem.getListStatus();
            pnlAction.Visible = false;

            lstBoxImp.DataSource = null;
            lstBoxImp.DataSource = ConfigItem.getImportance();

            cbBoxType.SelectedIndex = 0;
        }

        private void cbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxType.SelectedItem == "Action")
            {
                pnlAction.Visible = true;
            }
            else
            {
                pnlAction.Visible = false;
            }
        }

        private void FormAjoutEvent_Load(object sender, EventArgs e)
        {

        }

        private void btCreaEvent_Click(object sender, EventArgs e)
        {
            string type;
            type = cbBoxType.SelectedItem.ToString();

            DateTime dtEvent;
            string idEvent, corpsEvent;
            status etatEvent, importanceEvent;

            corpsEvent = txtCorpsEvent.Text;
            string mess = "";

            if (corpsEvent == "")
            {
                mess = "Merci de remplir la description de l'évènement";
            }
            if (type == "Action")
            {
                ActionProjet act;

                idEvent = sessionUser.projetModif.code_Projet + "ACT" ;
                dtEvent = dtAction.Value;
                etatEvent = (status) lstBoxEtat.SelectedItem;
                importanceEvent = (status)lstBoxImp.SelectedItem;

                
                if (dtEvent < DateTime.Now.Date)
                {
                    mess = mess + ((char)13) + "La date de l'action doit être égale ou supérieure à la date du jour";
                }

                if (mess != "")
                {
                    MessageBox.Show(mess);
                }
                else
                {
                    act = new ActionProjet(idEvent, etatEvent.codeStatus.ToString(), dtEvent,corpsEvent, importanceEvent.codeStatus);
                    act.projet = sessionUser.projetModif;
                    act.user = sessionUser.utilisateur;
                    sessionUser.projetModif.lstAction.Add(act);
                    BDDEvent.insertAction(act);
                    MessageBox.Show("Enregistrement de l'evenement");
                }
                
            }
            else
            {
                Information info;
                idEvent = sessionUser.projetModif.code_Projet + "INF";
                dtEvent = DateTime.Now.Date;
                etatEvent = (status)lstBoxEtat.SelectedItem;
                importanceEvent = (status)lstBoxImp.SelectedItem;

                if (mess != "")
                {
                    MessageBox.Show(mess);
                }
                else
                {
                    info = new Information(idEvent, dtEvent, corpsEvent);
                    info.projet = sessionUser.projetModif;
                    info.user = sessionUser.utilisateur;
                    BDDEvent.insertInfo(info);
                    
                    sessionUser.projetModif.lstInfo.Add(info);
                    MessageBox.Show("Enregistrement de l'evenement");
                }
            }


           
        }
    }
}
