using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Plan
    {
        private string code_Plan;
        private int indice;
        private string code_Projet;
        private int numero_Plan;
        private string libelle_Plan;
        private string designation;
        private DateTime dt_Plan;

        public string Code_Plan
        {
            get
            {
                return code_Plan;
            }

            set
            {
                code_Plan = value;
            }
        }

        public int Indice
        {
            get
            {
                return indice;
            }

            set
            {
                indice = value;
            }
        }

        public string Code_Projet
        {
            get
            {
                return code_Projet;
            }

            set
            {
                code_Projet = value;
            }
        }

        public int Numero_Plan
        {
            get
            {
                return numero_Plan;
            }

            set
            {
                numero_Plan = value;
            }
        }

        public string Libelle_Plan
        {
            get
            {
                return libelle_Plan;
            }

            set
            {
                libelle_Plan = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }

        public DateTime Dt_Plan
        {
            get
            {
                return dt_Plan;
            }

            set
            {
                dt_Plan = value;
            }
        }

        //public virtual Projet projet ;
        //public virtual List<ValidArchi> listValidArchi ;
        //public virtual List<ValidBc> listValidBc ;
        //public virtual List<BordPlan> listBordPlan ;

        public Plan(string codePlan, int indice, string codeProjet, int numeroPlan, string libellePlan, string designation, DateTime dtPlan)
        {
            this.Code_Plan = codePlan;
            this.Indice = indice;
            this.Code_Projet = codeProjet;
            this.Numero_Plan = numeroPlan;
            this.Libelle_Plan = libellePlan;
            this.Designation = designation;
            this.Dt_Plan = dtPlan;
        }

        public override string ToString()
        {
            return this.Code_Plan + " " + this.Indice + " " + this.Code_Projet + " " + this.Numero_Plan + " " + this.Libelle_Plan + " " + this.Designation + " " + this.Dt_Plan.ToString();
        }
        public bool Equals(Plan plan)
        {
            bool result = false;
            // If parameter is null return false:
            if (plan == null)
            {
                result = false;
            }
            else
            {
                if (this.Code_Plan == plan.code_Plan && this.Indice == plan.indice && this.Code_Projet == plan.code_Projet && this.Numero_Plan == plan.numero_Plan && this.Libelle_Plan == plan.libelle_Plan && 
                    this.Designation == plan.designation && this.Dt_Plan == plan.dt_Plan)
                {
                    result = true;
                }
            }

            return result;
        }

    }
}
