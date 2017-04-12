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
    public partial class FormValidation : Form
    {
        public FormValidation(string codePlan, int indice, DateTime dtRep, int numCour, string rep)
        {
            InitializeComponent();

            dtTimeValidation.Value = dtRep;
            if(rep != "0")
            {

            }
            textBox1.Text = numCour.ToString();
        }
    }
}
