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
    public static class BDDValidBC
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static ValidBc GetVBC(string codePlan, int indice, int idBC)
        {
            ValidBc vBC;

            req = "SELECT `ID_BC`, `CODE_PLAN`, `INDICE`, `DT_REP_BC`, `NUM_COURR_BC`, `REP_BC` FROM `valid_bc` WHERE `CODE_PLAN` = '" + codePlan + "' AND `INDICE` = '" + indice.ToString() + "' AND `ID_BC` = '" + idBC + "';";
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                vBC = new ValidBc(Convert.ToDateTime(dataReader[3].ToString()), Convert.ToInt32(dataReader[4]), dataReader[5].ToString());
            }
            else
            {
                vBC = null;
            }

            DataBase.FermeDataReader(dataReader);

            return vBC;
        }
        public static int CreateVBC(string codePlan, int indice, int id_Archi)
        {
            int nbLigne = 0;

            req = "INSERT INTO `valid_archi`(`CODE_PLAN`, `INDICE`, `ID_ARCHI`, 'DT_REP_BC', 'NUM_COURR_BC', 'REP_BC') VALUES ('" + codePlan + "', '" + indice.ToString() + "', '" + id_Archi + "', '1900-01-01', '0', ' ')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
    }
}
