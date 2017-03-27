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

            if (type == "Action")
            {
                ActionProjet act;

                idEvent = sessionUser.projetModif.code_Projet + "ACT" ;
                dtEvent = dtAction.Value;
                etatEvent = (status) lstBoxEtat.SelectedItem;
                importanceEvent = (status)lstBoxImp.SelectedItem;
                act = new ActionProjet(idEvent,  corpsEvent, dtEvent, etatEvent.codeStatus.ToString(), importanceEvent.codeStatus);
            }
            else
            {
                Information info;
                idEvent = sessionUser.projetModif.code_Projet + "INF";
                dtEvent = DateTime.Now.Date;
                etatEvent = (status)lstBoxEtat.SelectedItem;
                importanceEvent = (status)lstBoxImp.SelectedItem;
            }

            MessageBox.Show(dtEvent.ToShortDateString());
        }
    }
}
