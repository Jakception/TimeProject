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

            req = "SELECT * FROM `valid_archi` WHERE `CODE_PLAN` = '" + codePlan + "' AND `INDICE` = '" + indice.ToString() + "' AND `ID_ARCHI` = '" + idArchi + "';";
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {
                vA = new ValidArchi(Convert.ToDateTime(dataReader[3].ToString()), Convert.ToInt32(dataReader[4]), Convert.ToInt32(dataReader[5]));
            }
            else
            {
                vA = null;
            }

            DataBase.FermeDataReader(dataReader);

            return vA;
        }

        public static int CreateVA(string codePlan, int indice, int idBC)
        {
            int nbLigne = 0;

            req = "INSERT INTO `valid_bc`(`CODE_PLAN`, `INDICE`, `ID_BC`) VALUES ('" + codePlan + "', '" + indice.ToString() + "', '" + idBC + "')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
    }
}
