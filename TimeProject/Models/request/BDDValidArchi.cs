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
    public static class BDDValidArchi
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static ValidArchi GetVA(string codePlan, int indice, int idArchi)
        {
            ValidArchi vA;

            req = "SELECT CODE_PLAN, INDICE, ID_ARCHI, DT_REP_ARCHI, NUM_COUR_ARCHI, REP_ARCHI FROM `valid_archi` WHERE `CODE_PLAN` = '" + codePlan + "' AND `INDICE` = '" + indice.ToString() + "' AND `ID_ARCHI` = '" + idArchi + "';";
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                vA = new ValidArchi(Convert.ToDateTime(dataReader[3].ToString()), Convert.ToInt32(dataReader[4]), dataReader[5].ToString());
            }
            else
            {
                vA = null;
            }

            DataBase.FermeDataReader(dataReader);

            return vA;
        }

        public static int CreateVA(string codePlan, int indice, int idArchi)
        {
            int nbLigne = 0;

            req = "INSERT INTO `valid_archi` (CODE_PLAN, INDICE, ID_ARCHI, DT_REP_ARCHI, NUM_COUR_ARCHI, REP_ARCHI ) VALUES ('" + codePlan + "', '" + indice.ToString() + "', '" + idArchi + "', '1900-01-01', '0', '0')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
        public static int UpdateValidArchi(string codePlan, int indice, int idArchi, DateTime dtRep, string rep, int numCour)
        {
            int nbLigne = 0;

            req = "UPDATE `valid_archi` SET DT_REP_ARCHI = '" + dtRep.ToString("yy-MM-dd") + "' , NUM_COUR_ARCHI = '" + numCour + "', REP_ARCHI = '" + rep + "' WHERE CODE_PLAN = '" + codePlan + "' AND INDICE = '" + indice + "' AND ID_ARCHI = '" + idArchi + "';";
            
            nbLigne = DataBase.DBUpdate(req);

            return nbLigne;
        }
    }
}
