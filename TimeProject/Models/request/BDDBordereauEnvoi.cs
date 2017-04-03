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
    public static class BDDBordereauEnvoi
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        static public List<BordereauEnvoi> getAllBE(string codeProjet)
        {
            // Charger les bordereau par rapport au code projet et ensuite les plans de chaque bordereau :)
            List<BordereauEnvoi> listBE = new List<BordereauEnvoi>();

            req = "SELECT BE.CODE_BORDEREAU, BE.NUMERO_BORDEREAU, BE.DESIGNATION, BE.EXEMPLAIRE, BE.VERSION, BE.ETAT " +
                  "FROM bordereau_envoi BE" +
                  "INNER JOIN bord_projet BP ON BE.CODE_BORDEREAU = BP.CODE_BORDEREAU " +
                  "WHERE BP.code_projet = '" + codeProjet + "';";

            dataReader = DataBase.DBSelect(req);

            while (dataReader.Read())
            {
                BordereauEnvoi be;
                List<Plan> listPlan = new List<Plan>();

                be = new BordereauEnvoi(dataReader[0].ToString(), Convert.ToInt32(dataReader[1]), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), Convert.ToInt32(dataReader[5]), listPlan);

                listBE.Add(be);
            }

            DataBase.FermeDataReader(dataReader);

            foreach(BordereauEnvoi be in listBE)
            {
                be.ListPlan = BDDPlan.getAllPlanBE(be.Code_Bordereau, codeProjet);
            }

            return listBE;
        }

        public static int CreateBordereauEnvoi(string codeProjet, string codeBordereau,int numeroBordereau, string designation, string exemplaire, string version, int etat)
        {
            int nbLigne = 0;

            req = "INSERT INTO `bordereau_envoi`(`CODE_BORDEREAU`, `NUMERO_BORDEREAU`, `DESIGNATION`, `EXEMPLAIRE`, `VERSION`, `ETAT`) VALUES ('" + codeBordereau + "', '" + numeroBordereau.ToString() + "', '" + designation + "', '" + exemplaire + "', '" + version + "', '" + etat  + "')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
        public static string GenerateCodeBE(string codeProjet)
        {
            int nbBE;
            string codeBE = "";

            req = "SELECT COUNT(*) FROM `bordereau_envoi`;";

            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                nbBE = Convert.ToInt32(dataReader[0]);
            }
            else
            {
                nbBE = 0;
            }

            DataBase.FermeDataReader(dataReader);

            codeBE = codeProjet + nbBE.ToString();

            return codeBE;
        }

        public static int DeletePlan(string codePlan, string indice)
        {
            int nbLigne = 0;

            req = "DELETE FROM `plan` WHERE CODE_PLAN = '" + codePlan + "' AND INDICE = '" + indice + "';";

            nbLigne = DataBase.DBDelete(req);

            return nbLigne;
        }
    }
}
