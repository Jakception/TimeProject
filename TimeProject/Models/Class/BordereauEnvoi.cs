using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class BordereauEnvoi
    {
        private string code_Bordereau;
        private int numero_Bordereau;
        private string  designation;
        private string exemplaire;
        private string version;
        private int etat;
        private List<BordPlan> listBordPlan;
        private List<BordProjet> listBordProjet;

        public string Code_Bordereau
        {
            get
            {
                return code_Bordereau;
            }

            set
            {
                code_Bordereau = value;
            }
        }

        public int Numero_Bordereau
        {
            get
            {
                return numero_Bordereau;
            }

            set
            {
                numero_Bordereau = value;
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

        public string Exemplaire
        {
            get
            {
                return exemplaire;
            }

            set
            {
                exemplaire = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public int Etat
        {
            get
            {
                return etat;
            }

            set
            {
                etat = value;
            }
        }

        public List<BordPlan> ListBordPlan
        {
            get
            {
                return listBordPlan;
            }

            set
            {
                listBordPlan = value;
            }
        }

        public List<BordProjet> ListBordProjet
        {
            get
            {
                return listBordProjet;
            }

            set
            {
                listBordProjet = value;
            }
        }

        public BordereauEnvoi(string codeBordereau, int numeroBordereau, string designation, string exemplaire, string version, int etat)
        {
            this.Code_Bordereau = codeBordereau;
            this.Numero_Bordereau = numeroBordereau;
            this.Designation = designation;
            this.Exemplaire = exemplaire;
            this.Version = version;
            this.Etat = etat;
        }
        public BordereauEnvoi(string codeBordereau, int numeroBordereau, string designation, string exemplaire, string version, int etat, List<BordPlan> ListBordPlan)
        {
            this.Code_Bordereau = codeBordereau;
            this.Numero_Bordereau = numeroBordereau;
            this.Designation = designation;
            this.Exemplaire = exemplaire;
            this.Version = version;
            this.Etat = etat;
            this.ListBordPlan = listBordPlan;
        }
        public BordereauEnvoi(string codeBordereau, int numeroBordereau, string designation, string exemplaire, string version, int etat, List<BordPlan> ListBordPlan, List<BordProjet> ListBordProjet)
        {
            this.Code_Bordereau = codeBordereau;
            this.Numero_Bordereau = numeroBordereau;
            this.Designation = designation;
            this.Exemplaire = exemplaire;
            this.Version = version;
            this.Etat = etat;
            this.ListBordPlan = listBordPlan;
            this.ListBordProjet = listBordProjet;
        }
    }
}
