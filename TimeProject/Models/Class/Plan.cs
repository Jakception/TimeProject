using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Plan
    {
        private int code_Plan { get; set; }
        private int indice { get; set; }
        private int code_Projet { get; set; }
        private int numero_Plan { get; set; }
        private string libelle_Plan { get; set; }
        private string designation { get; set; }
        private DateTime dt_Plan { get; set; }
        //public virtual Projet projet { get; set; }
        //public virtual List<ValidArchi> listValidArchi { get; set; }
        //public virtual List<ValidBc> listValidBc { get; set; }
        //public virtual List<BordPlan> listBordPlan { get; set; }

        public Plan(int codePlan, int indice, int codeProjet, int numeroPlan, string libellePlan, string designation, DateTime dtPlan)
        {
            this.code_Plan = codePlan;
            this.indice = indice;
            this.code_Projet = codeProjet;
            this.numero_Plan = numeroPlan;
            this.libelle_Plan = libellePlan;
            this.designation = designation;
            this.dt_Plan = dtPlan;
        }
    }
}
