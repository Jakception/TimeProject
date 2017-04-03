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
        static public List<Plan> getAllPlanBE(string codeBordereau, string codeProjet)
        {
            List<Plan> listPlan = new List<Plan>();

            req = "SELECT p.CODE_PLAN, p.INDICE, p.CODE_PROJET, p.NUMERO_PLAN, p.LIBELLE_PLAN, p.DESIGNATION, p.DT_PLAN " +
                  "FROM plan p " +
                  "INNER JOIN bord_plan bp ON p.CODE_PLAN = bp.CODE_PLAN " +
                  "WHERE p.code_projet = '" + codeProjet + "' " +
                  "AND bp.CODE_BORDEREAU = '" + codeBordereau + "';";

            dataReader = DataBase.DBSelect(req);

            while (dataReader.Read())
            {
                Plan plan;

                plan = new Plan(dataReader[0].ToString(), Convert.ToInt32(dataReader[1]), dataReader[2].ToString(), Convert.ToInt32(dataReader[3]), dataReader[4].ToString(), dataReader[5].ToString(), Convert.ToDateTime(dataReader[6]));

                listPlan.Add(plan);
            }

            DataBase.FermeDataReader(dataReader);

            return listPlan;
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

            DataBase.FermeDataReader(dataReader);

            return plan;
        }
        public static int CreatePlan(string codePlan, string indice, string codeProjet, string numeroPlan, string libellePlan, string designation, string dtPlan)
        {
            int nbLigne = 0;

            req = "INSERT INTO `plan`(`CODE_PLAN`, `INDICE`, `CODE_PROJET`, `NUMERO_PLAN`, `LIBELLE_PLAN`, `DESIGNATION`, `DT_PLAN`) VALUES ('" + codePlan + "', '" + indice + "', '" + codeProjet + "', '" + numeroPlan + "', '" + libellePlan + "', '" + designation + "', '" + dtPlan + "')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
        public static int RecupereDernierIndice(string codePlan)
        {
            int maxIndice;

            req = "SELECT MAX(INDICE) FROM `plan` WHERE `CODE_PLAN` = '" + codePlan + "';";

            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                maxIndice = Convert.ToInt32(dataReader[0]);
            }
            else
            {
                maxIndice = 0;
            }

            DataBase.FermeDataReader(dataReader);

            return maxIndice;
        }

        public static int DeletePlan(string codePlan, string indice)
        {
            int nbLigne = 0;

            req = "DELETE FROM `plan` WHERE CODE_PLAN = '" + codePlan + "' AND INDICE = '" + indice + "';";

            nbLigne = DataBase.DBDelete(req);

            return nbLigne;
        }

        public static List<Plan> GetPlanWithMaxIndice(string codeProjet)
        {
            List<Plan> lstPlans = new List<Plan>();
 
            req = "SELECT CODE_PLAN, MAX(INDICE), CODE_PROJET, NUMERO_PLAN, LIBELLE_PLAN, DESIGNATION, DT_PLAN " +
                  "FROM PLAN " +
                  "WHERE CODE_PROJET = '" + codeProjet + "' " +
                  "GROUP BY CODE_PLAN, CODE_PROJET, NUMERO_PLAN, LIBELLE_PLAN, DESIGNATION, DT_PLAN " +
                  "ORDER BY CODE_PLAN;";

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
    }
}
