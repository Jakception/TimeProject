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
    public static class BDDBordPlan
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static int CreateBordPlan(string codeBordereau, string codePlan, int indice)
        {
            int nbLigne = 0;

            req = "INSERT INTO `bord_plan`(`CODE_BORDEREAU`, `CODE_PLAN`, `INDICE`)  VALUES ('" + codeBordereau + "', '" + codePlan + "', '" + indice.ToString() + "');";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }

        public static int DeleteBordPlan(string codeBordereau, string codePlan, int indice)
        {
            int nbLigne = 0;

            req = "DELETE FROM `bord_plan` WHERE CODE_BORDEREAU = '" + codeBordereau + "' AND CODE_PLAN = '" + codePlan + "' AND INDICE = '" + indice.ToString() + "';";

            nbLigne = DataBase.DBDelete(req);

            return nbLigne;
        }
    }
}
