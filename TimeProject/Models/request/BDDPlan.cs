using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeProject.Models.Class;
using System.Data.Common;
using TimeProject.Models.request;

namespace TimeProject.Models.request
{
    public static class BDDPlan
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;


        static public List<Plan> getAllPlan(string codeProjet)
        {
            List<Plan> lstPlans = new List<Plan>();
            DataBase.ConnexionToDataBase();
            req = "select * from plan where code_projet = '" + codeProjet + "';";

            dataReader = DataBase.DBSelect(req);

            while (dataReader.Read())
            {
                Plan p;

                p = new Plan(dataReader[0].ToString(), Convert.ToInt32(dataReader[1]), dataReader[2].ToString(), Convert.ToInt32(dataReader[3]), dataReader[4].ToString(), dataReader[5].ToString(), Convert.ToDateTime(dataReader[6]));

                lstPlans.Add(p);
            }


            DataBase.FermeDataReader(dataReader);
            return lstPlans;
        }

        public static Plan DejaExistePlan(string codePlan, int indice, string codeProjet)
        {
            Plan plan;

            req = "SELECT * FROM PLAN WHERE CODE_PLAN = '" + codePlan + "' AND INDICE = '" + indice + "' AND CODE_PROJET = '" + codeProjet + "';";
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                plan = new Plan(dataReader[0].ToString(), Convert.ToInt32(dataReader[1]), dataReader[2].ToString(), Convert.ToInt32(dataReader[3]), dataReader[4].ToString(), dataReader[5].ToString(), Convert.ToDateTime(dataReader[6]));
            }
            else
            {
                plan = null;
            }
            return plan;
        }
        public static int CreatePlan(string codePlan, string indice, string codeProjet, string numeroPlan, string libellePlan, string designation, string dtPla)
        {
            int nbLigne = 0;

            req = "INSERT INTO `plan`(`CODE_PLAN`, `INDICE`, `CODE_PROJET`, `NUMERO_PLAN`, `LIBELLE_PLAN`, `DESIGNATION`, `DT_PLAN`) VALUES ('" + codePlan + "', '" + indice + "', '" + codeProjet + "', '" + numeroPlan + "', '" + libellePlan + "', '" + designation + "', '" + dtPla + "')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
    }
}
